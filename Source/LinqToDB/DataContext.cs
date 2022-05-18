﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using JetBrains.Annotations;

namespace LinqToDB
{
#if !NATIVE_ASYNC
	using Async;
#endif
	using Data;
	using DataProvider;
	using Linq;
	using Mapping;
	using SqlProvider;
	using Infrastructure;

	/// <summary>
	/// Implements abstraction over non-persistent database connection that could be released after query or transaction execution.
	/// </summary>
	[PublicAPI]
	public partial class DataContext : IDataContext
	{
		private CoreDataContextOptionsExtension _prebuiltCoreExtension;
		private DataContextOptionsExtensionOld   _prebuiltDbExtension;
		private DataContextOptions              _prebuiltOptions;

		private bool _disposed;

		/// <summary>
		/// Creates data context using default database configuration.
		/// <see cref="DataConnection.DefaultConfiguration"/> for more details.
		/// </summary>
		public DataContext() : this(DataConnection.DefaultConfiguration)
		{
		}

		/// <summary>
		/// Creates data context using specific database configuration.
		/// </summary>
		/// <param name="configurationString">Connection configuration name.
		/// In case of <c>null</c> value, context will use default configuration.
		/// <see cref="DataConnection.DefaultConfiguration"/> for more details.
		/// </param>
		public DataContext(string? configurationString)
			: this(new DataContextOptionsBuilder()
				.UseConfigurationString(
					configurationString ?? DataConnection.DefaultConfiguration
						?? throw new ArgumentNullException($"Neither {nameof(configurationString)} nor {nameof(DataConnection)}.{DataConnection.DefaultConfiguration} specified"))
				.Options)
		{
		}

		/// <summary>
		/// Creates data context using specific data provider implementation and connection string.
		/// </summary>
		/// <param name="dataProvider">Database provider implementation.</param>
		/// <param name="connectionString">Database connection string.</param>
		public DataContext(IDataProvider dataProvider, string connectionString)
			: this(new DataContextOptionsBuilder()
				.UseConnectionString(
					dataProvider     ?? throw new ArgumentNullException(nameof(dataProvider)),
					connectionString ?? throw new ArgumentNullException(nameof(connectionString)))
				.Options)
		{
		}

		/// <summary>
		/// Creates data context using specified database provider and connection string.
		/// </summary>
		/// <param name="providerName">Name of database provider to use with this connection. <see cref="ProviderName"/> class for list of providers.</param>
		/// <param name="connectionString">Database connection string to use for connection with database.</param>
		public DataContext( string providerName, string connectionString)
			: this(new DataContextOptionsBuilder()
				.UseConnectionString(
					providerName     ?? throw new ArgumentNullException(nameof(providerName)),
					connectionString ?? throw new ArgumentNullException(nameof(connectionString)))
				.Options)
		{
		}

		/// <summary>
		/// Creates database context object that uses a <see cref="DataContextOptions"/> to configure the connection.
		/// </summary>
		/// <param name="options">Options, setup ahead of time.</param>
		public DataContext(DataContextOptions options)
		{
			var extension = options.FindExtension<DataContextOptionsExtensionOld>();

			extension ??= new DataContextOptionsExtensionOld();

			var dataProvider = extension.DataProvider;
			if (dataProvider == null)
			{
				if (extension.ProviderName != null && extension.ConnectionString != null)
				{
					dataProvider =
						DataConnection.GetDataProvider(extension.ProviderName, extension.ConnectionString)
						?? throw new LinqToDBException($"DataProvider '{extension.ProviderName}' not found.");
				}
				else if (extension.ConfigurationString != null)
					dataProvider = DataConnection.GetDataProvider(extension.ConfigurationString);
			}

			if (dataProvider == null)
				throw new LinqToDBException($"DataProvider not specified.");

			extension = extension
				.WithMappingSchema(dataProvider.MappingSchema)
				.WithDataProvider(dataProvider);

			options = options.WithExtension(extension);

			_prebuiltDbExtension = options.GetExtension<DataContextOptionsExtensionOld>();

			var coreExtension = options.FindExtension<CoreDataContextOptionsExtension>();
			if (coreExtension != null)
			{
				_prebuiltCoreExtension = coreExtension;
			}
			else
			{
				coreExtension          = new CoreDataContextOptionsExtension();
				options                = options.WithExtension(coreExtension);
				_prebuiltCoreExtension = coreExtension;
			}

			var linqExtension = options.FindExtension<LinqOptions>();
			if (linqExtension == null)
			{
				linqExtension = Common.Configuration.Linq.Options;
				options       = options.WithExtension(linqExtension);
			}

			_prebuiltOptions = options;

			ContextID   = dataProvider.ID;
			ContextName = dataProvider.Name;
		}

