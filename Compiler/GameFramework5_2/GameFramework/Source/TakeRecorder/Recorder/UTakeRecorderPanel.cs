#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorderPanel.h")]
///<summary>Take recorder UI panel interop object</summary>
public partial class UTakeRecorderPanel : UObject {
// TakeRecorderPanel
	public ETakeRecorderPanelMode GetMode() { return default; }
	public void SetupForRecording_TakePreset(UObject TakePresetAsset) {}
	public void SetupForRecording_LevelSequence(UObject LevelSequenceAsset) {}
	public void SetupForRecordingInto_LevelSequence(UObject LevelSequenceAsset) {}
	public void SetupForEditing(UObject TakePreset) {}
	public void SetupForViewing(UObject LevelSequenceAsset) {}
	public void NewTake() {}
	public void ClearPendingTake() {}
	public UObject GetLevelSequence() { return default; }
	public UObject GetLastRecordedLevelSequence() { return default; }
	public UObject GetTakeMetaData() { return default; }
	public FFrameRate GetFrameRate() { return default; }
	public void SetFrameRate(FFrameRate InFrameRate) {}
	public void SetFrameRateFromTimecode(bool bInFromTimecode) {}
	public UObject GetSources() { return default; }
	public void StartRecording() {}
	public void StopRecording() {}
	public bool CanStartRecording(string OutErrorText) { return default; }
}
