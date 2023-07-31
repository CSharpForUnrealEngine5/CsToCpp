#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/IMovieSceneCustomClockSource.h")]
public partial class UMovieSceneCustomClockSource : UInterface {
	///<summary>OnTick</summary>
	public  void OnTick(float DeltaSeconds,float InPlayRate) {}
	///<summary>OnStartPlaying</summary>
	public  void OnStartPlaying(FQualifiedFrameTime InStartTime) {}
	///<summary>OnStopPlaying</summary>
	public  void OnStopPlaying(FQualifiedFrameTime InStopTime) {}
	///<summary>OnRequestCurrentTime</summary>
	public  FFrameTime OnRequestCurrentTime(FQualifiedFrameTime InCurrentTime,float InPlayRate) { return default; }
}