		/// <summary>
		/// Current DataContext LINQ options
		/// </summary>
		public DataContextOptions Options => _prebuiltOptions;

		/// <summary>
		/// Gets initial value for database connection configuration name.
		/// </summary>
		public string?       ConfigurationString => _prebuiltDbExtension.ConfigurationString;
		/// <summary>
		/// Gets initial value for database connection string.
		/// </summary>
		public string?       ConnectionString    => _prebuiltDbExtension.ConnectionString;
		/// <summary>
		/// Gets database provider implementation.
		/// </summary>
		public IDataProvider DataProvider        => _prebuiltDbExtension.DataProvider!;
		/// <summary>
		/// Gets or sets context identifier. Uses provider's name by default.
		/// </summary>
		public string ContextName { get; private set; }

		/// <summary>
		/// Gets or sets ContextID.
		/// </summary>
		public int ContextID { get; private set; }

		/// <summary>
		/// Gets or sets mapping schema. Uses provider's mapping schema by default.
		/// </summary>
		public MappingSchema MappingSchema
		{
			get => _prebuiltDbExtension.MappingSchema!;
			set
			{
				_prebuiltDbExtension = _prebuiltDbExtension.WithMappingSchema(value);
				_prebuiltOptions     = _prebuiltOptions.WithExtension(_prebuiltCoreExtension);
			}
		}
		/// <summary>
		/// Gets or sets option to force inline parameter values as literals into command text. If parameter inlining not supported
		/// for specific value type, it will be used as parameter.
		/// </summary>
		public bool          InlineParameters    { get; set; }
		/// <summary>
		/// Contains text of last command, sent to database using current context.
		/// </summary>
		public string?       LastQuery           { get; set; }

		/// <summary>
		/// Gets or sets trace handler, used for data connection instance.
		/// </summary>
		public Action<TraceInfo>? OnTraceConnection { get; set; }

		private bool _keepConnectionAlive;
		/// <summary>
		/// Gets or sets option to dispose underlying connection after use.
		/// Default value: <c>false</c>.
		/// </summary>
		public  bool  KeepConnectionAlive
		{
			get => _keepConnectionAlive;
			set
			{
				_keepConnectionAlive = value;

				if (value == false)
					ReleaseQuery();
			}
		}

		private bool? _isMarsEnabled;
		/// <summary>
		/// Gets or sets status of Multiple Active Result Sets (MARS) feature. This feature available only for
		/// SQL Azure and SQL Server 2005+.
		/// </summary>
		public bool   IsMarsEnabled
		{
			get
			{
				if (_isMarsEnabled == null)
				{
					if (_dataConnection == null)
						return false;
					_isMarsEnabled = _dataConnection.IsMarsEnabled;
				}

				return _isMarsEnabled.Value;
			}
			set => _isMarsEnabled = value;
		}

		private List<string>? _queryHints;
		/// <summary>
		/// Gets list of query hints (writable collection), that will be used for all queries, executed through current context.
		/// </summary>
		public List<string>  QueryHints
		{
			get
			{
				if (_dataConnection != null)
					return _dataConnection.QueryHints;

				return _queryHints ??= new List<string>();
			}
		}

		private List<string>? _nextQueryHints;
		/// <summary>
		/// Gets list of query hints (writable collection), that will be used only for next query, executed through current context.
		/// </summary>
		public List<string>  NextQueryHints
		{
			get
			{
				if (_dataConnection != null)
					return _dataConnection.NextQueryHints;

				return _nextQueryHints ??= new List<string>();
			}
		}

		/// <summary>
		/// Gets or sets flag to close context after query execution or leave it open.
		/// </summary>
		public bool CloseAfterUse { get; set; }

		/// <summary>
		/// Counts number of locks, put on underlying connection. Connection will not be released while counter is not zero.
		/// </summary>
		internal int LockDbManagerCounter;

		private int? _commandTimeout;

