namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceUtilLibrary.h")]
public partial class UTraceUtilLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>StartTraceToFile</summary>
	public static bool StartTraceToFile(string FileName,TArray<string> Channels) { return default; }
	///<summary>StartTraceSendTo</summary>
	public static bool StartTraceSendTo(string Target,TArray<string> Channels) { return default; }
	///<summary>StopTracing</summary>
	public static bool StopTracing() { return default; }
	///<summary>PauseTracing</summary>
	public static bool PauseTracing() { return default; }
	///<summary>ResumeTracing</summary>
	public static bool ResumeTracing() { return default; }
	///<summary>IsTracing</summary>
	public static bool IsTracing() { return default; }
	///<summary>ToggleChannel</summary>
	public static bool ToggleChannel(string ChannelName,bool enabled) { return default; }
	///<summary>IsChannelEnabled</summary>
	public static bool IsChannelEnabled(string ChannelName) { return default; }
	///<summary>GetEnabledChannels</summary>
	public static TArray<string> GetEnabledChannels() { return default; }
	///<summary>GetAllChannels</summary>
	public static TArray<string> GetAllChannels() { return default; }
	///<summary>TraceBookmark</summary>
	public static void TraceBookmark(string Name) {}
	///<summary>Traces a &quot;RegionStart:Name&quot; bookmark, where Name is defined through the Name parameter.</summary>
	public static void TraceMarkRegionStart(string Name) {}
	///<summary>Traces a &quot;RegionEnd:Name&quot; bookmark, where Name is defined through the Name parameter.</summary>
	public static void TraceMarkRegionEnd(string Name) {}
}
