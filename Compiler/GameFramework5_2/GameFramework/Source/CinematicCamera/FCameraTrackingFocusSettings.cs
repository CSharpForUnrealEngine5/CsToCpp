namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings to control tracking-focus mode.</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FCameraTrackingFocusSettings {
	public TSoftObjectPtr<AActor> ActorToTrack;
	public FVector RelativeOffset;
	public bool bDrawDebugTrackingFocusPoint;
}
