#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data source that loads from a specific curve table asset</summary>
[CppInclude("DataRegistrySource_CurveTable.h")]
public partial class UDataRegistrySource_CurveTable : UDataRegistrySource {
	public static UClass StaticClass() {return default;}
	///<summary>What table to load from</summary>
	public TSoftObjectPtr<UCurveTable> SourceTable;
	///<summary>Access rules</summary>
	public FDataRegistrySource_DataTableRules TableRules;
	///<summary>Hard ref to loaded table</summary>
	public UCurveTable CachedTable;
	///<summary>Preload table ref, will be set if this is a hard source</summary>
	public UCurveTable PreloadTable;
}
