namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is a BP / Game thread wrapper around FQuartzClockProxy</summary>
[CppInclude("Quartz/AudioMixerClockHandle.h")]
public partial class UQuartzClockHandle : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Clock manipulation</summary>
	public void StartClock(UObject WorldContextObject,UQuartzClockHandle ClockHandle) {}
	///<summary>StopClock</summary>
	public void StopClock(UObject WorldContextObject,bool CancelPendingEvents,UQuartzClockHandle ClockHandle) {}
	///<summary>PauseClock</summary>
	public void PauseClock(UObject WorldContextObject,UQuartzClockHandle ClockHandle) {}
	///<summary>ResumeClock</summary>
	public void ResumeClock(UObject WorldContextObject,UQuartzClockHandle ClockHandle) {}
	///<summary>ResetTransport</summary>
	public void ResetTransport(UObject WorldContextObject,FOnQuartzCommandEventBP InDelegate) {}
	///<summary>ResetTransportQuantized</summary>
	public void ResetTransportQuantized(UObject WorldContextObject,FQuartzQuantizationBoundary InQuantizationBoundary,FOnQuartzCommandEventBP InDelegate,UQuartzClockHandle ClockHandle) {}
	///<summary>IsClockRunning</summary>
	public bool IsClockRunning(UObject WorldContextObject) { return default; }
	///<summary>Returns the duration in seconds of the given Quantization Type</summary>
	public float GetDurationOfQuantizationTypeInSeconds(UObject WorldContextObject,EQuartzCommandQuantization QuantizationType,float Multiplier/*=1.0f*/) { return default; }
	///<summary>Retrieves a timestamp for the clock</summary>
	public FQuartzTransportTimeStamp GetCurrentTimestamp(UObject WorldContextObject) { return default; }
	///<summary>Returns the amount of time, in seconds, the clock has been running. Caution: due to latency, this will not be perfectly accurate</summary>
	public float GetEstimatedRunTime(UObject WorldContextObject) { return default; }
	///<summary>&quot;other&quot; clock manipulation</summary>
	public void StartOtherClock(UObject WorldContextObject,FName OtherClockName,FQuartzQuantizationBoundary InQuantizationBoundary,FOnQuartzCommandEventBP InDelegate) {}
	///<summary>Metronome subscription</summary>
	public void SubscribeToQuantizationEvent(UObject WorldContextObject,EQuartzCommandQuantization InQuantizationBoundary,FOnQuartzMetronomeEventBP OnQuantizationEvent,UQuartzClockHandle ClockHandle) {}
	///<summary>SubscribeToAllQuantizationEvents</summary>
	public void SubscribeToAllQuantizationEvents(UObject WorldContextObject,FOnQuartzMetronomeEventBP OnQuantizationEvent,UQuartzClockHandle ClockHandle) {}
	///<summary>UnsubscribeFromTimeDivision</summary>
	public void UnsubscribeFromTimeDivision(UObject WorldContextObject,EQuartzCommandQuantization InQuantizationBoundary,UQuartzClockHandle ClockHandle) {}
	///<summary>UnsubscribeFromAllTimeDivisions</summary>
	public void UnsubscribeFromAllTimeDivisions(UObject WorldContextObject,UQuartzClockHandle ClockHandle) {}
	///<summary>Metronome Alteration (setters)</summary>
	public void SetMillisecondsPerTick(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float MillisecondsPerTick/*=100.0f*/) {}
	///<summary>SetTicksPerSecond</summary>
	public void SetTicksPerSecond(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float TicksPerSecond/*=10.0f*/) {}
	///<summary>SetSecondsPerTick</summary>
	public void SetSecondsPerTick(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float SecondsPerTick/*=0.25f*/) {}
	///<summary>SetThirtySecondNotesPerMinute</summary>
	public void SetThirtySecondNotesPerMinute(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float ThirtySecondsNotesPerMinute/*=960.0f*/) {}
	///<summary>SetBeatsPerMinute</summary>
	public void SetBeatsPerMinute(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float BeatsPerMinute/*=60.0f*/) {}
	///<summary>Metronome getters</summary>
	public float GetMillisecondsPerTick(UObject WorldContextObject) { return default; }
	///<summary>GetTicksPerSecond</summary>
	public float GetTicksPerSecond(UObject WorldContextObject) { return default; }
	///<summary>GetSecondsPerTick</summary>
	public float GetSecondsPerTick(UObject WorldContextObject) { return default; }
	///<summary>GetThirtySecondNotesPerMinute</summary>
	public float GetThirtySecondNotesPerMinute(UObject WorldContextObject) { return default; }
	///<summary>GetBeatsPerMinute</summary>
	public float GetBeatsPerMinute(UObject WorldContextObject) { return default; }
}
