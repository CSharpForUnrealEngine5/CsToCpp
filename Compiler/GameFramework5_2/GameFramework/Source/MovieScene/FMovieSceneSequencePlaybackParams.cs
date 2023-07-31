#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSequencePlayer.h")]
public partial struct FMovieSceneSequencePlaybackParams {
	public FFrameTime Frame;
	public float Time;
	public string MarkedFrame;
	public EMovieScenePositionType PositionType;
	public EUpdatePositionMethod UpdateMethod;
	public bool bHasJumped;
}
