namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineShotOutputData {
	public TWeakObjectPtr<UMoviePipelineExecutorShot> Shot;
	public TMap<FMoviePipelinePassIdentifier,FMoviePipelineRenderPassOutputData> RenderPassData;
}
