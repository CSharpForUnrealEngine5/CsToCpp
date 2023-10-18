namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Plane Cutting Tool</summary>
[CppInclude("PolygonOnMeshTool.h")]
public partial class UPolygonOnMeshTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>BasicProperties</summary>
	public UPolygonOnMeshToolProperties BasicProperties;
	///<summary>ActionProperties</summary>
	public UPolygonOnMeshToolActionPropertySet ActionProperties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>DrawnLineSet</summary>
	public ULineSetComponent DrawnLineSet;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
	///<summary>DrawPolygonMechanic</summary>
	public UCollectSurfacePathMechanic DrawPolygonMechanic;
}
