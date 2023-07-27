#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/IMovieSceneCustomClockSource.h")]
public partial class UMovieSceneCustomClockSource : UInterface {
// MovieSceneCustomClockSource
	public  void OnTick(float DeltaSeconds,float InPlayRate) {}
	public  void OnStartPlaying(FQualifiedFrameTime InStartTime) {}
	public  void OnStopPlaying(FQualifiedFrameTime InStopTime) {}
	public  FFrameTime OnRequestCurrentTime(FQualifiedFrameTime InCurrentTime,float InPlayRate) { return default; }
}
