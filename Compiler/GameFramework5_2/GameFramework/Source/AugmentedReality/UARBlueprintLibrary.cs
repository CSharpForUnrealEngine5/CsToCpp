#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARBlueprintLibrary.h")]
public partial class UARBlueprintLibrary : UBlueprintFunctionLibrary {
// ARBlueprintLibrary
	public static bool IsARSupported() { return default; }
	public static void StartARSession(UARSessionConfig SessionConfig) {}
	public static void PauseARSession() {}
	public static void StopARSession() {}
	public static FARSessionStatus GetARSessionStatus() { return default; }
	public static UARSessionConfig GetSessionConfig() { return default; }
	public static bool ToggleARCapture(bool bOnOff,EARCaptureType CaptureType) { return default; }
	public static void SetEnabledXRCamera(bool bOnOff) {}
	public static FIntPoint ResizeXRCamera(FIntPoint InSize) { return default; }
	public static void SetAlignmentTransform(FTransform InAlignmentTransform) {}
	public static TArray<FARTraceResult> LineTraceTrackedObjects(FVector2D ScreenCoord,bool bTestFeaturePoints/*=true*/,bool bTestGroundPlane/*=true*/,bool bTestPlaneExtents/*=true*/,bool bTestPlaneBoundaryPolygon/*=true*/) { return default; }
	public static TArray<FARTraceResult> LineTraceTrackedObjects3D(FVector Start,FVector End,bool bTestFeaturePoints/*=true*/,bool bTestGroundPlane/*=true*/,bool bTestPlaneExtents/*=true*/,bool bTestPlaneBoundaryPolygon/*=true*/) { return default; }
	public static EARTrackingQuality GetTrackingQuality() { return default; }
	public static EARTrackingQualityReason GetTrackingQualityReason() { return default; }
	public static TArray<UARTrackedGeometry> GetAllGeometries() { return default; }
	public static TArray<UARTrackedGeometry> GetAllGeometriesByClass(UClass GeometryClass) { return default; }
	public static UARTextureCameraImage GetCameraImage() { return default; }
	public static UARTextureCameraDepth GetCameraDepth() { return default; }
	public static UARTexture GetARTexture(EARTextureType TextureType) { return default; }
	public static bool IsSessionTypeSupported(EARSessionType SessionType) { return default; }
	public static void DebugDrawTrackedGeometry(UARTrackedGeometry TrackedGeometry,UObject WorldContextObject,FLinearColor Color/*=new FLinearColor(1.0f,1.0f,0.0f,0.75f)*/,float OutlineThickness/*=5.0f*/,float PersistForSeconds/*=0.0f*/) {}
	public static void DebugDrawPin(UARPin ARPin,UObject WorldContextObject,FLinearColor Color/*=new FLinearColor(1.0f,1.0f,0.0f,0.75f)*/,float Scale/*=5.0f*/,float PersistForSeconds/*=0.0f*/) {}
	public static UARLightEstimate GetCurrentLightEstimate() { return default; }
	public static UARPin PinComponent(USceneComponent ComponentToPin,FTransform PinToWorldTransform,UARTrackedGeometry TrackedGeometry/*=nullptr*/,string DebugName/*=NAME_None*/) { return default; }
	public static UARPin PinComponentToTraceResult(USceneComponent ComponentToPin,FARTraceResult TraceResult,string DebugName/*=NAME_None*/) { return default; }
	public static bool PinComponentToARPin(USceneComponent ComponentToPin,UARPin Pin) { return default; }
	public static void UnpinComponent(USceneComponent ComponentToUnpin) {}
	public static void RemovePin(UARPin PinToRemove) {}
	public static TArray<UARPin> GetAllPins() { return default; }
	public static bool IsARPinLocalStoreSupported() { return default; }
	public static bool IsARPinLocalStoreReady() { return default; }
	public static TMap<string,UARPin> LoadARPinsFromLocalStore() { return default; }
	public static bool SaveARPinToLocalStore(string InSaveName,UARPin InPin) { return default; }
	public static void RemoveARPinFromLocalStore(string InSaveName) {}
	public static void RemoveAllARPinsFromLocalStore() {}
	public static TArray<UARPlaneGeometry> GetAllTrackedPlanes() { return default; }
	public static TArray<UARTrackedPoint> GetAllTrackedPoints() { return default; }
	public static TArray<UARTrackedImage> GetAllTrackedImages() { return default; }
	public static TArray<UAREnvironmentCaptureProbe> GetAllTrackedEnvironmentCaptureProbes() { return default; }
	public static bool AddManualEnvironmentCaptureProbe(FVector Location,FVector Extent) { return default; }
	public static EARWorldMappingState GetWorldMappingStatus() { return default; }
	public static TArray<FVector> GetPointCloud() { return default; }
	public static TArray<FARVideoFormat> GetSupportedVideoFormats(EARSessionType SessionType) { return default; }
	public static UARCandidateImage AddRuntimeCandidateImage(UARSessionConfig SessionConfig,UTexture2D CandidateTexture,string FriendlyName,float PhysicalWidth) { return default; }
	public static bool IsSessionTrackingFeatureSupported(EARSessionType SessionType,EARSessionTrackingFeature SessionTrackingFeature) { return default; }
	public static bool IsSceneReconstructionSupported(EARSessionType SessionType,EARSceneReconstruction SceneReconstructionMethod) { return default; }
	public static TArray<FARPose2D> GetAllTracked2DPoses() { return default; }
	public static TArray<UARTrackedPose> GetAllTrackedPoses() { return default; }
	public static UARTexture GetPersonSegmentationImage() { return default; }
	public static UARTexture GetPersonSegmentationDepthImage() { return default; }
	public static bool GetObjectClassificationAtLocation(FVector InWorldLocation,EARObjectClassification OutClassification,FVector OutClassificationLocation,float MaxLocationDiff/*=10.0f*/) { return default; }
	public static void SetARWorldOriginLocationAndRotation(FVector OriginLocation,FRotator OriginRotation,bool bIsTransformInWorldSpace/*=true*/,bool bMaintainUpDirection/*=true*/) {}
	public static void SetARWorldScale(float InWorldScale) {}
	public static float GetARWorldScale() { return default; }
	public static FTransform GetAlignmentTransform() { return default; }
	public static bool AddTrackedPointWithName(FTransform WorldTransform,string PointName,bool bDeletePointsWithSameName/*=true*/) { return default; }
	public static TArray<UARTrackedPoint> FindTrackedPointsByName(string PointName) { return default; }
	public static void CalculateClosestIntersection(TArray<FVector> StartPoints,TArray<FVector> EndPoints,FVector ClosestIntersection) {}
	public static void CalculateAlignmentTransform(FTransform TransformInFirstCoordinateSystem,FTransform TransformInSecondCoordinateSystem,FTransform AlignmentTransform) {}
	public static int GetNumberOfTrackedFacesSupported() { return default; }
	public static bool GetCameraIntrinsics(FARCameraIntrinsics OutCameraIntrinsics) { return default; }
}
