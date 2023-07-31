#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipeline.h")]
public partial class UMoviePipeline : UObject {
	///<summary>Initialize the movie pipeline with the specified settings. This kicks off the rendering process.</summary>
	public  void Initialize(UMoviePipelineExecutorJob InJob) {}
	///<summary>Request the movie pipeline to shut down at the next available time. The pipeline will attempt to abandon</summary>
	public  void RequestShutdown(bool bIsError/*=false*/) {}
	///<summary>Abandons any future work on this Movie Pipeline and runs through the shutdown flow to ensure already</summary>
	public  void Shutdown(bool bError/*=false*/) {}
	///<summary>Has RequestShutdown() been called?</summary>
	public  bool IsShutdownRequested() { return default; }
	///<summary>Returns the time this movie pipeline was initialized at.</summary>
	public  FDateTime GetInitializationTime() { return default; }
	///<summary>Override the time this movie pipeline was initialized at. This can be used for render farms</summary>
	public  void SetInitializationTime(FDateTime InDateTime) {}
	///<summary>OnMoviePipelineFinishedDelegate</summary>
	public FMoviePipelineFinished OnMoviePipelineFinishedDelegate;
	///<summary>Called when we have completely finished this pipeline. This means that all frames have been rendered,</summary>
	public FMoviePipelineWorkFinished OnMoviePipelineWorkFinishedDelegate;
	///<summary>Only called if `IsFlushDiskWritesPerShot()` is set!</summary>
	public FMoviePipelineWorkFinished OnMoviePipelineShotWorkFinishedDelegate;
	///<summary>Get the Primary Configuration used to render this shot. This contains the global settings for the shot, as well as per-shot</summary>
	public  UMoviePipelinePrimaryConfig GetPipelinePrimaryConfig() { return default; }
	///<summary>GetPipelineMasterConfig</summary>
	public  UMoviePipelinePrimaryConfig GetPipelineMasterConfig() { return default; }
	///<summary>GetPreviewTexture</summary>
	public  UTexture GetPreviewTexture() { return default; }
	///<summary>GetCurrentJob</summary>
	public  UMoviePipelineExecutorJob GetCurrentJob() { return default; }
	///<summary>This function should be called by the Executor when execution has finished (this should still be called in the event of an error)</summary>
	public  void OnMoviePipelineFinishedImpl() {}
	///<summary>Custom TimeStep used to drive the engine while rendering.</summary>
	public UMoviePipelineCustomTimeStep CustomTimeStep;
	///<summary>Hold a reference to the existing custom time step (if any) so we can restore it after we&#39;re done using our custom one.</summary>
	public UEngineCustomTimeStep CachedPrevCustomTimeStep;
	///<summary>This is our duplicated sequence that we&#39;re rendering. This will get modified throughout the rendering process.</summary>
	public ULevelSequence TargetSequence;
	///<summary>The Level Sequence Actor we spawned to play our TargetSequence.</summary>
	public ALevelSequenceActor LevelSequenceActor;
	///<summary>The Debug UI Widget that is spawned and placed on the player UI</summary>
	public UMovieRenderDebugWidget DebugWidget;
	///<summary>PreviewTexture</summary>
	public UTexture PreviewTexture;
	///<summary>DebugWidgetClass</summary>
	public UClass DebugWidgetClass;
	///<summary>Keep track of which job we&#39;re working on. This holds our Configuration + which shots we&#39;re supposed to render from it.</summary>
	public UMoviePipelineExecutorJob CurrentJob;
}
