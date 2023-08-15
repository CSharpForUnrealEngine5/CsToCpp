namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Quartz/QuartzSubsystem.h")]
public partial class UQuartzSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>IsQuartzEnabled</summary>
	public bool IsQuartzEnabled() { return default; }
	///<summary>Clock Creation</summary>
	public UQuartzClockHandle CreateNewClock(UObject WorldContextObject,FName ClockName,FQuartzClockSettings InSettings,bool bOverrideSettingsIfClockExists/*=false*/,bool bUseAudioEngineClockManager/*=true*/) { return default; }
	///<summary>delete an existing clock given its name</summary>
	public void DeleteClockByName(UObject WorldContextObject,FName ClockName) {}
	///<summary>delete an existing clock given its clock handle</summary>
	public void DeleteClockByHandle(UObject WorldContextObject,UQuartzClockHandle InClockHandle) {}
	///<summary>get handle for existing clock</summary>
	public UQuartzClockHandle GetHandleForClock(UObject WorldContextObject,FName ClockName) { return default; }
	///<summary>returns true if the clock exists</summary>
	public bool DoesClockExist(UObject WorldContextObject,FName ClockName) { return default; }
	///<summary>returns true if the clock is running</summary>
	public bool IsClockRunning(UObject WorldContextObject,FName ClockName) { return default; }
	///<summary>Returns the duration in seconds of the given Quantization Type</summary>
	public float GetDurationOfQuantizationTypeInSeconds(UObject WorldContextObject,FName ClockName,EQuartzCommandQuantization QuantizationType,float Multiplier/*=1.0f*/) { return default; }
	///<summary>Retrieves a timestamp for the clock</summary>
	public FQuartzTransportTimeStamp GetCurrentClockTimestamp(UObject WorldContextObject,FName InClockName) { return default; }
	///<summary>Returns the amount of time, in seconds, the clock has been running. Caution: due to latency, this will not be perfectly accurate</summary>
	public float GetEstimatedClockRunTime(UObject WorldContextObject,FName InClockName) { return default; }
	///<summary>latency data (Game thread -&gt; Audio Render Thread)</summary>
	public float GetGameThreadToAudioRenderThreadAverageLatency(UObject WorldContextObject) { return default; }
	///<summary>GetGameThreadToAudioRenderThreadMinLatency</summary>
	public float GetGameThreadToAudioRenderThreadMinLatency(UObject WorldContextObject) { return default; }
	///<summary>GetGameThreadToAudioRenderThreadMaxLatency</summary>
	public float GetGameThreadToAudioRenderThreadMaxLatency(UObject WorldContextObject) { return default; }
	///<summary>latency data (Audio Render Thread -&gt; Game thread)</summary>
	public float GetAudioRenderThreadToGameThreadAverageLatency() { return default; }
	///<summary>GetAudioRenderThreadToGameThreadMinLatency</summary>
	public float GetAudioRenderThreadToGameThreadMinLatency() { return default; }
	///<summary>GetAudioRenderThreadToGameThreadMaxLatency</summary>
	public float GetAudioRenderThreadToGameThreadMaxLatency() { return default; }
	///<summary>latency data (Round trip)</summary>
	public float GetRoundTripAverageLatency(UObject WorldContextObject) { return default; }
	///<summary>GetRoundTripMinLatency</summary>
	public float GetRoundTripMinLatency(UObject WorldContextObject) { return default; }
	///<summary>GetRoundTripMaxLatency</summary>
	public float GetRoundTripMaxLatency(UObject WorldContextObject) { return default; }
}
