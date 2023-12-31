namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings to control the camera&#39;s lookat feature</summary>
[CppInclude("CineCameraActor.h")]
public partial struct FCameraLookatTrackingSettings {
	public bool bEnableLookAtTracking;
	public bool bDrawDebugLookAtTrackingPosition;
	public float LookAtTrackingInterpSpeed;
	public TSoftObjectPtr<AActor> ActorToTrack;
	public FVector RelativeOffset;
	public bool bAllowRoll;
}
