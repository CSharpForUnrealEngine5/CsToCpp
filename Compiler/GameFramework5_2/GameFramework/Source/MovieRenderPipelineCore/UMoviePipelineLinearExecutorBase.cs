#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineLinearExecutor.h")]
///<summary>This is an abstract base class designed for executing an array of movie pipelines in linear</summary>
public partial class UMoviePipelineLinearExecutorBase : UMoviePipelineExecutorBase {
// MoviePipelineLinearExecutorBase
	public UMoviePipelineQueue Queue;
	public UMoviePipeline ActiveMoviePipeline;
}
