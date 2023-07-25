#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueueEngineSubsystem.h")]
///<summary>This subsystem is intended for use when rendering in a shipping game (but can also be used in PIE</summary>
public partial class UMoviePipelineQueueEngineSubsystem : UEngineSubsystem {
// MoviePipelineQueueEngineSubsystem
	public UObject GetQueue() { return default; }
	public UObject GetActiveExecutor() { return default; }
	public UObject RenderQueueWithExecutor(UClass InExecutorType) { return default; }
	public void RenderQueueWithExecutorInstance(UObject InExecutor) {}
	public bool IsRendering() { return default; }
	public void SetConfiguration(UClass InProgressWidgetClass/*=nullptr*/,bool bRenderPlayerViewport/*=false*/) {}
	public UObject AllocateJob(UObject InSequence) { return default; }
	public void RenderJob(UObject InJob) {}
	public FMoviePipelineWorkFinished OnRenderFinished;
	public UMoviePipelineExecutorBase ActiveExecutor;
	public UMoviePipelineQueue CurrentQueue;
}
