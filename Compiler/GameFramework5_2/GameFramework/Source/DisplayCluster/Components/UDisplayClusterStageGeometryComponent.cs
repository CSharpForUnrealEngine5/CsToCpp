#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DisplayClusterStageGeometryComponent.h")]
///<summary>A component that stores the generated geometry map of the stage actor, which is used for placing stage actors (light cards, CCWs, etc) flush to the stage's walls and ceiling</summary>
public partial class UDisplayClusterStageGeometryComponent : UActorComponent {
// DisplayClusterStageGeometryComponent
	public void Invalidate(bool bForceImmediateRedraw/*=false*/) {}
	public bool GetStageDistanceAndNormal(FVector InDirection,float OutDistance,FVector OutNormal) { return default; }
	public float GetStageBoundingRadius() { return default; }
	public FDisplayClusterStageGeometryMap NorthGeometryMap;
	public FDisplayClusterStageGeometryMap SouthGeometryMap;
	public float StageBoundingRadius;
}
