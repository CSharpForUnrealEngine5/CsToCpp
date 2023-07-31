#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A function library that provides static/Blueprint functions associated with most recent GoogleARCore tracking frame.</summary>
[CppInclude("GoogleARCoreFunctionLibrary.h")]
public partial class UGoogleARCoreFrameFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>GetTrackingState</summary>
	public static EGoogleARCoreTrackingState GetTrackingState() { return default; }
	///<summary>GetTrackingFailureReason</summary>
	public static EGoogleARCoreTrackingFailureReason GetTrackingFailureReason() { return default; }
	///<summary>GetPose</summary>
	public static void GetPose(FTransform OutPose) {}
	///<summary>ARCoreLineTrace</summary>
	public static bool ARCoreLineTrace(UObject WorldContextObject,FVector2D ScreenPosition,TSet<EGoogleARCoreLineTraceChannel> TraceChannels,TArray<FARTraceResult> OutHitResults) { return default; }
	///<summary>ARCoreLineTraceRay</summary>
	public static bool ARCoreLineTraceRay(UObject WorldContextObject,FVector Start,FVector End,TSet<EGoogleARCoreLineTraceChannel> TraceChannels,TArray<FARTraceResult> OutHitResults) { return default; }
	///<summary>GetUpdatedARPins</summary>
	public static void GetUpdatedARPins(TArray<UARPin> OutAnchorList) {}
	///<summary>GetUpdatedPlanes</summary>
	public static void GetUpdatedPlanes(TArray<UARPlaneGeometry> OutPlaneList) {}
	///<summary>GetUpdatedTrackablePoints</summary>
	public static void GetUpdatedTrackablePoints(TArray<UARTrackedPoint> OutTrackablePointList) {}
	///<summary>GetUpdatedAugmentedImages</summary>
	public static void GetUpdatedAugmentedImages(TArray<UGoogleARCoreAugmentedImage> OutImageList) {}
	///<summary>GetUpdatedAugmentedFaces</summary>
	public static void GetUpdatedAugmentedFaces(TArray<UGoogleARCoreAugmentedFace> OutFaceList) {}
	///<summary>GetLightEstimation</summary>
	public static void GetLightEstimation(FGoogleARCoreLightEstimate OutLightEstimate) {}
	///<summary>GetPointCloud</summary>
	public static EGoogleARCoreFunctionStatus GetPointCloud(UGoogleARCorePointCloud OutLatestPointCloud) { return default; }
	///<summary>AcquirePointCloud</summary>
	public static EGoogleARCoreFunctionStatus AcquirePointCloud(UGoogleARCorePointCloud OutLatestPointCloud) { return default; }
	///<summary>GetCameraTexture</summary>
	public static UTexture GetCameraTexture() { return default; }
	///<summary>AcquireCameraImage</summary>
	public static EGoogleARCoreFunctionStatus AcquireCameraImage(UGoogleARCoreCameraImage OutLatestCameraImage) { return default; }
	///<summary>TransformARCoordinates2D</summary>
	public static void TransformARCoordinates2D(EGoogleARCoreCoordinates2DType InputCoordinatesType,TArray<FVector2D> InputCoordinates,EGoogleARCoreCoordinates2DType OutputCoordinatesType,TArray<FVector2D> OutputCoordinates) {}
	///<summary>GetCameraImageIntrinsics</summary>
	public static EGoogleARCoreFunctionStatus GetCameraImageIntrinsics(UGoogleARCoreCameraIntrinsics OutCameraIntrinsics) { return default; }
	///<summary>GetCameraTextureIntrinsics</summary>
	public static EGoogleARCoreFunctionStatus GetCameraTextureIntrinsics(UGoogleARCoreCameraIntrinsics OutCameraIntrinsics) { return default; }
}
