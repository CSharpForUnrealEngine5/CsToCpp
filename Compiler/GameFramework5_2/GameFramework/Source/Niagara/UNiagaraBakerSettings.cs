#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerSettings.h")]
public partial class UNiagaraBakerSettings : UObject {
// NiagaraBakerSettings
	public float StartSeconds;
	public float DurationSeconds;
	public int FramesPerSecond;
	public bool bPreviewLooping;
	public FIntPoint FramesPerDimension;
	public TArray<UNiagaraBakerOutput> Outputs;
	public TArray<FNiagaraBakerCameraSettings> CameraSettings;
	public int CurrentCameraIndex;
	public string BakeQualityLevel;
	public bool bRenderComponentOnly;
	public TArray<FNiagaraBakerTextureSettings> OutputTextures_DEPRECATED;
	public ENiagaraBakerViewMode CameraViewportMode_DEPRECATED;
	public FVector CameraViewportLocation_DEPRECATED;
	public FRotator CameraViewportRotation_DEPRECATED;
	public float CameraOrbitDistance_DEPRECATED;
	public float CameraFOV_DEPRECATED;
	public float CameraOrthoWidth_DEPRECATED;
	public bool bUseCameraAspectRatio_DEPRECATED;
	public float CameraAspectRatio_DEPRECATED;
}
