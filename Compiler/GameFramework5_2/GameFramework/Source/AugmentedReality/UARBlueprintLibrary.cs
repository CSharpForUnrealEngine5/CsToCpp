#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARBlueprintLibrary.h")]
public partial class UARBlueprintLibrary : UBlueprintFunctionLibrary {
// ARBlueprintLibrary
	public bool IsARSupported() { return default; }
	public void StartARSession(UObject SessionConfig) {}
	public void PauseARSession() {}
	public void StopARSession() {}
	public FARSessionStatus GetARSessionStatus() { return default; }
	public UObject GetSessionConfig() { return default; }
	public bool ToggleARCapture(bool bOnOff,EARCaptureType CaptureType) { return default; }
	public void SetEnabledXRCamera(bool bOnOff) {}
	public FIntPoint ResizeXRCamera(FIntPoint InSize) { return default; }
	public void SetAlignmentTransform(FTransform InAlignmentTransform) {}
	public TArray<FARTraceResult> LineTraceTrackedObjects(FVector2D ScreenCoord,bool bTestFeaturePoints/*=true*/,bool bTestGroundPlane/*=true*/,bool bTestPlaneExtents/*=true*/,bool bTestPlaneBoundaryPolygon/*=true*/) { return default; }
	public TArray<FARTraceResult> LineTraceTrackedObjects3D(FVector Start,FVector End,bool bTestFeaturePoints/*=true*/,bool bTestGroundPlane/*=true*/,bool bTestPlaneExtents/*=true*/,bool bTestPlaneBoundaryPolygon/*=true*/) { return default; }
	public EARTrackingQuality GetTrackingQuality() { return default; }
	public EARTrackingQualityReason GetTrackingQualityReason() { return default; }
	public TArray<UObject> GetAllGeometries() { return default; }
	public TArray<UObject> GetAllGeometriesByClass(UClass GeometryClass) { return default; }
	public UObject GetCameraImage() { return default; }
	public UObject GetCameraDepth() { return default; }
	public UObject GetARTexture(EARTextureType TextureType) { return default; }
	public bool IsSessionTypeSupported(EARSessionType SessionType) { return default; }
	public void DebugDrawTrackedGeometry(UObject TrackedGeometry,UObject WorldContextObject,FLinearColor Color/*=new FLinearColor(1.0f,1.0f,0.0f,0.75f)*/,float OutlineThickness/*=5.0f*/,float PersistForSeconds/*=0.0f*/) {}
	public void DebugDrawPin(UObject ARPin,UObject WorldContextObject,FLinearColor Color/*=new FLinearColor(1.0f,1.0f,0.0f,0.75f)*/,float Scale/*=5.0f*/,float PersistForSeconds/*=0.0f*/) {}
	public UObject GetCurrentLightEstimate() { return default; }
	public UObject PinComponent(UObject ComponentToPin,FTransform PinToWorldTransform,UObject TrackedGeometry/*=nullptr*/,string DebugName/*=NAME_None*/) { return default; }
	public UObject PinComponentToTraceResult(UObject ComponentToPin,FARTraceResult TraceResult,string DebugName/*=NAME_None*/) { return default; }
	public bool PinComponentToARPin(UObject ComponentToPin,UObject Pin) { return default; }
	public void UnpinComponent(UObject ComponentToUnpin) {}
	public void RemovePin(UObject PinToRemove) {}
	public TArray<UObject> GetAllPins() { return default; }
	public bool IsARPinLocalStoreSupported() { return default; }
	public bool IsARPinLocalStoreReady() { return default; }
	public TMap<string,UObject> LoadARPinsFromLocalStore() { return default; }
	public bool SaveARPinToLocalStore(string InSaveName,UObject InPin) { return default; }
	public void RemoveARPinFromLocalStore(string InSaveName) {}
	public void RemoveAllARPinsFromLocalStore() {}
	public TArray<UObject> GetAllTrackedPlanes() { return default; }
	public TArray<UObject> GetAllTrackedPoints() { return default; }
	public TArray<UObject> GetAllTrackedImages() { return default; }
	public TArray<UObject> GetAllTrackedEnvironmentCaptureProbes() { return default; }
	public bool AddManualEnvironmentCaptureProbe(FVector Location,FVector Extent) { return default; }
	public EARWorldMappingState GetWorldMappingStatus() { return default; }
	public TArray<FVector> GetPointCloud() { return default; }
	public TArray<FARVideoFormat> GetSupportedVideoFormats(EARSessionType SessionType) { return default; }
	public UObject AddRuntimeCandidateImage(UObject SessionConfig,UObject CandidateTexture,string FriendlyName,float PhysicalWidth) { return default; }
	public bool IsSessionTrackingFeatureSupported(EARSessionType SessionType,EARSessionTrackingFeature SessionTrackingFeature) { return default; }
	public bool IsSceneReconstructionSupported(EARSessionType SessionType,EARSceneReconstruction SceneReconstructionMethod) { return default; }
	public TArray<FARPose2D> GetAllTracked2DPoses() { return default; }
	public TArray<UObject> GetAllTrackedPoses() { return default; }
	public UObject GetPersonSegmentationImage() { return default; }
	public UObject GetPersonSegmentationDepthImage() { return default; }
	public bool GetObjectClassificationAtLocation(FVector InWorldLocation,EARObjectClassification OutClassification,FVector OutClassificationLocation,float MaxLocationDiff/*=10.0f*/) { return default; }
	public void SetARWorldOriginLocationAndRotation(FVector OriginLocation,FRotator OriginRotation,bool bIsTransformInWorldSpace/*=true*/,bool bMaintainUpDirection/*=true*/) {}
	public void SetARWorldScale(float InWorldScale) {}
	public float GetARWorldScale() { return default; }
	public FTransform GetAlignmentTransform() { return default; }
	public bool AddTrackedPointWithName(FTransform WorldTransform,string PointName,bool bDeletePointsWithSameName/*=true*/) { return default; }
	public TArray<UObject> FindTrackedPointsByName(string PointName) { return default; }
	public void CalculateClosestIntersection(TArray<FVector> StartPoints,TArray<FVector> EndPoints,FVector ClosestIntersection) {}
	public void CalculateAlignmentTransform(FTransform TransformInFirstCoordinateSystem,FTransform TransformInSecondCoordinateSystem,FTransform AlignmentTransform) {}
	public int GetNumberOfTrackedFacesSupported() { return default; }
	public bool GetCameraIntrinsics(FARCameraIntrinsics OutCameraIntrinsics) { return default; }
}
