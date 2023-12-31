namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is an abstract base class designed for executing an array of movie pipelines in linear</summary>
[CppInclude("MoviePipelineLinearExecutor.h")]
public partial class UMoviePipelineLinearExecutorBase : UMoviePipelineExecutorBase {
	public static UClass StaticClass() {return default;}
	///<summary>List of Pipeline Configs we&#39;ve been asked to execute.</summary>
	public UMoviePipelineQueue Queue;
	///<summary>A Movie Pipeline that has been spawned and is running (if any)</summary>
	public UMoviePipelineBase ActiveMoviePipeline;
}
