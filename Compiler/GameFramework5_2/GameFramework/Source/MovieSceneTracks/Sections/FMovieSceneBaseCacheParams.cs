#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneBaseCacheSection.h")]
///<summary>Base class for the cache parameters that will be used in all the cache sections</summary>
public partial struct FMovieSceneBaseCacheParams {
// MovieSceneBaseCacheParams
	public FFrameNumber FirstLoopStartFrameOffset;
	public FFrameNumber StartFrameOffset;
	public FFrameNumber EndFrameOffset;
	public float PlayRate;
	public bool bReverse;
}
