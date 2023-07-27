#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSequencePlayer.h")]
///<summary>Abstract class that provides consistent player behaviour for various animation players</summary>
public partial class UMovieSceneSequencePlayer : UObject {
// MovieSceneSequencePlayer
	public object /*Observer*/ Observer;
	public  void Play() {}
	public  void PlayReverse() {}
	public  void ChangePlaybackDirection() {}
	public  void PlayLooping(int NumLoops/*=-1*/) {}
	public  void Pause() {}
	public  void Scrub() {}
	public  void Stop() {}
	public  void StopAtCurrentTime() {}
	public  void GoToEndAndStop() {}
	public  FQualifiedFrameTime GetCurrentTime() { return default; }
	public  FQualifiedFrameTime GetDuration() { return default; }
	public  int GetFrameDuration() { return default; }
	public  FFrameRate GetFrameRate() { return default; }
	public  void SetFrameRate(FFrameRate FrameRate) {}
	public  FQualifiedFrameTime GetStartTime() { return default; }
	public  FQualifiedFrameTime GetEndTime() { return default; }
	public  void SetWeight(double InWeight) {}
	public  void RemoveWeight() {}
	public  void SetFrameRange(int StartFrame,int Duration,float SubFrames/*=0.0f*/) {}
	public  void SetTimeRange(float StartTime,float Duration) {}
	public  void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams,FMovieSceneSequencePlayToParams PlayToParams) {}
	public  void SetPlaybackPosition(FMovieSceneSequencePlaybackParams PlaybackParams) {}
	public  void RestoreState() {}
	public  void PlayToFrame(FFrameTime NewPosition) {}
	public  void ScrubToFrame(FFrameTime NewPosition) {}
	public  void JumpToFrame(FFrameTime NewPosition) {}
	public  void PlayToSeconds(float TimeInSeconds) {}
	public  void ScrubToSeconds(float TimeInSeconds) {}
	public  void JumpToSeconds(float TimeInSeconds) {}
	public  bool PlayToMarkedFrame(string InLabel) { return default; }
	public  bool ScrubToMarkedFrame(string InLabel) { return default; }
	public  bool JumpToMarkedFrame(string InLabel) { return default; }
	public  bool IsPlaying() { return default; }
	public  bool IsPaused() { return default; }
	public  bool IsReversed() { return default; }
	public  float GetPlayRate() { return default; }
	public  void SetPlayRate(float PlayRate) {}
	public  void SetDisableCameraCuts(bool bInDisableCameraCuts) {}
	public  bool GetDisableCameraCuts() { return default; }
	public FOnMovieSceneSequencePlayerEvent OnPlay;
	public FOnMovieSceneSequencePlayerEvent OnPlayReverse;
	public FOnMovieSceneSequencePlayerEvent OnStop;
	public FOnMovieSceneSequencePlayerEvent OnPause;
	public FOnMovieSceneSequencePlayerEvent OnFinished;
	public  TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	public  TArray<FMovieSceneObjectBindingID> GetObjectBindings(UObject InObject) { return default; }
	public  UMovieSceneSequence GetSequence() { return default; }
	public  string GetSequenceName(bool bAddClientInfo/*=false*/) { return default; }
	public  void RPC_ExplicitServerUpdateEvent(EUpdatePositionMethod Method,FFrameTime RelevantTime) {}
	public  void RPC_OnStopEvent(FFrameTime StoppedTime) {}
	public  void RPC_OnFinishPlaybackEvent(FFrameTime StoppedTime) {}
	public EMovieScenePlayerStatus Status;
	public bool bReversePlayback;
	public UMovieSceneSequence Sequence;
	public FFrameNumber StartTime;
	public int DurationFrames;
	public float DurationSubFrames;
	public int CurrentNumLoops;
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
	public FMovieSceneSequenceReplProperties NetSyncProps;
	public object /*PlaybackClient*/ PlaybackClient;
	public UMovieSceneSequenceTickManager TickManager;
}
