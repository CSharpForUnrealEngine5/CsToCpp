#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineEditorBlueprintLibrary.h")]
public partial class UMoviePipelineEditorBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ExportConfigToAsset</summary>
	public static bool ExportConfigToAsset(UMoviePipelinePrimaryConfig InConfig,string InPackagePath,string InFileName,bool bInSaveAsset,UMoviePipelinePrimaryConfig OutAsset,string OutErrorReason) { return default; }
	///<summary>Checks to see if any of the Jobs try to point to maps that wouldn&#39;t be valid on a remote render (ie: unsaved maps)</summary>
	public static bool IsMapValidForRemoteRender(TArray<UMoviePipelineExecutorJob> InJobs) { return default; }
	///<summary>Pop a dialog box that specifies that they cannot render due to never saved map. Only shows OK button.</summary>
	public static void WarnUserOfUnsavedMap() {}
	///<summary>Take the specified Queue, duplicate it and write it to disk in the ../Saved/MovieRenderPipeline/ folder. Returns the duplicated queue.</summary>
	public static UMoviePipelineQueue SaveQueueToManifestFile(UMoviePipelineQueue InPipelineQueue,string OutManifestFilePath) { return default; }
	///<summary>Loads the specified manifest file and converts it into an FString to be embedded with HTTP REST requests. Use in combination with SaveQueueToManifestFile.</summary>
	public static string ConvertManifestFileToString(string InManifestFilePath) { return default; }
	///<summary>Create a job from a level sequence. Sets the map as the currently editor world, the author, the sequence and the job name as the sequence name on the new job. Returns the newly created job.</summary>
	public static UMoviePipelineExecutorJob CreateJobFromSequence(UMoviePipelineQueue InPipelineQueue,ULevelSequence InSequence) { return default; }
	///<summary>Ensure the job has the settings specified by the project settings added. If they&#39;re already added we don&#39;t modify the object so that we don&#39;t make it confused about whether or not you&#39;ve modified the preset.</summary>
	public static void EnsureJobHasDefaultSettings(UMoviePipelineExecutorJob InJob) {}
	///<summary>Resolves as much of the output directory for this job into a usable directory path as possible. Cannot resolve anything that relies on shot name, frame numbers, etc.</summary>
	public static string ResolveOutputDirectoryFromJob(UMoviePipelineExecutorJob InJob) { return default; }
}
