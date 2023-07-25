#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertPresenceEvents.h")]
public partial struct FConcertClientVRPresenceUpdateEvent {
// ConcertClientVRPresenceUpdateEvent
	public FVector LeftMotionControllerPosition;
	public FQuat LeftMotionControllerOrientation;
	public FVector RightMotionControllerPosition;
	public FQuat RightMotionControllerOrientation;
	public FConcertLaserData Lasers;
}
