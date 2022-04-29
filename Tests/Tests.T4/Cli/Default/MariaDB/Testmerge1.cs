// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;
using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.MariaDB
{
	[Table("testmerge1")]
	public class Testmerge1
	{
		[Column("Id"             , IsPrimaryKey = true)] public int       Id              { get; set; } // int(11)
		[Column("Field1"                              )] public int?      Field1          { get; set; } // int(11)
		[Column("Field2"                              )] public int?      Field2          { get; set; } // int(11)
		[Column("Field3"                              )] public int?      Field3          { get; set; } // int(11)
		[Column("Field4"                              )] public int?      Field4          { get; set; } // int(11)
		[Column("Field5"                              )] public int?      Field5          { get; set; } // int(11)
		[Column("FieldInt64"                          )] public long?     FieldInt64      { get; set; } // bigint(20)
		[Column("FieldBoolean"                        )] public bool?     FieldBoolean    { get; set; } // bit(1)
		[Column("FieldString"                         )] public string?   FieldString     { get; set; } // varchar(20)
		[Column("FieldNString"                        )] public string?   FieldNString    { get; set; } // varchar(20)
		[Column("FieldChar"                           )] public char?     FieldChar       { get; set; } // char(1)
		[Column("FieldNChar"                          )] public char?     FieldNChar      { get; set; } // char(1)
		[Column("FieldFloat"                          )] public float?    FieldFloat      { get; set; } // float
		[Column("FieldDouble"                         )] public double?   FieldDouble     { get; set; } // double
		[Column("FieldDateTime"                       )] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column("FieldBinary"                         )] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column("FieldGuid"                           )] public string?   FieldGuid       { get; set; } // char(36)
		[Column("FieldDecimal"                        )] public decimal?  FieldDecimal    { get; set; } // decimal(24,10)
		[Column("FieldDate"                           )] public DateTime? FieldDate       { get; set; } // date
		[Column("FieldTime"                           )] public TimeSpan? FieldTime       { get; set; } // time
		[Column("FieldEnumString"                     )] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column("FieldEnumNumber"                     )] public int?      FieldEnumNumber { get; set; } // int(11)
	}
}