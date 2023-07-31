#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Camera configuration from ARCore.</summary>
[CppInclude("GoogleARCoreTypes.h")]
public partial struct FGoogleARCoreCameraConfig {
	public FIntPoint CameraImageResolution;
	public FIntPoint CameraTextureResolution;
	public string CameraID;
	public int TargetFPS;
	public int DepthSensorUsage;
}
