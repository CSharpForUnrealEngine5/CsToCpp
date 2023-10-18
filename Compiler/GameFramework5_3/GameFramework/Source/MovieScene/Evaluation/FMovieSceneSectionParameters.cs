namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>namespace UE::MovieScene</summary>
[CppInclude("Evaluation/MovieSceneSectionParameters.h")]
public partial struct FMovieSceneSectionParameters {
	public FFrameNumber StartFrameOffset;
	public bool bCanLoop;
	public FFrameNumber EndFrameOffset;
	public FFrameNumber FirstLoopStartFrameOffset;
	public float TimeScale;
	public int HierarchicalBias;
	public EMovieSceneSubSectionFlags Flags;
	public float StartOffset_DEPRECATED;
	public float PrerollTime_DEPRECATED;
	public float PostrollTime_DEPRECATED;
}
