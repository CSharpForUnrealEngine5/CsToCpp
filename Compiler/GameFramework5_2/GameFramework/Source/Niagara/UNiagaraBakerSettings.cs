#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerSettings.h")]
public partial class UNiagaraBakerSettings : UObject {
	///<summary>This is the start time of the simulation where we begin the capture.</summary>
	public float StartSeconds;
	///<summary>Duration in seconds to take the capture over.</summary>
	public float DurationSeconds;
	///<summary>The frame rate to run the simulation at during capturing.</summary>
	public int FramesPerSecond;
	///<summary>Should the preview playback as looping or not.</summary>
	public bool bPreviewLooping;
	///<summary>Number of frames in each dimension.</summary>
	public FIntPoint FramesPerDimension;
	///<summary>Array of outputs for the baker to generate.</summary>
	public TArray<UNiagaraBakerOutput> Outputs;
	///<summary>Camera Settings, will always be at least ENiagaraBakerViewMode::Num elements and those are fixed cameras.</summary>
	public TArray<FNiagaraBakerCameraSettings> CameraSettings;
	///<summary>Active camera that we were saved with</summary>
	public int CurrentCameraIndex;
	///<summary>What quality level to use when baking the simulation, where None means use the current quality level.</summary>
	public string BakeQualityLevel;
	///<summary>Should we render just the component or the whole scene.</summary>
	public bool bRenderComponentOnly;
	///<summary>Deprecated properties</summary>
	public TArray<FNiagaraBakerTextureSettings> OutputTextures_DEPRECATED;
	///<summary>CameraViewportMode_DEPRECATED</summary>
	public ENiagaraBakerViewMode CameraViewportMode_DEPRECATED;
	///<summary>CameraViewportLocation_DEPRECATED</summary>
	public FVector CameraViewportLocation_DEPRECATED;
	///<summary>CameraViewportRotation_DEPRECATED</summary>
	public FRotator CameraViewportRotation_DEPRECATED;
	///<summary>CameraOrbitDistance_DEPRECATED</summary>
	public float CameraOrbitDistance_DEPRECATED;
	///<summary>CameraFOV_DEPRECATED</summary>
	public float CameraFOV_DEPRECATED;
	///<summary>CameraOrthoWidth_DEPRECATED</summary>
	public float CameraOrthoWidth_DEPRECATED;
	///<summary>bUseCameraAspectRatio_DEPRECATED</summary>
	public bool bUseCameraAspectRatio_DEPRECATED;
	///<summary>CameraAspectRatio_DEPRECATED</summary>
	public float CameraAspectRatio_DEPRECATED;
}
