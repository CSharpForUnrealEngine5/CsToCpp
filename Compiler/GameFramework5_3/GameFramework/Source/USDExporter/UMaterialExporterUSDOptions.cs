namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options for exporting materials to USD format.</summary>
[CppInclude("MaterialExporterUSDOptions.h")]
public partial class UMaterialExporterUSDOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>MaterialBakingOptions</summary>
	public FUsdMaterialBakingOptions MaterialBakingOptions;
	///<summary>Whether to export any asset (StaticMesh, Material, etc.) even if the existing file already describes the same version of a compatible asset.</summary>
	public bool bReExportIdenticalAssets;
}
