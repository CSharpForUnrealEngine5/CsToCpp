namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueueSubsystem.h")]
public partial class UMoviePipelineQueueSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the queue of Movie Pipelines that need to be rendered.</summary>
	public UMoviePipelineQueue GetQueue() { return default; }
	///<summary>Loads a new queue by copying it into the queue subsystem&#39;s current transient queue (the one returned by GetQueue()).</summary>
	public bool LoadQueue(UMoviePipelineQueue QueueToLoad,bool bPromptOnReplacingDirtyQueue/*=true*/) { return default; }
	///<summary>Returns true if the current queue has been modified since it was loaded, else returns false. Note that the empty</summary>
	public bool IsQueueDirty() { return default; }
	///<summary>Returns the active executor (if there is one). This can be used to subscribe to events on an already in-progress render. May be null.</summary>
	public UMoviePipelineExecutorBase GetActiveExecutor() { return default; }
	///<summary>Starts processing the current queue with the supplied executor class. This starts an async process which</summary>
	public UMoviePipelineExecutorBase RenderQueueWithExecutor(UClass InExecutorType) { return default; }
	///<summary>Starts processing the current queue with the supplied executor. This starts an async process which</summary>
	public void RenderQueueWithExecutorInstance(UMoviePipelineExecutorBase InExecutor) {}
	///<summary>Returns true if there is an active executor working on producing a movie. This could be actively rendering frames,</summary>
	public bool IsRendering() { return default; }
	///<summary>ActiveExecutor</summary>
	public UMoviePipelineExecutorBase ActiveExecutor;
	///<summary>CurrentQueue</summary>
	public UMoviePipelineQueue CurrentQueue;
}
