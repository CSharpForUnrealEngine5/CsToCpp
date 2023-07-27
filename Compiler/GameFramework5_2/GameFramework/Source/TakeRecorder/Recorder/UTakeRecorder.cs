#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorder.h")]
public partial class UTakeRecorder : UObject {
// TakeRecorder
	public  float GetCountdownSeconds() { return default; }
	public  ULevelSequence GetSequence() { return default; }
	public  ETakeRecorderState GetState() { return default; }
	public ULevelSequence SequenceAsset;
	public UTakeRecorderOverlayWidget OverlayWidget;
	public TWeakObjectPtr<UWorld> WeakWorld;
	public FTakeRecorderParameters Parameters;
}
