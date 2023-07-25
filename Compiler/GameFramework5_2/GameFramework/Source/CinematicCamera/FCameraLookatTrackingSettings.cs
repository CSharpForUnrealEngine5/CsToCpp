#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraActor.h")]
///<summary>Settings to control the camera's lookat feature</summary>
public partial struct FCameraLookatTrackingSettings {
// CameraLookatTrackingSettings
	public bool bEnableLookAtTracking;
	public bool bDrawDebugLookAtTrackingPosition;
	public float LookAtTrackingInterpSpeed;
	public TSoftObjectPtr<AActor> ActorToTrack;
	public FVector RelativeOffset;
	public bool bAllowRoll;
}
