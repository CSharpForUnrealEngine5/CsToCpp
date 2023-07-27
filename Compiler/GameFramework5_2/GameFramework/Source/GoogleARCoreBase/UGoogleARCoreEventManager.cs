#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreTypes.h")]
///<summary>Manager for ARCore delegates.</summary>
public partial class UGoogleARCoreEventManager : UObject {
// GoogleARCoreEventManager
	public  void FGoogleARCoreOnConfigCameraDynamicDelegate(TArray<FGoogleARCoreCameraConfig> SupportedCameraConfig) {}
	public FGoogleARCoreOnConfigCameraDynamicDelegate OnConfigCamera;
}
