#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCardsEditorTool.h")]
public partial class UGroomCardsEditorTool : UMeshSurfacePointTool {
// GroomCardsEditorTool
	public USelectGroomCardsToolActions SelectActions;
	public UEditGroomCardsToolActions EditActions;
	public UGroomCardsInfoToolProperties InfoProperties;
	public UPreviewMesh PreviewMesh;
	public TLazyObjectPtr<AGroomActor> TargetGroom;
	public UPreviewGeometry PreviewGeom;
	public UMaterialInterface MeshMaterial;
	public UMaterialInterface UVMaterial;
	public UPolygonSelectionMechanic CardMeshSelectionMechanic;
	public USpaceCurveDeformationMechanic ControlPointsMechanic;
}
