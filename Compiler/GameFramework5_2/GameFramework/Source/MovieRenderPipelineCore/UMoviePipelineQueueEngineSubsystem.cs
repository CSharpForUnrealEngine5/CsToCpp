namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This subsystem is intended for use when rendering in a shipping game (but can also be used in PIE</summary>
[CppInclude("MoviePipelineQueueEngineSubsystem.h")]
public partial class UMoviePipelineQueueEngineSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the queue of Movie Pipelines that need to be rendered.</summary>
	public UMoviePipelineQueue GetQueue() { return default; }
	///<summary>Returns the active executor (if there is one). This can be used to subscribe to events on an already in-progress render. May be null.</summary>
	public UMoviePipelineExecutorBase GetActiveExecutor() { return default; }
	///<summary>Starts processing the current queue with the supplied executor class. This starts an async process which</summary>
	public UMoviePipelineExecutorBase RenderQueueWithExecutor(UClass InExecutorType) { return default; }
	///<summary>Starts processing the current queue with the supplied executor. This starts an async process which</summary>
	public void RenderQueueWithExecutorInstance(UMoviePipelineExecutorBase InExecutor) {}
	///<summary>Returns true if there is an active executor working on producing a movie. This could be actively rendering frames,</summary>
	public bool IsRendering() { return default; }
	///<summary>Sets some advanced configuration options that are used only occasionally to have better control over integrating it into</summary>
	public void SetConfiguration(UClass InProgressWidgetClass/*=nullptr*/,bool bRenderPlayerViewport/*=false*/) {}
	///<summary>Convenience function for creating a UMoviePipelineExecutorJob out of the given Level Sequence asset. The</summary>
	public UMoviePipelineExecutorJob AllocateJob(ULevelSequence InSequence) { return default; }
	///<summary>Convenience function for rendering the specified job. Calling this will render the specified job (if it was</summary>
	public void RenderJob(UMoviePipelineExecutorJob InJob) {}
	///<summary>Assign a function to this delegate to get notified when each individual job is finished.</summary>
	public FMoviePipelineWorkFinished OnRenderFinished;
	///<summary>ActiveExecutor</summary>
	public UMoviePipelineExecutorBase ActiveExecutor;
	///<summary>CurrentQueue</summary>
	public UMoviePipelineQueue CurrentQueue;
}
