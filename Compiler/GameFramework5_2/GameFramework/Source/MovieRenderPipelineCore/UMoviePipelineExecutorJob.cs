#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueue.h")]
///<summary>A particular job within the Queue</summary>
public partial class UMoviePipelineExecutorJob : UObject {
// MoviePipelineExecutorJob
	public void SetStatusMessage(string InStatus) {}
	public string GetStatusMessage() { return default; }
	public void SetStatusProgress(float InProgress) {}
	public float GetStatusProgress() { return default; }
	public void SetConsumed(bool bInConsumed) {}
	public bool IsConsumed() { return default; }
	public void SetIsEnabled(bool bInEnabled) {}
	public bool IsEnabled() { return default; }
	public void OnDuplicated() {}
	public void SetPresetOrigin(UObject InPreset) {}
	public UObject GetPresetOrigin() { return default; }
	public UObject GetConfiguration() { return default; }
	public void SetConfiguration(UObject InPreset) {}
	public void SetSequence(FSoftObjectPath InSequence) {}
	public string JobName;
	public FSoftObjectPath Sequence;
	public FSoftObjectPath Map;
	public string Author;
	public string Comment;
	public TArray<UMoviePipelineExecutorShot> ShotInfo;
	public string UserData;
	public string StatusMessage;
	public float StatusProgress;
	public bool bIsConsumed;
	public UMoviePipelinePrimaryConfig Configuration;
	public TSoftObjectPtr<UMoviePipelinePrimaryConfig> PresetOrigin;
	public bool bEnabled;
}
