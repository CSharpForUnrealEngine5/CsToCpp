#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineShotOutputData {
// MoviePipelineShotOutputData
	public TWeakObjectPtr<UMoviePipelineExecutorShot> Shot;
	public TMap<FMoviePipelinePassIdentifier,FMoviePipelineRenderPassOutputData> RenderPassData;
}
