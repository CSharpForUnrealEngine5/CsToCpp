#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertClientDesktopPresenceActor.h")]
///<summary>A AConcertClientDesktopPresenceActor is a child of AConcertClientPresenceActor that is used to represent users in desktop</summary>
public partial class AConcertClientDesktopPresenceActor : AConcertClientPresenceActor {
// ConcertClientDesktopPresenceActor
	public UStaticMeshComponent DesktopMeshComponent;
	public USplineMeshComponent LaserPointer;
	public UMaterialInstanceDynamic LaserMid;
	public UMaterialInstanceDynamic LaserCoreMid;
	public bool bMovingCamera;
	public FVector LastEndPoint;
	public bool bIsLaserVisible;
}
