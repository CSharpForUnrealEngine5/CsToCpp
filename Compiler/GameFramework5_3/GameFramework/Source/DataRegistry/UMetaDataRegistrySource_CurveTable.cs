namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Meta source that will generate CurveTable sources at runtime based on a directory scan or asset registration</summary>
[CppInclude("DataRegistrySource_CurveTable.h")]
public partial class UMetaDataRegistrySource_CurveTable : UMetaDataRegistrySource {
	public static UClass StaticClass() {return default;}
	///<summary>What specific source class to spawn</summary>
	public UClass CreatedSource;
	///<summary>Access rules</summary>
	public FDataRegistrySource_DataTableRules TableRules;
}
