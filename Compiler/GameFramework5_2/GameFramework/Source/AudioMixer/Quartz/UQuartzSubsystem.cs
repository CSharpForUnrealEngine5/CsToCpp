#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Quartz/QuartzSubsystem.h")]
public partial class UQuartzSubsystem : UTickableWorldSubsystem {
// QuartzSubsystem
	public bool IsQuartzEnabled() { return default; }
	public UObject CreateNewClock(UObject WorldContextObject,string ClockName,FQuartzClockSettings InSettings,bool bOverrideSettingsIfClockExists/*=false*/,bool bUseAudioEngineClockManager/*=true*/) { return default; }
	public void DeleteClockByName(UObject WorldContextObject,string ClockName) {}
	public void DeleteClockByHandle(UObject WorldContextObject,UObject InClockHandle) {}
	public UObject GetHandleForClock(UObject WorldContextObject,string ClockName) { return default; }
	public bool DoesClockExist(UObject WorldContextObject,string ClockName) { return default; }
	public bool IsClockRunning(UObject WorldContextObject,string ClockName) { return default; }
	public float GetDurationOfQuantizationTypeInSeconds(UObject WorldContextObject,string ClockName,EQuartzCommandQuantization QuantizationType,float Multiplier/*=1.0f*/) { return default; }
	public FQuartzTransportTimeStamp GetCurrentClockTimestamp(UObject WorldContextObject,string InClockName) { return default; }
	public float GetEstimatedClockRunTime(UObject WorldContextObject,string InClockName) { return default; }
	public float GetGameThreadToAudioRenderThreadAverageLatency(UObject WorldContextObject) { return default; }
	public float GetGameThreadToAudioRenderThreadMinLatency(UObject WorldContextObject) { return default; }
	public float GetGameThreadToAudioRenderThreadMaxLatency(UObject WorldContextObject) { return default; }
	public float GetAudioRenderThreadToGameThreadAverageLatency() { return default; }
	public float GetAudioRenderThreadToGameThreadMinLatency() { return default; }
	public float GetAudioRenderThreadToGameThreadMaxLatency() { return default; }
	public float GetRoundTripAverageLatency(UObject WorldContextObject) { return default; }
	public float GetRoundTripMinLatency(UObject WorldContextObject) { return default; }
	public float GetRoundTripMaxLatency(UObject WorldContextObject) { return default; }
}
