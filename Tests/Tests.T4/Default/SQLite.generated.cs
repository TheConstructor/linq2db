﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1573, 1591
#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Mapping;

namespace Default.SQLite
{
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>           AllTypes            { get { return this.GetTable<AllType>(); } }
		public ITable<Child>             Children            { get { return this.GetTable<Child>(); } }
		public ITable<Doctor>            Doctors             { get { return this.GetTable<Doctor>(); } }
		public ITable<Dual>              Duals               { get { return this.GetTable<Dual>(); } }
		public ITable<FKTestPosition>    FKTestPositions     { get { return this.GetTable<FKTestPosition>(); } }
		public ITable<ForeignKeyTable>   ForeignKeyTables    { get { return this.GetTable<ForeignKeyTable>(); } }
		public ITable<GrandChild>        GrandChildren       { get { return this.GetTable<GrandChild>(); } }
		public ITable<InheritanceChild>  InheritanceChildren { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent> InheritanceParents  { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<LinqDataType>      LinqDataTypes       { get { return this.GetTable<LinqDataType>(); } }
		public ITable<Parent>            Parents             { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>           Patients            { get { return this.GetTable<Patient>(); } }
		public ITable<Person>            People              { get { return this.GetTable<Person>(); } }
		public ITable<PrimaryKeyTable>   PrimaryKeyTables    { get { return this.GetTable<PrimaryKeyTable>(); } }
		public ITable<TestIdentity>      TestIdentities      { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>        TestMerge1          { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>        TestMerge2          { get { return this.GetTable<TestMerge2>(); } }
		public ITable<TestT4Casing>      TestT4Casings       { get { return this.GetTable<TestT4Casing>(); } }

		public TestDataDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(DataOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Column(),                           PrimaryKey, Identity] public long      ID                       { get; set; } // integer
		[Column("bigintDataType"),           Nullable            ] public long?     BigintDataType           { get; set; } // bigint
		[Column("numericDataType"),          Nullable            ] public decimal?  NumericDataType          { get; set; } // numeric
		[Column("bitDataType"),              Nullable            ] public bool?     BitDataType              { get; set; } // bit
		[Column("smallintDataType"),         Nullable            ] public short?    SmallintDataType         { get; set; } // smallint
		[Column("decimalDataType"),          Nullable            ] public decimal?  DecimalDataType          { get; set; } // decimal
		[Column("intDataType"),              Nullable            ] public int?      IntDataType              { get; set; } // int
		[Column("tinyintDataType"),          Nullable            ] public byte?     TinyintDataType          { get; set; } // tinyint
		[Column("moneyDataType"),            Nullable            ] public decimal?  MoneyDataType            { get; set; } // money
		[Column("floatDataType"),            Nullable            ] public double?   FloatDataType            { get; set; } // float
		[Column("realDataType"),             Nullable            ] public double?   RealDataType             { get; set; } // real
		[Column("datetimeDataType"),         Nullable            ] public DateTime? DatetimeDataType         { get; set; } // datetime
		[Column("charDataType"),             Nullable            ] public char?     CharDataType             { get; set; } // char(1)
		[Column("char20DataType"),           Nullable            ] public string?   Char20DataType           { get; set; } // char(20)
		[Column("varcharDataType"),          Nullable            ] public string?   VarcharDataType          { get; set; } // varchar(20)
		[Column("textDataType"),             Nullable            ] public string?   TextDataType             { get; set; } // text(max)
		[Column("ncharDataType"),            Nullable            ] public string?   NcharDataType            { get; set; } // char(20)
		[Column("nvarcharDataType"),         Nullable            ] public string?   NvarcharDataType         { get; set; } // nvarchar(20)
		[Column("ntextDataType"),            Nullable            ] public string?   NtextDataType            { get; set; } // ntext(max)
		[Column("binaryDataType"),           Nullable            ] public byte[]?   BinaryDataType           { get; set; } // binary
		[Column("varbinaryDataType"),        Nullable            ] public byte[]?   VarbinaryDataType        { get; set; } // varbinary
		[Column("imageDataType"),            Nullable            ] public byte[]?   ImageDataType            { get; set; } // image
		[Column("uniqueidentifierDataType"), Nullable            ] public Guid?     UniqueidentifierDataType { get; set; } // uniqueidentifier
		[Column("objectDataType"),           Nullable            ] public object?   ObjectDataType           { get; set; } // object
	}

	[Table("Child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? ChildID  { get; set; } // int
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[PrimaryKey, NotNull] public long   PersonID { get; set; } // integer
		[Column,     NotNull] public string Taxonomy { get; set; } = null!; // nvarchar(50)

		#region Associations

		/// <summary>
		/// FK_Doctor_0_0 (main.Person)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table("Dual")]
	public partial class Dual
	{
		[Column, Nullable] public string? Dummy { get; set; } // varchar(10)
	}

	[Table("FKTestPosition")]
	public partial class FKTestPosition
	{
		[PrimaryKey(0), NotNull] public long   Company    { get; set; } // integer
		[PrimaryKey(1), NotNull] public long   Department { get; set; } // integer
		[PrimaryKey(2), NotNull] public long   PositionID { get; set; } // integer
		[Column,        NotNull] public string Name       { get; set; } = null!; // nvarchar(50)
	}

	[Table("ForeignKeyTable")]
	public partial class ForeignKeyTable
	{
		[Column, NotNull] public long   PrimaryKeyTableID { get; set; } // integer
		[Column, NotNull] public string Name              { get; set; } = null!; // nvarchar(50)

		#region Associations

		/// <summary>
		/// FK_ForeignKeyTable_0_0 (main.PrimaryKeyTable)
		/// </summary>
		[Association(ThisKey="PrimaryKeyTableID", OtherKey="ID", CanBeNull=false)]
		public PrimaryKeyTable PrimaryKeyTable { get; set; } = null!;

		#endregion
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // int
		[Column, Nullable] public int? ChildID      { get; set; } // int
		[Column, Nullable] public int? GrandChildID { get; set; } // int
	}

	[Table("InheritanceChild")]
	public partial class InheritanceChild
	{
		[Column, NotNull    ] public long    InheritanceChildId  { get; set; } // integer
		[Column, NotNull    ] public long    InheritanceParentId { get; set; } // integer
		[Column,    Nullable] public long?   TypeDiscriminator   { get; set; } // integer
		[Column,    Nullable] public string? Name                { get; set; } // nvarchar(50)
	}

	[Table("InheritanceParent")]
	public partial class InheritanceParent
	{
		[Column, NotNull    ] public long    InheritanceParentId { get; set; } // integer
		[Column,    Nullable] public long?   TypeDiscriminator   { get; set; } // integer
		[Column,    Nullable] public string? Name                { get; set; } // nvarchar(50)
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, Nullable] public int?      ID             { get; set; } // int
		[Column, Nullable] public decimal?  MoneyValue     { get; set; } // decimal
		[Column, Nullable] public DateTime? DateTimeValue  { get; set; } // datetime
		[Column, Nullable] public DateTime? DateTimeValue2 { get; set; } // datetime2
		[Column, Nullable] public bool?     BoolValue      { get; set; } // boolean
		[Column, Nullable] public Guid?     GuidValue      { get; set; } // uniqueidentifier
		[Column, Nullable] public byte[]?   BinaryValue    { get; set; } // binary
		[Column, Nullable] public short?    SmallIntValue  { get; set; } // smallint
		[Column, Nullable] public int?      IntValue       { get; set; } // int
		[Column, Nullable] public long?     BigIntValue    { get; set; } // bigint
		[Column, Nullable] public string?   StringValue    { get; set; } // nvarchar(50)
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? Value1   { get; set; } // int
	}

	[Table("Patient")]
	public partial class Patient
	{
		[PrimaryKey, NotNull] public long   PersonID  { get; set; } // integer
		[Column,     NotNull] public string Diagnosis { get; set; } = null!; // nvarchar(256)

		#region Associations

		/// <summary>
		/// FK_Patient_0_0 (main.Person)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table("Person")]
	public partial class Person
	{
		[PrimaryKey, Identity   ] public long    PersonID   { get; set; } // integer
		[Column,     NotNull    ] public string  FirstName  { get; set; } = null!; // nvarchar(50)
		[Column,     NotNull    ] public string  LastName   { get; set; } = null!; // nvarchar(50)
		[Column,        Nullable] public string? MiddleName { get; set; } // nvarchar(50)
		[Column,     NotNull    ] public char    Gender     { get; set; } // char(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_0_0_BackReference (main.Doctor)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public Doctor? Doctor { get; set; }

		/// <summary>
		/// FK_Patient_0_0_BackReference (main.Patient)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public Patient? Patient { get; set; }

		#endregion
	}

	[Table("PrimaryKeyTable")]
	public partial class PrimaryKeyTable
	{
		[PrimaryKey, NotNull] public long   ID   { get; set; } // integer
		[Column,     NotNull] public string Name { get; set; } = null!; // nvarchar(50)

		#region Associations

		/// <summary>
		/// FK_ForeignKeyTable_0_0_BackReference (main.ForeignKeyTable)
		/// </summary>
		[Association(ThisKey="ID", OtherKey="PrimaryKeyTableID", CanBeNull=true)]
		public IEnumerable<ForeignKeyTable> ForeignKeyTables { get; set; } = null!;

		#endregion
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, Identity] public long ID { get; set; } // integer
	}

	[Table("TestMerge1")]
	public partial class TestMerge1
	{
		[Column, NotNull    ] public long      Id              { get; set; } // integer
		[Column,    Nullable] public long?     Field1          { get; set; } // integer
		[Column,    Nullable] public long?     Field2          { get; set; } // integer
		[Column,    Nullable] public long?     Field3          { get; set; } // integer
		[Column,    Nullable] public long?     Field4          { get; set; } // integer
		[Column,    Nullable] public long?     Field5          { get; set; } // integer
		[Column,    Nullable] public long?     FieldInt64      { get; set; } // bigint
		[Column,    Nullable] public bool?     FieldBoolean    { get; set; } // bit
		[Column,    Nullable] public string?   FieldString     { get; set; } // varchar(20)
		[Column,    Nullable] public string?   FieldNString    { get; set; } // nvarchar(20)
		[Column,    Nullable] public char?     FieldChar       { get; set; } // char(1)
		[Column,    Nullable] public char?     FieldNChar      { get; set; } // char(1)
		[Column,    Nullable] public double?   FieldFloat      { get; set; } // float
		[Column,    Nullable] public double?   FieldDouble     { get; set; } // float
		[Column,    Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,    Nullable] public byte[]?   FieldBinary     { get; set; } // varbinary
		[Column,    Nullable] public Guid?     FieldGuid       { get; set; } // uniqueidentifier
		[Column,    Nullable] public DateTime? FieldDate       { get; set; } // date
		[Column,    Nullable] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column,    Nullable] public int?      FieldEnumNumber { get; set; } // int
	}

	[Table("TestMerge2")]
	public partial class TestMerge2
	{
		[Column, NotNull    ] public long      Id              { get; set; } // integer
		[Column,    Nullable] public long?     Field1          { get; set; } // integer
		[Column,    Nullable] public long?     Field2          { get; set; } // integer
		[Column,    Nullable] public long?     Field3          { get; set; } // integer
		[Column,    Nullable] public long?     Field4          { get; set; } // integer
		[Column,    Nullable] public long?     Field5          { get; set; } // integer
		[Column,    Nullable] public long?     FieldInt64      { get; set; } // bigint
		[Column,    Nullable] public bool?     FieldBoolean    { get; set; } // bit
		[Column,    Nullable] public string?   FieldString     { get; set; } // varchar(20)
		[Column,    Nullable] public string?   FieldNString    { get; set; } // nvarchar(20)
		[Column,    Nullable] public char?     FieldChar       { get; set; } // char(1)
		[Column,    Nullable] public char?     FieldNChar      { get; set; } // char(1)
		[Column,    Nullable] public double?   FieldFloat      { get; set; } // float
		[Column,    Nullable] public double?   FieldDouble     { get; set; } // float
		[Column,    Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,    Nullable] public byte[]?   FieldBinary     { get; set; } // varbinary
		[Column,    Nullable] public Guid?     FieldGuid       { get; set; } // uniqueidentifier
		[Column,    Nullable] public DateTime? FieldDate       { get; set; } // date
		[Column,    Nullable] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column,    Nullable] public int?      FieldEnumNumber { get; set; } // int
	}

	[Table("TEST_T4_CASING")]
	public partial class TestT4Casing
	{
		[Column("ALL_CAPS"),              NotNull] public int AllCaps             { get; set; } // int
		[Column(),                        NotNull] public int CAPS                { get; set; } // int
		[Column(),                        NotNull] public int PascalCase          { get; set; } // int
		[Column("Pascal_Snake_Case"),     NotNull] public int PascalSnakeCase     { get; set; } // int
		[Column("PascalCase_Snake_Case"), NotNull] public int PascalCaseSnakeCase { get; set; } // int
		[Column("snake_case"),            NotNull] public int SnakeCase           { get; set; } // int
		[Column("camelCase"),             NotNull] public int CamelCase           { get; set; } // int
	}

	public static partial class TableExtensions
	{
		public static AllType? Find(this ITable<AllType> table, long ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Doctor? Find(this ITable<Doctor> table, long PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static FKTestPosition? Find(this ITable<FKTestPosition> table, long Company, long Department, long PositionID)
		{
			return table.FirstOrDefault(t =>
				t.Company    == Company    &&
				t.Department == Department &&
				t.PositionID == PositionID);
		}

		public static Patient? Find(this ITable<Patient> table, long PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person? Find(this ITable<Person> table, long PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static PrimaryKeyTable? Find(this ITable<PrimaryKeyTable> table, long ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, long ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}
	}
}
