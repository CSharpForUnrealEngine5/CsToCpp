#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A CineCameraActor is a CameraActor specialized to work like a cinematic camera.</summary>
[CppInclude("CineCameraActor.h")]
public partial class ACineCameraActor : ACameraActor {
	public static UClass StaticClass() {return default;}
	///<summary>LookatTrackingSettings</summary>
	public FCameraLookatTrackingSettings LookatTrackingSettings;
	///<summary>Returns the CineCameraComponent of this CineCamera</summary>
	public  UCineCameraComponent GetCineCameraComponent() { return default; }
}
