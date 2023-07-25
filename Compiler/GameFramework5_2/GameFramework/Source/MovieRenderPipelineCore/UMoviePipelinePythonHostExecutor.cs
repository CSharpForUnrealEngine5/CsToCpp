#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelinePythonHostExecutor.h")]
///<summary>This is a dummy executor that is designed to host a executor implemented in</summary>
public partial class UMoviePipelinePythonHostExecutor : UMoviePipelineExecutorBase {
// MoviePipelinePythonHostExecutor
	public void ExecuteDelayed(UObject InPipelineQueue) {}
	public void OnMapLoad(UObject InWorld) {}
	public UObject GetLastLoadedWorld() { return default; }
	public UClass ExecutorClass;
	public UMoviePipelineQueue PipelineQueue;
	public UWorld LastLoadedWorld;
}
