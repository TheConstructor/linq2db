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

namespace InformixDataContext
{
	public partial class TestdataidsDB : LinqToDB.Data.DataConnection
	{
		public ITable<Alltype>           Alltypes           { get { return this.GetTable<Alltype>(); } }
		public ITable<Child>             Children           { get { return this.GetTable<Child>(); } }
		public ITable<Collatedtable>     Collatedtables     { get { return this.GetTable<Collatedtable>(); } }
		public ITable<Doctor>            Doctors            { get { return this.GetTable<Doctor>(); } }
		public ITable<Grandchild>        Grandchilds        { get { return this.GetTable<Grandchild>(); } }
		public ITable<Inheritancechild>  Inheritancechilds  { get { return this.GetTable<Inheritancechild>(); } }
		public ITable<Inheritanceparent> Inheritanceparents { get { return this.GetTable<Inheritanceparent>(); } }
		public ITable<Linqdatatype>      Linqdatatypes      { get { return this.GetTable<Linqdatatype>(); } }
		public ITable<Parent>            Parents            { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>           Patients           { get { return this.GetTable<Patient>(); } }
		public ITable<Person>            People             { get { return this.GetTable<Person>(); } }
		public ITable<Personview>        Personviews        { get { return this.GetTable<Personview>(); } }
		public ITable<Testfkunique>      Testfkuniques      { get { return this.GetTable<Testfkunique>(); } }
		public ITable<Testidentity>      Testidentities     { get { return this.GetTable<Testidentity>(); } }
		public ITable<Testmerge1>        Testmerge1         { get { return this.GetTable<Testmerge1>(); } }
		public ITable<Testmerge2>        Testmerge2         { get { return this.GetTable<Testmerge2>(); } }
		public ITable<Testunique>        Testuniques        { get { return this.GetTable<Testunique>(); } }

		public TestdataidsDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestdataidsDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestdataidsDB(LinqToDBConnectionOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestdataidsDB(LinqToDBConnectionOptions<TestdataidsDB> options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table(Schema="informix", Name="alltypes")]
	public partial class Alltype
	{
		[Column("id"),               PrimaryKey, Identity] public int       Id               { get; set; } // SERIAL
		[Column("bigintdatatype"),   Nullable            ] public long?     Bigintdatatype   { get; set; } // BIGINT
		[Column("int8datatype"),     Nullable            ] public long?     Int8datatype     { get; set; } // INT8
		[Column("intdatatype"),      Nullable            ] public int?      Intdatatype      { get; set; } // INTEGER
		[Column("smallintdatatype"), Nullable            ] public short?    Smallintdatatype { get; set; } // SMALLINT
		[Column("decimaldatatype"),  Nullable            ] public decimal?  Decimaldatatype  { get; set; } // DECIMAL
		[Column("moneydatatype"),    Nullable            ] public decimal?  Moneydatatype    { get; set; } // MONEY(16,2)
		[Column("realdatatype"),     Nullable            ] public float?    Realdatatype     { get; set; } // SMALLFLOAT
		[Column("floatdatatype"),    Nullable            ] public double?   Floatdatatype    { get; set; } // FLOAT
		[Column("booldatatype"),     Nullable            ] public bool?     Booldatatype     { get; set; } // BOOLEAN
		[Column("chardatatype"),     Nullable            ] public char?     Chardatatype     { get; set; } // CHAR(1)
		[Column("char20datatype"),   Nullable            ] public string?   Char20datatype   { get; set; } // CHAR(20)
		[Column("varchardatatype"),  Nullable            ] public string?   Varchardatatype  { get; set; } // VARCHAR(10)
		[Column("nchardatatype"),    Nullable            ] public string?   Nchardatatype    { get; set; } // NCHAR(10)
		[Column("nvarchardatatype"), Nullable            ] public string?   Nvarchardatatype { get; set; } // NVARCHAR(10)
		[Column("lvarchardatatype"), Nullable            ] public string?   Lvarchardatatype { get; set; } // LVARCHAR(10)
		[Column("textdatatype"),     Nullable            ] public string?   Textdatatype     { get; set; } // TEXT
		[Column("datedatatype"),     Nullable            ] public DateTime? Datedatatype     { get; set; } // DATE
		[Column("datetimedatatype"), Nullable            ] public DateTime? Datetimedatatype { get; set; } // DATETIME YEAR TO SECOND
		[Column("intervaldatatype"), Nullable            ] public TimeSpan? Intervaldatatype { get; set; } // INTERVAL HOUR TO SECOND
		[Column("bytedatatype"),     Nullable            ] public byte[]?   Bytedatatype     { get; set; } // BYTE
	}

	[Table(Schema="informix", Name="child")]
	public partial class Child
	{
		[Column("parentid"), Nullable] public int? Parentid { get; set; } // INTEGER
		[Column("childid"),  Nullable] public int? Childid  { get; set; } // INTEGER
	}

	[Table(Schema="informix", Name="collatedtable")]
	public partial class Collatedtable
	{
		[Column("id"),              NotNull] public int    Id              { get; set; } // INTEGER
		[Column("casesensitive"),   NotNull] public string Casesensitive   { get; set; } = null!; // VARCHAR(20)
		[Column("caseinsensitive"), NotNull] public string Caseinsensitive { get; set; } = null!; // NVARCHAR(20)
	}

	[Table(Schema="informix", Name="doctor")]
	public partial class Doctor
	{
		[Column("personid"), PrimaryKey, NotNull] public int    Personid { get; set; } // INTEGER
		[Column("taxonomy"),             NotNull] public string Taxonomy { get; set; } = null!; // NVARCHAR(50)

		#region Associations

		/// <summary>
		/// FK_doctor_person (informix.person)
		/// </summary>
		[Association(ThisKey="Personid", OtherKey="Personid", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table(Schema="informix", Name="grandchild")]
	public partial class Grandchild
	{
		[Column("parentid"),     Nullable] public int? Parentid     { get; set; } // INTEGER
		[Column("childid"),      Nullable] public int? Childid      { get; set; } // INTEGER
		[Column("grandchildid"), Nullable] public int? Grandchildid { get; set; } // INTEGER
	}

	[Table(Schema="informix", Name="inheritancechild")]
	public partial class Inheritancechild
	{
		[Column("inheritancechildid"),  PrimaryKey,  NotNull] public int     Inheritancechildid  { get; set; } // INTEGER
		[Column("inheritanceparentid"),              NotNull] public int     Inheritanceparentid { get; set; } // INTEGER
		[Column("typediscriminator"),      Nullable         ] public int?    Typediscriminator   { get; set; } // INTEGER
		[Column("name"),                   Nullable         ] public string? Name                { get; set; } // NVARCHAR(50)
	}

	[Table(Schema="informix", Name="inheritanceparent")]
	public partial class Inheritanceparent
	{
		[Column("inheritanceparentid"), PrimaryKey,  NotNull] public int     Inheritanceparentid { get; set; } // INTEGER
		[Column("typediscriminator"),      Nullable         ] public int?    Typediscriminator   { get; set; } // INTEGER
		[Column("name"),                   Nullable         ] public string? Name                { get; set; } // NVARCHAR(50)
	}

	[Table(Schema="informix", Name="linqdatatypes")]
	public partial class Linqdatatype
	{
		[Column("id"),             Nullable] public int?      Id             { get; set; } // INTEGER
		[Column("moneyvalue"),     Nullable] public decimal?  Moneyvalue     { get; set; } // DECIMAL(10,4)
		[Column("datetimevalue"),  Nullable] public DateTime? Datetimevalue  { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column("datetimevalue2"), Nullable] public DateTime? Datetimevalue2 { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column("boolvalue"),      Nullable] public bool?     Boolvalue      { get; set; } // BOOLEAN
		[Column("guidvalue"),      Nullable] public string?   Guidvalue      { get; set; } // CHAR(36)
		[Column("binaryvalue"),    Nullable] public byte[]?   Binaryvalue    { get; set; } // BYTE
		[Column("smallintvalue"),  Nullable] public short?    Smallintvalue  { get; set; } // SMALLINT
		[Column("intvalue"),       Nullable] public int?      Intvalue       { get; set; } // INTEGER
		[Column("bigintvalue"),    Nullable] public long?     Bigintvalue    { get; set; } // BIGINT
		[Column("stringvalue"),    Nullable] public string?   Stringvalue    { get; set; } // NVARCHAR(50)
	}

	[Table(Schema="informix", Name="parent")]
	public partial class Parent
	{
		[Column("parentid"), Nullable] public int? Parentid { get; set; } // INTEGER
		[Column("value1"),   Nullable] public int? Value1   { get; set; } // INTEGER
	}

	[Table(Schema="informix", Name="patient")]
	public partial class Patient
	{
		[Column("personid"),  PrimaryKey, NotNull] public int    Personid  { get; set; } // INTEGER
		[Column("diagnosis"),             NotNull] public string Diagnosis { get; set; } = null!; // NVARCHAR(100)

		#region Associations

		/// <summary>
		/// FK_patient_person (informix.person)
		/// </summary>
		[Association(ThisKey="Personid", OtherKey="Personid", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table(Schema="informix", Name="person")]
	public partial class Person
	{
		[Column("personid"),   PrimaryKey,  Identity] public int     Personid   { get; set; } // SERIAL
		[Column("firstname"),  NotNull              ] public string  Firstname  { get; set; } = null!; // NVARCHAR(50)
		[Column("lastname"),   NotNull              ] public string  Lastname   { get; set; } = null!; // NVARCHAR(50)
		[Column("middlename"),    Nullable          ] public string? Middlename { get; set; } // NVARCHAR(50)
		[Column("gender"),     NotNull              ] public char    Gender     { get; set; } // CHAR(1)

		#region Associations

		/// <summary>
		/// FK_doctor_person_BackReference (informix.doctor)
		/// </summary>
		[Association(ThisKey="Personid", OtherKey="Personid", CanBeNull=true)]
		public Doctor? Doctor { get; set; }

		/// <summary>
		/// FK_patient_person_BackReference (informix.patient)
		/// </summary>
		[Association(ThisKey="Personid", OtherKey="Personid", CanBeNull=true)]
		public Patient? Patient { get; set; }

		#endregion
	}

	[Table(Schema="informix", Name="personview", IsView=true)]
	public partial class Personview
	{
		[Column("personid"),   Identity   ] public int     Personid   { get; set; } // SERIAL
		[Column("firstname"),  NotNull    ] public string  Firstname  { get; set; } = null!; // NVARCHAR(50)
		[Column("lastname"),   NotNull    ] public string  Lastname   { get; set; } = null!; // NVARCHAR(50)
		[Column("middlename"),    Nullable] public string? Middlename { get; set; } // NVARCHAR(50)
		[Column("gender"),     NotNull    ] public char    Gender     { get; set; } // CHAR(1)
	}

	[Table(Schema="informix", Name="testfkunique")]
	public partial class Testfkunique
	{
		[Column("id1"), NotNull] public int Id1 { get; set; } // INTEGER
		[Column("id2"), NotNull] public int Id2 { get; set; } // INTEGER
		[Column("id3"), NotNull] public int Id3 { get; set; } // INTEGER
		[Column("id4"), NotNull] public int Id4 { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_testfkunique_testunique_1 (informix.testunique)
		/// </summary>
		[Association(ThisKey="Id3, Id4", OtherKey="Id3, Id4", CanBeNull=false)]
		public Testunique FkTestfkuniqueTestunique1 { get; set; } = null!;

		/// <summary>
		/// FK_testfkunique_testunique (informix.testunique)
		/// </summary>
		[Association(ThisKey="Id1, Id2", OtherKey="Id1, Id2", CanBeNull=false)]
		public Testunique Testunique { get; set; } = null!;

		#endregion
	}

	[Table(Schema="informix", Name="testidentity")]
	public partial class Testidentity
	{
		[Column("id"), PrimaryKey, Identity] public int Id { get; set; } // SERIAL
	}

	[Table(Schema="informix", Name="testmerge1")]
	public partial class Testmerge1
	{
		[Column("id"),              PrimaryKey,  NotNull] public int       Id              { get; set; } // INTEGER
		[Column("field1"),             Nullable         ] public int?      Field1          { get; set; } // INTEGER
		[Column("field2"),             Nullable         ] public int?      Field2          { get; set; } // INTEGER
		[Column("field3"),             Nullable         ] public int?      Field3          { get; set; } // INTEGER
		[Column("field4"),             Nullable         ] public int?      Field4          { get; set; } // INTEGER
		[Column("field5"),             Nullable         ] public int?      Field5          { get; set; } // INTEGER
		[Column("fieldint64"),         Nullable         ] public long?     Fieldint64      { get; set; } // BIGINT
		[Column("fieldboolean"),       Nullable         ] public bool?     Fieldboolean    { get; set; } // BOOLEAN
		[Column("fieldstring"),        Nullable         ] public string?   Fieldstring     { get; set; } // VARCHAR(20)
		[Column("fieldchar"),          Nullable         ] public char?     Fieldchar       { get; set; } // CHAR(1)
		[Column("fieldfloat"),         Nullable         ] public float?    Fieldfloat      { get; set; } // SMALLFLOAT
		[Column("fielddouble"),        Nullable         ] public double?   Fielddouble     { get; set; } // FLOAT
		[Column("fielddatetime"),      Nullable         ] public DateTime? Fielddatetime   { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column("fieldbinary"),        Nullable         ] public byte[]?   Fieldbinary     { get; set; } // BYTE
		[Column("fielddecimal"),       Nullable         ] public decimal?  Fielddecimal    { get; set; } // DECIMAL(24,10)
		[Column("fielddate"),          Nullable         ] public DateTime? Fielddate       { get; set; } // DATE
		[Column("fieldtime"),          Nullable         ] public TimeSpan? Fieldtime       { get; set; } // INTERVAL HOUR TO FRACTION(5)
		[Column("fieldenumstring"),    Nullable         ] public string?   Fieldenumstring { get; set; } // VARCHAR(20)
		[Column("fieldenumnumber"),    Nullable         ] public int?      Fieldenumnumber { get; set; } // INTEGER
	}

	[Table(Schema="informix", Name="testmerge2")]
	public partial class Testmerge2
	{
		[Column("id"),              PrimaryKey,  NotNull] public int       Id              { get; set; } // INTEGER
		[Column("field1"),             Nullable         ] public int?      Field1          { get; set; } // INTEGER
		[Column("field2"),             Nullable         ] public int?      Field2          { get; set; } // INTEGER
		[Column("field3"),             Nullable         ] public int?      Field3          { get; set; } // INTEGER
		[Column("field4"),             Nullable         ] public int?      Field4          { get; set; } // INTEGER
		[Column("field5"),             Nullable         ] public int?      Field5          { get; set; } // INTEGER
		[Column("fieldint64"),         Nullable         ] public long?     Fieldint64      { get; set; } // BIGINT
		[Column("fieldboolean"),       Nullable         ] public bool?     Fieldboolean    { get; set; } // BOOLEAN
		[Column("fieldstring"),        Nullable         ] public string?   Fieldstring     { get; set; } // VARCHAR(20)
		[Column("fieldchar"),          Nullable         ] public char?     Fieldchar       { get; set; } // CHAR(1)
		[Column("fieldfloat"),         Nullable         ] public float?    Fieldfloat      { get; set; } // SMALLFLOAT
		[Column("fielddouble"),        Nullable         ] public double?   Fielddouble     { get; set; } // FLOAT
		[Column("fielddatetime"),      Nullable         ] public DateTime? Fielddatetime   { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column("fieldbinary"),        Nullable         ] public byte[]?   Fieldbinary     { get; set; } // BYTE
		[Column("fielddecimal"),       Nullable         ] public decimal?  Fielddecimal    { get; set; } // DECIMAL(24,10)
		[Column("fielddate"),          Nullable         ] public DateTime? Fielddate       { get; set; } // DATE
		[Column("fieldtime"),          Nullable         ] public TimeSpan? Fieldtime       { get; set; } // INTERVAL HOUR TO FRACTION(5)
		[Column("fieldenumstring"),    Nullable         ] public string?   Fieldenumstring { get; set; } // VARCHAR(20)
		[Column("fieldenumnumber"),    Nullable         ] public int?      Fieldenumnumber { get; set; } // INTEGER
	}

	[Table(Schema="informix", Name="testunique")]
	public partial class Testunique
	{
		[Column("id1"), PrimaryKey(0), NotNull] public int Id1 { get; set; } // INTEGER
		[Column("id2"), PrimaryKey(1), NotNull] public int Id2 { get; set; } // INTEGER
		[Column("id3"),                NotNull] public int Id3 { get; set; } // INTEGER
		[Column("id4"),                NotNull] public int Id4 { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_testfkunique_testunique_1_BackReference (informix.testfkunique)
		/// </summary>
		[Association(ThisKey="Id3, Id4", OtherKey="Id3, Id4", CanBeNull=true)]
		public IEnumerable<Testfkunique> FkTestfkuniqueTestunique1BackReferences { get; set; } = null!;

		/// <summary>
		/// FK_testfkunique_testunique_BackReference (informix.testfkunique)
		/// </summary>
		[Association(ThisKey="Id1, Id2", OtherKey="Id1, Id2", CanBeNull=true)]
		public IEnumerable<Testfkunique> Testfkuniques { get; set; } = null!;

		#endregion
	}

	public static partial class TableExtensions
	{
		public static Alltype? Find(this ITable<Alltype> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Doctor? Find(this ITable<Doctor> table, int Personid)
		{
			return table.FirstOrDefault(t =>
				t.Personid == Personid);
		}

		public static Inheritancechild? Find(this ITable<Inheritancechild> table, int Inheritancechildid)
		{
			return table.FirstOrDefault(t =>
				t.Inheritancechildid == Inheritancechildid);
		}

		public static Inheritanceparent? Find(this ITable<Inheritanceparent> table, int Inheritanceparentid)
		{
			return table.FirstOrDefault(t =>
				t.Inheritanceparentid == Inheritanceparentid);
		}

		public static Patient? Find(this ITable<Patient> table, int Personid)
		{
			return table.FirstOrDefault(t =>
				t.Personid == Personid);
		}

		public static Person? Find(this ITable<Person> table, int Personid)
		{
			return table.FirstOrDefault(t =>
				t.Personid == Personid);
		}

		public static Testidentity? Find(this ITable<Testidentity> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Testmerge1? Find(this ITable<Testmerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Testmerge2? Find(this ITable<Testmerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Testunique? Find(this ITable<Testunique> table, int Id1, int Id2)
		{
			return table.FirstOrDefault(t =>
				t.Id1 == Id1 &&
				t.Id2 == Id2);
		}
	}
}
