// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.T4.SqlCe
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

		public ITable<AllType>           AllTypes            => this.GetTable<AllType>();
		public ITable<Child>             Children            => this.GetTable<Child>();
		public ITable<DataType>          DataTypes           => this.GetTable<DataType>();
		public ITable<Doctor>            Doctors             => this.GetTable<Doctor>();
		public ITable<GrandChild>        GrandChildren       => this.GetTable<GrandChild>();
		public ITable<InheritanceChild>  InheritanceChildren => this.GetTable<InheritanceChild>();
		public ITable<InheritanceParent> InheritanceParents  => this.GetTable<InheritanceParent>();
		public ITable<Issue695>          Issue695            => this.GetTable<Issue695>();
		public ITable<Issue695Parent>    Issue695Parents     => this.GetTable<Issue695Parent>();
		public ITable<LinqDataType>      LinqDataTypes       => this.GetTable<LinqDataType>();
		public ITable<Parent>            Parents             => this.GetTable<Parent>();
		public ITable<Patient>           Patients            => this.GetTable<Patient>();
		public ITable<Person>            People              => this.GetTable<Person>();
		public ITable<TestIdentity>      TestIdentities      => this.GetTable<TestIdentity>();
		public ITable<TestMerge1>        TestMerge1          => this.GetTable<TestMerge1>();
		public ITable<TestMerge2>        TestMerge2          => this.GetTable<TestMerge2>();
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Column("ID"                      , IsPrimaryKey = true)] public int       ID                       { get; set; } // int
		[Column("bigintDataType"                               )] public long?     BigintDataType           { get; set; } // bigint
		[Column("numericDataType"                              )] public decimal?  NumericDataType          { get; set; } // numeric(18, 0)
		[Column("bitDataType"                                  )] public bool?     BitDataType              { get; set; } // bit
		[Column("smallintDataType"                             )] public short?    SmallintDataType         { get; set; } // smallint
		[Column("decimalDataType"                              )] public decimal?  DecimalDataType          { get; set; } // numeric(18, 0)
		[Column("intDataType"                                  )] public int?      IntDataType              { get; set; } // int
		[Column("tinyintDataType"                              )] public byte?     TinyintDataType          { get; set; } // tinyint
		[Column("moneyDataType"                                )] public decimal?  MoneyDataType            { get; set; } // money
		[Column("floatDataType"                                )] public double?   FloatDataType            { get; set; } // float
		[Column("realDataType"                                 )] public float?    RealDataType             { get; set; } // real
		[Column("datetimeDataType"                             )] public DateTime? DatetimeDataType         { get; set; } // datetime
		[Column("ncharDataType"                                )] public string?   NcharDataType            { get; set; } // nchar(20)
		[Column("nvarcharDataType"                             )] public string?   NvarcharDataType         { get; set; } // nvarchar(20)
		[Column("ntextDataType"                                )] public string?   NtextDataType            { get; set; } // ntext
		[Column("binaryDataType"                               )] public byte[]?   BinaryDataType           { get; set; } // binary(1)
		[Column("varbinaryDataType"                            )] public byte[]?   VarbinaryDataType        { get; set; } // varbinary(1)
		[Column("imageDataType"                                )] public byte[]?   ImageDataType            { get; set; } // image
		[Column("timestampDataType"                            )] public byte[]?   TimestampDataType        { get; set; } // rowversion
		[Column("uniqueidentifierDataType"                     )] public Guid?     UniqueidentifierDataType { get; set; } // uniqueidentifier
	}

	public static partial class ExtensionMethods
	{
		#region Table Extensions
		public static AllType? Find(this ITable<AllType> table, int id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static Doctor? Find(this ITable<Doctor> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int inheritanceChildId)
		{
			return table.FirstOrDefault(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int inheritanceParentId)
		{
			return table.FirstOrDefault(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static Issue695? Find(this ITable<Issue695> table, int id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static Issue695Parent? Find(this ITable<Issue695Parent> table, int id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static Patient? Find(this ITable<Patient> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static Person? Find(this ITable<Person> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, int id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}
		#endregion
	}

	[Table("Child")]
	public partial class Child
	{
		[Column("ParentID")] public int? ParentID { get; set; } // int
		[Column("ChildID" )] public int? ChildID  { get; set; } // int
	}

	[Table("DataTypes")]
	public partial class DataType
	{
		[Column("ID"        )] public int?     ID         { get; set; } // int
		[Column("MoneyValue")] public decimal? MoneyValue { get; set; } // numeric(10, 4)
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[Column("PersonID", IsPrimaryKey = true )] public int    PersonID { get; set; } // int
		[Column("Taxonomy", CanBeNull    = false)] public string Taxonomy { get; set; } = null!; // nvarchar(50)

		#region Associations
		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(PersonID), OtherKey = nameof(SqlCe.Person.PersonID))]
		public Person Person { get; set; } = null!;
		#endregion
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column("ParentID"    )] public int? ParentID     { get; set; } // int
		[Column("ChildID"     )] public int? ChildID      { get; set; } // int
		[Column("GrandChildID")] public int? GrandChildID { get; set; } // int
	}

	[Table("InheritanceChild")]
	public partial class InheritanceChild
	{
		[Column("InheritanceChildId" , IsPrimaryKey = true)] public int     InheritanceChildId  { get; set; } // int
		[Column("InheritanceParentId"                     )] public int     InheritanceParentId { get; set; } // int
		[Column("TypeDiscriminator"                       )] public int?    TypeDiscriminator   { get; set; } // int
		[Column("Name"                                    )] public string? Name                { get; set; } // nvarchar(50)
	}

	[Table("InheritanceParent")]
	public partial class InheritanceParent
	{
		[Column("InheritanceParentId", IsPrimaryKey = true)] public int     InheritanceParentId { get; set; } // int
		[Column("TypeDiscriminator"                       )] public int?    TypeDiscriminator   { get; set; } // int
		[Column("Name"                                    )] public string? Name                { get; set; } // nvarchar(50)
	}

	[Table("Issue695")]
	public partial class Issue695
	{
		[Column("ID"         , IsPrimaryKey = true)] public int ID          { get; set; } // int
		[Column("UniqueValue"                     )] public int UniqueValue { get; set; } // int

		#region Associations
		/// <summary>
		/// FK_Issue695_Parent
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(ID) + "," + nameof(ID), OtherKey = nameof(Issue695Parent.ID) + "," + nameof(ID))]
		public Issue695Parent Parent { get; set; } = null!;
		#endregion
	}

	[Table("Issue695Parent")]
	public partial class Issue695Parent
	{
		[Column("ID", IsPrimaryKey = true)] public int ID { get; set; } // int

		#region Associations
		/// <summary>
		/// FK_Issue695_Parent backreference
		/// </summary>
		[Association(ThisKey = nameof(ID) + "," + nameof(ID), OtherKey = nameof(Issue695.ID) + "," + nameof(ID))]
		public IEnumerable<Issue695> Issue695Parents { get; set; } = null!;
		#endregion
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column("ID"            )] public int?      ID             { get; set; } // int
		[Column("MoneyValue"    )] public decimal?  MoneyValue     { get; set; } // numeric(10, 4)
		[Column("DateTimeValue" )] public DateTime? DateTimeValue  { get; set; } // datetime
		[Column("DateTimeValue2")] public DateTime? DateTimeValue2 { get; set; } // datetime
		[Column("BoolValue"     )] public bool?     BoolValue      { get; set; } // bit
		[Column("GuidValue"     )] public Guid?     GuidValue      { get; set; } // uniqueidentifier
		[Column("BinaryValue"   )] public byte[]?   BinaryValue    { get; set; } // varbinary(5000)
		[Column("SmallIntValue" )] public short?    SmallIntValue  { get; set; } // smallint
		[Column("IntValue"      )] public int?      IntValue       { get; set; } // int
		[Column("BigIntValue"   )] public long?     BigIntValue    { get; set; } // bigint
		[Column("StringValue"   )] public string?   StringValue    { get; set; } // nvarchar(50)
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column("ParentID")] public int? ParentID { get; set; } // int
		[Column("Value1"  )] public int? Value1   { get; set; } // int
	}

	[Table("Patient")]
	public partial class Patient
	{
		[Column("PersonID" , IsPrimaryKey = true )] public int    PersonID  { get; set; } // int
		[Column("Diagnosis", CanBeNull    = false)] public string Diagnosis { get; set; } = null!; // nvarchar(256)

		#region Associations
		/// <summary>
		/// FK_Patient_Person
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(PersonID), OtherKey = nameof(SqlCe.Person.PersonID))]
		public Person Person { get; set; } = null!;
		#endregion
	}

	[Table("Person")]
	public partial class Person
	{
		[Column("PersonID"  , IsPrimaryKey = true )] public int     PersonID   { get; set; } // int
		[Column("FirstName" , CanBeNull    = false)] public string  FirstName  { get; set; } = null!; // nvarchar(50)
		[Column("LastName"  , CanBeNull    = false)] public string  LastName   { get; set; } = null!; // nvarchar(50)
		[Column("MiddleName"                      )] public string? MiddleName { get; set; } // nvarchar(50)
		[Column("Gender"                          )] public char    Gender     { get; set; } // nchar(1)

		#region Associations
		/// <summary>
		/// FK_Doctor_Person backreference
		/// </summary>
		[Association(ThisKey = nameof(PersonID), OtherKey = nameof(SqlCe.Doctor.PersonID))]
		public Doctor? Doctor { get; set; }

		/// <summary>
		/// FK_Patient_Person backreference
		/// </summary>
		[Association(ThisKey = nameof(PersonID), OtherKey = nameof(SqlCe.Patient.PersonID))]
		public Patient? Patient { get; set; }
		#endregion
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[Column("ID", IsPrimaryKey = true)] public int ID { get; set; } // int
	}

	[Table("TestMerge1")]
	public partial class TestMerge1
	{
		[Column("Id"             , IsPrimaryKey = true)] public int       Id              { get; set; } // int
		[Column("Field1"                              )] public int?      Field1          { get; set; } // int
		[Column("Field2"                              )] public int?      Field2          { get; set; } // int
		[Column("Field3"                              )] public int?      Field3          { get; set; } // int
		[Column("Field4"                              )] public int?      Field4          { get; set; } // int
		[Column("Field5"                              )] public int?      Field5          { get; set; } // int
		[Column("FieldInt64"                          )] public long?     FieldInt64      { get; set; } // bigint
		[Column("FieldBoolean"                        )] public bool?     FieldBoolean    { get; set; } // bit
		[Column("FieldString"                         )] public string?   FieldString     { get; set; } // nvarchar(20)
		[Column("FieldNString"                        )] public string?   FieldNString    { get; set; } // nvarchar(20)
		[Column("FieldChar"                           )] public char?     FieldChar       { get; set; } // nchar(1)
		[Column("FieldNChar"                          )] public char?     FieldNChar      { get; set; } // nchar(1)
		[Column("FieldFloat"                          )] public float?    FieldFloat      { get; set; } // real
		[Column("FieldDouble"                         )] public double?   FieldDouble     { get; set; } // float
		[Column("FieldDateTime"                       )] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column("FieldBinary"                         )] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column("FieldGuid"                           )] public Guid?     FieldGuid       { get; set; } // uniqueidentifier
		[Column("FieldDecimal"                        )] public decimal?  FieldDecimal    { get; set; } // numeric(24, 10)
		[Column("FieldEnumString"                     )] public string?   FieldEnumString { get; set; } // nvarchar(20)
		[Column("FieldEnumNumber"                     )] public int?      FieldEnumNumber { get; set; } // int
	}

	[Table("TestMerge2")]
	public partial class TestMerge2
	{
		[Column("Id"             , IsPrimaryKey = true)] public int       Id              { get; set; } // int
		[Column("Field1"                              )] public int?      Field1          { get; set; } // int
		[Column("Field2"                              )] public int?      Field2          { get; set; } // int
		[Column("Field3"                              )] public int?      Field3          { get; set; } // int
		[Column("Field4"                              )] public int?      Field4          { get; set; } // int
		[Column("Field5"                              )] public int?      Field5          { get; set; } // int
		[Column("FieldInt64"                          )] public long?     FieldInt64      { get; set; } // bigint
		[Column("FieldBoolean"                        )] public bool?     FieldBoolean    { get; set; } // bit
		[Column("FieldString"                         )] public string?   FieldString     { get; set; } // nvarchar(20)
		[Column("FieldNString"                        )] public string?   FieldNString    { get; set; } // nvarchar(20)
		[Column("FieldChar"                           )] public char?     FieldChar       { get; set; } // nchar(1)
		[Column("FieldNChar"                          )] public char?     FieldNChar      { get; set; } // nchar(1)
		[Column("FieldFloat"                          )] public float?    FieldFloat      { get; set; } // real
		[Column("FieldDouble"                         )] public double?   FieldDouble     { get; set; } // float
		[Column("FieldDateTime"                       )] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column("FieldBinary"                         )] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column("FieldGuid"                           )] public Guid?     FieldGuid       { get; set; } // uniqueidentifier
		[Column("FieldDecimal"                        )] public decimal?  FieldDecimal    { get; set; } // numeric(24, 10)
		[Column("FieldEnumString"                     )] public string?   FieldEnumString { get; set; } // nvarchar(20)
		[Column("FieldEnumNumber"                     )] public int?      FieldEnumNumber { get; set; } // int
	}
}
