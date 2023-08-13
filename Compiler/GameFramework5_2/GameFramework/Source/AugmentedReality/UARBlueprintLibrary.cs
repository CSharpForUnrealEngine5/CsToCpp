namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARBlueprintLibrary.h")]
public partial class UARBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Checks if the current device can support AR</summary>
	public static bool IsARSupported() { return default; }
	///<summary>Begin a new Augmented Reality session. Subsequently, use the \c GetARSessionStatus() function to figure out the status of the session.</summary>
	public static void StartARSession(UARSessionConfig SessionConfig) {}
	///<summary>Pause a running Augmented Reality session without clearing existing state.</summary>
	public static void PauseARSession() {}
	///<summary>Stop a running Augmented Reality session and clear any state.</summary>
	public static void StopARSession() {}
	///<summary>It is intended that you check the status of the Augmented Reality session on every frame and take action accordingly.</summary>
	public static FARSessionStatus GetARSessionStatus() { return default; }
	///<summary>@return the configuration that the current session was started with.</summary>
	public static UARSessionConfig GetSessionConfig() { return default; }
	///<summary>Starts or stops a battery intensive service on device.</summary>
	public static bool ToggleARCapture(bool bOnOff,EARCaptureType CaptureType) { return default; }
	///<summary>Enable or disable Mixed Reality Capture camera.</summary>
	public static void SetEnabledXRCamera(bool bOnOff) {}
	///<summary>Change screen size of Mixed Reality Capture camera.</summary>
	public static FIntPoint ResizeXRCamera(FIntPoint InSize) { return default; }
	///<summary>Set a transform that will be applied to the tracking space. This effectively moves any camera</summary>
	public static void SetAlignmentTransform(FTransform InAlignmentTransform) {}
	///<summary>Perform a line trace against any real-world geometry as tracked by the AR system.</summary>
	public static TArray<FARTraceResult> LineTraceTrackedObjects(FVector2D ScreenCoord,bool bTestFeaturePoints/*=true*/,bool bTestGroundPlane/*=true*/,bool bTestPlaneExtents/*=true*/,bool bTestPlaneBoundaryPolygon/*=true*/) { return default; }
	///<summary>Perform a line trace against any real-world geometry as tracked by the AR system.</summary>
	public static TArray<FARTraceResult> LineTraceTrackedObjects3D(FVector Start,FVector End,bool bTestFeaturePoints/*=true*/,bool bTestGroundPlane/*=true*/,bool bTestPlaneExtents/*=true*/,bool bTestPlaneBoundaryPolygon/*=true*/) { return default; }
	///<summary>@return how well the tracking system is performing at the moment</summary>
	public static EARTrackingQuality GetTrackingQuality() { return default; }
	///<summary>@return The reason for the current limited tracking state</summary>
	public static EARTrackingQualityReason GetTrackingQualityReason() { return default; }
	///<summary>@return a list of all the real-world geometry as currently seen by the Augmented Reality system</summary>
	public static TArray<UARTrackedGeometry> GetAllGeometries() { return default; }
	///<summary>@return a list of all the real-world geometry of the specified class as currently seen by the Augmented Reality system</summary>
	public static TArray<UARTrackedGeometry> GetAllGeometriesByClass(UClass GeometryClass) { return default; }
	///<summary>GetCameraImage</summary>
	public static UARTextureCameraImage GetCameraImage() { return default; }
	///<summary>GetCameraDepth</summary>
	public static UARTextureCameraDepth GetCameraDepth() { return default; }
	///<summary>@return the AR texture for the specified type</summary>
	public static UARTexture GetARTexture(EARTextureType TextureType) { return default; }
	///<summary>Test whether this type of session is supported by the current Augmented Reality platform.</summary>
	public static bool IsSessionTypeSupported(EARSessionType SessionType) { return default; }
	///<summary>Given some real-world geometry being tracked by the Augmented Reality system, draw it on the screen for debugging purposes (rudimentary)</summary>
	public static void DebugDrawTrackedGeometry(UARTrackedGeometry TrackedGeometry,UObject WorldContextObject,FLinearColor Color/*=new FLinearColor(1.0f,1.0f,0.0f,0.75f)*/,float OutlineThickness/*=5.0f*/,float PersistForSeconds/*=0.0f*/) {}
	///<summary>Given a \c UARPin, draw it for debugging purposes.</summary>
	public static void DebugDrawPin(UARPin ARPin,UObject WorldContextObject,FLinearColor Color/*=new FLinearColor(1.0f,1.0f,0.0f,0.75f)*/,float Scale/*=5.0f*/,float PersistForSeconds/*=0.0f*/) {}
	///<summary>An AugmentedReality session can be configured to provide light estimates.</summary>
	public static UARLightEstimate GetCurrentLightEstimate() { return default; }
	///<summary>Pin an Unreal Component to a location in tracking spce (i.e. the real world).</summary>
	public static UARPin PinComponent(USceneComponent ComponentToPin,FTransform PinToWorldTransform,UARTrackedGeometry TrackedGeometry/*=nullptr*/,string DebugName/*=NAME_None*/) { return default; }
	///<summary>A convenient version of \c PinComponent() that can be used in conjunction</summary>
	public static UARPin PinComponentToTraceResult(USceneComponent ComponentToPin,FARTraceResult TraceResult,string DebugName/*=NAME_None*/) { return default; }
	///<summary>Associate a component with an ARPin, so that its transform will be updated by the pin.  Any previously associated component will be detached.</summary>
	public static bool PinComponentToARPin(USceneComponent ComponentToPin,UARPin Pin) { return default; }
	///<summary>Given a pinned \c ComponentToUnpin, remove its attachment to the real world.</summary>
	public static void UnpinComponent(USceneComponent ComponentToUnpin) {}
	///<summary>Remove a pin such that it no longer updates the associated component.</summary>
	public static void RemovePin(UARPin PinToRemove) {}
	///<summary>Get a list of all the \c UARPin objects that the Augmented Reality session is currently using to connect virtual objects to real-world, tracked locations.</summary>
	public static TArray<UARPin> GetAllPins() { return default; }
	///<summary>Is ARPin Local Store Supported</summary>
	public static bool IsARPinLocalStoreSupported() { return default; }
	///<summary>Is ARPin Local Store Ready</summary>
	public static bool IsARPinLocalStoreReady() { return default; }
	///<summary>Load all ARPins from local save</summary>
	public static TMap<string,UARPin> LoadARPinsFromLocalStore() { return default; }
	///<summary>Save an ARPin to local store</summary>
	public static bool SaveARPinToLocalStore(string InSaveName,UARPin InPin) { return default; }
	///<summary>Remove an ARPin from the local store</summary>
	public static void RemoveARPinFromLocalStore(string InSaveName) {}
	///<summary>Remove all ARPins from the local store</summary>
	public static void RemoveAllARPinsFromLocalStore() {}
	///<summary>GetAllTrackedPlanes</summary>
	public static TArray<UARPlaneGeometry> GetAllTrackedPlanes() { return default; }
	///<summary>GetAllTrackedPoints</summary>
	public static TArray<UARTrackedPoint> GetAllTrackedPoints() { return default; }
	///<summary>GetAllTrackedImages</summary>
	public static TArray<UARTrackedImage> GetAllTrackedImages() { return default; }
	///<summary>GetAllTrackedEnvironmentCaptureProbes</summary>
	public static TArray<UAREnvironmentCaptureProbe> GetAllTrackedEnvironmentCaptureProbes() { return default; }
	///<summary>Adds an environment capture probe to the ar world</summary>
	public static bool AddManualEnvironmentCaptureProbe(FVector Location,FVector Extent) { return default; }
	///<summary>@return the current world mapping status for the AR world</summary>
	public static EARWorldMappingState GetWorldMappingStatus() { return default; }
	///<summary>@return the raw point cloud view of the AR scene</summary>
	public static TArray<FVector> GetPointCloud() { return default; }
	///<summary>@return The list of supported video formats for this device</summary>
	public static TArray<FARVideoFormat> GetSupportedVideoFormats(EARSessionType SessionType) { return default; }
	///<summary>Create an ARCandidateImage object and add it to the ARCandidateImageList of the given \c UARSessionConfig object.</summary>
	public static UARCandidateImage AddRuntimeCandidateImage(UARSessionConfig SessionConfig,UTexture2D CandidateTexture,string FriendlyName,float PhysicalWidth) { return default; }
	///<summary>@return if a particular session feature is supported with the specified session type on the current platform</summary>
	public static bool IsSessionTrackingFeatureSupported(EARSessionType SessionType,EARSessionTrackingFeature SessionTrackingFeature) { return default; }
	///<summary>@return if a particular scene reconstruction method is supported with the specified session type on the current platform</summary>
	public static bool IsSceneReconstructionSupported(EARSessionType SessionType,EARSceneReconstruction SceneReconstructionMethod) { return default; }
	///<summary>@return all the 2D poses tracked by the AR system</summary>
	public static TArray<FARPose2D> GetAllTracked2DPoses() { return default; }
	///<summary>GetAllTrackedPoses</summary>
	public static TArray<UARTrackedPose> GetAllTrackedPoses() { return default; }
	///<summary>GetPersonSegmentationImage</summary>
	public static UARTexture GetPersonSegmentationImage() { return default; }
	///<summary>GetPersonSegmentationDepthImage</summary>
	public static UARTexture GetPersonSegmentationDepthImage() { return default; }
	///<summary>Try to determine the classification of the object at a world space location</summary>
	public static bool GetObjectClassificationAtLocation(FVector InWorldLocation,EARObjectClassification OutClassification,FVector OutClassificationLocation,float MaxLocationDiff/*=10.0f*/) { return default; }
	///<summary>For a point P in the AR local space, whose location and rotation are &quot;OriginLocation&quot; and &quot;OriginRotation&quot; in the world space</summary>
	public static void SetARWorldOriginLocationAndRotation(FVector OriginLocation,FRotator OriginRotation,bool bIsTransformInWorldSpace/*=true*/,bool bMaintainUpDirection/*=true*/) {}
	///<summary>Helper function that modifies the alignment transform scale so that virtual content in the world space appears to be &quot;scaled&quot;.</summary>
	public static void SetARWorldScale(float InWorldScale) {}
	///<summary>@return the AR world scale, see &quot;SetARWorldScale&quot;</summary>
	public static float GetARWorldScale() { return default; }
	///<summary>@return the alignment transform, see &quot;SetAlignmentTransform&quot;</summary>
	public static FTransform GetAlignmentTransform() { return default; }
	///<summary>Manually add a tracked point with name and world transform.</summary>
	public static bool AddTrackedPointWithName(FTransform WorldTransform,string PointName,bool bDeletePointsWithSameName/*=true*/) { return default; }
	///<summary>@return a list of the tracked points with the given name</summary>
	public static TArray<UARTrackedPoint> FindTrackedPointsByName(string PointName) { return default; }
	///<summary>Alignment helpers</summary>
	public static void CalculateClosestIntersection(TArray<FVector> StartPoints,TArray<FVector> EndPoints,FVector ClosestIntersection) {}
	///<summary>Computes a transform that aligns two coordinate systems. Requires the transform of the same known point in each coordinate system.</summary>
	public static void CalculateAlignmentTransform(FTransform TransformInFirstCoordinateSystem,FTransform TransformInSecondCoordinateSystem,FTransform AlignmentTransform) {}
	///<summary>@return the max number of faces can be tracked at the same time</summary>
	public static int GetNumberOfTrackedFacesSupported() { return default; }
	///<summary>@return the intrinsics of the AR camera.</summary>
	public static bool GetCameraIntrinsics(FARCameraIntrinsics OutCameraIntrinsics) { return default; }
}
