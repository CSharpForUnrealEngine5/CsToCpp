#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGridQueue.h")]
///<summary>This class is responsible for the movie pipeline part of the rendering of the given render grid job.</summary>
public partial class URenderGridMoviePipelineRenderJob : UObject {
// RenderGridMoviePipelineRenderJob
	public URenderGridJob RenderGridJob;
	public URenderGrid RenderGrid;
	public UMoviePipelineQueue PipelineQueue;
	public UMoviePipelineExecutorBase PipelineExecutor;
	public UMoviePipelineExecutorJob PipelineExecutorJob;
	public string Status;
	public bool bCanExecute;
	public bool bCanceled;
}
