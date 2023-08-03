#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library to expose FPaths to Blueprints and Python</summary>
[CppInclude("Kismet/BlueprintPathsLibrary.h")]
public partial class UBlueprintPathsLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Should the &quot;saved&quot; directory structures be rooted in the user dir or relative to the &quot;engine/game&quot;</summary>
	public static bool ShouldSaveToUserDir() { return default; }
	///<summary>Returns the directory the application was launched from (useful for commandline utilities)</summary>
	public static string LaunchDir() { return default; }
	///<summary>Returns the base directory of the &quot;core&quot; engine that can be shared across</summary>
	public static string EngineDir() { return default; }
	///<summary>Returns the root directory for user-specific engine files. Always writable.</summary>
	public static string EngineUserDir() { return default; }
	///<summary>Returns the root directory for user-specific engine files which can be shared between versions. Always writable.</summary>
	public static string EngineVersionAgnosticUserDir() { return default; }
	///<summary>Returns the content directory of the &quot;core&quot; engine that can be shared across</summary>
	public static string EngineContentDir() { return default; }
	///<summary>Returns the directory the root configuration files are located.</summary>
	public static string EngineConfigDir() { return default; }
	///<summary>Returns the intermediate directory of the engine</summary>
	public static string EngineIntermediateDir() { return default; }
	///<summary>Returns the saved directory of the engine</summary>
	public static string EngineSavedDir() { return default; }
	///<summary>Returns the plugins directory of the engine</summary>
	public static string EnginePluginsDir() { return default; }
	///<summary>Returns the base directory enterprise directory.</summary>
	public static string EnterpriseDir() { return default; }
	///<summary>Returns the enterprise plugins directory</summary>
	public static string EnterprisePluginsDir() { return default; }
	///<summary>Returns the enterprise FeaturePack directory</summary>
	public static string EnterpriseFeaturePackDir() { return default; }
	///<summary>Returns the root directory of the engine directory tree</summary>
	public static string RootDir() { return default; }
	///<summary>Returns the base directory of the current project by looking at FApp::GetProjectName().</summary>
	public static string ProjectDir() { return default; }
	///<summary>Returns the root directory for user-specific game files.</summary>
	public static string ProjectUserDir() { return default; }
	///<summary>Returns the content directory of the current game by looking at FApp::GetProjectName().</summary>
	public static string ProjectContentDir() { return default; }
	///<summary>Returns the directory the root configuration files are located.</summary>
	public static string ProjectConfigDir() { return default; }
	///<summary>Returns the saved directory of the current game by looking at FApp::GetProjectName().</summary>
	public static string ProjectSavedDir() { return default; }
	///<summary>Returns the intermediate directory of the current game by looking at FApp::GetProjectName().</summary>
	public static string ProjectIntermediateDir() { return default; }
	///<summary>Returns the Shader Working Directory</summary>
	public static string ShaderWorkingDir() { return default; }
	///<summary>Returns the plugins directory of the current game by looking at FApp::GetProjectName().</summary>
	public static string ProjectPluginsDir() { return default; }
	///<summary>Returns the mods directory of the current project by looking at FApp::GetProjectName().</summary>
	public static string ProjectModsDir() { return default; }
	///<summary>* Returns true if a writable directory for downloaded data that persists across play sessions is available</summary>
	public static bool HasProjectPersistentDownloadDir() { return default; }
	///<summary>* Returns the writable directory for downloaded data that persists across play sessions.</summary>
	public static string ProjectPersistentDownloadDir() { return default; }
	///<summary>Returns the directory the engine uses to look for the source leaf ini files. This</summary>
	public static string SourceConfigDir() { return default; }
	///<summary>Returns the directory the engine saves generated config files.</summary>
	public static string GeneratedConfigDir() { return default; }
	///<summary>Returns the directory the engine stores sandbox output</summary>
	public static string SandboxesDir() { return default; }
	///<summary>Returns the directory the engine uses to output profiling files.</summary>
	public static string ProfilingDir() { return default; }
	///<summary>Returns the directory the engine uses to output screenshot files.</summary>
	public static string ScreenShotDir() { return default; }
	///<summary>Returns the directory the engine uses to output BugIt files.</summary>
	public static string BugItDir() { return default; }
	///<summary>Returns the directory the engine uses to output user requested video capture files.</summary>
	public static string VideoCaptureDir() { return default; }
	///<summary>Returns the directory the engine uses to output logs. This currently can&#39;t</summary>
	public static string ProjectLogDir() { return default; }
	///<summary>Returns the directory for automation save files</summary>
	public static string AutomationDir() { return default; }
	///<summary>Returns the directory for automation save files that are meant to be deleted every run</summary>
	public static string AutomationTransientDir() { return default; }
	///<summary>Returns the directory for automation log files</summary>
	public static string AutomationLogDir() { return default; }
	///<summary>Returns the directory for local files used in cloud emulation or support</summary>
	public static string CloudDir() { return default; }
	///<summary>Returns the directory that contains subfolders for developer-specific content</summary>
	public static string GameDevelopersDir() { return default; }
	///<summary>Returns the directory that contains developer-specific content for the current user</summary>
	public static string GameUserDeveloperDir() { return default; }
	///<summary>Returns the directory for temp files used for diffing</summary>
	public static string DiffDir() { return default; }
	///<summary>Returns a list of engine-specific localization paths</summary>
	public static TArray<string> GetEngineLocalizationPaths() { return default; }
	///<summary>Returns a list of editor-specific localization paths</summary>
	public static TArray<string> GetEditorLocalizationPaths() { return default; }
	///<summary>Returns a list of property name localization paths</summary>
	public static TArray<string> GetPropertyNameLocalizationPaths() { return default; }
	///<summary>Returns a list of tool tip localization paths</summary>
	public static TArray<string> GetToolTipLocalizationPaths() { return default; }
	///<summary>Returns a list of game-specific localization paths</summary>
	public static TArray<string> GetGameLocalizationPaths() { return default; }
	///<summary>Returns a list of restricted/internal folder names (without any slashes) which may be tested against full paths to determine if a path is restricted or not.</summary>
	public static TArray<string> GetRestrictedFolderNames() { return default; }
	///<summary>Determines if supplied path uses a restricted/internal subdirectory.  Note that slashes are normalized and character case is ignored for the comparison.</summary>
	public static bool IsRestrictedPath(string InPath) { return default; }
	///<summary>Returns the saved directory that is not game specific. This is usually the same as</summary>
	public static string GameAgnosticSavedDir() { return default; }
	///<summary>Returns the directory where engine source code files are kept</summary>
	public static string EngineSourceDir() { return default; }
	///<summary>Returns the directory where game source code files are kept</summary>
	public static string GameSourceDir() { return default; }
	///<summary>Returns the directory where feature packs are kept</summary>
	public static string FeaturePackDir() { return default; }
	///<summary>Checks whether the path to the project file, if any, is set.</summary>
	public static bool IsProjectFilePathSet() { return default; }
	///<summary>Gets the path to the project file.</summary>
	public static string GetProjectFilePath() { return default; }
	///<summary>Sets the path to the project file.</summary>
	public static void SetProjectFilePath(string NewGameProjectFilePath) {}
	///<summary>Gets the extension for this filename.</summary>
	public static string GetExtension(string InPath,bool bIncludeDot/*=false*/) { return default; }
	///<summary>Returns the filename (with extension), minus any path information.</summary>
	public static string GetCleanFilename(string InPath) { return default; }
	///<summary>Returns the same thing as GetCleanFilename, but without the extension</summary>
	public static string GetBaseFilename(string InPath,bool bRemovePath/*=true*/) { return default; }
	///<summary>Returns the path in front of the filename</summary>
	public static string GetPath(string InPath) { return default; }
	///<summary>Changes the extension of the given filename (does nothing if the file has no extension)</summary>
	public static string ChangeExtension(string InPath,string InNewExtension) { return default; }
	///<summary>Sets the extension of the given filename (like ChangeExtension, but also applies the extension if the file doesn&#39;t have one)</summary>
	public static string SetExtension(string InPath,string InNewExtension) { return default; }
	///<summary>Returns true if this file was found, false otherwise</summary>
	public static bool FileExists(string InPath) { return default; }
	///<summary>Returns true if this directory was found, false otherwise</summary>
	public static bool DirectoryExists(string InPath) { return default; }
	///<summary>Returns true if this path represents a root drive or volume</summary>
	public static bool IsDrive(string InPath) { return default; }
	///<summary>Returns true if this path is relative to another path</summary>
	public static bool IsRelative(string InPath) { return default; }
	///<summary>Convert all / and \ to TEXT(&quot;/&quot;)</summary>
	public static void NormalizeFilename(string InPath,string OutPath) {}
	///<summary>Checks if two paths are the same.</summary>
	public static bool IsSamePath(string PathA,string PathB) { return default; }
	///<summary>Normalize all / and \ to TEXT(&quot;/&quot;) and remove any trailing TEXT(&quot;/&quot;) if the character before that is not a TEXT(&quot;/&quot;) or a colon</summary>
	public static void NormalizeDirectoryName(string InPath,string OutPath) {}
	///<summary>Takes a fully pathed string and eliminates relative pathing (eg: annihilates &quot;..&quot; with the adjacent directory).</summary>
	public static bool CollapseRelativeDirectories(string InPath,string OutPath) { return default; }
	///<summary>Removes duplicate slashes in paths.</summary>
	public static void RemoveDuplicateSlashes(string InPath,string OutPath) {}
	///<summary>Make fully standard &quot;Unreal&quot; pathname:</summary>
	public static void MakeStandardFilename(string InPath,string OutPath) {}
	///<summary>Takes an &quot;Unreal&quot; pathname and converts it to a platform filename.</summary>
	public static void MakePlatformFilename(string InPath,string OutPath) {}
	///<summary>Assuming both paths (or filenames) are relative to the same base dir, converts InPath to be relative to InRelativeTo</summary>
	public static bool MakePathRelativeTo(string InPath,string InRelativeTo,string OutPath) { return default; }
	///<summary>Converts a relative path name to a fully qualified name relative to the specified BasePath.</summary>
	public static string ConvertRelativePathToFull(string InPath,string InBasePath/*=TEXT("")*/) { return default; }
	///<summary>Converts a normal path to a sandbox path (in Saved/Sandboxes).</summary>
	public static string ConvertToSandboxPath(string InPath,string InSandboxName) { return default; }
	///<summary>Converts a sandbox (in Saved/Sandboxes) path to a normal path.</summary>
	public static string ConvertFromSandboxPath(string InPath,string InSandboxName) { return default; }
	///<summary>Creates a temporary filename with the specified prefix.</summary>
	public static string CreateTempFilename(string Path,string Prefix/*=TEXT("")*/,string Extension/*=TEXT(".tmp")*/) { return default; }
	///<summary>Returns a string containing all invalid characters as dictated by the operating system</summary>
	public static string GetInvalidFileSystemChars() { return default; }
	///<summary>Returns a string that is safe to use as a filename because all items in</summary>
	public static string MakeValidFileName(string InString,string InReplacementChar/*=TEXT("")*/) { return default; }
	///<summary>Validates that the parts that make up the path contain no invalid characters as dictated by the operating system</summary>
	public static void ValidatePath(string InPath,bool bDidSucceed,string OutReason) {}
	///<summary>Parses a fully qualified or relative filename into its components (filename, path, extension).</summary>
	public static void Split(string InPath,string PathPart,string FilenamePart,string ExtensionPart) {}
	///<summary>Gets the relative path to get from BaseDir to RootDirectory</summary>
	public static string GetRelativePathToRoot() { return default; }
	///<summary>Combine two or more Paths into one single Path</summary>
	public static string Combine(TArray<string> InPaths) { return default; }
}
