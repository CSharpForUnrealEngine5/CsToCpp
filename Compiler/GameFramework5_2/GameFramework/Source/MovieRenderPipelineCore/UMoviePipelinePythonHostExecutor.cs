#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelinePythonHostExecutor.h")]
///<summary>This is a dummy executor that is designed to host a executor implemented in</summary>
public partial class UMoviePipelinePythonHostExecutor : UMoviePipelineExecutorBase {
// MoviePipelinePythonHostExecutor
	public  void ExecuteDelayed(UMoviePipelineQueue InPipelineQueue) {}
	public  void OnMapLoad(UWorld InWorld) {}
	public  UWorld GetLastLoadedWorld() { return default; }
	public UClass ExecutorClass;
	public UMoviePipelineQueue PipelineQueue;
	public UWorld LastLoadedWorld;
}
