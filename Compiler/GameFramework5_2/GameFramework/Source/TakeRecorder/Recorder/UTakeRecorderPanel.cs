#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Take recorder UI panel interop object</summary>
[CppInclude("Recorder/TakeRecorderPanel.h")]
public partial class UTakeRecorderPanel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the mode that the panel is currently in</summary>
	public  ETakeRecorderPanelMode GetMode() { return default; }
	///<summary>Setup this panel such that it is ready to start recording using the specified</summary>
	public  void SetupForRecording_TakePreset(UTakePreset TakePresetAsset) {}
	///<summary>Setup this panel such that it is ready to start recording using the specified</summary>
	public  void SetupForRecording_LevelSequence(ULevelSequence LevelSequenceAsset) {}
	///<summary>Setup this panel such that it is ready to start recording using the specified</summary>
	public  void SetupForRecordingInto_LevelSequence(ULevelSequence LevelSequenceAsset) {}
	///<summary>Setup this panel as an editor for the specified take preset asset.</summary>
	public  void SetupForEditing(UTakePreset TakePreset) {}
	///<summary>Setup this panel as a viewer for a previously recorded take.</summary>
	public  void SetupForViewing(ULevelSequence LevelSequenceAsset) {}
	///<summary>NewTake</summary>
	public  void NewTake() {}
	///<summary>* Clear the pending take level sequence</summary>
	public  void ClearPendingTake() {}
	///<summary>Access the level sequence for this take</summary>
	public  ULevelSequence GetLevelSequence() { return default; }
	///<summary>Access the last level sequence that was recorded</summary>
	public  ULevelSequence GetLastRecordedLevelSequence() { return default; }
	///<summary>Access take meta data for this take</summary>
	public  UTakeMetaData GetTakeMetaData() { return default; }
	///<summary>Access the frame rate for this take</summary>
	public  FFrameRate GetFrameRate() { return default; }
	///<summary>Set the frame rate for this take</summary>
	public  void SetFrameRate(FFrameRate InFrameRate) {}
	///<summary>Set if the frame rate is set from the Timecode frame rate</summary>
	public  void SetFrameRateFromTimecode(bool bInFromTimecode) {}
	///<summary>Access the sources that are to be (or were) used for recording this take</summary>
	public  UTakeRecorderSources GetSources() { return default; }
	///<summary>Start recording with the current take</summary>
	public  void StartRecording() {}
	///<summary>Stop recording with the current take</summary>
	public  void StopRecording() {}
	///<summary>Whether the panel is ready to start recording</summary>
	public  bool CanStartRecording(string OutErrorText) { return default; }
}
