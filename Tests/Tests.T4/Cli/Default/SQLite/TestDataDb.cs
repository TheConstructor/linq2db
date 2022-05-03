// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.SQLite
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

		public TestDataDB(DataContextOptions<TestDataDB> options)
			: base(options)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<Dual>              Duals               => this.GetTable<Dual>();
		public ITable<InheritanceParent> InheritanceParents  => this.GetTable<InheritanceParent>();
		public ITable<InheritanceChild>  InheritanceChildren => this.GetTable<InheritanceChild>();
		public ITable<Person>            People              => this.GetTable<Person>();
		public ITable<Doctor>            Doctors             => this.GetTable<Doctor>();
		public ITable<Patient>           Patients            => this.GetTable<Patient>();
		public ITable<Parent>            Parents             => this.GetTable<Parent>();
		public ITable<Child>             Children            => this.GetTable<Child>();
		public ITable<GrandChild>        GrandChildren       => this.GetTable<GrandChild>();
		public ITable<LinqDataType>      LinqDataTypes       => this.GetTable<LinqDataType>();
		public ITable<TestIdentity>      TestIdentities      => this.GetTable<TestIdentity>();
		public ITable<AllType>           AllTypes            => this.GetTable<AllType>();
		public ITable<PrimaryKeyTable>   PrimaryKeyTables    => this.GetTable<PrimaryKeyTable>();
		public ITable<ForeignKeyTable>   ForeignKeyTables    => this.GetTable<ForeignKeyTable>();
		public ITable<FkTestPosition>    FkTestPositions     => this.GetTable<FkTestPosition>();
		public ITable<TestMerge1>        TestMerge1          => this.GetTable<TestMerge1>();
		public ITable<TestMerge2>        TestMerge2          => this.GetTable<TestMerge2>();
		public ITable<TestT4Casing>      TestT4Casings       => this.GetTable<TestT4Casing>();
	}

	public static partial class ExtensionMethods
	{
		#region Table Extensions
		public static Person? Find(this ITable<Person> table, long personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Person?> FindAsync(this ITable<Person> table, long personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static Doctor? Find(this ITable<Doctor> table, long personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Doctor?> FindAsync(this ITable<Doctor> table, long personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static Patient? Find(this ITable<Patient> table, long personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Patient?> FindAsync(this ITable<Patient> table, long personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, long id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestIdentity?> FindAsync(this ITable<TestIdentity> table, long id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static AllType? Find(this ITable<AllType> table, long id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<AllType?> FindAsync(this ITable<AllType> table, long id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static PrimaryKeyTable? Find(this ITable<PrimaryKeyTable> table, long id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<PrimaryKeyTable?> FindAsync(this ITable<PrimaryKeyTable> table, long id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static FkTestPosition? Find(this ITable<FkTestPosition> table, long company, long department, long positionId)
		{
			return table.FirstOrDefault(e => e.Company == company && e.Department == department && e.PositionId == positionId);
		}

		public static Task<FkTestPosition?> FindAsync(this ITable<FkTestPosition> table, long company, long department, long positionId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Company == company && e.Department == department && e.PositionId == positionId, cancellationToken);
		}
		#endregion
	}
}
