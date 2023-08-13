namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NvidiaSyncWatchdog.h")]
public partial struct FNvidiaSyncEvent {
	public int MissedFrames;
	public float LastFrameDuration;
	public float SynchronizationDuration;
}
