namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TimelineComponent holds a series of events, floats, vectors or colors with associated keyframes.</summary>
[CppInclude("Components/TimelineComponent.h")]
public partial class UTimelineComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The actual timeline structure</summary>
	public FTimeline TheTimeline;
	///<summary>True if global time dilation should be ignored by this timeline, false otherwise.</summary>
	public bool bIgnoreTimeDilation;
	///<summary>Start playback of timeline</summary>
	public void Play() {}
	///<summary>Start playback of timeline from the start</summary>
	public void PlayFromStart() {}
	///<summary>Start playback of timeline in reverse</summary>
	public void Reverse() {}
	///<summary>Start playback of timeline in reverse from the end</summary>
	public void ReverseFromEnd() {}
	///<summary>Stop playback of timeline</summary>
	public void Stop() {}
	///<summary>Get whether this timeline is playing or not.</summary>
	public bool IsPlaying() { return default; }
	///<summary>Get whether we are reversing or not</summary>
	public bool IsReversing() { return default; }
	///<summary>Jump to a position in the timeline.</summary>
	public void SetPlaybackPosition(float NewPosition,bool bFireEvents,bool bFireUpdate/*=true*/) {}
	///<summary>Get the current playback position of the Timeline</summary>
	public float GetPlaybackPosition() { return default; }
	///<summary>true means we would loop, false means we should not.</summary>
	public void SetLooping(bool bNewLooping) {}
	///<summary>Get whether we are looping or not</summary>
	public bool IsLooping() { return default; }
	///<summary>Sets the new play rate for this timeline</summary>
	public void SetPlayRate(float NewRate) {}
	///<summary>Get the current play rate for this timeline</summary>
	public float GetPlayRate() { return default; }
	///<summary>Set the new playback position time to use</summary>
	public void SetNewTime(float NewTime) {}
	///<summary>Get length of the timeline</summary>
	public float GetTimelineLength() { return default; }
	///<summary>Get length of the timeline divided by the play rate</summary>
	public float GetScaledTimelineLength() { return default; }
	///<summary>Set length of the timeline</summary>
	public void SetTimelineLength(float NewLength) {}
	///<summary>Sets the length mode of the timeline</summary>
	public void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode) {}
	///<summary>Set whether to ignore time dilation.</summary>
	public void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation) {}
	///<summary>Get whether to ignore time dilation.</summary>
	public bool GetIgnoreTimeDilation() { return default; }
	///<summary>Update a certain float track&#39;s curve</summary>
	public void SetFloatCurve(UCurveFloat NewFloatCurve,FName FloatTrackName) {}
	///<summary>Update a certain vector track&#39;s curve</summary>
	public void SetVectorCurve(UCurveVector NewVectorCurve,FName VectorTrackName) {}
	///<summary>Update a certain linear color track&#39;s curve</summary>
	public void SetLinearColorCurve(UCurveLinearColor NewLinearColorCurve,FName LinearColorTrackName) {}
	///<summary>OnRep_Timeline</summary>
	public void OnRep_Timeline(FTimeline OldTimeline) {}
}
