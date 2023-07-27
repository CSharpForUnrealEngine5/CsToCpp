#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueueEngineSubsystem.h")]
///<summary>This subsystem is intended for use when rendering in a shipping game (but can also be used in PIE</summary>
public partial class UMoviePipelineQueueEngineSubsystem : UEngineSubsystem {
// MoviePipelineQueueEngineSubsystem
	public  UMoviePipelineQueue GetQueue() { return default; }
	public  UMoviePipelineExecutorBase GetActiveExecutor() { return default; }
	public  UMoviePipelineExecutorBase RenderQueueWithExecutor(UClass InExecutorType) { return default; }
	public  void RenderQueueWithExecutorInstance(UMoviePipelineExecutorBase InExecutor) {}
	public  bool IsRendering() { return default; }
	public  void SetConfiguration(UClass InProgressWidgetClass/*=nullptr*/,bool bRenderPlayerViewport/*=false*/) {}
	public  UMoviePipelineExecutorJob AllocateJob(ULevelSequence InSequence) { return default; }
	public  void RenderJob(UMoviePipelineExecutorJob InJob) {}
	public FMoviePipelineWorkFinished OnRenderFinished;
	public UMoviePipelineExecutorBase ActiveExecutor;
	public UMoviePipelineQueue CurrentQueue;
}
