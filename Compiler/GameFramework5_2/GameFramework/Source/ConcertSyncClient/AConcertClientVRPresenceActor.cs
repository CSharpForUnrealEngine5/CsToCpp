#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertClientVRPresenceActor.h")]
///<summary>A ConcertClientVRPresenceActor is a child of AConcertClientPresenceActor that is used to represent users in VR</summary>
public partial class AConcertClientVRPresenceActor : AConcertClientPresenceActor {
// ConcertClientVRPresenceActor
	public UStaticMeshComponent LeftControllerMeshComponent;
	public UStaticMeshComponent RightControllerMeshComponent;
	public UMaterialInstanceDynamic LaserMid;
	public UMaterialInstanceDynamic LaserCoreMid;
	public float LaserThickness;
	public USplineComponent LeftLaserSplineComponent;
	public TArray<USplineMeshComponent> LeftLaserSplineMeshComponents;
	public USplineComponent RightLaserSplineComponent;
	public TArray<USplineMeshComponent> RightLaserSplineMeshComponents;
	public bool bIsLeftControllerVisible;
	public bool bIsRightControllerVisible;
	public bool bIsLeftLaserVisible;
	public bool bIsRightLaserVisible;
}
