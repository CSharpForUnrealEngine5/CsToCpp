#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshOpPreviewHelpers.h")]
///<summary>UMeshOpPreviewWithBackgroundCompute is an infrastructure object that implements a common UI</summary>
public partial class UMeshOpPreviewWithBackgroundCompute : UObject {
// MeshOpPreviewWithBackgroundCompute
	public UPreviewMesh PreviewMesh;
	public TArray<UMaterialInterface> StandardMaterials;
	public UMaterialInterface OverrideMaterial;
	public UMaterialInterface WorkingMaterial;
	public UMaterialInterface SecondaryMaterial;
	public TWeakObjectPtr<UWorld> PreviewWorld;
}
