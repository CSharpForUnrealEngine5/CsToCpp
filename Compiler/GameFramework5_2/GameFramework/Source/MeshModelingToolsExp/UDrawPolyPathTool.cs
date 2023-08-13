namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolyPathTool.h")]
public partial class UDrawPolyPathTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Property set for type of output object (StaticMesh, Volume, etc)</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>TransformProps</summary>
	public UDrawPolyPathProperties TransformProps;
	///<summary>ExtrudeProperties</summary>
	public UDrawPolyPathExtrudeProperties ExtrudeProperties;
	///<summary>MaterialProperties</summary>
	public UNewMeshMaterialProperties MaterialProperties;
	///<summary>drawing plane and gizmo</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
	///<summary>EditPreview</summary>
	public UPolyEditPreviewMesh EditPreview;
	///<summary>ExtrudeHeightMechanic</summary>
	public UPlaneDistanceFromHitMechanic ExtrudeHeightMechanic;
	///<summary>CurveDistMechanic</summary>
	public USpatialCurveDistanceMechanic CurveDistMechanic;
	///<summary>SurfacePathMechanic</summary>
	public UCollectSurfacePathMechanic SurfacePathMechanic;
}
