#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions associated with GoogleARCore session.</summary>
public partial class UGoogleARCoreSessionFunctionLibrary : UBlueprintFunctionLibrary {
// GoogleARCoreSessionFunctionLibrary
	public void CheckARCoreAvailability(UObject WorldContextObject,FLatentActionInfo LatentInfo,EGoogleARCoreAvailability OutAvailability) {}
	public void InstallARCoreService(UObject WorldContextObject,FLatentActionInfo LatentInfo,EGoogleARCoreInstallRequestResult OutInstallResult) {}
	public UObject GetARCoreEventManager() { return default; }
	public void StartARCoreSession(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject Configuration) {}
	public bool SetARCoreCameraConfig(FGoogleARCoreCameraConfig TargetCameraConfig) { return default; }
	public bool GetARCoreCameraConfig(FGoogleARCoreCameraConfig OutCurrentCameraConfig) { return default; }
	public bool IsPassthroughCameraRenderingEnabled() { return default; }
	public void SetPassthroughCameraRenderingEnabled(bool bEnable) {}
	public void GetPassthroughCameraImageUV(TArray<float> InUV,TArray<float> OutUV) {}
	public void GetAllPlanes(TArray<UObject> OutPlaneList) {}
	public void GetAllTrackablePoints(TArray<UObject> OutTrackablePointList) {}
	public void GetAllAugmentedImages(TArray<UObject> OutAugmentedImageList) {}
	public void GetAllAugmentedFaces(TArray<UObject> OutAugmentedFaceList) {}
	public UObject AddRuntimeCandidateImageFromRawbytes(UObject SessionConfig,TArray<byte> ImageGrayscalePixels,int ImageWidth,int ImageHeight,string FriendlyName,float PhysicalWidth,UObject CandidateTexture/*=nullptr*/) { return default; }
}
