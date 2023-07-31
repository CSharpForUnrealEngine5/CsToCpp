#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FMediaFrameworkCaptureCameraViewportCameraOutputInfo</summary>
[CppInclude("MediaFrameworkWorldSettingsAssetUserData.h")]
public partial struct FMediaFrameworkCaptureCameraViewportCameraOutputInfo {
	public TArray<TLazyObjectPtr<AActor>> LockedActors;
	public UMediaOutput MediaOutput;
	public FMediaCaptureOptions CaptureOptions;
	public EViewModeIndex ViewMode;
	public TArray<AActor> LockedCameraActors_DEPRECATED;
}
