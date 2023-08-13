namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An Unreal Data Asset that defines what features are used in the AR session.</summary>
[CppInclude("ARSessionConfig.h")]
public partial class UARSessionConfig : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>See: EARWorldAlignment</summary>
	public EARWorldAlignment GetWorldAlignment() { return default; }
	///<summary>See: SessionType</summary>
	public EARSessionType GetSessionType() { return default; }
	///<summary>See: PlaneDetectionMode</summary>
	public EARPlaneDetectionMode GetPlaneDetectionMode() { return default; }
	///<summary>See: LightEstimationMode</summary>
	public EARLightEstimationMode GetLightEstimationMode() { return default; }
	///<summary>See: FrameSyncMode</summary>
	public EARFrameSyncMode GetFrameSyncMode() { return default; }
	///<summary>See: bEnableAutomaticCameraOverlay</summary>
	public bool ShouldRenderCameraOverlay() { return default; }
	///<summary>See: bEnableAutomaticCameraTracking</summary>
	public bool ShouldEnableCameraTracking() { return default; }
	///<summary>See: bEnableAutoFocus</summary>
	public bool ShouldEnableAutoFocus() { return default; }
	///<summary>See: bEnableAutoFocus</summary>
	public void SetEnableAutoFocus(bool bNewValue) {}
	///<summary>See: bResetCameraTracking</summary>
	public bool ShouldResetCameraTracking() { return default; }
	///<summary>See: bResetCameraTracking</summary>
	public void SetResetCameraTracking(bool bNewValue) {}
	///<summary>See: bResetTrackedObjects</summary>
	public bool ShouldResetTrackedObjects() { return default; }
	///<summary>See: bResetTrackedObjects</summary>
	public void SetResetTrackedObjects(bool bNewValue) {}
	///<summary>See: CandidateImages</summary>
	public TArray<UARCandidateImage> GetCandidateImageList() { return default; }
	///<summary>Add a new CandidateImage to the ARSessionConfig.</summary>
	public void AddCandidateImage(UARCandidateImage NewCandidateImage) {}
	///<summary>See: MaxNumSimultaneousImagesTracked</summary>
	public int GetMaxNumSimultaneousImagesTracked() { return default; }
	///<summary>See: EnvironmentCaptureProbeType</summary>
	public EAREnvironmentCaptureProbeType GetEnvironmentCaptureProbeType() { return default; }
	///<summary>See: WorldMapData</summary>
	public TArray<byte> GetWorldMapData() { return default; }
	///<summary>See: WorldMapData</summary>
	public void SetWorldMapData(TArray<byte> WorldMapData) {}
	///<summary>See: CandidateObjects</summary>
	public TArray<UARCandidateObject> GetCandidateObjectList() { return default; }
	///<summary>See: CandidateObjects</summary>
	public void SetCandidateObjectList(TArray<UARCandidateObject> InCandidateObjects) {}
	///<summary>See: CandidateObjects</summary>
	public void AddCandidateObject(UARCandidateObject CandidateObject) {}
	///<summary>See: DesiredVideoFormat</summary>
	public FARVideoFormat GetDesiredVideoFormat() { return default; }
	///<summary>See: DesiredVideoFormat</summary>
	public void SetDesiredVideoFormat(FARVideoFormat NewFormat) {}
	///<summary>See: FaceTrackingDirection</summary>
	public EARFaceTrackingDirection GetFaceTrackingDirection() { return default; }
	///<summary>See: FaceTrackingDirection</summary>
	public void SetFaceTrackingDirection(EARFaceTrackingDirection InDirection) {}
	///<summary>See: FaceTrackingUpdate</summary>
	public EARFaceTrackingUpdate GetFaceTrackingUpdate() { return default; }
	///<summary>See: FaceTrackingUpdate</summary>
	public void SetFaceTrackingUpdate(EARFaceTrackingUpdate InUpdate) {}
	///<summary>See: EnabledSessionTrackingFeatures</summary>
	public EARSessionTrackingFeature GetEnabledSessionTrackingFeature() { return default; }
	///<summary>See: SceneReconstructionMethod</summary>
	public EARSceneReconstruction GetSceneReconstructionMethod() { return default; }
	///<summary>See: EnabledSessionTrackingFeatures</summary>
	public void SetSessionTrackingFeatureToEnable(EARSessionTrackingFeature InSessionTrackingFeature) {}
	///<summary>See: SceneReconstructionMethod</summary>
	public void SetSceneReconstructionMethod(EARSceneReconstruction InSceneReconstructionMethod) {}
	///<summary>Boolean to determine whether the AR system should generate mesh data that can be used for rendering, collision, NavMesh, and more. This feature is used by OpenXR, Windows Mixed Reality.</summary>
	public bool bGenerateMeshDataFromTrackedGeometry;
	///<summary>Boolean to determine whether the AR system should generate collision data from the mesh data.</summary>
	public bool bGenerateCollisionForMeshData;
	///<summary>Boolean to determine whether the AR system should generate collision data from the mesh data.</summary>
	public bool bGenerateNavMeshForMeshData;
	///<summary>Boolean to determine whether the AR system should render the mesh data as occlusion meshes.</summary>
	public bool bUseMeshDataForOcclusion;
	///<summary>Boolean to determine whether the AR system should render the mesh data as wireframe.  It is reccomended to simply set the DefaultMeshMaterial to whatever is desired, including a wireframe material and ignore this setting (there is no good reason for this to exist as a special case).</summary>
	public bool bRenderMeshDataInWireframe;
	///<summary>Boolean to determine whether the AR system should track scene objects: See: EARObjectClassification::SceneObject.</summary>
	public bool bTrackSceneObjects;
	///<summary>Boolean to determine whether to use the person segmentation results for occluding virtual content. This feature is used by ARKit.</summary>
	public bool bUsePersonSegmentationForOcclusion;
	///<summary>Boolean to determine whether to use the scene depth information for occluding virtual content. This feature is used by ARCore and ARKit.</summary>
	public bool bUseSceneDepthForOcclusion;
	///<summary>Boolean to determine whether to automatically estimate and set the scale of a detected, or tracked, image. This feature is used by ARKit.</summary>
	public bool bUseAutomaticImageScaleEstimation;
	///<summary>Boolean to determine whether to use the standard onboarding UX, if the system supports it. This feature is used by ARKit.</summary>
	public bool bUseStandardOnboardingUX;
	///<summary>See: EARWorldAlignment</summary>
	public EARWorldAlignment WorldAlignment;
	///<summary>See: EARSessionType</summary>
	public EARSessionType SessionType;
	///<summary>See: EARPlaneDetectionMode</summary>
	public EARPlaneDetectionMode PlaneDetectionMode_DEPRECATED;
	///<summary>Boolean to determine whether flat, horizontal surfaces are detected. This feature is used by ARCore and ARKit.</summary>
	public bool bHorizontalPlaneDetection;
	///<summary>Boolean to determine whether flat, vertical surfaces are detected. This feature is used by ARCore and ARKit.</summary>
	public bool bVerticalPlaneDetection;
	///<summary>Boolean to determine whether the camera should autofocus. Autofocus can cause subtle shifts in position for small objects at further camera distance. This feature is used by ARCore and ARKit.</summary>
	public bool bEnableAutoFocus;
	///<summary>See: EARLightEstimationMode</summary>
	public EARLightEstimationMode LightEstimationMode;
	///<summary>See: EARFrameSyncMode</summary>
	public EARFrameSyncMode FrameSyncMode;
	///<summary>Boolean to determine whether the AR camera feed should be drawn as an overlay. Defaults to true. This feature is used by ARCore and ARKit.</summary>
	public bool bEnableAutomaticCameraOverlay;
	///<summary>Boolean to determine whether the virtual camera should track the device movement. Defaults to true. This feature is used by ARCore and ARKit.</summary>
	public bool bEnableAutomaticCameraTracking;
	///<summary>Boolean to determine whether the AR system should reset camera tracking, such as its origin and transforms, when a new AR session starts. Defaults to true. This feature is used by ARKit.</summary>
	public bool bResetCameraTracking;
	///<summary>Boolean to determine whether the AR system should remove any tracked objects when a new AR session starts. Defaults to true. This feature is used by ARKit.</summary>
	public bool bResetTrackedObjects;
	///<summary>The list of candidate images to detect within the AR camera view. This feature is used by ARKit.</summary>
	public TArray<UARCandidateImage> CandidateImages;
	///<summary>The maximum number of images to track at the same time. Defaults to 1. This feature is used by ARKit.</summary>
	public int MaxNumSimultaneousImagesTracked;
	///<summary>See: EAREnvironmentCaptureProbeType</summary>
	public EAREnvironmentCaptureProbeType EnvironmentCaptureProbeType;
	///<summary>A previously saved world that will be loaded when the session starts. This feature is used by ARKit.</summary>
	public TArray<byte> WorldMapData;
	///<summary>The list of candidate objects to search for in the scene. This feature is used by ARKit.</summary>
	public TArray<UARCandidateObject> CandidateObjects;
	///<summary>The desired video format (or the default, if not supported) that this session should use if the camera is enabled.</summary>
	public FARVideoFormat DesiredVideoFormat;
	///<summary>Boolean to determine whether to automatically pick the video format that best matches the device screen size</summary>
	public bool bUseOptimalVideoFormat;
	///<summary>See: EARFaceTrackingDirection</summary>
	public EARFaceTrackingDirection FaceTrackingDirection;
	///<summary>See: EARFaceTrackingUpdate</summary>
	public EARFaceTrackingUpdate FaceTrackingUpdate;
	///<summary>The maximum number of faces to track simultaneously. This feature is used by ARKit.</summary>
	public int MaxNumberOfTrackedFaces;
	///<summary>Data array for storing the cooked image database. This feature is used by ARCore.</summary>
	public TArray<byte> SerializedARCandidateImageDatabase;
	///<summary>See: EARSessionTrackingFeature</summary>
	public EARSessionTrackingFeature EnabledSessionTrackingFeature;
	///<summary>See: EARSceneReconstruction</summary>
	public EARSceneReconstruction SceneReconstructionMethod;
	///<summary>See: UARPlaneComponent</summary>
	public UClass PlaneComponentClass;
	///<summary>See: UARPointComponent</summary>
	public UClass PointComponentClass;
	///<summary>See: UARFaceComponent</summary>
	public UClass FaceComponentClass;
	///<summary>See: UARImageComponent</summary>
	public UClass ImageComponentClass;
	///<summary>See: UARQRCodeComponent</summary>
	public UClass QRCodeComponentClass;
	///<summary>See: UARPoseComponent</summary>
	public UClass PoseComponentClass;
	///<summary>See: UAREnvironmentProbeComponent</summary>
	public UClass EnvironmentProbeComponentClass;
	///<summary>See: UARObjectComponent</summary>
	public UClass ObjectComponentClass;
	///<summary>See: UARMeshComponent</summary>
	public UClass MeshComponentClass;
	///<summary>See: UARGeoAnchorComponent</summary>
	public UClass GeoAnchorComponentClass;
	///<summary>The default mesh material used by the generated mesh component.</summary>
	public UMaterialInterface DefaultMeshMaterial;
	///<summary>The default mesh material used by the wireframe setting of the generated mesh component.  Note: It is recommended to ignore this wireframe feature and use a wireframe material for the DefaultMeshMaterial instead.</summary>
	public UMaterialInterface DefaultWireframeMeshMaterial;
}
