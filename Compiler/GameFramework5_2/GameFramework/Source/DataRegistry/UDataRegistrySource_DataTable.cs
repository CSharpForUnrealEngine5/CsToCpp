#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistrySource_DataTable.h")]
///<summary>Data source that loads from a specific data table containing the same type of structs as the registry</summary>
public partial class UDataRegistrySource_DataTable : UDataRegistrySource {
// DataRegistrySource_DataTable
	public TSoftObjectPtr<UDataTable> SourceTable;
	public FDataRegistrySource_DataTableRules TableRules;
	public UDataTable CachedTable;
	public UDataTable PreloadTable;
}
