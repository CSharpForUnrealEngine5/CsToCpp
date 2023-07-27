#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPathsLibrary.h")]
///<summary>Function library to expose FPaths to Blueprints and Python</summary>
public partial class UBlueprintPathsLibrary : UBlueprintFunctionLibrary {
// BlueprintPathsLibrary
	public static bool ShouldSaveToUserDir() { return default; }
	public static string LaunchDir() { return default; }
	public static string EngineDir() { return default; }
	public static string EngineUserDir() { return default; }
	public static string EngineVersionAgnosticUserDir() { return default; }
	public static string EngineContentDir() { return default; }
	public static string EngineConfigDir() { return default; }
	public static string EngineIntermediateDir() { return default; }
	public static string EngineSavedDir() { return default; }
	public static string EnginePluginsDir() { return default; }
	public static string EnterpriseDir() { return default; }
	public static string EnterprisePluginsDir() { return default; }
	public static string EnterpriseFeaturePackDir() { return default; }
	public static string RootDir() { return default; }
	public static string ProjectDir() { return default; }
	public static string ProjectUserDir() { return default; }
	public static string ProjectContentDir() { return default; }
	public static string ProjectConfigDir() { return default; }
	public static string ProjectSavedDir() { return default; }
	public static string ProjectIntermediateDir() { return default; }
	public static string ShaderWorkingDir() { return default; }
	public static string ProjectPluginsDir() { return default; }
	public static string ProjectModsDir() { return default; }
	public static bool HasProjectPersistentDownloadDir() { return default; }
	public static string ProjectPersistentDownloadDir() { return default; }
	public static string SourceConfigDir() { return default; }
	public static string GeneratedConfigDir() { return default; }
	public static string SandboxesDir() { return default; }
	public static string ProfilingDir() { return default; }
	public static string ScreenShotDir() { return default; }
	public static string BugItDir() { return default; }
	public static string VideoCaptureDir() { return default; }
	public static string ProjectLogDir() { return default; }
	public static string AutomationDir() { return default; }
	public static string AutomationTransientDir() { return default; }
	public static string AutomationLogDir() { return default; }
	public static string CloudDir() { return default; }
	public static string GameDevelopersDir() { return default; }
	public static string GameUserDeveloperDir() { return default; }
	public static string DiffDir() { return default; }
	public static TArray<string> GetEngineLocalizationPaths() { return default; }
	public static TArray<string> GetEditorLocalizationPaths() { return default; }
	public static TArray<string> GetPropertyNameLocalizationPaths() { return default; }
	public static TArray<string> GetToolTipLocalizationPaths() { return default; }
	public static TArray<string> GetGameLocalizationPaths() { return default; }
	public static TArray<string> GetRestrictedFolderNames() { return default; }
	public static bool IsRestrictedPath(string InPath) { return default; }
	public static string GameAgnosticSavedDir() { return default; }
	public static string EngineSourceDir() { return default; }
	public static string GameSourceDir() { return default; }
	public static string FeaturePackDir() { return default; }
	public static bool IsProjectFilePathSet() { return default; }
	public static string GetProjectFilePath() { return default; }
	public static void SetProjectFilePath(string NewGameProjectFilePath) {}
	public static string GetExtension(string InPath,bool bIncludeDot/*=false*/) { return default; }
	public static string GetCleanFilename(string InPath) { return default; }
	public static string GetBaseFilename(string InPath,bool bRemovePath/*=true*/) { return default; }
	public static string GetPath(string InPath) { return default; }
	public static string ChangeExtension(string InPath,string InNewExtension) { return default; }
	public static string SetExtension(string InPath,string InNewExtension) { return default; }
	public static bool FileExists(string InPath) { return default; }
	public static bool DirectoryExists(string InPath) { return default; }
	public static bool IsDrive(string InPath) { return default; }
	public static bool IsRelative(string InPath) { return default; }
	public static void NormalizeFilename(string InPath,string OutPath) {}
	public static bool IsSamePath(string PathA,string PathB) { return default; }
	public static void NormalizeDirectoryName(string InPath,string OutPath) {}
	public static bool CollapseRelativeDirectories(string InPath,string OutPath) { return default; }
	public static void RemoveDuplicateSlashes(string InPath,string OutPath) {}
	public static void MakeStandardFilename(string InPath,string OutPath) {}
	public static void MakePlatformFilename(string InPath,string OutPath) {}
	public static bool MakePathRelativeTo(string InPath,string InRelativeTo,string OutPath) { return default; }
	public static string ConvertRelativePathToFull(string InPath,string InBasePath/*=TEXT("")*/) { return default; }
	public static string ConvertToSandboxPath(string InPath,string InSandboxName) { return default; }
	public static string ConvertFromSandboxPath(string InPath,string InSandboxName) { return default; }
	public static string CreateTempFilename(string Path,string Prefix/*=TEXT("")*/,string Extension/*=TEXT(".tmp")*/) { return default; }
	public static string GetInvalidFileSystemChars() { return default; }
	public static string MakeValidFileName(string InString,string InReplacementChar/*=TEXT("")*/) { return default; }
	public static void ValidatePath(string InPath,bool bDidSucceed,string OutReason) {}
	public static void Split(string InPath,string PathPart,string FilenamePart,string ExtensionPart) {}
	public static string GetRelativePathToRoot() { return default; }
	public static string Combine(TArray<string> InPaths) { return default; }
}
