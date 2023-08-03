#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineBlueprintLibrary.h")]
public partial class UMoviePipelineBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Duplicates the specified sequence using a medium depth copy. Standard duplication will only duplicate</summary>
	public static UMovieSceneSequence DuplicateSequence(UObject Outer,UMovieSceneSequence InSequence) { return default; }
	///<summary>Resolves the provided InFormatString by converting {format_strings} into settings provided by the primary config.</summary>
	public static void ResolveFilenameFormatArguments(string InFormatString,FMoviePipelineFilenameResolveParams InParams,string OutFinalPath,FMoviePipelineFormatArgs OutMergedFormatArgs) {}
	///<summary>Get the estimated amount of time remaining for the current pipeline. Based on looking at the total</summary>
	public static bool GetEstimatedTimeRemaining(UMoviePipeline InPipeline,FTimespan OutEstimate) { return default; }
	///<summary>GetJobInitializationTime</summary>
	public static FDateTime GetJobInitializationTime(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>Get the current state of the specified Pipeline. See EMovieRenderPipelineState for more detail about each state.</summary>
	public static EMovieRenderPipelineState GetPipelineState(UMoviePipeline InPipeline) { return default; }
	///<summary>GetCurrentSegmentState</summary>
	public static EMovieRenderShotState GetCurrentSegmentState(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetJobName</summary>
	public static string GetJobName(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetJobAuthor</summary>
	public static string GetJobAuthor(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetOverallOutputFrames</summary>
	public static void GetOverallOutputFrames(UMoviePipeline InMoviePipeline,int OutCurrentIndex,int OutTotalCount) {}
	///<summary>GetCurrentSegmentName</summary>
	public static void GetCurrentSegmentName(UMoviePipeline InMoviePipeline,string OutOuterName,string OutInnerName) {}
	///<summary>GetOverallSegmentCounts</summary>
	public static void GetOverallSegmentCounts(UMoviePipeline InMoviePipeline,int OutCurrentIndex,int OutTotalCount) {}
	///<summary>GetCurrentSegmentWorkMetrics</summary>
	public static FMoviePipelineSegmentWorkMetrics GetCurrentSegmentWorkMetrics(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>Gets the completion percent of the Pipeline in 0-1</summary>
	public static float GetCompletionPercentage(UMoviePipeline InPipeline) { return default; }
	///<summary>GetRootTimecode</summary>
	public static FTimecode GetRootTimecode(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetMasterTimecode</summary>
	public static FTimecode GetMasterTimecode(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetRootFrameNumber</summary>
	public static FFrameNumber GetRootFrameNumber(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetMasterFrameNumber</summary>
	public static FFrameNumber GetMasterFrameNumber(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetCurrentShotTimecode</summary>
	public static FTimecode GetCurrentShotTimecode(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetCurrentShotFrameNumber</summary>
	public static FFrameNumber GetCurrentShotFrameNumber(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetCurrentFocusDistance</summary>
	public static float GetCurrentFocusDistance(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetCurrentFocalLength</summary>
	public static float GetCurrentFocalLength(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetCurrentAperture</summary>
	public static float GetCurrentAperture(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>Get the package name for the map in this job. The level travel command requires the package path and not the asset path.</summary>
	public static string GetMapPackageName(UMoviePipelineExecutorJob InJob) { return default; }
	///<summary>Loads the specified manifest file and converts it into an UMoviePipelineQueue. Use in combination with SaveQueueToManifestFile.</summary>
	public static UMoviePipelineQueue LoadManifestFileFromString(string InManifestFilePath) { return default; }
	///<summary>Scan the provided sequence in the job to see which camera cut sections we would try to render and update the job&#39;s shotlist.</summary>
	public static void UpdateJobShotListFromSequence(ULevelSequence InSequence,UMoviePipelineExecutorJob InJob,bool bShotsChanged) {}
	///<summary>If version number is manually specified by the Job, returns that. Otherwise search the Output Directory for the highest version already existing (and increment it by one if bGetNextVersion is true).</summary>
	public static int ResolveVersionNumber(FMoviePipelineFilenameResolveParams InParams,bool bGetNextVersion/*=true*/) { return default; }
	///<summary>In case of Overscan percentage being higher than 0 we render additional pixels. This function returns the resolution with overscan taken into account.</summary>
	public static FIntPoint GetEffectiveOutputResolution(UMoviePipelinePrimaryConfig InPrimaryConfig,UMoviePipelineExecutorShot InPipelineExecutorShot) { return default; }
	///<summary>Allows access to a setting of provided type for specific shot.</summary>
	public static UMoviePipelineSetting FindOrGetDefaultSettingForShot(UClass InSettingType,UMoviePipelinePrimaryConfig InPrimaryConfig,UMoviePipelineExecutorShot InShot) { return default; }
	///<summary>GetCurrentSequence</summary>
	public static ULevelSequence GetCurrentSequence(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>GetCurrentExecutorShot</summary>
	public static UMoviePipelineExecutorShot GetCurrentExecutorShot(UMoviePipeline InMoviePipeline) { return default; }
	///<summary>Get a string to represent the Changelist Number for the burn in. This can be driven by a Modular Feature if you want to permanently replace it with different information.</summary>
	public static string GetMoviePipelineEngineChangelistLabel(UMoviePipeline InMoviePipeline) { return default; }
}
