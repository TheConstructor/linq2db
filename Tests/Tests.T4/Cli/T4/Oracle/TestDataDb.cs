// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.T4.Oracle
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

		public TestDataDB(DataContextOptions options)
			: base(options)
		{
			InitDataContext();
		}

		public TestDataDB(DataContextOptions<TestDataDB> options)
			: base(options)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<AllType>                 AllTypes                 => this.GetTable<AllType>();
		public ITable<Binarydatum>             Binarydata               => this.GetTable<Binarydatum>();
		public ITable<Child>                   Children                 => this.GetTable<Child>();
		public ITable<CollatedTable>           CollatedTables           => this.GetTable<CollatedTable>();
		public ITable<DataTypeTest>            DataTypeTests            => this.GetTable<DataTypeTest>();
		public ITable<DecimalOverflow>         DecimalOverflows         => this.GetTable<DecimalOverflow>();
		public ITable<Dest2>                   Dest2                    => this.GetTable<Dest2>();
		public ITable<Doctor>                  Doctors                  => this.GetTable<Doctor>();
		public ITable<GrandChild>              GrandChildren            => this.GetTable<GrandChild>();
		public ITable<InheritanceChild>        InheritanceChildren      => this.GetTable<InheritanceChild>();
		public ITable<InheritanceParent>       InheritanceParents       => this.GetTable<InheritanceParent>();
		public ITable<Issue2564Table>          Issue2564Tables          => this.GetTable<Issue2564Table>();
		public ITable<LinqDataType>            LinqDataTypes            => this.GetTable<LinqDataType>();
		public ITable<Linqdatatypesbc>         Linqdatatypesbcs         => this.GetTable<Linqdatatypesbc>();
		public ITable<LongRawTable>            LongRawTables            => this.GetTable<LongRawTable>();
		public ITable<Parent>                  Parents                  => this.GetTable<Parent>();
		public ITable<Patient>                 Patients                 => this.GetTable<Patient>();
		public ITable<Person>                  People                   => this.GetTable<Person>();
		/// <summary>
		/// This is table
		/// </summary>
		public ITable<SchemaTestTable>         SchemaTestTables         => this.GetTable<SchemaTestTable>();
		public ITable<Sequencetest>            Sequencetests            => this.GetTable<Sequencetest>();
		public ITable<StgTradeInformation>     StgTradeInformation      => this.GetTable<StgTradeInformation>();
		public ITable<StringTest>              StringTests              => this.GetTable<StringTest>();
		public ITable<TEntity>                 TEntities                => this.GetTable<TEntity>();
		public ITable<TestIdentity>            TestIdentities           => this.GetTable<TestIdentity>();
		public ITable<TestMerge1>              TestMerge1               => this.GetTable<TestMerge1>();
		public ITable<TestMerge2>              TestMerge2               => this.GetTable<TestMerge2>();
		public ITable<TestSequenceSchemaTable> TestSequenceSchemaTables => this.GetTable<TestSequenceSchemaTable>();
		public ITable<TestSource>              TestSources              => this.GetTable<TestSource>();
		public ITable<TTestUser>               TTestUsers               => this.GetTable<TTestUser>();
		public ITable<TTestUserContract>       TTestUserContracts       => this.GetTable<TTestUserContract>();
		/// <summary>
		/// This is matview
		/// </summary>
		public ITable<SchemaTestMatView>       SchemaTestMatViews       => this.GetTable<SchemaTestMatView>();
		public ITable<SchemaTestView>          SchemaTestViews          => this.GetTable<SchemaTestView>();
	}

	[Table("AllTypes", Schema = "MANAGED")]
	public partial class AllType
	{
		[Column("ID"                    , IsPrimaryKey = true)] public decimal         ID                     { get; set; } // NUMBER
		[Column("bigintDataType"                             )] public decimal?        BigintDataType         { get; set; } // NUMBER (20,0)
		[Column("numericDataType"                            )] public decimal?        NumericDataType        { get; set; } // NUMBER
		[Column("bitDataType"                                )] public sbyte?          BitDataType            { get; set; } // NUMBER (1,0)
		[Column("smallintDataType"                           )] public int?            SmallintDataType       { get; set; } // NUMBER (5,0)
		[Column("decimalDataType"                            )] public decimal?        DecimalDataType        { get; set; } // NUMBER
		[Column("smallmoneyDataType"                         )] public decimal?        SmallmoneyDataType     { get; set; } // NUMBER (10,4)
		[Column("intDataType"                                )] public long?           IntDataType            { get; set; } // NUMBER (10,0)
		[Column("tinyintDataType"                            )] public short?          TinyintDataType        { get; set; } // NUMBER (3,0)
		[Column("moneyDataType"                              )] public decimal?        MoneyDataType          { get; set; } // NUMBER
		[Column("floatDataType"                              )] public double?         FloatDataType          { get; set; } // BINARY_DOUBLE
		[Column("realDataType"                               )] public float?          RealDataType           { get; set; } // BINARY_FLOAT
		[Column("datetimeDataType"                           )] public DateTime?       DatetimeDataType       { get; set; } // DATE
		[Column("datetime2DataType"                          )] public DateTime?       Datetime2DataType      { get; set; } // TIMESTAMP(6)
		[Column("datetimeoffsetDataType"                     )] public DateTimeOffset? DatetimeoffsetDataType { get; set; } // TIMESTAMP(6) WITH TIME ZONE
		[Column("localZoneDataType"                          )] public DateTimeOffset? LocalZoneDataType      { get; set; } // TIMESTAMP(6) WITH LOCAL TIME ZONE
		[Column("charDataType"                               )] public char?           CharDataType           { get; set; } // CHAR(1)
		[Column("char20DataType"                             )] public string?         Char20DataType         { get; set; } // CHAR(20)
		[Column("varcharDataType"                            )] public string?         VarcharDataType        { get; set; } // VARCHAR2(20)
		[Column("textDataType"                               )] public string?         TextDataType           { get; set; } // CLOB
		[Column("ncharDataType"                              )] public string?         NcharDataType          { get; set; } // NCHAR(20)
		[Column("nvarcharDataType"                           )] public string?         NvarcharDataType       { get; set; } // NVARCHAR2(20)
		[Column("ntextDataType"                              )] public string?         NtextDataType          { get; set; } // NCLOB
		[Column("binaryDataType"                             )] public byte[]?         BinaryDataType         { get; set; } // BLOB
		[Column("bfileDataType"                              )] public byte[]?         BfileDataType          { get; set; } // BFILE
		[Column("guidDataType"                               )] public byte[]?         GuidDataType           { get; set; } // RAW(16)
		[Column("longDataType"                               )] public string?         LongDataType           { get; set; } // LONG
		[Column("xmlDataType"                                )] public string?         XmlDataType            { get; set; } // XMLTYPE
	}

	public static partial class ExtensionMethods
	{
		#region Table Extensions
		public static AllType? Find(this ITable<AllType> table, decimal id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static Binarydatum? Find(this ITable<Binarydatum> table, decimal binarydataid)
		{
			return table.FirstOrDefault(e => e.Binarydataid == binarydataid);
		}

		public static DataTypeTest? Find(this ITable<DataTypeTest> table, decimal dataTypeId)
		{
			return table.FirstOrDefault(e => e.DataTypeID == dataTypeId);
		}

		public static Doctor? Find(this ITable<Doctor> table, decimal personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, decimal inheritanceChildId)
		{
			return table.FirstOrDefault(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, decimal inheritanceParentId)
		{
			return table.FirstOrDefault(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static Issue2564Table? Find(this ITable<Issue2564Table> table, long id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static LongRawTable? Find(this ITable<LongRawTable> table, decimal id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static Patient? Find(this ITable<Patient> table, decimal personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static Person? Find(this ITable<Person> table, decimal personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static SchemaTestTable? Find(this ITable<SchemaTestTable> table, decimal id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Sequencetest? Find(this ITable<Sequencetest> table, decimal id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static TEntity? Find(this ITable<TEntity> table, decimal entityId)
		{
			return table.FirstOrDefault(e => e.EntityId == entityId);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, decimal id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, decimal id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, decimal id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static TestSequenceSchemaTable? Find(this ITable<TestSequenceSchemaTable> table, long id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static TTestUser? Find(this ITable<TTestUser> table, decimal userId)
		{
			return table.FirstOrDefault(e => e.UserId == userId);
		}

		public static TTestUserContract? Find(this ITable<TTestUserContract> table, decimal userContractId)
		{
			return table.FirstOrDefault(e => e.UserContractId == userContractId);
		}

		public static SchemaTestMatView? Find(this ITable<SchemaTestMatView> table, decimal id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}
		#endregion

		#region Stored Procedures
		#region PersonUpdate
		public static int PersonUpdate(this TestDataDB dataConnection, decimal? ppersonid, string? pfirstname, string? plastname, string? pmiddlename, string? pgender)
		{
			var parameters = new []
			{
				new DataParameter("PPERSONID", ppersonid, DataType.Decimal)
				{
					Size = 22
				},
				new DataParameter("PFIRSTNAME", pfirstname, DataType.NVarChar),
				new DataParameter("PLASTNAME", plastname, DataType.NVarChar),
				new DataParameter("PMIDDLENAME", pmiddlename, DataType.NVarChar),
				new DataParameter("PGENDER", pgender, DataType.Char)
			};
			return dataConnection.ExecuteProc("MANAGED.PERSON_UPDATE", parameters);
		}
		#endregion

		#region PersonDelete
		public static int PersonDelete(this TestDataDB dataConnection, decimal? ppersonid)
		{
			var parameters = new []
			{
				new DataParameter("PPERSONID", ppersonid, DataType.Decimal)
				{
					Size = 22
				}
			};
			return dataConnection.ExecuteProc("MANAGED.PERSON_DELETE", parameters);
		}
		#endregion

		#region Outreftest
		public static int Outreftest(this TestDataDB dataConnection, decimal? pid, out decimal? poutputid, ref decimal? pinputoutputid, string? pstr, out string? poutputstr, ref string? pinputoutputstr)
		{
			var parameters = new []
			{
				new DataParameter("PID", pid, DataType.Decimal)
				{
					Size = 22
				},
				new DataParameter("POUTPUTID", null, DataType.Decimal)
				{
					Direction = ParameterDirection.Output,
					Size = 22
				},
				new DataParameter("PINPUTOUTPUTID", pinputoutputid, DataType.Decimal)
				{
					Direction = ParameterDirection.InputOutput,
					Size = 22
				},
				new DataParameter("PSTR", pstr, DataType.NVarChar),
				new DataParameter("POUTPUTSTR", null, DataType.NVarChar)
				{
					Direction = ParameterDirection.Output
				},
				new DataParameter("PINPUTOUTPUTSTR", pinputoutputstr, DataType.NVarChar)
				{
					Direction = ParameterDirection.InputOutput
				}
			};
			poutputid = Converter.ChangeTypeTo<decimal?>(parameters[1].Value);
			pinputoutputid = Converter.ChangeTypeTo<decimal?>(parameters[2].Value);
			poutputstr = Converter.ChangeTypeTo<string?>(parameters[4].Value);
			pinputoutputstr = Converter.ChangeTypeTo<string?>(parameters[5].Value);
			return dataConnection.ExecuteProc("MANAGED.OUTREFTEST", parameters);
		}
		#endregion

		#region Outrefenumtest
		public static int Outrefenumtest(this TestDataDB dataConnection, string? pstr, out string? poutputstr, ref string? pinputoutputstr)
		{
			var parameters = new []
			{
				new DataParameter("PSTR", pstr, DataType.NVarChar),
				new DataParameter("POUTPUTSTR", null, DataType.NVarChar)
				{
					Direction = ParameterDirection.Output
				},
				new DataParameter("PINPUTOUTPUTSTR", pinputoutputstr, DataType.NVarChar)
				{
					Direction = ParameterDirection.InputOutput
				}
			};
			poutputstr = Converter.ChangeTypeTo<string?>(parameters[1].Value);
			pinputoutputstr = Converter.ChangeTypeTo<string?>(parameters[2].Value);
			return dataConnection.ExecuteProc("MANAGED.OUTREFENUMTEST", parameters);
		}
		#endregion
		#endregion
	}

	[Table("BINARYDATA", Schema = "MANAGED")]
	public partial class Binarydatum
	{
		[Column("BINARYDATAID", IsPrimaryKey = true )] public decimal  Binarydataid { get; set; } // NUMBER
		[Column("STAMP"                             )] public DateTime Stamp        { get; set; } // TIMESTAMP(6)
		[Column("DATA"        , CanBeNull    = false)] public byte[]   Data         { get; set; } = null!; // BLOB
	}

	[Table("Child", Schema = "MANAGED")]
	public partial class Child
	{
		[Column("ParentID")] public decimal? ParentID { get; set; } // NUMBER
		[Column("ChildID" )] public decimal? ChildID  { get; set; } // NUMBER
	}

	[Table("CollatedTable", Schema = "MANAGED")]
	public partial class CollatedTable
	{
		[Column("Id"                                )] public decimal Id              { get; set; } // NUMBER
		[Column("CaseSensitive"  , CanBeNull = false)] public string  CaseSensitive   { get; set; } = null!; // VARCHAR2(20)
		[Column("CaseInsensitive", CanBeNull = false)] public string  CaseInsensitive { get; set; } = null!; // VARCHAR2(20)
	}

	[Table("DataTypeTest", Schema = "MANAGED")]
	public partial class DataTypeTest
	{
		[Column("DataTypeID", IsPrimaryKey = true)] public decimal   DataTypeID { get; set; } // NUMBER
		[Column("Binary_"                        )] public byte[]?   Binary     { get; set; } // RAW(50)
		[Column("Boolean_"                       )] public sbyte?    Boolean    { get; set; } // NUMBER (1,0)
		[Column("Byte_"                          )] public short?    Byte       { get; set; } // NUMBER (3,0)
		[Column("Bytes_"                         )] public byte[]?   Bytes      { get; set; } // BLOB
		[Column("Char_"                          )] public char?     Char       { get; set; } // NCHAR(1)
		[Column("DateTime_"                      )] public DateTime? DateTime   { get; set; } // DATE
		[Column("Decimal_"                       )] public decimal?  Decimal    { get; set; } // NUMBER (19,5)
		[Column("Double_"                        )] public decimal?  Double     { get; set; } // FLOAT(126)
		[Column("Guid_"                          )] public byte[]?   Guid       { get; set; } // RAW(16)
		[Column("Int16_"                         )] public int?      Int16      { get; set; } // NUMBER (5,0)
		[Column("Int32_"                         )] public long?     Int32      { get; set; } // NUMBER (10,0)
		[Column("Int64_"                         )] public decimal?  Int64      { get; set; } // NUMBER (20,0)
		[Column("Money_"                         )] public decimal?  Money      { get; set; } // NUMBER
		[Column("SByte_"                         )] public short?    SByte      { get; set; } // NUMBER (3,0)
		[Column("Single_"                        )] public decimal?  Single     { get; set; } // FLOAT(126)
		[Column("Stream_"                        )] public byte[]?   Stream     { get; set; } // BLOB
		[Column("String_"                        )] public string?   String     { get; set; } // NVARCHAR2(50)
		[Column("UInt16_"                        )] public int?      UInt16     { get; set; } // NUMBER (5,0)
		[Column("UInt32_"                        )] public long?     UInt32     { get; set; } // NUMBER (10,0)
		[Column("UInt64_"                        )] public decimal?  UInt64     { get; set; } // NUMBER (20,0)
		[Column("Xml_"                           )] public string?   Xml        { get; set; } // XMLTYPE
	}

	[Table("DecimalOverflow", Schema = "MANAGED")]
	public partial class DecimalOverflow
	{
		[Column("Decimal1")] public decimal? Decimal1 { get; set; } // NUMBER (38,20)
		[Column("Decimal2")] public decimal? Decimal2 { get; set; } // NUMBER (31,2)
		[Column("Decimal3")] public decimal? Decimal3 { get; set; } // NUMBER (38,36)
		[Column("Decimal4")] public decimal? Decimal4 { get; set; } // NUMBER (29,0)
		[Column("Decimal5")] public decimal? Decimal5 { get; set; } // NUMBER (38,38)
	}

	[Table("Dest2", Schema = "MANAGED")]
	public partial class Dest2
	{
		[Column("ID" )] public decimal ID  { get; set; } // NUMBER
		[Column("Int")] public decimal Int { get; set; } // NUMBER
	}

	[Table("Doctor", Schema = "MANAGED")]
	public partial class Doctor
	{
		[Column("PersonID", IsPrimaryKey = true )] public decimal PersonID { get; set; } // NUMBER
		[Column("Taxonomy", CanBeNull    = false)] public string  Taxonomy { get; set; } = null!; // NVARCHAR2(50)

		#region Associations
		/// <summary>
		/// Fk_Doctor_Person
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(PersonID), OtherKey = nameof(Oracle.Person.PersonID))]
		public Person Person { get; set; } = null!;
		#endregion
	}

	[Table("GrandChild", Schema = "MANAGED")]
	public partial class GrandChild
	{
		[Column("ParentID"    )] public decimal? ParentID     { get; set; } // NUMBER
		[Column("ChildID"     )] public decimal? ChildID      { get; set; } // NUMBER
		[Column("GrandChildID")] public decimal? GrandChildID { get; set; } // NUMBER
	}

	[Table("InheritanceChild", Schema = "MANAGED")]
	public partial class InheritanceChild
	{
		[Column("InheritanceChildId" , IsPrimaryKey = true)] public decimal  InheritanceChildId  { get; set; } // NUMBER
		[Column("InheritanceParentId"                     )] public decimal  InheritanceParentId { get; set; } // NUMBER
		[Column("TypeDiscriminator"                       )] public decimal? TypeDiscriminator   { get; set; } // NUMBER
		[Column("Name"                                    )] public string?  Name                { get; set; } // NVARCHAR2(50)
	}

	[Table("InheritanceParent", Schema = "MANAGED")]
	public partial class InheritanceParent
	{
		[Column("InheritanceParentId", IsPrimaryKey = true)] public decimal  InheritanceParentId { get; set; } // NUMBER
		[Column("TypeDiscriminator"                       )] public decimal? TypeDiscriminator   { get; set; } // NUMBER
		[Column("Name"                                    )] public string?  Name                { get; set; } // NVARCHAR2(50)
	}

	[Table("Issue2564Table", Schema = "MANAGED")]
	public partial class Issue2564Table
	{
		[Column("Id"                    , IsPrimaryKey = true)] public long      Id                     { get; set; } // NUMBER (19,0)
		[Column("TimestampGenerated"                         )] public DateTime  TimestampGenerated     { get; set; } // TIMESTAMP(6)
		[Column("TimestampGone"                              )] public DateTime? TimestampGone          { get; set; } // TIMESTAMP(6)
		[Column("MessageClassName"                           )] public string?   MessageClassName       { get; set; } // VARCHAR2(255)
		[Column("ExternID1"                                  )] public string?   ExternID1              { get; set; } // VARCHAR2(255)
		[Column("TranslatedMessageGroup"                     )] public string?   TranslatedMessageGroup { get; set; } // VARCHAR2(255)
		[Column("TranslatedMessage1"                         )] public string?   TranslatedMessage1     { get; set; } // VARCHAR2(255)
	}

	[Table("LinqDataTypes", Schema = "MANAGED")]
	public partial class LinqDataType
	{
		[Column("ID"            )] public decimal?  ID             { get; set; } // NUMBER
		[Column("MoneyValue"    )] public decimal?  MoneyValue     { get; set; } // NUMBER (10,4)
		[Column("DateTimeValue" )] public DateTime? DateTimeValue  { get; set; } // TIMESTAMP(6)
		[Column("DateTimeValue2")] public DateTime? DateTimeValue2 { get; set; } // TIMESTAMP(6)
		[Column("BoolValue"     )] public decimal?  BoolValue      { get; set; } // NUMBER
		[Column("GuidValue"     )] public byte[]?   GuidValue      { get; set; } // RAW(16)
		[Column("BinaryValue"   )] public byte[]?   BinaryValue    { get; set; } // BLOB
		[Column("SmallIntValue" )] public decimal?  SmallIntValue  { get; set; } // NUMBER
		[Column("IntValue"      )] public decimal?  IntValue       { get; set; } // NUMBER
		[Column("BigIntValue"   )] public decimal?  BigIntValue    { get; set; } // NUMBER (20,0)
		[Column("StringValue"   )] public string?   StringValue    { get; set; } // VARCHAR2(50)
	}

	[Table("LINQDATATYPESBC", Schema = "MANAGED")]
	public partial class Linqdatatypesbc
	{
		[Column("ID"            )] public decimal?  ID             { get; set; } // NUMBER
		[Column("MONEYVALUE"    )] public decimal?  Moneyvalue     { get; set; } // NUMBER (10,4)
		[Column("DATETIMEVALUE" )] public DateTime? Datetimevalue  { get; set; } // TIMESTAMP(6)
		[Column("DATETIMEVALUE2")] public DateTime? Datetimevalue2 { get; set; } // TIMESTAMP(6)
		[Column("BOOLVALUE"     )] public decimal?  Boolvalue      { get; set; } // NUMBER
		[Column("GUIDVALUE"     )] public byte[]?   Guidvalue      { get; set; } // RAW(16)
		[Column("SMALLINTVALUE" )] public decimal?  Smallintvalue  { get; set; } // NUMBER
		[Column("INTVALUE"      )] public decimal?  Intvalue       { get; set; } // NUMBER
		[Column("BIGINTVALUE"   )] public decimal?  Bigintvalue    { get; set; } // NUMBER (20,0)
		[Column("STRINGVALUE"   )] public string?   Stringvalue    { get; set; } // VARCHAR2(50)
	}

	[Table("LongRawTable", Schema = "MANAGED")]
	public partial class LongRawTable
	{
		[Column("ID"             , IsPrimaryKey = true)] public decimal ID              { get; set; } // NUMBER
		[Column("longRawDataType"                     )] public byte[]? LongRawDataType { get; set; } // LONG RAW
	}

	[Table("Parent", Schema = "MANAGED")]
	public partial class Parent
	{
		[Column("ParentID")] public decimal? ParentID { get; set; } // NUMBER
		[Column("Value1"  )] public decimal? Value1   { get; set; } // NUMBER
	}

	[Table("Patient", Schema = "MANAGED")]
	public partial class Patient
	{
		[Column("PersonID" , IsPrimaryKey = true )] public decimal PersonID  { get; set; } // NUMBER
		[Column("Diagnosis", CanBeNull    = false)] public string  Diagnosis { get; set; } = null!; // NVARCHAR2(256)

		#region Associations
		/// <summary>
		/// Fk_Patient_Person
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(PersonID), OtherKey = nameof(Oracle.Person.PersonID))]
		public Person Person { get; set; } = null!;
		#endregion
	}

	[Table("Person", Schema = "MANAGED")]
	public partial class Person
	{
		[Column("PersonID"  , IsPrimaryKey = true )] public decimal PersonID   { get; set; } // NUMBER
		[Column("FirstName" , CanBeNull    = false)] public string  FirstName  { get; set; } = null!; // VARCHAR2(50)
		[Column("LastName"  , CanBeNull    = false)] public string  LastName   { get; set; } = null!; // VARCHAR2(50)
		[Column("MiddleName"                      )] public string? MiddleName { get; set; } // VARCHAR2(50)
		[Column("Gender"                          )] public char    Gender     { get; set; } // CHAR(1)

		#region Associations
		/// <summary>
		/// Fk_Doctor_Person backreference
		/// </summary>
		[Association(ThisKey = nameof(PersonID), OtherKey = nameof(Doctor.PersonID))]
		public Doctor? FkDoctor { get; set; }

		/// <summary>
		/// Fk_Patient_Person backreference
		/// </summary>
		[Association(ThisKey = nameof(PersonID), OtherKey = nameof(Patient.PersonID))]
		public Patient? FkPatient { get; set; }
		#endregion
	}

	/// <summary>
	/// This is table
	/// </summary>
	[Table("SchemaTestTable", Schema = "MANAGED")]
	public partial class SchemaTestTable
	{
		/// <summary>
		/// This is column
		/// </summary>
		[Column("Id", IsPrimaryKey = true)] public decimal Id { get; set; } // NUMBER
	}

	[Table("SEQUENCETEST", Schema = "MANAGED")]
	public partial class Sequencetest
	{
		[Column("ID"   , IsPrimaryKey = true )] public decimal ID    { get; set; } // NUMBER
		[Column("VALUE", CanBeNull    = false)] public string  Value { get; set; } = null!; // VARCHAR2(50)
	}

	[Table("STG_TRADE_INFORMATION", Schema = "MANAGED")]
	public partial class StgTradeInformation
	{
		[Column("STG_TRADE_ID"         )] public decimal   StgTradeID          { get; set; } // NUMBER
		[Column("STG_TRADE_VERSION"    )] public decimal   StgTradeVersion     { get; set; } // NUMBER
		[Column("INFORMATION_TYPE_ID"  )] public decimal   InformationTypeID   { get; set; } // NUMBER
		[Column("INFORMATION_TYPE_NAME")] public string?   InformationTypeName { get; set; } // VARCHAR2(50)
		[Column("VALUE"                )] public string?   Value               { get; set; } // VARCHAR2(4000)
		[Column("VALUE_AS_INTEGER"     )] public decimal?  ValueASInteger      { get; set; } // NUMBER
		[Column("VALUE_AS_DATE"        )] public DateTime? ValueASDate         { get; set; } // DATE
	}

	[Table("StringTest", Schema = "MANAGED")]
	public partial class StringTest
	{
		[Column("StringValue1"                   )] public string? StringValue1 { get; set; } // VARCHAR2(50)
		[Column("StringValue2"                   )] public string? StringValue2 { get; set; } // CHAR(50)
		[Column("KeyValue"    , CanBeNull = false)] public string  KeyValue     { get; set; } = null!; // VARCHAR2(50)
	}

	[Table("t_entity", Schema = "MANAGED")]
	public partial class TEntity
	{
		[Column("entity_id", IsPrimaryKey = true)] public decimal   EntityId { get; set; } // NUMBER
		[Column("time"                          )] public DateTime? Time     { get; set; } // DATE
		[Column("duration"                      )] public TimeSpan? Duration { get; set; } // INTERVAL DAY(3) TO SECOND(2)
	}

	[Table("TestIdentity", Schema = "MANAGED")]
	public partial class TestIdentity
	{
		[Column("ID", IsPrimaryKey = true)] public decimal ID { get; set; } // NUMBER
	}

	[Table("TestMerge1", Schema = "MANAGED")]
	public partial class TestMerge1
	{
		[Column("Id"             , IsPrimaryKey = true)] public decimal         Id              { get; set; } // NUMBER
		[Column("Field1"                              )] public decimal?        Field1          { get; set; } // NUMBER
		[Column("Field2"                              )] public decimal?        Field2          { get; set; } // NUMBER
		[Column("Field3"                              )] public decimal?        Field3          { get; set; } // NUMBER
		[Column("Field4"                              )] public decimal?        Field4          { get; set; } // NUMBER
		[Column("Field5"                              )] public decimal?        Field5          { get; set; } // NUMBER
		[Column("FieldInt64"                          )] public decimal?        FieldInt64      { get; set; } // NUMBER (20,0)
		[Column("FieldBoolean"                        )] public sbyte?          FieldBoolean    { get; set; } // NUMBER (1,0)
		[Column("FieldString"                         )] public string?         FieldString     { get; set; } // VARCHAR2(20)
		[Column("FieldNString"                        )] public string?         FieldNString    { get; set; } // NVARCHAR2(20)
		[Column("FieldChar"                           )] public char?           FieldChar       { get; set; } // CHAR(1)
		[Column("FieldNChar"                          )] public char?           FieldNChar      { get; set; } // NCHAR(1)
		[Column("FieldFloat"                          )] public float?          FieldFloat      { get; set; } // BINARY_FLOAT
		[Column("FieldDouble"                         )] public double?         FieldDouble     { get; set; } // BINARY_DOUBLE
		[Column("FieldDateTime"                       )] public DateTime?       FieldDateTime   { get; set; } // DATE
		[Column("FieldDateTime2"                      )] public DateTimeOffset? FieldDateTime2  { get; set; } // TIMESTAMP(7) WITH TIME ZONE
		[Column("FieldBinary"                         )] public byte[]?         FieldBinary     { get; set; } // BLOB
		[Column("FieldGuid"                           )] public byte[]?         FieldGuid       { get; set; } // RAW(16)
		[Column("FieldDecimal"                        )] public decimal?        FieldDecimal    { get; set; } // NUMBER (24,10)
		[Column("FieldEnumString"                     )] public string?         FieldEnumString { get; set; } // VARCHAR2(20)
		[Column("FieldEnumNumber"                     )] public decimal?        FieldEnumNumber { get; set; } // NUMBER
	}

	[Table("TestMerge2", Schema = "MANAGED")]
	public partial class TestMerge2
	{
		[Column("Id"             , IsPrimaryKey = true)] public decimal         Id              { get; set; } // NUMBER
		[Column("Field1"                              )] public decimal?        Field1          { get; set; } // NUMBER
		[Column("Field2"                              )] public decimal?        Field2          { get; set; } // NUMBER
		[Column("Field3"                              )] public decimal?        Field3          { get; set; } // NUMBER
		[Column("Field4"                              )] public decimal?        Field4          { get; set; } // NUMBER
		[Column("Field5"                              )] public decimal?        Field5          { get; set; } // NUMBER
		[Column("FieldInt64"                          )] public decimal?        FieldInt64      { get; set; } // NUMBER (20,0)
		[Column("FieldBoolean"                        )] public sbyte?          FieldBoolean    { get; set; } // NUMBER (1,0)
		[Column("FieldString"                         )] public string?         FieldString     { get; set; } // VARCHAR2(20)
		[Column("FieldNString"                        )] public string?         FieldNString    { get; set; } // NVARCHAR2(20)
		[Column("FieldChar"                           )] public char?           FieldChar       { get; set; } // CHAR(1)
		[Column("FieldNChar"                          )] public char?           FieldNChar      { get; set; } // NCHAR(1)
		[Column("FieldFloat"                          )] public float?          FieldFloat      { get; set; } // BINARY_FLOAT
		[Column("FieldDouble"                         )] public double?         FieldDouble     { get; set; } // BINARY_DOUBLE
		[Column("FieldDateTime"                       )] public DateTime?       FieldDateTime   { get; set; } // DATE
		[Column("FieldDateTime2"                      )] public DateTimeOffset? FieldDateTime2  { get; set; } // TIMESTAMP(7) WITH TIME ZONE
		[Column("FieldBinary"                         )] public byte[]?         FieldBinary     { get; set; } // BLOB
		[Column("FieldGuid"                           )] public byte[]?         FieldGuid       { get; set; } // RAW(16)
		[Column("FieldDecimal"                        )] public decimal?        FieldDecimal    { get; set; } // NUMBER (24,10)
		[Column("FieldEnumString"                     )] public string?         FieldEnumString { get; set; } // VARCHAR2(20)
		[Column("FieldEnumNumber"                     )] public decimal?        FieldEnumNumber { get; set; } // NUMBER
	}

	[Table("TestSequenceSchemaTable", Schema = "MANAGED")]
	public partial class TestSequenceSchemaTable
	{
		[Column("Id", IsPrimaryKey = true)] public long Id { get; set; } // NUMBER (19,0)
	}

	[Table("TestSource", Schema = "MANAGED")]
	public partial class TestSource
	{
		[Column("ID")] public decimal ID { get; set; } // NUMBER
		[Column("N" )] public decimal N  { get; set; } // NUMBER
	}

	[Table("t_test_user", Schema = "MANAGED")]
	public partial class TTestUser
	{
		[Column("user_id", IsPrimaryKey = true )] public decimal UserId { get; set; } // NUMBER
		[Column("name"   , CanBeNull    = false)] public string  Name   { get; set; } = null!; // VARCHAR2(255)

		#region Associations
		/// <summary>
		/// SYS_C00901116 backreference
		/// </summary>
		[Association(ThisKey = nameof(UserId), OtherKey = nameof(TTestUserContract.UserId))]
		public IEnumerable<TTestUserContract> Syscs { get; set; } = null!;
		#endregion
	}

	[Table("t_test_user_contract", Schema = "MANAGED")]
	public partial class TTestUserContract
	{
		[Column("user_contract_id", IsPrimaryKey = true )] public decimal UserContractId { get; set; } // NUMBER
		[Column("user_id"                               )] public decimal UserId         { get; set; } // NUMBER
		[Column("contract_no"                           )] public decimal ContractNo     { get; set; } // NUMBER
		[Column("name"            , CanBeNull    = false)] public string  Name           { get; set; } = null!; // VARCHAR2(255)

		#region Associations
		/// <summary>
		/// SYS_C00901116
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(UserId), OtherKey = nameof(TTestUser.UserId))]
		public TTestUser User { get; set; } = null!;
		#endregion
	}

	/// <summary>
	/// This is matview
	/// </summary>
	[Table("SchemaTestMatView", Schema = "MANAGED", IsView = true)]
	public partial class SchemaTestMatView
	{
		/// <summary>
		/// This is matview column
		/// </summary>
		[Column("Id", IsPrimaryKey = true)] public decimal Id { get; set; } // NUMBER
	}

	[Table("SchemaTestView", Schema = "MANAGED", IsView = true)]
	public partial class SchemaTestView
	{
		/// <summary>
		/// This is view column
		/// </summary>
		[Column("Id")] public decimal Id { get; set; } // NUMBER
	}
}
