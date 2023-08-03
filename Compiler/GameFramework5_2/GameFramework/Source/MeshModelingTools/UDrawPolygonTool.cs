#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This tool allows the user to draw and extrude 2D polygons</summary>
[CppInclude("DrawPolygonTool.h")]
public partial class UDrawPolygonTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Property set for type of output object (StaticMesh, Volume, etc)</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>Properties that control polygon generation exposed to user via details view</summary>
	public UDrawPolygonToolStandardProperties PolygonProperties;
	///<summary>SnapProperties</summary>
	public UDrawPolygonToolSnapProperties SnapProperties;
	///<summary>MaterialProperties</summary>
	public UNewMeshMaterialProperties MaterialProperties;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>HeightMechanic</summary>
	public UPlaneDistanceFromHitMechanic HeightMechanic;
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
}
