#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceUtilLibrary.h")]
public partial class UTraceUtilLibrary : UBlueprintFunctionLibrary {
// TraceUtilLibrary
	public static bool StartTraceToFile(string FileName,TArray<string> Channels) { return default; }
	public static bool StartTraceSendTo(string Target,TArray<string> Channels) { return default; }
	public static bool StopTracing() { return default; }
	public static bool PauseTracing() { return default; }
	public static bool ResumeTracing() { return default; }
	public static bool IsTracing() { return default; }
	public static bool ToggleChannel(string ChannelName,bool enabled) { return default; }
	public static bool IsChannelEnabled(string ChannelName) { return default; }
	public static TArray<string> GetEnabledChannels() { return default; }
	public static TArray<string> GetAllChannels() { return default; }
	public static void TraceBookmark(string Name) {}
	public static void TraceMarkRegionStart(string Name) {}
	public static void TraceMarkRegionEnd(string Name) {}
}
