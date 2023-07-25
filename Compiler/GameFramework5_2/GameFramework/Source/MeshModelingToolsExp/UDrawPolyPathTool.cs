#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolyPathTool.h")]
public partial class UDrawPolyPathTool : UInteractiveTool {
// DrawPolyPathTool
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public UDrawPolyPathProperties TransformProps;
	public UDrawPolyPathExtrudeProperties ExtrudeProperties;
	public UNewMeshMaterialProperties MaterialProperties;
	public UConstructionPlaneMechanic PlaneMechanic;
	public UPolyEditPreviewMesh EditPreview;
	public UPlaneDistanceFromHitMechanic ExtrudeHeightMechanic;
	public USpatialCurveDistanceMechanic CurveDistMechanic;
	public UCollectSurfacePathMechanic SurfacePathMechanic;
}
