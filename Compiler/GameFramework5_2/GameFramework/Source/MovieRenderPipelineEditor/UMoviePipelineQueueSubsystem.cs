#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueueSubsystem.h")]
public partial class UMoviePipelineQueueSubsystem : UEditorSubsystem {
// MoviePipelineQueueSubsystem
	public  UMoviePipelineQueue GetQueue() { return default; }
	public  UMoviePipelineExecutorBase GetActiveExecutor() { return default; }
	public  UMoviePipelineExecutorBase RenderQueueWithExecutor(UClass InExecutorType) { return default; }
	public  void RenderQueueWithExecutorInstance(UMoviePipelineExecutorBase InExecutor) {}
	public  bool IsRendering() { return default; }
	public UMoviePipelineExecutorBase ActiveExecutor;
	public UMoviePipelineQueue CurrentQueue;
}
