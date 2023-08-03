#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A function library that provides static/Blueprint functions associated with GoogleARCore session.</summary>
[CppInclude("GoogleARCoreFunctionLibrary.h")]
public partial class UGoogleARCoreSessionFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>CheckARCoreAvailability</summary>
	public static void CheckARCoreAvailability(UObject WorldContextObject,FLatentActionInfo LatentInfo,EGoogleARCoreAvailability OutAvailability) {}
	///<summary>InstallARCoreService</summary>
	public static void InstallARCoreService(UObject WorldContextObject,FLatentActionInfo LatentInfo,EGoogleARCoreInstallRequestResult OutInstallResult) {}
	///<summary>GetARCoreEventManager</summary>
	public static UGoogleARCoreEventManager GetARCoreEventManager() { return default; }
	///<summary>StartARCoreSession</summary>
	public static void StartARCoreSession(UObject WorldContextObject,FLatentActionInfo LatentInfo,UGoogleARCoreSessionConfig Configuration) {}
	///<summary>SetARCoreCameraConfig</summary>
	public static bool SetARCoreCameraConfig(FGoogleARCoreCameraConfig TargetCameraConfig) { return default; }
	///<summary>GetARCoreCameraConfig</summary>
	public static bool GetARCoreCameraConfig(FGoogleARCoreCameraConfig OutCurrentCameraConfig) { return default; }
	///<summary>IsPassthroughCameraRenderingEnabled</summary>
	public static bool IsPassthroughCameraRenderingEnabled() { return default; }
	///<summary>SetPassthroughCameraRenderingEnabled</summary>
	public static void SetPassthroughCameraRenderingEnabled(bool bEnable) {}
	///<summary>GetPassthroughCameraImageUV</summary>
	public static void GetPassthroughCameraImageUV(TArray<float> InUV,TArray<float> OutUV) {}
	///<summary>GetAllPlanes</summary>
	public static void GetAllPlanes(TArray<UARPlaneGeometry> OutPlaneList) {}
	///<summary>GetAllTrackablePoints</summary>
	public static void GetAllTrackablePoints(TArray<UARTrackedPoint> OutTrackablePointList) {}
	///<summary>GetAllAugmentedImages</summary>
	public static void GetAllAugmentedImages(TArray<UGoogleARCoreAugmentedImage> OutAugmentedImageList) {}
	///<summary>GetAllAugmentedFaces</summary>
	public static void GetAllAugmentedFaces(TArray<UGoogleARCoreAugmentedFace> OutAugmentedFaceList) {}
	///<summary>Create an ARCandidateImage object from the raw pixel data and add it to the ARCandidateImageList of the given \c UARSessionConfig object.</summary>
	public static UARCandidateImage AddRuntimeCandidateImageFromRawbytes(UARSessionConfig SessionConfig,TArray<byte> ImageGrayscalePixels,int ImageWidth,int ImageHeight,string FriendlyName,float PhysicalWidth,UTexture2D CandidateTexture/*=nullptr*/) { return default; }
}
