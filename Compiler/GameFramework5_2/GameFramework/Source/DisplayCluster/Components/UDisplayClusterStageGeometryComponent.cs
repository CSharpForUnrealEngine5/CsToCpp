#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that stores the generated geometry map of the stage actor, which is used for placing stage actors (light cards, CCWs, etc) flush to the stage&#39;s walls and ceiling</summary>
[CppInclude("Components/DisplayClusterStageGeometryComponent.h")]
public partial class UDisplayClusterStageGeometryComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Invalidates and regenerates the cached stage geometry map</summary>
	public  void Invalidate(bool bForceImmediateRedraw/*=false*/) {}
	///<summary>Gets the distance and normal vector (in radial space) of the stage&#39;s geometry in the specified world direction</summary>
	public  bool GetStageDistanceAndNormal(FVector InDirection,float OutDistance,FVector OutNormal) { return default; }
	///<summary>Gets the bounding radius of the stage&#39;s geometry</summary>
	public  float GetStageBoundingRadius() { return default; }
	///<summary>The cached geometry map for the stage&#39;s northern hemisphere</summary>
	public FDisplayClusterStageGeometryMap NorthGeometryMap;
	///<summary>The cached geometry map for the stage&#39;s southern hemisphere</summary>
	public FDisplayClusterStageGeometryMap SouthGeometryMap;
	///<summary>The cached bounding radius of the stage&#39;s geometry</summary>
	public float StageBoundingRadius;
}
