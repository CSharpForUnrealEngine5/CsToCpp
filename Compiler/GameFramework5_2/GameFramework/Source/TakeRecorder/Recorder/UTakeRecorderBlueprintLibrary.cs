#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorderBlueprintLibrary.h")]
public partial class UTakeRecorderBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Is the Take Recorder enabled in the build</summary>
	public static bool IsTakeRecorderEnabled() { return default; }
	///<summary>Start a new recording using the specified parameters. Will fail if a recording is currently in progress</summary>
	public static UTakeRecorder StartRecording(ULevelSequence LevelSequence,UTakeRecorderSources Sources,UTakeMetaData MetaData,FTakeRecorderParameters Parameters) { return default; }
	///<summary>Get the default recorder parameters according to the project and user settings</summary>
	public static FTakeRecorderParameters GetDefaultParameters() { return default; }
	///<summary>Set the default recorder parameters</summary>
	public static void SetDefaultParameters(FTakeRecorderParameters DefaultParameters) {}
	///<summary>Check whether a recording is currently active</summary>
	public static bool IsRecording() { return default; }
	///<summary>Retrieve the currently active recorder, or None if there none are active</summary>
	public static UTakeRecorder GetActiveRecorder() { return default; }
	///<summary>Stop recording if there is a recorder currently active</summary>
	public static void StopRecording() {}
	///<summary>Cancel recording if there is a recorder currently active</summary>
	public static void CancelRecording() {}
	///<summary>Get the currently open take recorder panel, if one is open</summary>
	public static UTakeRecorderPanel GetTakeRecorderPanel() { return default; }
	///<summary>Get the currently open take recorder panel, if one is open, opening a new one if not</summary>
	public static UTakeRecorderPanel OpenTakeRecorderPanel() { return default; }
	///<summary>Called when a Take Panel is constructed or destroyed.</summary>
	public static void SetOnTakeRecorderPanelChanged(FOnTakeRecorderPanelChanged OnTakeRecorderPanelChanged) {}
	///<summary>Called before initialization occurs (ie. when the recording button is pressed and before the countdown starts)</summary>
	public static void SetOnTakeRecorderPreInitialize(FOnTakeRecorderPreInitialize OnTakeRecorderPreInitialize) {}
	///<summary>Called when take recording starts.</summary>
	public static void SetOnTakeRecorderStarted(FOnTakeRecorderStarted OnTakeRecorderStarted) {}
	///<summary>Called when take recording is stopped.</summary>
	public static void SetOnTakeRecorderStopped(FOnTakeRecorderStopped OnTakeRecorderStopped) {}
	///<summary>Called when take recording finishes.</summary>
	public static void SetOnTakeRecorderFinished(FOnTakeRecorderFinished OnTakeRecorderFinished) {}
	///<summary>Called when take recording is cancelled.</summary>
	public static void SetOnTakeRecorderCancelled(FOnTakeRecorderCancelled OnTakeRecorderCancelled) {}
	///<summary>Called when a marked frame is added.</summary>
	public static void SetOnTakeRecorderMarkedFrameAdded(FOnTakeRecorderMarkedFrameAdded OnTakeRecorderMarkedFrameAdded) {}
}
