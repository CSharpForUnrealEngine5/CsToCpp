#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineBlueprintLibrary.h")]
public partial class UMoviePipelineBlueprintLibrary : UBlueprintFunctionLibrary {
// MoviePipelineBlueprintLibrary
	public UObject DuplicateSequence(UObject Outer,UObject InSequence) { return default; }
	public void ResolveFilenameFormatArguments(string InFormatString,FMoviePipelineFilenameResolveParams InParams,string OutFinalPath,FMoviePipelineFormatArgs OutMergedFormatArgs) {}
	public bool GetEstimatedTimeRemaining(UObject InPipeline,FTimespan OutEstimate) { return default; }
	public FDateTime GetJobInitializationTime(UObject InMoviePipeline) { return default; }
	public EMovieRenderPipelineState GetPipelineState(UObject InPipeline) { return default; }
	public EMovieRenderShotState GetCurrentSegmentState(UObject InMoviePipeline) { return default; }
	public string GetJobName(UObject InMoviePipeline) { return default; }
	public string GetJobAuthor(UObject InMoviePipeline) { return default; }
	public void GetOverallOutputFrames(UObject InMoviePipeline,int OutCurrentIndex,int OutTotalCount) {}
	public void GetCurrentSegmentName(UObject InMoviePipeline,string OutOuterName,string OutInnerName) {}
	public void GetOverallSegmentCounts(UObject InMoviePipeline,int OutCurrentIndex,int OutTotalCount) {}
	public FMoviePipelineSegmentWorkMetrics GetCurrentSegmentWorkMetrics(UObject InMoviePipeline) { return default; }
	public float GetCompletionPercentage(UObject InPipeline) { return default; }
	public FTimecode GetRootTimecode(UObject InMoviePipeline) { return default; }
	public FTimecode GetMasterTimecode(UObject InMoviePipeline) { return default; }
	public FFrameNumber GetRootFrameNumber(UObject InMoviePipeline) { return default; }
	public FFrameNumber GetMasterFrameNumber(UObject InMoviePipeline) { return default; }
	public FTimecode GetCurrentShotTimecode(UObject InMoviePipeline) { return default; }
	public FFrameNumber GetCurrentShotFrameNumber(UObject InMoviePipeline) { return default; }
	public float GetCurrentFocusDistance(UObject InMoviePipeline) { return default; }
	public float GetCurrentFocalLength(UObject InMoviePipeline) { return default; }
	public float GetCurrentAperture(UObject InMoviePipeline) { return default; }
	public string GetMapPackageName(UObject InJob) { return default; }
	public UObject LoadManifestFileFromString(string InManifestFilePath) { return default; }
	public void UpdateJobShotListFromSequence(UObject InSequence,UObject InJob,bool bShotsChanged) {}
	public int ResolveVersionNumber(FMoviePipelineFilenameResolveParams InParams,bool bGetNextVersion/*=true*/) { return default; }
	public FIntPoint GetEffectiveOutputResolution(UObject InPrimaryConfig,UObject InPipelineExecutorShot) { return default; }
	public UObject FindOrGetDefaultSettingForShot(UClass InSettingType,UObject InPrimaryConfig,UObject InShot) { return default; }
	public UObject GetCurrentSequence(UObject InMoviePipeline) { return default; }
	public UObject GetCurrentExecutorShot(UObject InMoviePipeline) { return default; }
	public string GetMoviePipelineEngineChangelistLabel(UObject InMoviePipeline) { return default; }
}
