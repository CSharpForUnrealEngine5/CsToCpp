#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineBlueprintLibrary.h")]
public partial class UMoviePipelineBlueprintLibrary : UBlueprintFunctionLibrary {
// MoviePipelineBlueprintLibrary
	public static UMovieSceneSequence DuplicateSequence(UObject Outer,UMovieSceneSequence InSequence) { return default; }
	public static void ResolveFilenameFormatArguments(string InFormatString,FMoviePipelineFilenameResolveParams InParams,string OutFinalPath,FMoviePipelineFormatArgs OutMergedFormatArgs) {}
	public static bool GetEstimatedTimeRemaining(UMoviePipeline InPipeline,FTimespan OutEstimate) { return default; }
	public static FDateTime GetJobInitializationTime(UMoviePipeline InMoviePipeline) { return default; }
	public static EMovieRenderPipelineState GetPipelineState(UMoviePipeline InPipeline) { return default; }
	public static EMovieRenderShotState GetCurrentSegmentState(UMoviePipeline InMoviePipeline) { return default; }
	public static string GetJobName(UMoviePipeline InMoviePipeline) { return default; }
	public static string GetJobAuthor(UMoviePipeline InMoviePipeline) { return default; }
	public static void GetOverallOutputFrames(UMoviePipeline InMoviePipeline,int OutCurrentIndex,int OutTotalCount) {}
	public static void GetCurrentSegmentName(UMoviePipeline InMoviePipeline,string OutOuterName,string OutInnerName) {}
	public static void GetOverallSegmentCounts(UMoviePipeline InMoviePipeline,int OutCurrentIndex,int OutTotalCount) {}
	public static FMoviePipelineSegmentWorkMetrics GetCurrentSegmentWorkMetrics(UMoviePipeline InMoviePipeline) { return default; }
	public static float GetCompletionPercentage(UMoviePipeline InPipeline) { return default; }
	public static FTimecode GetRootTimecode(UMoviePipeline InMoviePipeline) { return default; }
	public static FTimecode GetMasterTimecode(UMoviePipeline InMoviePipeline) { return default; }
	public static FFrameNumber GetRootFrameNumber(UMoviePipeline InMoviePipeline) { return default; }
	public static FFrameNumber GetMasterFrameNumber(UMoviePipeline InMoviePipeline) { return default; }
	public static FTimecode GetCurrentShotTimecode(UMoviePipeline InMoviePipeline) { return default; }
	public static FFrameNumber GetCurrentShotFrameNumber(UMoviePipeline InMoviePipeline) { return default; }
	public static float GetCurrentFocusDistance(UMoviePipeline InMoviePipeline) { return default; }
	public static float GetCurrentFocalLength(UMoviePipeline InMoviePipeline) { return default; }
	public static float GetCurrentAperture(UMoviePipeline InMoviePipeline) { return default; }
	public static string GetMapPackageName(UMoviePipelineExecutorJob InJob) { return default; }
	public static UMoviePipelineQueue LoadManifestFileFromString(string InManifestFilePath) { return default; }
	public static void UpdateJobShotListFromSequence(ULevelSequence InSequence,UMoviePipelineExecutorJob InJob,bool bShotsChanged) {}
	public static int ResolveVersionNumber(FMoviePipelineFilenameResolveParams InParams,bool bGetNextVersion/*=true*/) { return default; }
	public static FIntPoint GetEffectiveOutputResolution(UMoviePipelinePrimaryConfig InPrimaryConfig,UMoviePipelineExecutorShot InPipelineExecutorShot) { return default; }
	public static UMoviePipelineSetting FindOrGetDefaultSettingForShot(UClass InSettingType,UMoviePipelinePrimaryConfig InPrimaryConfig,UMoviePipelineExecutorShot InShot) { return default; }
	public static ULevelSequence GetCurrentSequence(UMoviePipeline InMoviePipeline) { return default; }
	public static UMoviePipelineExecutorShot GetCurrentExecutorShot(UMoviePipeline InMoviePipeline) { return default; }
	public static string GetMoviePipelineEngineChangelistLabel(UMoviePipeline InMoviePipeline) { return default; }
}
