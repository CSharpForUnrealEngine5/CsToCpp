#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineSegmentWorkMetrics {
	public string SegmentName;
	public int OutputFrameIndex;
	public int TotalOutputFrameCount;
	public int OutputSubSampleIndex;
	public int TotalSubSampleCount;
	public int EngineWarmUpFrameIndex;
	public int TotalEngineWarmUpFrameCount;
}
