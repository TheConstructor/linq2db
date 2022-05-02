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

namespace Cli.Default.Informix
{
	[Table("linqdatatypes")]
	public class Linqdatatype
	{
		[Column("id"            )] public int?      Id             { get; set; } // INTEGER
		[Column("moneyvalue"    )] public decimal?  Moneyvalue     { get; set; } // DECIMAL(10,4)
		[Column("datetimevalue" )] public DateTime? Datetimevalue  { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column("datetimevalue2")] public DateTime? Datetimevalue2 { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column("boolvalue"     )] public bool?     Boolvalue      { get; set; } // BOOLEAN
		[Column("guidvalue"     )] public string?   Guidvalue      { get; set; } // CHAR(36)
		[Column("binaryvalue"   )] public byte[]?   Binaryvalue    { get; set; } // BYTE
		[Column("smallintvalue" )] public short?    Smallintvalue  { get; set; } // SMALLINT
		[Column("intvalue"      )] public int?      Intvalue       { get; set; } // INTEGER
		[Column("bigintvalue"   )] public long?     Bigintvalue    { get; set; } // BIGINT
		[Column("stringvalue"   )] public string?   Stringvalue    { get; set; } // NVARCHAR(50)
	}
}
