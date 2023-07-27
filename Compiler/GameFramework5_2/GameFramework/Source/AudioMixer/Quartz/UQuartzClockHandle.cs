#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Quartz/AudioMixerClockHandle.h")]
///<summary>This class is a BP / Game thread wrapper around FQuartzClockProxy</summary>
public partial class UQuartzClockHandle : UObject {
// QuartzClockHandle
	public  void StartClock(UObject WorldContextObject,UQuartzClockHandle ClockHandle) {}
	public  void StopClock(UObject WorldContextObject,bool CancelPendingEvents,UQuartzClockHandle ClockHandle) {}
	public  void PauseClock(UObject WorldContextObject,UQuartzClockHandle ClockHandle) {}
	public  void ResumeClock(UObject WorldContextObject,UQuartzClockHandle ClockHandle) {}
	public  void ResetTransport(UObject WorldContextObject,FOnQuartzCommandEventBP InDelegate) {}
	public  void ResetTransportQuantized(UObject WorldContextObject,FQuartzQuantizationBoundary InQuantizationBoundary,FOnQuartzCommandEventBP InDelegate,UQuartzClockHandle ClockHandle) {}
	public  bool IsClockRunning(UObject WorldContextObject) { return default; }
	public  float GetDurationOfQuantizationTypeInSeconds(UObject WorldContextObject,EQuartzCommandQuantization QuantizationType,float Multiplier/*=1.0f*/) { return default; }
	public  FQuartzTransportTimeStamp GetCurrentTimestamp(UObject WorldContextObject) { return default; }
	public  float GetEstimatedRunTime(UObject WorldContextObject) { return default; }
	public  void StartOtherClock(UObject WorldContextObject,string OtherClockName,FQuartzQuantizationBoundary InQuantizationBoundary,FOnQuartzCommandEventBP InDelegate) {}
	public  void SubscribeToQuantizationEvent(UObject WorldContextObject,EQuartzCommandQuantization InQuantizationBoundary,FOnQuartzMetronomeEventBP OnQuantizationEvent,UQuartzClockHandle ClockHandle) {}
	public  void SubscribeToAllQuantizationEvents(UObject WorldContextObject,FOnQuartzMetronomeEventBP OnQuantizationEvent,UQuartzClockHandle ClockHandle) {}
	public  void UnsubscribeFromTimeDivision(UObject WorldContextObject,EQuartzCommandQuantization InQuantizationBoundary,UQuartzClockHandle ClockHandle) {}
	public  void UnsubscribeFromAllTimeDivisions(UObject WorldContextObject,UQuartzClockHandle ClockHandle) {}
	public  void SetMillisecondsPerTick(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float MillisecondsPerTick/*=100.0f*/) {}
	public  void SetTicksPerSecond(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float TicksPerSecond/*=10.0f*/) {}
	public  void SetSecondsPerTick(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float SecondsPerTick/*=0.25f*/) {}
	public  void SetThirtySecondNotesPerMinute(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float ThirtySecondsNotesPerMinute/*=960.0f*/) {}
	public  void SetBeatsPerMinute(UObject WorldContextObject,FQuartzQuantizationBoundary QuantizationBoundary,FOnQuartzCommandEventBP Delegate,UQuartzClockHandle ClockHandle,float BeatsPerMinute/*=60.0f*/) {}
	public  float GetMillisecondsPerTick(UObject WorldContextObject) { return default; }
	public  float GetTicksPerSecond(UObject WorldContextObject) { return default; }
	public  float GetSecondsPerTick(UObject WorldContextObject) { return default; }
	public  float GetThirtySecondNotesPerMinute(UObject WorldContextObject) { return default; }
	public  float GetBeatsPerMinute(UObject WorldContextObject) { return default; }
}
