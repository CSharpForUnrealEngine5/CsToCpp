#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaFrameworkWorldSettingsAssetUserData.h")]
///<summary>FMediaFrameworkCaptureCameraViewportCameraOutputInfo</summary>
public partial struct FMediaFrameworkCaptureCameraViewportCameraOutputInfo {
// MediaFrameworkCaptureCameraViewportCameraOutputInfo
	public TArray<TLazyObjectPtr<AActor>> LockedActors;
	public UMediaOutput MediaOutput;
	public FMediaCaptureOptions CaptureOptions;
	public byte ViewMode;
	public TArray<AActor> LockedCameraActors_DEPRECATED;
}
