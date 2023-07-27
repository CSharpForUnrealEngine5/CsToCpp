#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorderBlueprintLibrary.h")]
public partial class UTakeRecorderBlueprintLibrary : UBlueprintFunctionLibrary {
// TakeRecorderBlueprintLibrary
	public static bool IsTakeRecorderEnabled() { return default; }
	public static UTakeRecorder StartRecording(ULevelSequence LevelSequence,UTakeRecorderSources Sources,UTakeMetaData MetaData,FTakeRecorderParameters Parameters) { return default; }
	public static FTakeRecorderParameters GetDefaultParameters() { return default; }
	public static void SetDefaultParameters(FTakeRecorderParameters DefaultParameters) {}
	public static bool IsRecording() { return default; }
	public static UTakeRecorder GetActiveRecorder() { return default; }
	public static void StopRecording() {}
	public static void CancelRecording() {}
	public static UTakeRecorderPanel GetTakeRecorderPanel() { return default; }
	public static UTakeRecorderPanel OpenTakeRecorderPanel() { return default; }
	public static void SetOnTakeRecorderPanelChanged(FOnTakeRecorderPanelChanged OnTakeRecorderPanelChanged) {}
	public static void SetOnTakeRecorderPreInitialize(FOnTakeRecorderPreInitialize OnTakeRecorderPreInitialize) {}
	public static void SetOnTakeRecorderStarted(FOnTakeRecorderStarted OnTakeRecorderStarted) {}
	public static void SetOnTakeRecorderStopped(FOnTakeRecorderStopped OnTakeRecorderStopped) {}
	public static void SetOnTakeRecorderFinished(FOnTakeRecorderFinished OnTakeRecorderFinished) {}
	public static void SetOnTakeRecorderCancelled(FOnTakeRecorderCancelled OnTakeRecorderCancelled) {}
	public static void SetOnTakeRecorderMarkedFrameAdded(FOnTakeRecorderMarkedFrameAdded OnTakeRecorderMarkedFrameAdded) {}
}
