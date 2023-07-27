#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSequencePlayer.h")]
///<summary>Properties that are broadcast from server->clients for time/state synchronization</summary>
public partial struct FMovieSceneSequenceReplProperties {
// MovieSceneSequenceReplProperties
	public FFrameTime LastKnownPosition;
	public EMovieScenePlayerStatus LastKnownStatus;
	public int LastKnownNumLoops;
}
