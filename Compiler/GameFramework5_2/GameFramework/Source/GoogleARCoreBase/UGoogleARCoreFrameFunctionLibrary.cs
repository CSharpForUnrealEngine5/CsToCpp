#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions associated with most recent GoogleARCore tracking frame.</summary>
public partial class UGoogleARCoreFrameFunctionLibrary : UBlueprintFunctionLibrary {
// GoogleARCoreFrameFunctionLibrary
	public static EGoogleARCoreTrackingState GetTrackingState() { return default; }
	public static EGoogleARCoreTrackingFailureReason GetTrackingFailureReason() { return default; }
	public static void GetPose(FTransform OutPose) {}
	public static bool ARCoreLineTrace(UObject WorldContextObject,FVector2D ScreenPosition,TSet<EGoogleARCoreLineTraceChannel> TraceChannels,TArray<FARTraceResult> OutHitResults) { return default; }
	public static bool ARCoreLineTraceRay(UObject WorldContextObject,FVector Start,FVector End,TSet<EGoogleARCoreLineTraceChannel> TraceChannels,TArray<FARTraceResult> OutHitResults) { return default; }
	public static void GetUpdatedARPins(TArray<UARPin> OutAnchorList) {}
	public static void GetUpdatedPlanes(TArray<UARPlaneGeometry> OutPlaneList) {}
	public static void GetUpdatedTrackablePoints(TArray<UARTrackedPoint> OutTrackablePointList) {}
	public static void GetUpdatedAugmentedImages(TArray<UGoogleARCoreAugmentedImage> OutImageList) {}
	public static void GetUpdatedAugmentedFaces(TArray<UGoogleARCoreAugmentedFace> OutFaceList) {}
	public static void GetLightEstimation(FGoogleARCoreLightEstimate OutLightEstimate) {}
	public static EGoogleARCoreFunctionStatus GetPointCloud(UGoogleARCorePointCloud OutLatestPointCloud) { return default; }
	public static EGoogleARCoreFunctionStatus AcquirePointCloud(UGoogleARCorePointCloud OutLatestPointCloud) { return default; }
	public static UTexture GetCameraTexture() { return default; }
	public static EGoogleARCoreFunctionStatus AcquireCameraImage(UGoogleARCoreCameraImage OutLatestCameraImage) { return default; }
	public static void TransformARCoordinates2D(EGoogleARCoreCoordinates2DType InputCoordinatesType,TArray<FVector2D> InputCoordinates,EGoogleARCoreCoordinates2DType OutputCoordinatesType,TArray<FVector2D> OutputCoordinates) {}
	public static EGoogleARCoreFunctionStatus GetCameraImageIntrinsics(UGoogleARCoreCameraIntrinsics OutCameraIntrinsics) { return default; }
	public static EGoogleARCoreFunctionStatus GetCameraTextureIntrinsics(UGoogleARCoreCameraIntrinsics OutCameraIntrinsics) { return default; }
}
