namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This data structure needs to be filled out each frame by the UMovieGraphTimeStepBase,</summary>
[CppInclude("Graph/MovieGraphTimeStepData.h")]
public partial struct FMovieGraphTimeStepData {
	public int OutputFrameNumber;
	public float FrameDeltaTime;
	public float WorldTimeDilation;
	public float WorldSeconds;
	public float MotionBlurFraction;
	public bool bIsFirstTemporalSampleForFrame;
	public bool bIsLastTemporalSampleForFrame;
	public bool bRequiresAccumulator;
	public UMovieGraphEvaluatedConfig EvaluatedConfig;
}
