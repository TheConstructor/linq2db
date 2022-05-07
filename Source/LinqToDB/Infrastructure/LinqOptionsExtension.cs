﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace LinqToDB.Infrastructure
{
	using Data;
	using Linq;

	public class LinqOptionsExtension : IDataContextOptionsExtension, IEquatable<LinqOptionsExtension>
	{
		bool     _preloadGroups;
		bool     _ignoreEmptyUpdate;
		bool     _generateExpressionTest;
		bool     _traceMapperExpression;
		bool     _doNotClearOrderBys;
		bool     _optimizeJoins;
		bool     _compareNullsAsValues;
		bool     _guardGrouping;
		bool     _disableQueryCache;
		TimeSpan _cacheSlidingExpiration;
		bool     _preferApply;
		bool     _keepDistinctOrdered;
		bool     _parameterizeTakeSkip;

		public LinqOptionsExtension()
		{
		}

		protected LinqOptionsExtension(LinqOptionsExtension copyFrom)
		{
			_preloadGroups          = copyFrom.PreloadGroups;
			_ignoreEmptyUpdate      = copyFrom.IgnoreEmptyUpdate;
			_generateExpressionTest = copyFrom.GenerateExpressionTest;
			_traceMapperExpression  = copyFrom.TraceMapperExpression;
			_doNotClearOrderBys     = copyFrom.DoNotClearOrderBys;
			_optimizeJoins          = copyFrom.OptimizeJoins;
			_compareNullsAsValues   = copyFrom.CompareNullsAsValues;
			_guardGrouping          = copyFrom.GuardGrouping;
			_disableQueryCache      = copyFrom.DisableQueryCache;
			_cacheSlidingExpiration = copyFrom.CacheSlidingExpiration;
			_preferApply            = copyFrom.PreferApply;
			_keepDistinctOrdered    = copyFrom.KeepDistinctOrdered;
			_parameterizeTakeSkip   = copyFrom.ParameterizeTakeSkip;
		}

		/// <summary>
		/// Controls how group data for LINQ queries ended with GroupBy will be loaded:
		/// - if <c>true</c> - group data will be loaded together with main query, resulting in 1 + N queries, where N - number of groups;
		/// - if <c>false</c> - group data will be loaded when you call enumerator for specific group <see cref="System.Linq.IGrouping{TKey, TElement}"/>.
		/// Default value: <c>false</c>.
		/// </summary>
		public bool PreloadGroups => _preloadGroups;

		/// <summary>
		/// Controls behavior of linq2db when there is no updateable fields in Update query:
		/// - if <c>true</c> - query not executed and Update operation returns 0 as number of affected records;
		/// - if <c>false</c> - <see cref="LinqException"/> will be thrown.
		/// Default value: <c>false</c>.
		/// </summary>
		public bool IgnoreEmptyUpdate => _ignoreEmptyUpdate;

		/// <summary>
		/// Enables generation of test class for each LINQ query, executed while this option is enabled.
		/// This option could be useful for issue reporting, when you need to provide reproducible case.
		/// Test file will be placed to <c>linq2db</c> subfolder of temp folder and exact file path will be logged
		/// to data connection tracing infrastructure.
		/// See <see cref="DataConnection.TraceSwitch"/> for more details.
		/// Default value: <c>false</c>.
		/// </summary>
		public bool GenerateExpressionTest => _generateExpressionTest;

		/// <summary>
		/// Enables logging of generated mapping expression to data connection tracing infrastructure.
		/// See <see cref="DataConnection.TraceSwitch"/> for more details.
		/// Default value: <c>false</c>.
		/// </summary>
		public bool TraceMapperExpression => _traceMapperExpression;

		/// <summary>
		/// Controls behavior, when LINQ query chain contains multiple <see cref="System.Linq.Queryable.OrderBy{TSource, TKey}(System.Linq.IQueryable{TSource}, Expression{Func{TSource, TKey}})"/> or <see cref="System.Linq.Queryable.OrderByDescending{TSource, TKey}(System.Linq.IQueryable{TSource}, Expression{Func{TSource, TKey}})"/> calls:
		/// - if <c>true</c> - non-first OrderBy* call will be treated as ThenBy* call;
		/// - if <c>false</c> - OrderBy* call will discard sort specifications, added by previous OrderBy* and ThenBy* calls.
		/// Default value: <c>false</c>.
		/// </summary>
		public bool DoNotClearOrderBys => _doNotClearOrderBys;

		/// <summary>
		/// If enabled, linq2db will try to reduce number of generated SQL JOINs for LINQ query.
		/// Attempted optimizations:
		/// - removes duplicate joins by unique target table key;
		/// - removes self-joins by unique key;
		/// - removes left joins if joined table is not used in query.
		/// Default value: <c>true</c>.
		/// </summary>
		public bool OptimizeJoins => _optimizeJoins;

		/// <summary>
		/// If set to true nullable fields would be checked for IS NULL in Equal/NotEqual comparisons.
		/// This affects: Equal, NotEqual, Not Contains
		/// Default value: <c>true</c>.
		/// </summary>
		/// <example>
		/// <code>
		/// public class MyEntity
		/// {
		///     public int? Value;
		/// }
		///
		/// db.MyEntity.Where(e => e.Value != 10)
		///
		/// from e1 in db.MyEntity
		/// join e2 in db.MyEntity on e1.Value equals e2.Value
		/// select e1
		///
		/// var filter = new [] {1, 2, 3};
		/// db.MyEntity.Where(e => ! filter.Contains(e.Value))
		/// </code>
		///
		/// Would be converted to next queries:
		/// <code>
		/// SELECT Value FROM MyEntity WHERE Value IS NULL OR Value != 10
		///
		/// SELECT e1.Value
		/// FROM MyEntity e1
		/// INNER JOIN MyEntity e2 ON e1.Value = e2.Value OR (e1.Value IS NULL AND e2.Value IS NULL)
		///
		/// SELECT Value FROM MyEntity WHERE Value IS NULL OR NOT Value IN (1, 2, 3)
		/// </code>
		/// </example>
		public bool CompareNullsAsValues => _compareNullsAsValues;

		/// <summary>
		/// Controls behavior of LINQ query, which ends with GroupBy call.
		/// - if <c>true</c> - <seealso cref="LinqToDBException"/> will be thrown for such queries;
		/// - if <c>false</c> - behavior is controlled by <see cref="PreloadGroups"/> option.
		/// Default value: <c>true</c>.
		/// </summary>
		/// <remarks>
		/// <a href="https://github.com/linq2db/linq2db/issues/365">More details</a>.
		/// </remarks>
		public bool GuardGrouping => _guardGrouping;

		/// <summary>
		/// Used to disable LINQ expressions caching for queries.
		/// This cache reduces time, required for query parsing but have several side-effects:
		/// <para />
		/// - cached LINQ expressions could contain references to external objects as parameters, which could lead to memory leaks if those objects are not used anymore by other code
		/// <para />
		/// - cache access synchronization could lead to bigger latencies than it saves.
		/// <para />
		/// Default value: <c>false</c>.
		/// <para />
		/// It is not recommended to enable this option as it could lead to severe slowdown. Better approach will be
		/// to call <see cref="Query{T}.ClearCache"/> method to cleanup cache after queries, that produce severe memory leaks you need to fix.
		/// <para />
		/// <a href="https://github.com/linq2db/linq2db/issues/256">More details</a>.
		/// </summary>
		public bool DisableQueryCache => _disableQueryCache;

		/// <summary>
		/// Specifies timeout when query will be evicted from cache since last execution of query.
		/// Default value is 1 hour.
		/// </summary>
		public TimeSpan CacheSlidingExpiration => _cacheSlidingExpiration;

		/// <summary>
		/// Used to generate CROSS APPLY or OUTER APPLY if possible.
		/// Default value: <c>true</c>.
		/// </summary>
		public bool PreferApply => _preferApply;

		/// <summary>
		/// Allows SQL generation to automatically transform
		/// <code>SELECT DISTINCT value FROM Table ORDER BY date</code>
		/// Into GROUP BY equivalent if syntax is not supported
		/// Default value: <c>true</c>.
		/// </summary>
		public bool KeepDistinctOrdered => _keepDistinctOrdered;

		/// <summary>
		/// Enables Take/Skip parameterization.
		/// Default value: <c>true</c>.
		/// </summary>
		public bool ParameterizeTakeSkip => _parameterizeTakeSkip;


		#region With Methods

		public virtual LinqOptionsExtension WithPreloadGroups(bool preloadGroups)
		{
			return SetValue(o => o._preloadGroups = preloadGroups);
		}

		public virtual LinqOptionsExtension WithIgnoreEmptyUpdate(bool ignoreEmptyUpdate)
		{
			return SetValue(o => o._ignoreEmptyUpdate = ignoreEmptyUpdate);
		}

		public virtual LinqOptionsExtension WithGenerateExpressionTest(bool generateExpressionTest)
		{
			return SetValue(o => o._generateExpressionTest = generateExpressionTest);
		}

		public virtual LinqOptionsExtension WithTraceMapperExpression(bool traceMapperExpression)
		{
			return SetValue(o => o._traceMapperExpression = traceMapperExpression);
		}

		public virtual LinqOptionsExtension WithDoNotClearOrderBys(bool doNotClearOrderBys)
		{
			return SetValue(o => o._doNotClearOrderBys = doNotClearOrderBys);
		}

		public virtual LinqOptionsExtension WithOptimizeJoins(bool optimizeJoins)
		{
			return SetValue(o => o._optimizeJoins = optimizeJoins);
		}

		public virtual LinqOptionsExtension WithCompareNullsAsValues(bool compareNullsAsValues)
		{
			return SetValue(o => o._compareNullsAsValues = compareNullsAsValues);
		}

		public virtual LinqOptionsExtension WithGuardGrouping(bool guardGrouping)
		{
			return SetValue(o => o._guardGrouping = guardGrouping);
		}

		public virtual LinqOptionsExtension WithDisableQueryCache(bool disableQueryCache)
		{
			return SetValue(o => o._disableQueryCache = disableQueryCache);
		}

		public virtual LinqOptionsExtension WithCacheSlidingExpiration(TimeSpan cacheSlidingExpiration)
		{
			return SetValue(o => o._cacheSlidingExpiration = cacheSlidingExpiration);
		}

		public virtual LinqOptionsExtension WithPreferApply(bool preferApply)
		{
			return SetValue(o => o._preferApply = preferApply);
		}

		public virtual LinqOptionsExtension WithKeepDistinctOrdered(bool keepDistinctOrdered)
		{
			return SetValue(o => o._keepDistinctOrdered = keepDistinctOrdered);
		}

		public virtual LinqOptionsExtension WithParameterizeTakeSkip(bool parameterizeTakeSkip)
		{
			return SetValue(o => o._parameterizeTakeSkip = parameterizeTakeSkip);
		}

		#endregion

		#region Helper Methods

		protected virtual LinqOptionsExtension Clone()
		{
			return new LinqOptionsExtension(this);
		}

		LinqOptionsExtension SetValue(Action<LinqOptionsExtension> setter)
		{
			var clone = Clone();

			setter(clone);

			return clone;
		}

		#endregion

		public DataContextOptionsExtensionInfo Info => throw new NotImplementedException();

		public void ApplyServices()
		{
		}

		public void Validate(IDataContextOptions options)
		{
		}

		#region IEquatable implementation

		public bool Equals(LinqOptionsExtension? other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				_preloadGroups          == other._preloadGroups               &&
				_ignoreEmptyUpdate      == other._ignoreEmptyUpdate           &&
				_generateExpressionTest == other._generateExpressionTest      &&
				_traceMapperExpression  == other._traceMapperExpression       &&
				_doNotClearOrderBys     == other._doNotClearOrderBys          &&
				_optimizeJoins          == other._optimizeJoins               &&
				_compareNullsAsValues   == other._compareNullsAsValues        &&
				_guardGrouping          == other._guardGrouping               &&
				_disableQueryCache      == other._disableQueryCache           &&
				_cacheSlidingExpiration.Equals(other._cacheSlidingExpiration) &&
				_preferApply            == other._preferApply                   &&
				_keepDistinctOrdered    == other._keepDistinctOrdered           &&
				_parameterizeTakeSkip   == other._parameterizeTakeSkip;
		}

		public override bool Equals(object? obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;

			if (obj.GetType() != this.GetType())
				return false;

			return Equals((LinqOptionsExtension)obj);
		}

		[SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = _preloadGroups.GetHashCode();
				hashCode = (hashCode * 397) ^ _ignoreEmptyUpdate.GetHashCode();
				hashCode = (hashCode * 397) ^ _generateExpressionTest.GetHashCode();
				hashCode = (hashCode * 397) ^ _traceMapperExpression.GetHashCode();
				hashCode = (hashCode * 397) ^ _doNotClearOrderBys.GetHashCode();
				hashCode = (hashCode * 397) ^ _optimizeJoins.GetHashCode();
				hashCode = (hashCode * 397) ^ _compareNullsAsValues.GetHashCode();
				hashCode = (hashCode * 397) ^ _guardGrouping.GetHashCode();
				hashCode = (hashCode * 397) ^ _disableQueryCache.GetHashCode();
				hashCode = (hashCode * 397) ^ _cacheSlidingExpiration.GetHashCode();
				hashCode = (hashCode * 397) ^ _preferApply.GetHashCode();
				hashCode = (hashCode * 397) ^ _keepDistinctOrdered.GetHashCode();
				hashCode = (hashCode * 397) ^ _parameterizeTakeSkip.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(LinqOptionsExtension? left, LinqOptionsExtension? right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(LinqOptionsExtension? left, LinqOptionsExtension? right)
		{
			return !Equals(left, right);
		}

		#endregion
	}
}
