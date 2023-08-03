#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeshOpPreviewWithBackgroundCompute is an infrastructure object that implements a common UI</summary>
[CppInclude("MeshOpPreviewHelpers.h")]
public partial class UMeshOpPreviewWithBackgroundCompute : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>preview of MeshOperator result</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>input set of materials to assign to PreviewMesh</summary>
	public TArray<UMaterialInterface> StandardMaterials;
	///<summary>override material to forward to PreviewMesh if set</summary>
	public UMaterialInterface OverrideMaterial;
	///<summary>if non-null, this material is swapped in when a background compute is active</summary>
	public UMaterialInterface WorkingMaterial;
	///<summary>secondary render material to forward to PreviewMesh if set</summary>
	public UMaterialInterface SecondaryMaterial;
	///<summary>PreviewWorld</summary>
	public TWeakObjectPtr<UWorld> PreviewWorld;
}
