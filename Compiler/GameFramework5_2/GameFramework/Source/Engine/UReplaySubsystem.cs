#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplaySubsystem.h")]
public partial class UReplaySubsystem : UGameInstanceSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Get current recording/playing replay name</summary>
	public  string GetActiveReplayName() { return default; }
	///<summary>Get current recording/playing replay time</summary>
	public  float GetReplayCurrentTime() { return default; }
	///<summary>IsRecording</summary>
	public  bool IsRecording() { return default; }
	///<summary>IsPlaying</summary>
	public  bool IsPlaying() { return default; }
	///<summary>Request a checkpoint write, if currently recording.</summary>
	public  void RequestCheckpoint() {}
	///<summary>Whether to reload the default map when StopReplay is called.</summary>
	public bool bLoadDefaultMapOnStop;
}