		/// <summary>
		/// Gets or sets command execution timeout in seconds.
		/// Negative timeout value means that default timeout will be used.
		/// 0 timeout value corresponds to infinite timeout.
		/// By default timeout is not set and default value for current provider used.
		/// </summary>
		public  int   CommandTimeout
		{
			get => _commandTimeout ?? -1;
			set
			{
				if (value < 0)
				{
					_commandTimeout = null;
					if (_dataConnection != null)
						_dataConnection.CommandTimeout = -1;
				}
				else
				{
					_commandTimeout = value;
					if (_dataConnection != null)
						_dataConnection.CommandTimeout = value;
				}
			}
		}

		/// <summary>
		/// Underlying active database connection.
		/// </summary>
		DataConnection? _dataConnection;

		/// <summary>
		/// Creates instance of <see cref="DataConnection"/> class, used by context internally.
		/// </summary>
		/// <returns>New <see cref="DataConnection"/> instance.</returns>
		protected virtual DataConnection CreateDataConnection(DataContextOptions options) => new (options);

		/// <summary>
		/// Returns associated database connection <see cref="DataConnection"/> or create new connection, if connection
		/// doesn't exists.
		/// </summary>
		/// <returns>Data connection.</returns>
		internal DataConnection GetDataConnection()
		{
			AssertDisposed();

			if (_dataConnection == null)
			{
				_dataConnection = CreateDataConnection(_prebuiltOptions);

				if (_commandTimeout != null)
					_dataConnection.CommandTimeout = CommandTimeout;

				if (_queryHints?.Count > 0)
				{
					_dataConnection.QueryHints.AddRange(_queryHints);
					_queryHints = null;
				}

				if (_nextQueryHints?.Count > 0)
				{
					_dataConnection.NextQueryHints.AddRange(_nextQueryHints);
					_nextQueryHints = null;
				}

				if (OnTraceConnection != null)
					_dataConnection.OnTraceConnection = OnTraceConnection;
			}

			return _dataConnection;
		}

		private void AssertDisposed()
		{
			if (_disposed)
				// GetType().FullName to support inherited types
				throw new ObjectDisposedException(GetType().FullName);
		}

		/// <summary>
		/// For active underlying connection, updates information about last executed query <see cref="LastQuery"/> and
		/// releases connection, if it is not locked (<see cref="LockDbManagerCounter"/>)
		/// and <see cref="KeepConnectionAlive"/> is <c>false</c>.
		/// </summary>
		internal void ReleaseQuery()
		{
			if (_dataConnection != null)
			{
				LastQuery = _dataConnection.LastQuery;

				if (LockDbManagerCounter == 0 && KeepConnectionAlive == false)
				{
					if (_dataConnection.QueryHints.    Count > 0) (_queryHints     ??= new List<string>()).AddRange(_dataConnection.QueryHints);
					if (_dataConnection.NextQueryHints.Count > 0) (_nextQueryHints ??= new List<string>()).AddRange(_dataConnection.NextQueryHints);

					_dataConnection.Dispose();
					_dataConnection = null;
				}
			}
		}

		/// <summary>
		/// For active underlying connection, updates information about last executed query <see cref="LastQuery"/> and
		/// releases connection, if it is not locked (<see cref="LockDbManagerCounter"/>)
		/// and <see cref="KeepConnectionAlive"/> is <c>false</c>.
		/// </summary>
		internal async Task ReleaseQueryAsync()
		{
			if (_dataConnection != null)
			{
				LastQuery = _dataConnection.LastQuery;

				if (LockDbManagerCounter == 0 && KeepConnectionAlive == false)
				{
					if (_dataConnection.QueryHints.    Count > 0) QueryHints.    AddRange(_queryHints!);
					if (_dataConnection.NextQueryHints.Count > 0) NextQueryHints.AddRange(_nextQueryHints!);

					await _dataConnection.DisposeAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
					_dataConnection = null;
				}
			}
		}

		Func<ISqlBuilder>   IDataContext.CreateSqlProvider     => () => DataProvider.CreateSqlBuilder(MappingSchema, this.GetLinqOptions());
		Func<ISqlOptimizer> IDataContext.GetSqlOptimizer       => DataProvider.GetSqlOptimizer;
		Type                IDataContext.DataReaderType        => DataProvider.DataReaderType;
		SqlProviderFlags    IDataContext.SqlProviderFlags      => DataProvider.SqlProviderFlags;
		TableOptions        IDataContext.SupportedTableOptions => DataProvider.SupportedTableOptions;

		Expression IDataContext.GetReaderExpression(DbDataReader reader, int idx, Expression readerExpression, Type toType)
		{
			return DataProvider.GetReaderExpression(reader, idx, readerExpression, toType);
		}

