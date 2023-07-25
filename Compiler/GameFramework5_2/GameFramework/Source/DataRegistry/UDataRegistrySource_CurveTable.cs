#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistrySource_CurveTable.h")]
///<summary>Data source that loads from a specific curve table asset</summary>
public partial class UDataRegistrySource_CurveTable : UDataRegistrySource {
// DataRegistrySource_CurveTable
	public TSoftObjectPtr<UCurveTable> SourceTable;
	public FDataRegistrySource_DataTableRules TableRules;
	public UCurveTable CachedTable;
	public UCurveTable PreloadTable;
}
