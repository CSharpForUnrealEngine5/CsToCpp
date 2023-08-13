namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MixedRealityCaptureComponent.h")]
public partial class UMixedRealityCaptureComponent : USceneCaptureComponent2D {
	public static UClass StaticClass() {return default;}
	///<summary>MediaSource</summary>
	public UMediaPlayer MediaSource;
	///<summary>VideoProcessingMaterial</summary>
	public UMaterialInterface VideoProcessingMaterial;
	///<summary>VideoProcessingParams</summary>
	public FMrcVideoProcessingParams VideoProcessingParams;
	///<summary>CaptureFeedRef</summary>
	public FMrcVideoCaptureFeedIndex CaptureFeedRef;
	///<summary>LensDistortionParameters</summary>
	public FOpenCVLensDistortionParameters LensDistortionParameters;
	///<summary>TrackingSourceName</summary>
	public string TrackingSourceName;
	///<summary>GarbageMatteCaptureTextureTarget</summary>
	public UTextureRenderTarget2D GarbageMatteCaptureTextureTarget;
	///<summary>Millisecond delay to apply to motion controller components when rendering to the capture view (to better align with latent camera feeds)</summary>
	public int TrackingLatency;
	///<summary>Determines if this component should attempt to load the default MR calibration file on initialization</summary>
	public bool bAutoLoadConfiguration;
	///<summary>Depth offset (in UE units) for the card that the camera feed is projected onto. By default the card is aligned with the HMD.</summary>
	public float ProjectionDepthOffset;
	///<summary>Enabled by default, the projection plane tracks with the HMD to simulate the depth of the player. Disable to keep the projection plane from moving.</summary>
	public bool bProjectionDepthTracking;
	///<summary>SaveAsDefaultConfiguration_K2</summary>
	public bool SaveAsDefaultConfiguration_K2() { return default; }
	///<summary>SaveConfiguration_K2</summary>
	public bool SaveConfiguration_K2(string SlotName,int UserIndex) { return default; }
	///<summary>LoadDefaultConfiguration</summary>
	public bool LoadDefaultConfiguration() { return default; }
	///<summary>LoadConfiguration</summary>
	public bool LoadConfiguration(string SlotName,int UserIndex) { return default; }
	///<summary>ConstructCalibrationData</summary>
	public UMrcCalibrationData ConstructCalibrationData() { return default; }
	///<summary>FillOutCalibrationData</summary>
	public void FillOutCalibrationData(UMrcCalibrationData Dst) {}
	///<summary>ApplyCalibrationData</summary>
	public void ApplyCalibrationData(UMrcCalibrationData ConfigData) {}
	///<summary>Set an external garbage matte actor to be used instead of the mixed reality component&#39;s</summary>
	public bool SetGarbageMatteActor(AMrcGarbageMatteActor Actor) { return default; }
	///<summary>SetVidProjectionMat</summary>
	public void SetVidProjectionMat(UMaterialInterface NewMaterial) {}
	///<summary>SetVidProcessingParams</summary>
	public void SetVidProcessingParams(FMrcVideoProcessingParams NewVidProcessingParams) {}
	///<summary>SetDeviceAttachment</summary>
	public void SetDeviceAttachment(string SourceName) {}
	///<summary>DetatchFromDevice</summary>
	public void DetatchFromDevice() {}
	///<summary>IsTracked</summary>
	public bool IsTracked() { return default; }
	///<summary>SetCaptureDevice</summary>
	public void SetCaptureDevice(FMrcVideoCaptureFeedIndex FeedRef) {}
	///<summary>SetLensDistortionParameters</summary>
	public void SetLensDistortionParameters(FOpenCVLensDistortionParameters ModelRef) {}
	///<summary>GetTrackingDelay</summary>
	public int GetTrackingDelay() { return default; }
	///<summary>SetTrackingDelay</summary>
	public void SetTrackingDelay(int DelayMS) {}
	///<summary>SetProjectionDepthOffset</summary>
	public void SetProjectionDepthOffset(float DepthOffset) {}
	///<summary>GetProjectionActor_K2</summary>
	public AActor GetProjectionActor_K2() { return default; }
	///<summary>FMRCaptureFeedOpenedDelegate</summary>
	public void FMRCaptureFeedOpenedDelegate(FMrcVideoCaptureFeedIndex FeedRef) {}
	///<summary>OnCaptureSourceOpened</summary>
	public FMRCaptureFeedOpenedDelegate OnCaptureSourceOpened;
	///<summary>Enabled by default, the projection plane tracks with the HMD to simulate</summary>
	public void SetEnableProjectionDepthTracking(bool bEnable/*=true*/) {}
	///<summary>needs to be a UFunction for binding purposes</summary>
	public void OnVideoFeedOpened(FMrcVideoCaptureFeedIndex FeedRef) {}
	///<summary>ProxyMesh</summary>
	public UStaticMesh ProxyMesh;
	///<summary>ProxyMeshComponent</summary>
	public UStaticMeshComponent ProxyMeshComponent;
	///<summary>ProjectionActor</summary>
	public UChildActorComponent ProjectionActor;
	///<summary>PairedTracker</summary>
	public UMotionControllerComponent PairedTracker;
	///<summary>TrackingOriginOffset</summary>
	public USceneComponent TrackingOriginOffset;
	///<summary>GarbageMatteCaptureComponent</summary>
	public UMrcGarbageMatteCaptureComponent GarbageMatteCaptureComponent;
	///<summary>DistortionDisplacementMap</summary>
	public UTexture2D DistortionDisplacementMap;
}
