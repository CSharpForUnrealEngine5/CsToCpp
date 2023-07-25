#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions associated with most recent GoogleARCore tracking frame.</summary>
public partial class UGoogleARCoreFrameFunctionLibrary : UBlueprintFunctionLibrary {
// GoogleARCoreFrameFunctionLibrary
	public EGoogleARCoreTrackingState GetTrackingState() { return default; }
	public EGoogleARCoreTrackingFailureReason GetTrackingFailureReason() { return default; }
	public void GetPose(FTransform OutPose) {}
	public bool ARCoreLineTrace(UObject WorldContextObject,FVector2D ScreenPosition,TSet<EGoogleARCoreLineTraceChannel> TraceChannels,TArray<FARTraceResult> OutHitResults) { return default; }
	public bool ARCoreLineTraceRay(UObject WorldContextObject,FVector Start,FVector End,TSet<EGoogleARCoreLineTraceChannel> TraceChannels,TArray<FARTraceResult> OutHitResults) { return default; }
	public void GetUpdatedARPins(TArray<UObject> OutAnchorList) {}
	public void GetUpdatedPlanes(TArray<UObject> OutPlaneList) {}
	public void GetUpdatedTrackablePoints(TArray<UObject> OutTrackablePointList) {}
	public void GetUpdatedAugmentedImages(TArray<UObject> OutImageList) {}
	public void GetUpdatedAugmentedFaces(TArray<UObject> OutFaceList) {}
	public void GetLightEstimation(FGoogleARCoreLightEstimate OutLightEstimate) {}
	public EGoogleARCoreFunctionStatus GetPointCloud(UObject OutLatestPointCloud) { return default; }
	public EGoogleARCoreFunctionStatus AcquirePointCloud(UObject OutLatestPointCloud) { return default; }
	public UObject GetCameraTexture() { return default; }
	public EGoogleARCoreFunctionStatus AcquireCameraImage(UObject OutLatestCameraImage) { return default; }
	public void TransformARCoordinates2D(EGoogleARCoreCoordinates2DType InputCoordinatesType,TArray<FVector2D> InputCoordinates,EGoogleARCoreCoordinates2DType OutputCoordinatesType,TArray<FVector2D> OutputCoordinates) {}
	public EGoogleARCoreFunctionStatus GetCameraImageIntrinsics(UObject OutCameraIntrinsics) { return default; }
	public EGoogleARCoreFunctionStatus GetCameraTextureIntrinsics(UObject OutCameraIntrinsics) { return default; }
}
