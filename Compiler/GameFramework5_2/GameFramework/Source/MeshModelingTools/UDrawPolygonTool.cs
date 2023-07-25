#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolygonTool.h")]
///<summary>This tool allows the user to draw and extrude 2D polygons</summary>
public partial class UDrawPolygonTool : UInteractiveTool {
// DrawPolygonTool
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public UDrawPolygonToolStandardProperties PolygonProperties;
	public UDrawPolygonToolSnapProperties SnapProperties;
	public UNewMeshMaterialProperties MaterialProperties;
	public UPreviewMesh PreviewMesh;
	public UPlaneDistanceFromHitMechanic HeightMechanic;
	public UDragAlignmentMechanic DragAlignmentMechanic;
	public UConstructionPlaneMechanic PlaneMechanic;
}
