#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceUtilLibrary.h")]
public partial class UTraceUtilLibrary : UBlueprintFunctionLibrary {
// TraceUtilLibrary
	public bool StartTraceToFile(string FileName,TArray<string> Channels) { return default; }
	public bool StartTraceSendTo(string Target,TArray<string> Channels) { return default; }
	public bool StopTracing() { return default; }
	public bool PauseTracing() { return default; }
	public bool ResumeTracing() { return default; }
	public bool IsTracing() { return default; }
	public bool ToggleChannel(string ChannelName,bool enabled) { return default; }
	public bool IsChannelEnabled(string ChannelName) { return default; }
	public TArray<string> GetEnabledChannels() { return default; }
	public TArray<string> GetAllChannels() { return default; }
	public void TraceBookmark(string Name) {}
	public void TraceMarkRegionStart(string Name) {}
	public void TraceMarkRegionEnd(string Name) {}
}
