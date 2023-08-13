namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties that are broadcast from server-&gt;clients for time/state synchronization</summary>
[CppInclude("MovieSceneSequencePlayer.h")]
public partial struct FMovieSceneSequenceReplProperties {
	public FFrameTime LastKnownPosition;
	public EMovieScenePlayerStatus LastKnownStatus;
	public int LastKnownNumLoops;
}
