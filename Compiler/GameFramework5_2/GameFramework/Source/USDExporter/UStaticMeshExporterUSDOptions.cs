#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticMeshExporterUSDOptions.h")]
///<summary>Options for exporting static meshes to USD format.</summary>
public partial class UStaticMeshExporterUSDOptions : UObject {
// StaticMeshExporterUSDOptions
	public FUsdStageOptions StageOptions;
	public FUsdMeshAssetOptions MeshAssetOptions;
	public bool bReExportIdenticalAssets;
}
