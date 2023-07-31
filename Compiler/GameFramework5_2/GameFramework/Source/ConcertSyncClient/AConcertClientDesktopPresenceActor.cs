#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A AConcertClientDesktopPresenceActor is a child of AConcertClientPresenceActor that is used to represent users in desktop</summary>
[CppInclude("ConcertClientDesktopPresenceActor.h")]
public partial class AConcertClientDesktopPresenceActor : AConcertClientPresenceActor {
	///<summary>The camera mesh component to show visually where the camera is placed</summary>
	public UStaticMeshComponent DesktopMeshComponent;
	///<summary>Spline mesh representing laser</summary>
	public USplineMeshComponent LaserPointer;
	///<summary>Dynamic material for the laser</summary>
	public UMaterialInstanceDynamic LaserMid;
	///<summary>Dynamic material for the laser</summary>
	public UMaterialInstanceDynamic LaserCoreMid;
	///<summary>bMovingCamera</summary>
	public bool bMovingCamera;
	///<summary>LastEndPoint</summary>
	public FVector LastEndPoint;
	///<summary>bIsLaserVisible</summary>
	public bool bIsLaserVisible;
}
