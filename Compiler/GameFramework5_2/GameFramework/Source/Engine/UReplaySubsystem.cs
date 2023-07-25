#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplaySubsystem.h")]
public partial class UReplaySubsystem : UGameInstanceSubsystem {
// ReplaySubsystem
	public string GetActiveReplayName() { return default; }
	public float GetReplayCurrentTime() { return default; }
	public bool IsRecording() { return default; }
	public bool IsPlaying() { return default; }
	public void RequestCheckpoint() {}
	public bool bLoadDefaultMapOnStop;
}
