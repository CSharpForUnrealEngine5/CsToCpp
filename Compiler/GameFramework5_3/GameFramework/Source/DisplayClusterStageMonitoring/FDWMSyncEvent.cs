namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DWMSyncWatchdog.h")]
public partial struct FDWMSyncEvent {
	public uint MissedFrames;
	public uint PresentCount;
	public uint LastPresentCount;
	public uint PresentRefreshCount;
}
