#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineEditorBlueprintLibrary.h")]
public partial class UMoviePipelineEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// MoviePipelineEditorBlueprintLibrary
	public static bool ExportConfigToAsset(UMoviePipelinePrimaryConfig InConfig,string InPackagePath,string InFileName,bool bInSaveAsset,UMoviePipelinePrimaryConfig OutAsset,string OutErrorReason) { return default; }
	public static bool IsMapValidForRemoteRender(TArray<UMoviePipelineExecutorJob> InJobs) { return default; }
	public static void WarnUserOfUnsavedMap() {}
	public static UMoviePipelineQueue SaveQueueToManifestFile(UMoviePipelineQueue InPipelineQueue,string OutManifestFilePath) { return default; }
	public static string ConvertManifestFileToString(string InManifestFilePath) { return default; }
	public static UMoviePipelineExecutorJob CreateJobFromSequence(UMoviePipelineQueue InPipelineQueue,ULevelSequence InSequence) { return default; }
	public static void EnsureJobHasDefaultSettings(UMoviePipelineExecutorJob InJob) {}
	public static string ResolveOutputDirectoryFromJob(UMoviePipelineExecutorJob InJob) { return default; }
}
