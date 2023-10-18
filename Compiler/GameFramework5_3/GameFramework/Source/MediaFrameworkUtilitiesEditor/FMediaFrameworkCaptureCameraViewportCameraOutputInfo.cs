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
