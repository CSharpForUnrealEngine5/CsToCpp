#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineEditorBlueprintLibrary.h")]
public partial class UMoviePipelineEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// MoviePipelineEditorBlueprintLibrary
	public bool ExportConfigToAsset(UObject InConfig,string InPackagePath,string InFileName,bool bInSaveAsset,UObject OutAsset,string OutErrorReason) { return default; }
	public bool IsMapValidForRemoteRender(TArray<UObject> InJobs) { return default; }
	public void WarnUserOfUnsavedMap() {}
	public UObject SaveQueueToManifestFile(UObject InPipelineQueue,string OutManifestFilePath) { return default; }
	public string ConvertManifestFileToString(string InManifestFilePath) { return default; }
	public UObject CreateJobFromSequence(UObject InPipelineQueue,UObject InSequence) { return default; }
	public void EnsureJobHasDefaultSettings(UObject InJob) {}
	public string ResolveOutputDirectoryFromJob(UObject InJob) { return default; }
}
