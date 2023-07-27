#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGrid.h")]
///<summary>This class represents a render grid job, in other words, an entry (a row) of a render grid.</summary>
public partial class URenderGridJob : UObject {
// RenderGridJob
	public  FIntPoint GetOutputResolution() { return default; }
	public  double GetOutputAspectRatio() { return default; }
	public  bool MatchesSearchTerm(string SearchTerm) { return default; }
	public  FGuid GetGuid() { return default; }
	public  void GenerateNewGuid() {}
	public  int GetWaitFramesBeforeRendering() { return default; }
	public  void SetWaitFramesBeforeRendering(int NewWaitFramesBeforeRendering) {}
	public  ULevelSequence GetLevelSequence() { return default; }
	public  void SetLevelSequence(ULevelSequence NewSequence) {}
	public  bool GetIsUsingCustomStartFrame() { return default; }
	public  void SetIsUsingCustomStartFrame(bool bNewOverrideStartFrame) {}
	public  int GetCustomStartFrame() { return default; }
	public  void SetCustomStartFrame(int NewCustomStartFrame) {}
	public  bool GetIsUsingCustomEndFrame() { return default; }
	public  void SetIsUsingCustomEndFrame(bool bNewOverrideEndFrame) {}
	public  int GetCustomEndFrame() { return default; }
	public  void SetCustomEndFrame(int NewCustomEndFrame) {}
	public  bool GetIsUsingCustomResolution() { return default; }
	public  void SetIsUsingCustomResolution(bool bNewOverrideResolution) {}
	public  FIntPoint GetCustomResolution() { return default; }
	public  void SetCustomResolution(FIntPoint NewCustomResolution) {}
	public  string GetJobId() { return default; }
	public  void SetJobId(string NewJobId) {}
	public  string GetJobName() { return default; }
	public  void SetJobName(string NewJobName) {}
	public  bool GetIsEnabled() { return default; }
	public  void SetIsEnabled(bool bEnabled) {}
	public  string GetOutputDirectory() { return default; }
	public  string GetOutputDirectoryForDisplay() { return default; }
	public  void SetOutputDirectory(string NewOutputDirectory) {}
	public  UMoviePipelinePrimaryConfig GetRenderPreset() { return default; }
	public  UMoviePipelineOutputSetting GetRenderPresetOutputSettings() { return default; }
	public  void SetRenderPreset(UMoviePipelinePrimaryConfig NewRenderPreset) {}
	public  bool HasRemoteControlValue(FGuid FieldId) { return default; }
	public  bool GetRemoteControlValue(FGuid FieldId,string OutJson) { return default; }
	public  bool SetRemoteControlValue(FGuid FieldId,string Json) { return default; }
	public  bool GetRemoteControlFieldIdFromLabel(string Label,FGuid OutFieldId) { return default; }
	public  bool GetRemoteControlLabelFromFieldId(FGuid FieldId,string OutLabel) { return default; }
	public  TMap<FGuid,string> GetRemoteControlValues() { return default; }
	public FGuid Guid;
	public int WaitFramesBeforeRendering;
	public ULevelSequence LevelSequence;
	public bool bOverrideStartFrame;
	public int CustomStartFrame;
	public bool bOverrideEndFrame;
	public int CustomEndFrame;
	public bool bOverrideResolution;
	public FIntPoint CustomResolution;
	public bool bIsEnabled;
	public string JobId;
	public string JobName;
	public string OutputDirectory;
	public UMoviePipelinePrimaryConfig RenderPreset;
	public TMap<FGuid,FRenderGridRemoteControlPropertyData> RemoteControlValues;
}