		bool? IDataContext.IsDBNullAllowed(DbDataReader reader, int idx) => DataProvider.IsDBNullAllowed(reader, idx);

		/// <summary>
		/// Creates instance of <see cref="DataConnection"/> class, attached to same database connection/transaction passed in options.
		/// Used by <see cref="IDataContext.Clone(bool)"/> API only if <see cref="DataConnection.IsMarsEnabled"/>
		/// is <c>true</c> and there is an active connection associated with current context.
		/// <param name="currentConnection"><see cref="DataConnection"/> instance, used by current context instance.</param>
		/// <param name="options">Connection options, will have <see cref="DbConnection"/> or <see cref="DbTransaction"/> set.</param>
		/// <returns>New <see cref="DataConnection"/> instance.</returns>
		/// </summary>
		protected virtual DataConnection CloneDataConnection(DataConnection currentConnection, DataContextOptions options) => new (options);

		IDataContext IDataContext.Clone(bool forNestedQuery)
		{
			AssertDisposed();

			var dc = new DataContext(_prebuiltOptions)
			{
				KeepConnectionAlive = KeepConnectionAlive,
				ContextName         = ContextName,
				ContextID           = ContextID,
				InlineParameters    = InlineParameters
			};

			if (forNestedQuery && _dataConnection != null && _dataConnection.IsMarsEnabled)
			{
				var coreOptions = _prebuiltDbExtension;

				if (_dataConnection.TransactionAsync != null)
					coreOptions = coreOptions.WithTransaction(_dataConnection.TransactionAsync.Transaction);
				else
					coreOptions = coreOptions.WithConnection(_dataConnection.EnsureConnection().Connection);

				var newOptions = _prebuiltOptions.WithExtension(coreOptions);
				dc._dataConnection = CloneDataConnection(_dataConnection, newOptions);
			}

			dc.QueryHints.    AddRange(QueryHints);
			dc.NextQueryHints.AddRange(NextQueryHints);

			return dc;
		}

		void IDisposable.Dispose()
		{
			Dispose(disposing: true);
		}

		/// <summary>
		/// Closes underlying connection.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			_disposed = true;
			((IDataContext)this).Close();
		}

#if NATIVE_ASYNC
		async ValueTask IAsyncDisposable.DisposeAsync()
#else
		async Task IAsyncDisposable.DisposeAsync()
#endif
		{
			await DisposeAsync(disposing: true).ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
		}

		/// <summary>
		/// Closes underlying connection.
		/// </summary>
#if NATIVE_ASYNC
		protected virtual ValueTask DisposeAsync(bool disposing)
#else
		protected virtual Task DisposeAsync(bool disposing)
#endif
		{
			_disposed = true;
#if NATIVE_ASYNC
			return new ValueTask(((IDataContext)this).CloseAsync());
#else
			return ((IDataContext)this).CloseAsync();
#endif
		}

		void IDataContext.Close()
		{
			_dataContextInterceptor?.OnClosing(new (this));

			if (_dataConnection != null)
			{
				if (_dataConnection.QueryHints.    Count > 0) (_queryHints     ??= new ()).AddRange(_dataConnection.QueryHints);
				if (_dataConnection.NextQueryHints.Count > 0) (_nextQueryHints ??= new ()).AddRange(_dataConnection.NextQueryHints);

				_dataConnection.Dispose();
				_dataConnection = null;
			}

			_dataContextInterceptor?.OnClosed(new (this));
		}

		async Task IDataContext.CloseAsync()
		{
			if (_dataContextInterceptor != null)
				await _dataContextInterceptor.OnClosingAsync(new (this)).ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);

			if (_dataConnection != null)
			{
				if (_dataConnection.QueryHints.    Count > 0) (_queryHints     ??= new ()).AddRange(_dataConnection.QueryHints);
				if (_dataConnection.NextQueryHints.Count > 0) (_nextQueryHints ??= new ()).AddRange(_dataConnection.NextQueryHints);

				await _dataConnection.DisposeAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
				_dataConnection = null;
			}

