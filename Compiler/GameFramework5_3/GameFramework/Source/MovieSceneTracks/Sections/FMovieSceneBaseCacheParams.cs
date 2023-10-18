namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for the cache parameters that will be used in all the cache sections</summary>
[CppInclude("Sections/MovieSceneBaseCacheSection.h")]
public partial struct FMovieSceneBaseCacheParams {
	public FFrameNumber FirstLoopStartFrameOffset;
	public FFrameNumber StartFrameOffset;
	public FFrameNumber EndFrameOffset;
	public float PlayRate;
	public bool bReverse;
}
