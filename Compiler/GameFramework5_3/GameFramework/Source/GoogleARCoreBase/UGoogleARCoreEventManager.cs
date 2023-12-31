namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manager for ARCore delegates.</summary>
[CppInclude("GoogleARCoreTypes.h")]
public partial class UGoogleARCoreEventManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>@cond EXCLUDE_FROM_DOXYGEN</summary>
	public void FGoogleARCoreOnConfigCameraDynamicDelegate(TArray<FGoogleARCoreCameraConfig> SupportedCameraConfig) {}
	///<summary>A dynamic delegate can be assigned through blueprint. Will be called before ARSession started and returns</summary>
	public FGoogleARCoreOnConfigCameraDynamicDelegate OnConfigCamera;
}