			if (_dataContextInterceptor != null)
				await _dataContextInterceptor.OnClosedAsync(new (this)).ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
		}

		/// <summary>
		/// Starts new transaction for current context with specified isolation level.
		/// If connection already has transaction, it will be rolled back.
		/// </summary>
		/// <param name="level">Transaction isolation level.</param>
		/// <returns>Database transaction object.</returns>
		public virtual DataContextTransaction BeginTransaction(IsolationLevel level)
		{
			var dct = new DataContextTransaction(this);

			dct.BeginTransaction(level);

			return dct;
		}

		/// <summary>
		/// Starts new transaction for current context with default isolation level.
		/// If connection already has transaction, it will be rolled back.
		/// </summary>
		/// <returns>Database transaction object.</returns>
		public virtual DataContextTransaction BeginTransaction()
		{
			var dct = new DataContextTransaction(this);

			dct.BeginTransaction();

			return dct;
		}

		/// <summary>
		/// Starts new transaction asynchronously for current context with specified isolation level.
		/// If connection already has transaction, it will be rolled back.
		/// </summary>
		/// <param name="level">Transaction isolation level.</param>
		/// <param name="cancellationToken">Asynchronous operation cancellation token.</param>
		/// <returns>Database transaction object.</returns>
		public virtual async Task<DataContextTransaction> BeginTransactionAsync(IsolationLevel level, CancellationToken cancellationToken = default)
		{
			var dct = new DataContextTransaction(this);

			await dct.BeginTransactionAsync(level, cancellationToken).ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);

			return dct;
		}

		/// <summary>
		/// Starts new transaction asynchronously for current context with default isolation level.
		/// If connection already has transaction, it will be rolled back.
		/// </summary>
		/// <param name="cancellationToken">Asynchronous operation cancellation token.</param>
		/// <returns>Database transaction object.</returns>
		public virtual async Task<DataContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
		{
			var dct = new DataContextTransaction(this);

			await dct.BeginTransactionAsync(cancellationToken).ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);

			return dct;
		}

		IQueryRunner IDataContext.GetQueryRunner(Query query, int queryNumber, Expression expression, object?[]? parameters, object?[]? preambles)
		{
			return new QueryRunner(this, ((IDataContext)GetDataConnection()).GetQueryRunner(query, queryNumber, expression, parameters, preambles));
		}

		public FluentMappingBuilder GetFluentMappingBuilder()
		{
			return MappingSchema.GetFluentMappingBuilder();
		}

		class QueryRunner : IQueryRunner
		{
			public QueryRunner(DataContext dataContext, IQueryRunner queryRunner)
			{
				_dataContext = dataContext;
				_queryRunner = (DataConnection.QueryRunner)queryRunner;
			}

			DataContext? _dataContext;
			DataConnection.QueryRunner? _queryRunner;

			public void Dispose()
			{
				_queryRunner!.Dispose();
				_dataContext!.ReleaseQuery();
				_queryRunner = null;
				_dataContext = null;
			}

#if NATIVE_ASYNC
			public async ValueTask DisposeAsync()
#else
			public async Task DisposeAsync()
#endif
			{
				await _queryRunner!.DisposeAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
				await _dataContext!.ReleaseQueryAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);

				_queryRunner = null;
				_dataContext = null;
			}

			public int ExecuteNonQuery()
			{
				return _queryRunner!.ExecuteNonQuery();
			}

			public object? ExecuteScalar()
			{
				return _queryRunner!.ExecuteScalar();
			}

			public DataReaderWrapper ExecuteReader()
			{
				return _queryRunner!.ExecuteReader();
			}

			public Task<object?> ExecuteScalarAsync(CancellationToken cancellationToken)
			{
				return _queryRunner!.ExecuteScalarAsync(cancellationToken);
			}

			public Task<IDataReaderAsync> ExecuteReaderAsync(CancellationToken cancellationToken)
			{
				return _queryRunner!.ExecuteReaderAsync(cancellationToken);
			}

			public Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken)
			{
				return _queryRunner!.ExecuteNonQueryAsync(cancellationToken);
			}

			public string GetSqlText()
			{
				return _queryRunner!.GetSqlText();
			}

			public IDataContext DataContext      => _dataContext!;
			public Expression   Expression       => _queryRunner!.Expression;
			public object?[]?   Parameters       => _queryRunner!.Parameters;
			public object?[]?   Preambles        => _queryRunner!.Preambles;
			public Expression?  MapperExpression { get => _queryRunner!.MapperExpression; set => _queryRunner!.MapperExpression = value; }
			public int          RowsCount        { get => _queryRunner!.RowsCount;        set => _queryRunner!.RowsCount        = value; }
			public int          QueryNumber      { get => _queryRunner!.QueryNumber;      set => _queryRunner!.QueryNumber      = value; }
		}
	}
}
