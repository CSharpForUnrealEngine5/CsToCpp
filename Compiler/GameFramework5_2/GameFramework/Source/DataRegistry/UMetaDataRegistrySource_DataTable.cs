#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Meta source that will generate DataTable sources at runtime based on a directory scan or asset registration</summary>
[CppInclude("DataRegistrySource_DataTable.h")]
public partial class UMetaDataRegistrySource_DataTable : UMetaDataRegistrySource {
	public static UClass StaticClass() {return default;}
	///<summary>What specific source class to spawn</summary>
	public UClass CreatedSource;
	///<summary>Access rules</summary>
	public FDataRegistrySource_DataTableRules TableRules;
}
