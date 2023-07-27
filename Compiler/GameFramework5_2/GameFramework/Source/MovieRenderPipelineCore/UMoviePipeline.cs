#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipeline.h")]
public partial class UMoviePipeline : UObject {
// MoviePipeline
	public  void Initialize(UMoviePipelineExecutorJob InJob) {}
	public  void RequestShutdown(bool bIsError/*=false*/) {}
	public  void Shutdown(bool bError/*=false*/) {}
	public  bool IsShutdownRequested() { return default; }
	public  FDateTime GetInitializationTime() { return default; }
	public  void SetInitializationTime(FDateTime InDateTime) {}
	public FMoviePipelineFinished OnMoviePipelineFinishedDelegate;
	public FMoviePipelineWorkFinished OnMoviePipelineWorkFinishedDelegate;
	public FMoviePipelineWorkFinished OnMoviePipelineShotWorkFinishedDelegate;
	public  UMoviePipelinePrimaryConfig GetPipelinePrimaryConfig() { return default; }
	public  UMoviePipelinePrimaryConfig GetPipelineMasterConfig() { return default; }
	public  UTexture GetPreviewTexture() { return default; }
	public  UMoviePipelineExecutorJob GetCurrentJob() { return default; }
	public  void OnMoviePipelineFinishedImpl() {}
	public UMoviePipelineCustomTimeStep CustomTimeStep;
	public UEngineCustomTimeStep CachedPrevCustomTimeStep;
	public ULevelSequence TargetSequence;
	public ALevelSequenceActor LevelSequenceActor;
	public UMovieRenderDebugWidget DebugWidget;
	public UTexture PreviewTexture;
	public UClass DebugWidgetClass;
	public UMoviePipelineExecutorJob CurrentJob;
}
