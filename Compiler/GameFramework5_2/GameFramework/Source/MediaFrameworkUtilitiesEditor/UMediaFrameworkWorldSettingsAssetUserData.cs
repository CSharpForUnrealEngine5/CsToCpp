#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaFrameworkWorldSettingsAssetUserData.h")]
///<summary>UMediaFrameworkCaptureCameraViewportAssetUserData</summary>
public partial class UMediaFrameworkWorldSettingsAssetUserData : UAssetUserData {
// MediaFrameworkWorldSettingsAssetUserData
	public TArray<FMediaFrameworkCaptureRenderTargetCameraOutputInfo> RenderTargetCaptures;
	public TArray<FMediaFrameworkCaptureCameraViewportCameraOutputInfo> ViewportCaptures;
	public FMediaFrameworkCaptureCurrentViewportOutputInfo CurrentViewportMediaOutput;
}
