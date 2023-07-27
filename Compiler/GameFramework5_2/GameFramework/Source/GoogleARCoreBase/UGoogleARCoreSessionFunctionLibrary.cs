#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions associated with GoogleARCore session.</summary>
public partial class UGoogleARCoreSessionFunctionLibrary : UBlueprintFunctionLibrary {
// GoogleARCoreSessionFunctionLibrary
	public static void CheckARCoreAvailability(UObject WorldContextObject,FLatentActionInfo LatentInfo,EGoogleARCoreAvailability OutAvailability) {}
	public static void InstallARCoreService(UObject WorldContextObject,FLatentActionInfo LatentInfo,EGoogleARCoreInstallRequestResult OutInstallResult) {}
	public static UGoogleARCoreEventManager GetARCoreEventManager() { return default; }
	public static void StartARCoreSession(UObject WorldContextObject,FLatentActionInfo LatentInfo,UGoogleARCoreSessionConfig Configuration) {}
	public static bool SetARCoreCameraConfig(FGoogleARCoreCameraConfig TargetCameraConfig) { return default; }
	public static bool GetARCoreCameraConfig(FGoogleARCoreCameraConfig OutCurrentCameraConfig) { return default; }
	public static bool IsPassthroughCameraRenderingEnabled() { return default; }
	public static void SetPassthroughCameraRenderingEnabled(bool bEnable) {}
	public static void GetPassthroughCameraImageUV(TArray<float> InUV,TArray<float> OutUV) {}
	public static void GetAllPlanes(TArray<UARPlaneGeometry> OutPlaneList) {}
	public static void GetAllTrackablePoints(TArray<UARTrackedPoint> OutTrackablePointList) {}
	public static void GetAllAugmentedImages(TArray<UGoogleARCoreAugmentedImage> OutAugmentedImageList) {}
	public static void GetAllAugmentedFaces(TArray<UGoogleARCoreAugmentedFace> OutAugmentedFaceList) {}
	public static UARCandidateImage AddRuntimeCandidateImageFromRawbytes(UARSessionConfig SessionConfig,TArray<byte> ImageGrayscalePixels,int ImageWidth,int ImageHeight,string FriendlyName,float PhysicalWidth,UTexture2D CandidateTexture/*=nullptr*/) { return default; }
}
