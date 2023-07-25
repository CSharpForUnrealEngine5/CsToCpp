#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreTypes.h")]
///<summary>Camera configuration from ARCore.</summary>
public partial struct FGoogleARCoreCameraConfig {
// GoogleARCoreCameraConfig
	public FIntPoint CameraImageResolution;
	public FIntPoint CameraTextureResolution;
	public string CameraID;
	public int TargetFPS;
	public int DepthSensorUsage;
}
