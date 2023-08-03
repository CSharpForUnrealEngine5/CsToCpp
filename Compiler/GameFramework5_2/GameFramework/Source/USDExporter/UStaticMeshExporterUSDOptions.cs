#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options for exporting static meshes to USD format.</summary>
[CppInclude("StaticMeshExporterUSDOptions.h")]
public partial class UStaticMeshExporterUSDOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>StageOptions</summary>
	public FUsdStageOptions StageOptions;
	///<summary>MeshAssetOptions</summary>
	public FUsdMeshAssetOptions MeshAssetOptions;
	///<summary>Whether to export any asset (StaticMesh, Material, etc.) even if the existing file already describes the same version of a compatible asset.</summary>
	public bool bReExportIdenticalAssets;
}
