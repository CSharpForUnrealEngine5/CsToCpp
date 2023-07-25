#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CSGMeshesTool.h")]
///<summary>Simple Mesh Plane Cutting Tool</summary>
public partial class UCSGMeshesTool : UBaseCreateFromSelectedTool {
// CSGMeshesTool
	public UCSGMeshesToolProperties CSGProperties;
	public UTrimMeshesToolProperties TrimProperties;
	public TArray<UPreviewMesh> OriginalMeshPreviews;
	public UMaterialInstanceDynamic PreviewsGhostMaterial;
	public ULineSetComponent DrawnLineSet;
}
