#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneSectionParameters.h")]
public partial struct FMovieSceneSectionParameters {
	public FFrameNumber StartFrameOffset;
	public bool bCanLoop;
	public FFrameNumber EndFrameOffset;
	public FFrameNumber FirstLoopStartFrameOffset;
	public float TimeScale;
	public int HierarchicalBias;
	public float StartOffset_DEPRECATED;
	public float PrerollTime_DEPRECATED;
	public float PostrollTime_DEPRECATED;
}
