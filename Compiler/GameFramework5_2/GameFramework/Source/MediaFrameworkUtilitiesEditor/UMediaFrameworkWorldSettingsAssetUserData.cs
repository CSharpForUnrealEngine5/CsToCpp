#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMediaFrameworkCaptureCameraViewportAssetUserData</summary>
[CppInclude("MediaFrameworkWorldSettingsAssetUserData.h")]
public partial class UMediaFrameworkWorldSettingsAssetUserData : UAssetUserData {
	///<summary>RenderTargetCaptures</summary>
	public TArray<FMediaFrameworkCaptureRenderTargetCameraOutputInfo> RenderTargetCaptures;
	///<summary>ViewportCaptures</summary>
	public TArray<FMediaFrameworkCaptureCameraViewportCameraOutputInfo> ViewportCaptures;
	///<summary>Capture the current viewport. It may be the level editor active viewport or a PIE instance launch with &quot;New Editor Window PIE&quot;.</summary>
	public FMediaFrameworkCaptureCurrentViewportOutputInfo CurrentViewportMediaOutput;
}
