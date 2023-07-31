#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineShotOutputData {
	public TWeakObjectPtr<UMoviePipelineExecutorShot> Shot;
	public TMap<FMoviePipelinePassIdentifier,FMoviePipelineRenderPassOutputData> RenderPassData;
}
