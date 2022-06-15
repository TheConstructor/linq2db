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
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace SybaseDataActionDataContext
{
	public partial class TestDataCoreDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>           AllTypes            { get { return this.GetTable<AllType>(); } }
		public ITable<Child>             Children            { get { return this.GetTable<Child>(); } }
		public ITable<CollatedTable>     CollatedTables      { get { return this.GetTable<CollatedTable>(); } }
		public ITable<Doctor>            Doctors             { get { return this.GetTable<Doctor>(); } }
		public ITable<GrandChild>        GrandChildren       { get { return this.GetTable<GrandChild>(); } }
		public ITable<InheritanceChild>  InheritanceChildren { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent> InheritanceParents  { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<KeepIdentityTest>  KeepIdentityTests   { get { return this.GetTable<KeepIdentityTest>(); } }
		public ITable<LinqDataType>      LinqDataTypes       { get { return this.GetTable<LinqDataType>(); } }
		public ITable<Parent>            Parents             { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>           Patients            { get { return this.GetTable<Patient>(); } }
		public ITable<Person>            People              { get { return this.GetTable<Person>(); } }
		public ITable<SysObject>         SysObjects          { get { return this.GetTable<SysObject>(); } }
		public ITable<Sysquerymetric>    Sysquerymetrics     { get { return this.GetTable<Sysquerymetric>(); } }
		public ITable<TestIdentity>      TestIdentities      { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>        TestMerge1          { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>        TestMerge2          { get { return this.GetTable<TestMerge2>(); } }
		public ITable<TestMergeIdentity> TestMergeIdentities { get { return this.GetTable<TestMergeIdentity>(); } }

		public TestDataCoreDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataCoreDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataCoreDB(DataOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table(Schema="dbo", Name="AllTypes")]
	public partial class AllType
	{
		[Column(),                                                              Identity   ] public int       ID                    { get; set; } // int
		[Column("bigintDataType"),                                                 Nullable] public long?     BigintDataType        { get; set; } // bigint
		[Column("uBigintDataType"),                                                Nullable] public ulong?    UBigintDataType       { get; set; } // ubigint
		[Column("numericDataType"),                                                Nullable] public decimal?  NumericDataType       { get; set; } // numeric(18, 1)
		[Column("bitDataType"),                                                 NotNull    ] public bool      BitDataType           { get; set; } // bit
		[Column("smallintDataType"),                                               Nullable] public short?    SmallintDataType      { get; set; } // smallint
		[Column("uSmallintDataType"),                                              Nullable] public ushort?   USmallintDataType     { get; set; } // usmallint
		[Column("decimalDataType"),                                                Nullable] public decimal?  DecimalDataType       { get; set; } // decimal(18, 1)
		[Column("smallmoneyDataType"),                                             Nullable] public decimal?  SmallmoneyDataType    { get; set; } // smallmoney
		[Column("intDataType"),                                                    Nullable] public int?      IntDataType           { get; set; } // int
		[Column("uIntDataType"),                                                   Nullable] public uint?     UIntDataType          { get; set; } // uint
		[Column("tinyintDataType"),                                                Nullable] public sbyte?    TinyintDataType       { get; set; } // tinyint
		[Column("moneyDataType"),                                                  Nullable] public decimal?  MoneyDataType         { get; set; } // money
		[Column("floatDataType"),                                                  Nullable] public double?   FloatDataType         { get; set; } // float
		[Column("realDataType"),                                                   Nullable] public float?    RealDataType          { get; set; } // real
		[Column("datetimeDataType"),                                               Nullable] public DateTime? DatetimeDataType      { get; set; } // datetime
		[Column("smalldatetimeDataType"),                                          Nullable] public DateTime? SmalldatetimeDataType { get; set; } // smalldatetime
		[Column("dateDataType"),                                                   Nullable] public DateTime? DateDataType          { get; set; } // date
		[Column("timeDataType"),                                                   Nullable] public TimeSpan? TimeDataType          { get; set; } // time
		[Column("charDataType"),                                                   Nullable] public char?     CharDataType          { get; set; } // char(1)
		[Column("char20DataType"),                                                 Nullable] public string?   Char20DataType        { get; set; } // char(20)
		[Column("varcharDataType"),                                                Nullable] public string?   VarcharDataType       { get; set; } // varchar(20)
		[Column("textDataType"),                                                   Nullable] public string?   TextDataType          { get; set; } // text
		[Column("ncharDataType"),                                                  Nullable] public string?   NcharDataType         { get; set; } // nchar(60)
		[Column("nvarcharDataType"),                                               Nullable] public string?   NvarcharDataType      { get; set; } // nvarchar(60)
		[Column("ntextDataType"),                                                  Nullable] public string?   NtextDataType         { get; set; } // unitext
		[Column("binaryDataType"),                                                 Nullable] public byte[]?   BinaryDataType        { get; set; } // binary(1)
		[Column("varbinaryDataType"),                                              Nullable] public byte[]?   VarbinaryDataType     { get; set; } // varbinary(1)
		[Column("imageDataType"),                                                  Nullable] public byte[]?   ImageDataType         { get; set; } // image
		[Column("timestampDataType",     SkipOnInsert=true, SkipOnUpdate=true),    Nullable] public byte[]?   TimestampDataType     { get; set; } // timestamp
	}

	[Table(Schema="dbo", Name="Child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? ChildID  { get; set; } // int
	}

	[Table(Schema="dbo", Name="CollatedTable")]
	public partial class CollatedTable
	{
		[Column, NotNull] public int    Id              { get; set; } // int
		[Column, NotNull] public string CaseSensitive   { get; set; } = null!; // nvarchar(60)
		[Column, NotNull] public string CaseInsensitive { get; set; } = null!; // nvarchar(60)
	}

	[Table(Schema="dbo", Name="Doctor")]
	public partial class Doctor
	{
		[PrimaryKey, NotNull] public int    PersonID { get; set; } // int
		[Column,     NotNull] public string Taxonomy { get; set; } = null!; // nvarchar(150)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person (dbo.Person)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table(Schema="dbo", Name="GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // int
		[Column, Nullable] public int? ChildID      { get; set; } // int
		[Column, Nullable] public int? GrandChildID { get; set; } // int
	}

	[Table(Schema="dbo", Name="InheritanceChild")]
	public partial class InheritanceChild
	{
		[PrimaryKey, NotNull    ] public int     InheritanceChildId  { get; set; } // int
		[Column,     NotNull    ] public int     InheritanceParentId { get; set; } // int
		[Column,        Nullable] public int?    TypeDiscriminator   { get; set; } // int
		[Column,        Nullable] public string? Name                { get; set; } // nvarchar(150)
	}

	[Table(Schema="dbo", Name="InheritanceParent")]
	public partial class InheritanceParent
	{
		[PrimaryKey, NotNull    ] public int     InheritanceParentId { get; set; } // int
		[Column,        Nullable] public int?    TypeDiscriminator   { get; set; } // int
		[Column,        Nullable] public string? Name                { get; set; } // nvarchar(150)
	}

	[Table(Schema="dbo", Name="KeepIdentityTest")]
	public partial class KeepIdentityTest
	{
		[Identity          ] public int  ID    { get; set; } // int
		[Column,   Nullable] public int? Value { get; set; } // int
	}

	[Table(Schema="dbo", Name="LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, NotNull    ] public int       ID             { get; set; } // int
		[Column,    Nullable] public decimal?  MoneyValue     { get; set; } // decimal(10, 4)
		[Column,    Nullable] public DateTime? DateTimeValue  { get; set; } // datetime
		[Column,    Nullable] public DateTime? DateTimeValue2 { get; set; } // datetime
		[Column, NotNull    ] public bool      BoolValue      { get; set; } // bit
		[Column,    Nullable] public string?   GuidValue      { get; set; } // char(36)
		[Column,    Nullable] public byte[]?   BinaryValue    { get; set; } // binary(500)
		[Column,    Nullable] public short?    SmallIntValue  { get; set; } // smallint
		[Column,    Nullable] public int?      IntValue       { get; set; } // int
		[Column,    Nullable] public long?     BigIntValue    { get; set; } // bigint
		[Column,    Nullable] public string?   StringValue    { get; set; } // nvarchar(150)
	}

	[Table(Schema="dbo", Name="Parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? Value1   { get; set; } // int
	}

	[Table(Schema="dbo", Name="Patient")]
	public partial class Patient
	{
		[PrimaryKey, NotNull] public int    PersonID  { get; set; } // int
		[Column,     NotNull] public string Diagnosis { get; set; } = null!; // nvarchar(768)

		#region Associations

		/// <summary>
		/// FK_Patient_Person (dbo.Person)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table(Schema="dbo", Name="Person")]
	public partial class Person
	{
		[PrimaryKey, Identity   ] public int     PersonID   { get; set; } // int
		[Column,     NotNull    ] public string  FirstName  { get; set; } = null!; // nvarchar(150)
		[Column,     NotNull    ] public string  LastName   { get; set; } = null!; // nvarchar(150)
		[Column,        Nullable] public string? MiddleName { get; set; } // nvarchar(150)
		[Column,     NotNull    ] public char    Gender     { get; set; } // char(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference (dbo.Doctor)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public Doctor? Doctor { get; set; }

		/// <summary>
		/// FK_Patient_Person_BackReference (dbo.Patient)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public Patient? Patient { get; set; }

		#endregion
	}

	[Table("sysobjects")]
	public partial class SysObject
	{
		[Column, NotNull    ] public string   name      { get; set; } = null!; // varchar
		[Column, NotNull    ] public int      id        { get; set; } // int
		[Column, NotNull    ] public int      uid       { get; set; } // int
		[Column, NotNull    ] public string   type      { get; set; } = null!; // char
		[Column, NotNull    ] public short    userstat  { get; set; } // smallint
		[Column, NotNull    ] public short    sysstat   { get; set; } // smallint
		[Column, NotNull    ] public short    indexdel  { get; set; } // smallint
		[Column, NotNull    ] public short    schemacnt { get; set; } // smallint
		[Column, NotNull    ] public int      sysstat2  { get; set; } // int
		[Column, NotNull    ] public DateTime crdate    { get; set; } // datetime
		[Column, NotNull    ] public DateTime expdate   { get; set; } // datetime
		[Column, NotNull    ] public int      deltrig   { get; set; } // int
		[Column, NotNull    ] public int      instrig   { get; set; } // int
		[Column, NotNull    ] public int      updtrig   { get; set; } // int
		[Column, NotNull    ] public int      seltrig   { get; set; } // int
		[Column, NotNull    ] public int      ckfirst   { get; set; } // int
		[Column, NotNull    ] public short    cache     { get; set; } // smallint
		[Column,    Nullable] public int?     audflags  { get; set; } // int
		[Column, NotNull    ] public int      objspare  { get; set; } // int
		[Column,    Nullable] public byte[]?  versionts { get; set; } // binary
		[Column,    Nullable] public string?  loginame  { get; set; } // varchar
	}

	[Table(Schema="dbo", Name="sysquerymetrics", IsView=true)]
	public partial class Sysquerymetric
	{
		[Column("uid"),       NotNull    ] public int     Uid      { get; set; } // int
		[Column("gid"),       NotNull    ] public int     Gid      { get; set; } // int
		[Column("hashkey"),   NotNull    ] public int     Hashkey  { get; set; } // int
		[Column("id"),        NotNull    ] public int     Id       { get; set; } // int
		[Column("sequence"),  NotNull    ] public short   Sequence { get; set; } // smallint
		[Column("exec_min"),     Nullable] public ulong?  ExecMin  { get; set; } // ubigint
		[Column("exec_max"),     Nullable] public ulong?  ExecMax  { get; set; } // ubigint
		[Column("exec_avg"),     Nullable] public ulong?  ExecAvg  { get; set; } // ubigint
		[Column("elap_min"),     Nullable] public ulong?  ElapMin  { get; set; } // ubigint
		[Column("elap_max"),     Nullable] public ulong?  ElapMax  { get; set; } // ubigint
		[Column("elap_avg"),     Nullable] public ulong?  ElapAvg  { get; set; } // ubigint
		[Column("lio_min"),      Nullable] public ulong?  LioMin   { get; set; } // ubigint
		[Column("lio_max"),      Nullable] public ulong?  LioMax   { get; set; } // ubigint
		[Column("lio_avg"),      Nullable] public ulong?  LioAvg   { get; set; } // ubigint
		[Column("pio_min"),      Nullable] public ulong?  PioMin   { get; set; } // ubigint
		[Column("pio_max"),      Nullable] public ulong?  PioMax   { get; set; } // ubigint
		[Column("pio_avg"),      Nullable] public ulong?  PioAvg   { get; set; } // ubigint
		[Column("cnt"),          Nullable] public ulong?  Cnt      { get; set; } // ubigint
		[Column("abort_cnt"),    Nullable] public ulong?  AbortCnt { get; set; } // ubigint
		[Column("qtext"),        Nullable] public string? Qtext    { get; set; } // varchar(510)
	}

	[Table(Schema="dbo", Name="TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // int
	}

	[Table(Schema="dbo", Name="TestMerge1")]
	public partial class TestMerge1
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // int
		[Column,        Nullable] public int?      Field1          { get; set; } // int
		[Column,        Nullable] public int?      Field2          { get; set; } // int
		[Column,        Nullable] public int?      Field3          { get; set; } // int
		[Column,        Nullable] public int?      Field4          { get; set; } // int
		[Column,        Nullable] public int?      Field5          { get; set; } // int
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // bigint
		[Column,        Nullable] public string?   FieldString     { get; set; } // varchar(20)
		[Column,        Nullable] public string?   FieldNString    { get; set; } // nvarchar(60)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // char(1)
		[Column,        Nullable] public string?   FieldNChar      { get; set; } // nchar(3)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // real
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // float
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,        Nullable] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column,        Nullable] public string?   FieldGuid       { get; set; } // char(36)
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // decimal(24, 10)
		[Column,        Nullable] public DateTime? FieldDate       { get; set; } // date
		[Column,        Nullable] public TimeSpan? FieldTime       { get; set; } // time
		[Column,        Nullable] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // int
	}

	[Table(Schema="dbo", Name="TestMerge2")]
	public partial class TestMerge2
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // int
		[Column,        Nullable] public int?      Field1          { get; set; } // int
		[Column,        Nullable] public int?      Field2          { get; set; } // int
		[Column,        Nullable] public int?      Field3          { get; set; } // int
		[Column,        Nullable] public int?      Field4          { get; set; } // int
		[Column,        Nullable] public int?      Field5          { get; set; } // int
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // bigint
		[Column,        Nullable] public string?   FieldString     { get; set; } // varchar(20)
		[Column,        Nullable] public string?   FieldNString    { get; set; } // nvarchar(60)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // char(1)
		[Column,        Nullable] public string?   FieldNChar      { get; set; } // nchar(3)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // real
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // float
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,        Nullable] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column,        Nullable] public string?   FieldGuid       { get; set; } // char(36)
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // decimal(24, 10)
		[Column,        Nullable] public DateTime? FieldDate       { get; set; } // date
		[Column,        Nullable] public TimeSpan? FieldTime       { get; set; } // time
		[Column,        Nullable] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // int
	}

	[Table(Schema="dbo", Name="TestMergeIdentity")]
	public partial class TestMergeIdentity
	{
		[PrimaryKey, Identity] public int  Id    { get; set; } // int
		[Column,     Nullable] public int? Field { get; set; } // int
	}

	public static partial class TestDataCoreDBStoredProcedures
	{
		#region AddIssue792Record

		public static int AddIssue792Record(this TestDataCoreDB dataConnection, out int? RETURN_VALUE)
		{
			var parameters = new []
			{
				new DataParameter("RETURN_VALUE", null, LinqToDB.DataType.Int32)
				{
					Direction = ParameterDirection.ReturnValue,
					Size      = 10
				}
			};

			var ret = dataConnection.ExecuteProc("[dbo].[AddIssue792Record]", parameters);

			RETURN_VALUE = Converter.ChangeTypeTo<int?>(parameters[0].Value);

			return ret;
		}

		#endregion

		#region PersonSelectAll

		public static IEnumerable<PersonSelectAllResult> PersonSelectAll(this TestDataCoreDB dataConnection, out int? RETURN_VALUE)
		{
			var parameters = new []
			{
				new DataParameter("RETURN_VALUE", null, LinqToDB.DataType.Int32)
				{
					Direction = ParameterDirection.ReturnValue,
					Size      = 10
				}
			};

			var ret = dataConnection.QueryProc<PersonSelectAllResult>("[dbo].[Person_SelectAll]", parameters).ToList();

			RETURN_VALUE = Converter.ChangeTypeTo<int?>(parameters[0].Value);

			return ret;
		}

		public partial class PersonSelectAllResult
		{
			public int     PersonID   { get; set; }
			public string  FirstName  { get; set; } = null!;
			public string  LastName   { get; set; } = null!;
			public string? MiddleName { get; set; }
			public string  Gender     { get; set; } = null!;
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static Doctor? Find(this ITable<Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static Patient? Find(this ITable<Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person? Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestMergeIdentity? Find(this ITable<TestMergeIdentity> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}
	}
}
