#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomToMeshTool.h")]
public partial class UGroomToMeshTool : UInteractiveTool {
// GroomToMeshTool
	public UGroomToMeshToolProperties Settings;
	public UPreviewMesh PreviewMesh;
	public TLazyObjectPtr<AGroomActor> TargetGroom;
	public UPreviewGeometry PreviewGeom;
	public UMaterialInterface MeshMaterial;
	public UMaterialInterface UVMaterial;
}
