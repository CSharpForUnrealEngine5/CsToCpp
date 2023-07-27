#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TimelineComponent.h")]
///<summary>TimelineComponent holds a series of events, floats, vectors or colors with associated keyframes.</summary>
public partial class UTimelineComponent : UActorComponent {
// TimelineComponent
	public FTimeline TheTimeline;
	public bool bIgnoreTimeDilation;
	public  void Play() {}
	public  void PlayFromStart() {}
	public  void Reverse() {}
	public  void ReverseFromEnd() {}
	public  void Stop() {}
	public  bool IsPlaying() { return default; }
	public  bool IsReversing() { return default; }
	public  void SetPlaybackPosition(float NewPosition,bool bFireEvents,bool bFireUpdate/*=true*/) {}
	public  float GetPlaybackPosition() { return default; }
	public  void SetLooping(bool bNewLooping) {}
	public  bool IsLooping() { return default; }
	public  void SetPlayRate(float NewRate) {}
	public  float GetPlayRate() { return default; }
	public  void SetNewTime(float NewTime) {}
	public  float GetTimelineLength() { return default; }
	public  float GetScaledTimelineLength() { return default; }
	public  void SetTimelineLength(float NewLength) {}
	public  void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode) {}
	public  void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation) {}
	public  bool GetIgnoreTimeDilation() { return default; }
	public  void SetFloatCurve(UCurveFloat NewFloatCurve,string FloatTrackName) {}
	public  void SetVectorCurve(UCurveVector NewVectorCurve,string VectorTrackName) {}
	public  void SetLinearColorCurve(UCurveLinearColor NewLinearColorCurve,string LinearColorTrackName) {}
	public  void OnRep_Timeline(FTimeline OldTimeline) {}
}
