#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshExporterUSDOptions.h")]
///<summary>Options for exporting skeletal meshes to USD format.</summary>
public partial class USkeletalMeshExporterUSDOptions : UObject {
// SkeletalMeshExporterUSDOptions
	public FUsdStageOptions StageOptions;
	public FUsdMeshAssetOptions MeshAssetOptions;
	public bool bReExportIdenticalAssets;
}
