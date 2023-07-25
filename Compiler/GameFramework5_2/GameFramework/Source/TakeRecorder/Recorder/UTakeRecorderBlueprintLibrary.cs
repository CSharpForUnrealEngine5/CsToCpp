#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorderBlueprintLibrary.h")]
public partial class UTakeRecorderBlueprintLibrary : UBlueprintFunctionLibrary {
// TakeRecorderBlueprintLibrary
	public bool IsTakeRecorderEnabled() { return default; }
	public UObject StartRecording(UObject LevelSequence,UObject Sources,UObject MetaData,FTakeRecorderParameters Parameters) { return default; }
	public FTakeRecorderParameters GetDefaultParameters() { return default; }
	public void SetDefaultParameters(FTakeRecorderParameters DefaultParameters) {}
	public bool IsRecording() { return default; }
	public UObject GetActiveRecorder() { return default; }
	public void StopRecording() {}
	public void CancelRecording() {}
	public UObject GetTakeRecorderPanel() { return default; }
	public UObject OpenTakeRecorderPanel() { return default; }
	public void SetOnTakeRecorderPanelChanged(FOnTakeRecorderPanelChanged OnTakeRecorderPanelChanged) {}
	public void SetOnTakeRecorderPreInitialize(FOnTakeRecorderPreInitialize OnTakeRecorderPreInitialize) {}
	public void SetOnTakeRecorderStarted(FOnTakeRecorderStarted OnTakeRecorderStarted) {}
	public void SetOnTakeRecorderStopped(FOnTakeRecorderStopped OnTakeRecorderStopped) {}
	public void SetOnTakeRecorderFinished(FOnTakeRecorderFinished OnTakeRecorderFinished) {}
	public void SetOnTakeRecorderCancelled(FOnTakeRecorderCancelled OnTakeRecorderCancelled) {}
	public void SetOnTakeRecorderMarkedFrameAdded(FOnTakeRecorderMarkedFrameAdded OnTakeRecorderMarkedFrameAdded) {}
}
