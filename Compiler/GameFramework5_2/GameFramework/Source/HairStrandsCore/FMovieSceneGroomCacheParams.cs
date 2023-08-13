namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneGroomCacheSection.h")]
public partial struct FMovieSceneGroomCacheParams {
	public UGroomCache GroomCache;
	public FFrameNumber FirstLoopStartFrameOffset;
	public FFrameNumber StartFrameOffset;
	public FFrameNumber EndFrameOffset;
	public float PlayRate;
	public bool bReverse;
}
