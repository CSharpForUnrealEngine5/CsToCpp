namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/IMovieSceneCustomClockSource.h")]
public partial class UMovieSceneCustomClockSource : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>OnTick</summary>
	public virtual void OnTick(float DeltaSeconds,float InPlayRate) {}
	///<summary>OnStartPlaying</summary>
	public virtual void OnStartPlaying(FQualifiedFrameTime InStartTime) {}
	///<summary>OnStopPlaying</summary>
	public virtual void OnStopPlaying(FQualifiedFrameTime InStopTime) {}
	///<summary>OnRequestCurrentTime</summary>
	public virtual FFrameTime OnRequestCurrentTime(FQualifiedFrameTime InCurrentTime,float InPlayRate) { return default; }
}
