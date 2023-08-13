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
