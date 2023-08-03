#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data source that loads from a specific data table containing the same type of structs as the registry</summary>
[CppInclude("DataRegistrySource_DataTable.h")]
public partial class UDataRegistrySource_DataTable : UDataRegistrySource {
	public static UClass StaticClass() {return default;}
	///<summary>What table to load from</summary>
	public TSoftObjectPtr<UDataTable> SourceTable;
	///<summary>Access rules</summary>
	public FDataRegistrySource_DataTableRules TableRules;
	///<summary>Hard ref to loaded table</summary>
	public UDataTable CachedTable;
	///<summary>Preload table ref, will be set if this is a hard source</summary>
	public UDataTable PreloadTable;
}
