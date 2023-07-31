#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings to control tracking-focus mode.</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FCameraTrackingFocusSettings {
	public TSoftObjectPtr<AActor> ActorToTrack;
	public FVector RelativeOffset;
	public bool bDrawDebugTrackingFocusPoint;
}
