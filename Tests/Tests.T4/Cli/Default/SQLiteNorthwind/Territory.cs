// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.SQLiteNorthwind
{
	[Table("Territories")]
	public class Territory
	{
		[Column("TerritoryID"         , CanBeNull = false, IsPrimaryKey = true)] public string TerritoryId          { get; set; } = null!; // varchar(20)
		[Column("TerritoryDescription", CanBeNull = false                     )] public string TerritoryDescription { get; set; } = null!; // varchar(50)
		[Column("RegionID"                                                    )] public int    RegionId             { get; set; } // int
	}
}
