#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraSettings.h")]
///<summary>Settings to control tracking-focus mode.</summary>
public partial struct FCameraTrackingFocusSettings {
// CameraTrackingFocusSettings
	public TSoftObjectPtr<AActor> ActorToTrack;
	public FVector RelativeOffset;
	public bool bDrawDebugTrackingFocusPoint;
}
