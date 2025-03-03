// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.NoMetadata.Access.Odbc
{
	public partial class TestDataDB : DataConnection
	{
		public TestDataDB()
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		public TestDataDB(DataOptions<TestDataDB> options)
			: base(options.Options)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<AllType>             AllTypes             => this.GetTable<AllType>();
		public ITable<Child>               Children             => this.GetTable<Child>();
		public ITable<DataTypeTest>        DataTypeTests        => this.GetTable<DataTypeTest>();
		public ITable<Doctor>              Doctors              => this.GetTable<Doctor>();
		public ITable<Dual>                Duals                => this.GetTable<Dual>();
		public ITable<GrandChild>          GrandChildren        => this.GetTable<GrandChild>();
		public ITable<InheritanceChild>    InheritanceChildren  => this.GetTable<InheritanceChild>();
		public ITable<InheritanceParent>   InheritanceParents   => this.GetTable<InheritanceParent>();
		public ITable<LinqDataType>        LinqDataTypes        => this.GetTable<LinqDataType>();
		public ITable<Parent>              Parents              => this.GetTable<Parent>();
		public ITable<Patient>             Patients             => this.GetTable<Patient>();
		public ITable<Person>              People               => this.GetTable<Person>();
		public ITable<TestIdentity>        TestIdentities       => this.GetTable<TestIdentity>();
		public ITable<TestMerge1>          TestMerge1           => this.GetTable<TestMerge1>();
		public ITable<TestMerge2>          TestMerge2           => this.GetTable<TestMerge2>();
		public ITable<LinqDataTypesQuery>  LinqDataTypesQueries => this.GetTable<LinqDataTypesQuery>();
		public ITable<LinqDataTypesQuery1> LinqDataTypesQuery1  => this.GetTable<LinqDataTypesQuery1>();
		public ITable<LinqDataTypesQuery2> LinqDataTypesQuery2  => this.GetTable<LinqDataTypesQuery2>();
		public ITable<PatientSelectAll>    PatientSelectAll     => this.GetTable<PatientSelectAll>();
		public ITable<PersonSelectAll>     PersonSelectAll      => this.GetTable<PersonSelectAll>();
		public ITable<ScalarDataReader>    ScalarDataReaders    => this.GetTable<ScalarDataReader>();
	}

	public static partial class ExtensionMethods
	{
		#region Stored Procedures
		#region PatientSelectByName
		public static IEnumerable<PatientSelectByNameResult> PatientSelectByName(this TestDataDB dataConnection, string? firstName, string? lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@lastName", lastName, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.QueryProc<PatientSelectByNameResult>("[Patient_SelectByName]", parameters);
		}

		public static Task<IEnumerable<PatientSelectByNameResult>> PatientSelectByNameAsync(this TestDataDB dataConnection, string? firstName, string? lastName, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@lastName", lastName, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.QueryProcAsync<PatientSelectByNameResult>("[Patient_SelectByName]", cancellationToken, parameters);
		}

		public partial class PatientSelectByNameResult
		{
			public int     PersonId   { get; set; }
			public string? FirstName  { get; set; }
			public string? LastName   { get; set; }
			public string? MiddleName { get; set; }
			public string? Gender     { get; set; }
			public string? Diagnosis  { get; set; }
		}
		#endregion

		#region PersonDelete
		public static int PersonDelete(this TestDataDB dataConnection, int? personId)
		{
			var parameters = new []
			{
				new DataParameter("@PersonID", personId, DataType.Int32)
			};
			return dataConnection.ExecuteProc("[Person_Delete]", parameters);
		}

		public static Task<int> PersonDeleteAsync(this TestDataDB dataConnection, int? personId, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@PersonID", personId, DataType.Int32)
			};
			return dataConnection.ExecuteProcAsync("[Person_Delete]", cancellationToken, parameters);
		}
		#endregion

		#region PersonInsert
		public static int PersonInsert(this TestDataDB dataConnection, string? firstName, string? middleName, string? lastName, string? gender)
		{
			var parameters = new []
			{
				new DataParameter("@FirstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@MiddleName", middleName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@LastName", lastName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@Gender", gender, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.ExecuteProc("[Person_Insert]", parameters);
		}

		public static Task<int> PersonInsertAsync(this TestDataDB dataConnection, string? firstName, string? middleName, string? lastName, string? gender, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@FirstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@MiddleName", middleName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@LastName", lastName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@Gender", gender, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.ExecuteProcAsync("[Person_Insert]", cancellationToken, parameters);
		}
		#endregion

		#region PersonSelectByKey
		public static IEnumerable<PersonSelectByKeyResult> PersonSelectByKey(this TestDataDB dataConnection, int? id)
		{
			var parameters = new []
			{
				new DataParameter("@id", id, DataType.Int32)
			};
			return dataConnection.QueryProc<PersonSelectByKeyResult>("[Person_SelectByKey]", parameters);
		}

		public static Task<IEnumerable<PersonSelectByKeyResult>> PersonSelectByKeyAsync(this TestDataDB dataConnection, int? id, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@id", id, DataType.Int32)
			};
			return dataConnection.QueryProcAsync<PersonSelectByKeyResult>("[Person_SelectByKey]", cancellationToken, parameters);
		}

		public partial class PersonSelectByKeyResult
		{
			public int     PersonId   { get; set; }
			public string? FirstName  { get; set; }
			public string? LastName   { get; set; }
			public string? MiddleName { get; set; }
			public string? Gender     { get; set; }
		}
		#endregion

		#region PersonSelectByName
		public static IEnumerable<PersonSelectByNameResult> PersonSelectByName(this TestDataDB dataConnection, string? firstName, string? lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@lastName", lastName, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.QueryProc<PersonSelectByNameResult>("[Person_SelectByName]", parameters);
		}

		public static Task<IEnumerable<PersonSelectByNameResult>> PersonSelectByNameAsync(this TestDataDB dataConnection, string? firstName, string? lastName, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@lastName", lastName, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.QueryProcAsync<PersonSelectByNameResult>("[Person_SelectByName]", cancellationToken, parameters);
		}

		public partial class PersonSelectByNameResult
		{
			public int     PersonId   { get; set; }
			public string? FirstName  { get; set; }
			public string? LastName   { get; set; }
			public string? MiddleName { get; set; }
			public string? Gender     { get; set; }
		}
		#endregion

		#region PersonSelectListByName
		public static IEnumerable<PersonSelectListByNameResult> PersonSelectListByName(this TestDataDB dataConnection, string? firstName, string? lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@lastName", lastName, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.QueryProc<PersonSelectListByNameResult>("[Person_SelectListByName]", parameters);
		}

		public static Task<IEnumerable<PersonSelectListByNameResult>> PersonSelectListByNameAsync(this TestDataDB dataConnection, string? firstName, string? lastName, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@lastName", lastName, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.QueryProcAsync<PersonSelectListByNameResult>("[Person_SelectListByName]", cancellationToken, parameters);
		}

		public partial class PersonSelectListByNameResult
		{
			public int     PersonId   { get; set; }
			public string? FirstName  { get; set; }
			public string? LastName   { get; set; }
			public string? MiddleName { get; set; }
			public string? Gender     { get; set; }
		}
		#endregion

		#region PersonUpdate
		public static int PersonUpdate(this TestDataDB dataConnection, int? id, int? personId, string? firstName, string? middleName, string? lastName, string? gender)
		{
			var parameters = new []
			{
				new DataParameter("@id", id, DataType.Int32),
				new DataParameter("@PersonID", personId, DataType.Int32),
				new DataParameter("@FirstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@MiddleName", middleName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@LastName", lastName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@Gender", gender, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.ExecuteProc("[Person_Update]", parameters);
		}

		public static Task<int> PersonUpdateAsync(this TestDataDB dataConnection, int? id, int? personId, string? firstName, string? middleName, string? lastName, string? gender, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@id", id, DataType.Int32),
				new DataParameter("@PersonID", personId, DataType.Int32),
				new DataParameter("@FirstName", firstName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@MiddleName", middleName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@LastName", lastName, DataType.VarChar)
				{
					Size = 255
				},
				new DataParameter("@Gender", gender, DataType.VarChar)
				{
					Size = 255
				}
			};
			return dataConnection.ExecuteProcAsync("[Person_Update]", cancellationToken, parameters);
		}
		#endregion
		#endregion
	}
}
