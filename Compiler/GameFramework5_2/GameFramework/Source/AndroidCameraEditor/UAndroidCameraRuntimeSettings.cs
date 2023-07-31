#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the AndroidCamera plugin.</summary>
[CppInclude("AndroidCameraRuntimeSettings.h")]
public partial class UAndroidCameraRuntimeSettings : UObject {
	///<summary>Enable camera permission in AndroidManifest</summary>
	public bool bEnablePermission;
	///<summary>Requires a camera to operate (if true and back-facing and front-facing are false, sets android.hardware.camera.any as required)</summary>
	public bool bRequiresAnyCamera;
	///<summary>Requires back-facing camera in AndroidManifest (android.hardware.camera)</summary>
	public bool bRequiresBackFacingCamera;
	///<summary>Requires front-facing camera in AndroidManifest (android.hardware.camera.front)</summary>
	public bool bRequiresFrontFacingCamera;
}
