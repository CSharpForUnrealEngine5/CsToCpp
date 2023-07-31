#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerState {
	public string SequenceObjectPath;
	public FQualifiedFrameTime Time;
	public EConcertMovieScenePlayerStatus PlayerStatus;
	public FFrameNumberRange PlaybackRange;
	public float PlaybackSpeed;
	public bool bLoopMode;
}
