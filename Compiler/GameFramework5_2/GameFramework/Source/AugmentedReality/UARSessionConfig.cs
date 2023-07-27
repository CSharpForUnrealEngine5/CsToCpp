#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSessionConfig.h")]
///<summary>An Unreal Data Asset that defines what features are used in the AR session.</summary>
public partial class UARSessionConfig : UDataAsset {
// ARSessionConfig
	public  EARWorldAlignment GetWorldAlignment() { return default; }
	public  EARSessionType GetSessionType() { return default; }
	public  EARPlaneDetectionMode GetPlaneDetectionMode() { return default; }
	public  EARLightEstimationMode GetLightEstimationMode() { return default; }
	public  EARFrameSyncMode GetFrameSyncMode() { return default; }
	public  bool ShouldRenderCameraOverlay() { return default; }
	public  bool ShouldEnableCameraTracking() { return default; }
	public  bool ShouldEnableAutoFocus() { return default; }
	public  void SetEnableAutoFocus(bool bNewValue) {}
	public  bool ShouldResetCameraTracking() { return default; }
	public  void SetResetCameraTracking(bool bNewValue) {}
	public  bool ShouldResetTrackedObjects() { return default; }
	public  void SetResetTrackedObjects(bool bNewValue) {}
	public  TArray<UARCandidateImage> GetCandidateImageList() { return default; }
	public  void AddCandidateImage(UARCandidateImage NewCandidateImage) {}
	public  int GetMaxNumSimultaneousImagesTracked() { return default; }
	public  EAREnvironmentCaptureProbeType GetEnvironmentCaptureProbeType() { return default; }
	public  TArray<byte> GetWorldMapData() { return default; }
	public  void SetWorldMapData(TArray<byte> WorldMapData) {}
	public  TArray<UARCandidateObject> GetCandidateObjectList() { return default; }
	public  void SetCandidateObjectList(TArray<UARCandidateObject> InCandidateObjects) {}
	public  void AddCandidateObject(UARCandidateObject CandidateObject) {}
	public  FARVideoFormat GetDesiredVideoFormat() { return default; }
	public  void SetDesiredVideoFormat(FARVideoFormat NewFormat) {}
	public  EARFaceTrackingDirection GetFaceTrackingDirection() { return default; }
	public  void SetFaceTrackingDirection(EARFaceTrackingDirection InDirection) {}
	public  EARFaceTrackingUpdate GetFaceTrackingUpdate() { return default; }
	public  void SetFaceTrackingUpdate(EARFaceTrackingUpdate InUpdate) {}
	public  EARSessionTrackingFeature GetEnabledSessionTrackingFeature() { return default; }
	public  EARSceneReconstruction GetSceneReconstructionMethod() { return default; }
	public  void SetSessionTrackingFeatureToEnable(EARSessionTrackingFeature InSessionTrackingFeature) {}
	public  void SetSceneReconstructionMethod(EARSceneReconstruction InSceneReconstructionMethod) {}
	public bool bGenerateMeshDataFromTrackedGeometry;
	public bool bGenerateCollisionForMeshData;
	public bool bGenerateNavMeshForMeshData;
	public bool bUseMeshDataForOcclusion;
	public bool bRenderMeshDataInWireframe;
	public bool bTrackSceneObjects;
	public bool bUsePersonSegmentationForOcclusion;
	public bool bUseSceneDepthForOcclusion;
	public bool bUseAutomaticImageScaleEstimation;
	public bool bUseStandardOnboardingUX;
	public EARWorldAlignment WorldAlignment;
	public EARSessionType SessionType;
	public EARPlaneDetectionMode PlaneDetectionMode_DEPRECATED;
	public bool bHorizontalPlaneDetection;
	public bool bVerticalPlaneDetection;
	public bool bEnableAutoFocus;
	public EARLightEstimationMode LightEstimationMode;
	public EARFrameSyncMode FrameSyncMode;
	public bool bEnableAutomaticCameraOverlay;
	public bool bEnableAutomaticCameraTracking;
	public bool bResetCameraTracking;
	public bool bResetTrackedObjects;
	public TArray<UARCandidateImage> CandidateImages;
	public int MaxNumSimultaneousImagesTracked;
	public EAREnvironmentCaptureProbeType EnvironmentCaptureProbeType;
	public TArray<byte> WorldMapData;
	public TArray<UARCandidateObject> CandidateObjects;
	public FARVideoFormat DesiredVideoFormat;
	public bool bUseOptimalVideoFormat;
	public EARFaceTrackingDirection FaceTrackingDirection;
	public EARFaceTrackingUpdate FaceTrackingUpdate;
	public int MaxNumberOfTrackedFaces;
	public TArray<byte> SerializedARCandidateImageDatabase;
	public EARSessionTrackingFeature EnabledSessionTrackingFeature;
	public EARSceneReconstruction SceneReconstructionMethod;
	public UClass PlaneComponentClass;
	public UClass PointComponentClass;
	public UClass FaceComponentClass;
	public UClass ImageComponentClass;
	public UClass QRCodeComponentClass;
	public UClass PoseComponentClass;
	public UClass EnvironmentProbeComponentClass;
	public UClass ObjectComponentClass;
	public UClass MeshComponentClass;
	public UClass GeoAnchorComponentClass;
	public UMaterialInterface DefaultMeshMaterial;
	public UMaterialInterface DefaultWireframeMeshMaterial;
}
