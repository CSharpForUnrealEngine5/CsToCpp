namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains information about the to-disk output generated by a movie pipeline. This structure is used both for per-shot work finished</summary>
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineOutputData {
	public UMoviePipeline Pipeline;
	public UMoviePipelineExecutorJob Job;
	public bool bSuccess;
	public TArray<FMoviePipelineShotOutputData> ShotData;
}