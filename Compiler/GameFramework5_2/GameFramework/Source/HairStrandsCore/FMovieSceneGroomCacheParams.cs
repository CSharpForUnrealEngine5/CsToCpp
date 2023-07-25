#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneGroomCacheSection.h")]
public partial struct FMovieSceneGroomCacheParams {
// MovieSceneGroomCacheParams
	public UGroomCache GroomCache;
	public FFrameNumber FirstLoopStartFrameOffset;
	public FFrameNumber StartFrameOffset;
	public FFrameNumber EndFrameOffset;
	public float PlayRate;
	public bool bReverse;
}
