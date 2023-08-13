namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertPresenceEvents.h")]
public partial struct FConcertClientVRPresenceUpdateEvent {
	public FVector LeftMotionControllerPosition;
	public FQuat LeftMotionControllerOrientation;
	public FVector RightMotionControllerPosition;
	public FQuat RightMotionControllerOrientation;
	public FConcertLaserData Lasers;
}
