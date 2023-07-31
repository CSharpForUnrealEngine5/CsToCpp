#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCardsEditorTool.h")]
public partial class UGroomCardsEditorTool : UMeshSurfacePointTool {
	///<summary>SelectActions</summary>
	public USelectGroomCardsToolActions SelectActions;
	///<summary>EditActions</summary>
	public UEditGroomCardsToolActions EditActions;
	///<summary>InfoProperties</summary>
	public UGroomCardsInfoToolProperties InfoProperties;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>TargetGroom</summary>
	public TLazyObjectPtr<AGroomActor> TargetGroom;
	///<summary>PreviewGeom</summary>
	public UPreviewGeometry PreviewGeom;
	///<summary>materials</summary>
	public UMaterialInterface MeshMaterial;
	///<summary>UVMaterial</summary>
	public UMaterialInterface UVMaterial;
	///<summary>mechanics</summary>
	public UPolygonSelectionMechanic CardMeshSelectionMechanic;
	///<summary>ControlPointsMechanic</summary>
	public USpaceCurveDeformationMechanic ControlPointsMechanic;
}
