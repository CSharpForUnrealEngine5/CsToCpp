namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract class that provides consistent player behaviour for various animation players</summary>
[CppInclude("MovieSceneSequencePlayer.h")]
public partial class UMovieSceneSequencePlayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Obeserver interface used for controlling whether the effects of this sequence can be seen even when it is playing back.</summary>
	public object /*Observer*/ Observer;
	///<summary>Start playback forwards from the current time cursor position, using the current play rate.</summary>
	public void Play() {}
	///<summary>Reverse playback.</summary>
	public void PlayReverse() {}
	///<summary>Changes the direction of playback (go in reverse if it was going forward, or vice versa)</summary>
	public void ChangePlaybackDirection() {}
	///<summary>Start playback from the current time cursor position, looping the specified number of times.</summary>
	public void PlayLooping(int NumLoops/*=-1*/) {}
	///<summary>Pause playback.</summary>
	public void Pause() {}
	///<summary>Scrub playback.</summary>
	public void Scrub() {}
	///<summary>Stop playback and move the cursor to the end (or start, for reversed playback) of the sequence.</summary>
	public void Stop() {}
	///<summary>Stop playback without moving the cursor.</summary>
	public void StopAtCurrentTime() {}
	///<summary>Go to end of the sequence and stop. Adheres to &#39;When Finished&#39; section rules.</summary>
	public void GoToEndAndStop() {}
	///<summary>Get the current playback position</summary>
	public FQualifiedFrameTime GetCurrentTime() { return default; }
	///<summary>Get the total duration of the sequence</summary>
	public FQualifiedFrameTime GetDuration() { return default; }
	///<summary>Get this sequence&#39;s duration in frames</summary>
	public int GetFrameDuration() { return default; }
	///<summary>Get this sequence&#39;s display rate.</summary>
	public FFrameRate GetFrameRate() { return default; }
	///<summary>Set the frame-rate that this player should play with, making all frame numbers in the specified time-space</summary>
	public void SetFrameRate(FFrameRate FrameRate) {}
	///<summary>Get the offset within the level sequence to start playing</summary>
	public FQualifiedFrameTime GetStartTime() { return default; }
	///<summary>Get the offset within the level sequence to finish playing</summary>
	public FQualifiedFrameTime GetEndTime() { return default; }
	///<summary>Set a manual weight to be multiplied with all blendable elements within this sequence</summary>
	public void SetWeight(double InWeight) {}
	///<summary>Removes a previously assigned weight</summary>
	public void RemoveWeight() {}
	///<summary>Set the valid play range for this sequence, determined by a starting frame number (in this sequence player&#39;s plaback frame), and a number of frames duration</summary>
	public void SetFrameRange(int StartFrame,int Duration,float SubFrames/*=0.0f*/) {}
	///<summary>Set the valid play range for this sequence, determined by a starting time  and a duration (in seconds)</summary>
	public void SetTimeRange(float StartTime,float Duration) {}
	///<summary>Play from the current position to the requested position and pause. If requested position is before the current position,</summary>
	public void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams,FMovieSceneSequencePlayToParams PlayToParams) {}
	///<summary>Set the current time of the player by evaluating from the current time to the specified time, as if the sequence is playing.</summary>
	public void SetPlaybackPosition(FMovieSceneSequencePlaybackParams PlaybackParams) {}
	///<summary>Restore any changes made by this player to their original state</summary>
	public void RestoreState() {}
	///<summary>Check whether the sequence is actively playing.</summary>
	public bool IsPlaying() { return default; }
	///<summary>Check whether the sequence is paused.</summary>
	public bool IsPaused() { return default; }
	///<summary>Check whether playback is reversed.</summary>
	public bool IsReversed() { return default; }
	///<summary>Get the playback rate of this player.</summary>
	public float GetPlayRate() { return default; }
	///<summary>Set the playback rate of this player. Negative values will play the animation in reverse.</summary>
	public void SetPlayRate(float PlayRate) {}
	///<summary>Set whether to disable camera cuts</summary>
	public void SetDisableCameraCuts(bool bInDisableCameraCuts) {}
	///<summary>Set whether to disable camera cuts</summary>
	public bool GetDisableCameraCuts() { return default; }
	///<summary>Event triggered when the level sequence player is played</summary>
	public FOnMovieSceneSequencePlayerEvent OnPlay;
	///<summary>Event triggered when the level sequence player is played in reverse</summary>
	public FOnMovieSceneSequencePlayerEvent OnPlayReverse;
	///<summary>Event triggered when the level sequence player is stopped</summary>
	public FOnMovieSceneSequencePlayerEvent OnStop;
	///<summary>Event triggered when the level sequence player is paused</summary>
	public FOnMovieSceneSequencePlayerEvent OnPause;
	///<summary>Event triggered when the level sequence player finishes naturally (without explicitly calling stop)</summary>
	public FOnMovieSceneSequencePlayerEvent OnFinished;
	///<summary>Retrieve all objects currently bound to the specified binding identifier</summary>
	public TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	///<summary>Get the object bindings for the requested object</summary>
	public TArray<FMovieSceneObjectBindingID> GetObjectBindings(UObject InObject) { return default; }
	///<summary>Access the sequence this player is playing</summary>
	public UMovieSceneSequence GetSequence() { return default; }
	///<summary>Get the name of the sequence this player is playing</summary>
	public string GetSequenceName(bool bAddClientInfo/*=false*/) { return default; }
	///<summary>Called on the server whenever an explicit change in time has occurred through one of the (Play|Jump|Scrub)To methods</summary>
	public void RPC_ExplicitServerUpdateEvent(EUpdatePositionMethod Method,FFrameTime RelevantTime,int NewSerialNumber) {}
	///<summary>Called on the server when Stop() is called in order to differentiate Stops from Pauses.</summary>
	public void RPC_OnStopEvent(FFrameTime StoppedTime,int NewSerialNumber) {}
	///<summary>Called on the server when playback has reached the end. Could lead to stopping or pausing.</summary>
	public void RPC_OnFinishPlaybackEvent(FFrameTime StoppedTime,int NewSerialNumber) {}
	///<summary>Movie player status.</summary>
	public EMovieScenePlayerStatus Status;
	///<summary>Whether we&#39;re currently playing in reverse.</summary>
	public bool bReversePlayback;
	///<summary>The sequence to play back</summary>
	public UMovieSceneSequence Sequence;
	///<summary>Time (in playback frames) at which to start playing the sequence (defaults to the lower bound of the sequence&#39;s play range)</summary>
	public FFrameNumber StartTime;
	///<summary>Time (in playback frames) at which to stop playing the sequence (defaults to the upper bound of the sequence&#39;s play range)</summary>
	public int DurationFrames;
	///<summary>DurationSubFrames</summary>
	public float DurationSubFrames;
	///<summary>The number of times we have looped in the current playback</summary>
	public int CurrentNumLoops;
	///<summary>The serial number for the current update lifespan</summary>
	public int SerialNumber;
	///<summary>Specific playback settings for the animation.</summary>
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	///<summary>The root template instance we&#39;re evaluating</summary>
	public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
	///<summary>Replicated playback status and current time that are replicated to clients</summary>
	public FMovieSceneSequenceReplProperties NetSyncProps;
	///<summary>External client pointer in charge of playing back this sequence</summary>
	public object /*PlaybackClient*/ PlaybackClient;
	///<summary>Global tick manager, held here to keep it alive while world sequences are in play</summary>
	public UMovieSceneSequenceTickManager TickManager;
}
