#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PolygonOnMeshTool.h")]
///<summary>Simple Mesh Plane Cutting Tool</summary>
public partial class UPolygonOnMeshTool : USingleSelectionMeshEditingTool {
// PolygonOnMeshTool
	public UPolygonOnMeshToolProperties BasicProperties;
	public UPolygonOnMeshToolActionPropertySet ActionProperties;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public ULineSetComponent DrawnLineSet;
	public UConstructionPlaneMechanic PlaneMechanic;
	public UCollectSurfacePathMechanic DrawPolygonMechanic;
}
