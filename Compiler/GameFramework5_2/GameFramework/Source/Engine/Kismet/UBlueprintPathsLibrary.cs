#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPathsLibrary.h")]
///<summary>Function library to expose FPaths to Blueprints and Python</summary>
public partial class UBlueprintPathsLibrary : UBlueprintFunctionLibrary {
// BlueprintPathsLibrary
	public bool ShouldSaveToUserDir() { return default; }
	public string LaunchDir() { return default; }
	public string EngineDir() { return default; }
	public string EngineUserDir() { return default; }
	public string EngineVersionAgnosticUserDir() { return default; }
	public string EngineContentDir() { return default; }
	public string EngineConfigDir() { return default; }
	public string EngineIntermediateDir() { return default; }
	public string EngineSavedDir() { return default; }
	public string EnginePluginsDir() { return default; }
	public string EnterpriseDir() { return default; }
	public string EnterprisePluginsDir() { return default; }
	public string EnterpriseFeaturePackDir() { return default; }
	public string RootDir() { return default; }
	public string ProjectDir() { return default; }
	public string ProjectUserDir() { return default; }
	public string ProjectContentDir() { return default; }
	public string ProjectConfigDir() { return default; }
	public string ProjectSavedDir() { return default; }
	public string ProjectIntermediateDir() { return default; }
	public string ShaderWorkingDir() { return default; }
	public string ProjectPluginsDir() { return default; }
	public string ProjectModsDir() { return default; }
	public bool HasProjectPersistentDownloadDir() { return default; }
	public string ProjectPersistentDownloadDir() { return default; }
	public string SourceConfigDir() { return default; }
	public string GeneratedConfigDir() { return default; }
	public string SandboxesDir() { return default; }
	public string ProfilingDir() { return default; }
	public string ScreenShotDir() { return default; }
	public string BugItDir() { return default; }
	public string VideoCaptureDir() { return default; }
	public string ProjectLogDir() { return default; }
	public string AutomationDir() { return default; }
	public string AutomationTransientDir() { return default; }
	public string AutomationLogDir() { return default; }
	public string CloudDir() { return default; }
	public string GameDevelopersDir() { return default; }
	public string GameUserDeveloperDir() { return default; }
	public string DiffDir() { return default; }
	public TArray<string> GetEngineLocalizationPaths() { return default; }
	public TArray<string> GetEditorLocalizationPaths() { return default; }
	public TArray<string> GetPropertyNameLocalizationPaths() { return default; }
	public TArray<string> GetToolTipLocalizationPaths() { return default; }
	public TArray<string> GetGameLocalizationPaths() { return default; }
	public TArray<string> GetRestrictedFolderNames() { return default; }
	public bool IsRestrictedPath(string InPath) { return default; }
	public string GameAgnosticSavedDir() { return default; }
	public string EngineSourceDir() { return default; }
	public string GameSourceDir() { return default; }
	public string FeaturePackDir() { return default; }
	public bool IsProjectFilePathSet() { return default; }
	public string GetProjectFilePath() { return default; }
	public void SetProjectFilePath(string NewGameProjectFilePath) {}
	public string GetExtension(string InPath,bool bIncludeDot/*=false*/) { return default; }
	public string GetCleanFilename(string InPath) { return default; }
	public string GetBaseFilename(string InPath,bool bRemovePath/*=true*/) { return default; }
	public string GetPath(string InPath) { return default; }
	public string ChangeExtension(string InPath,string InNewExtension) { return default; }
	public string SetExtension(string InPath,string InNewExtension) { return default; }
	public bool FileExists(string InPath) { return default; }
	public bool DirectoryExists(string InPath) { return default; }
	public bool IsDrive(string InPath) { return default; }
	public bool IsRelative(string InPath) { return default; }
	public void NormalizeFilename(string InPath,string OutPath) {}
	public bool IsSamePath(string PathA,string PathB) { return default; }
	public void NormalizeDirectoryName(string InPath,string OutPath) {}
	public bool CollapseRelativeDirectories(string InPath,string OutPath) { return default; }
	public void RemoveDuplicateSlashes(string InPath,string OutPath) {}
	public void MakeStandardFilename(string InPath,string OutPath) {}
	public void MakePlatformFilename(string InPath,string OutPath) {}
	public bool MakePathRelativeTo(string InPath,string InRelativeTo,string OutPath) { return default; }
	public string ConvertRelativePathToFull(string InPath,string InBasePath/*=TEXT("")*/) { return default; }
	public string ConvertToSandboxPath(string InPath,string InSandboxName) { return default; }
	public string ConvertFromSandboxPath(string InPath,string InSandboxName) { return default; }
	public string CreateTempFilename(string Path,string Prefix/*=TEXT("")*/,string Extension/*=TEXT(".tmp")*/) { return default; }
	public string GetInvalidFileSystemChars() { return default; }
	public string MakeValidFileName(string InString,string InReplacementChar/*=TEXT("")*/) { return default; }
	public void ValidatePath(string InPath,bool bDidSucceed,string OutReason) {}
	public void Split(string InPath,string PathPart,string FilenamePart,string ExtensionPart) {}
	public string GetRelativePathToRoot() { return default; }
	public string Combine(TArray<string> InPaths) { return default; }
}
