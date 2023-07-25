#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraActor.h")]
///<summary>A CineCameraActor is a CameraActor specialized to work like a cinematic camera.</summary>
public partial class ACineCameraActor : ACameraActor {
// CineCameraActor
	public FCameraLookatTrackingSettings LookatTrackingSettings;
	public UObject GetCineCameraComponent() { return default; }
}
