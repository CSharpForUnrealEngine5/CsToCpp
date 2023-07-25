#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueue.h")]
///<summary>This class represents a segment of work within the Executor Job. This should be owned</summary>
public partial class UMoviePipelineExecutorShot : UObject {
// MoviePipelineExecutorShot
	public void SetStatusMessage(string InStatus) {}
	public string GetStatusMessage() { return default; }
	public void SetStatusProgress(float InProgress) {}
	public float GetStatusProgress() { return default; }
	public UObject AllocateNewShotOverrideConfig(UClass InConfigType) { return default; }
	public void SetShotOverrideConfiguration(UObject InPreset) {}
	public void SetShotOverridePresetOrigin(UObject InPreset) {}
	public UObject GetShotOverrideConfiguration() { return default; }
	public UObject GetShotOverridePresetOrigin() { return default; }
	public bool ShouldRender() { return default; }
	public string GetCameraName(int InCameraIndex) { return default; }
	public bool bEnabled;
	public string OuterName;
	public string InnerName;
	public TArray<FMoviePipelineSidecarCamera> SidecarCameras;
	public float Progress;
	public string StatusMessage;
	public UMoviePipelineShotConfig ShotOverrideConfig;
	public TSoftObjectPtr<UMoviePipelineShotConfig> ShotOverridePresetOrigin;
}
