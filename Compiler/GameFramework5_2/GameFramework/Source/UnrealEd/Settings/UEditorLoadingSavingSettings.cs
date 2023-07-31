#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Level Editor&#39;s loading and saving settings.</summary>
[CppInclude("Settings/EditorLoadingSavingSettings.h")]
public partial class UEditorLoadingSavingSettings : UObject {
	///<summary>Whether to load a default example map at startup</summary>
	public ELoadLevelAtStartup LoadLevelAtStartup;
	///<summary>Force project compilation at startup</summary>
	public bool bForceCompilationAtStartup;
	///<summary>Whether to restore previously open assets at startup</summary>
	public bool bRestoreOpenAssetTabsOnRestart;
	///<summary>bEnableSourceControlCompatabilityCheck_DEPRECATED</summary>
	public bool bEnableSourceControlCompatabilityCheck_DEPRECATED;
	///<summary>When enabled, changes to made to source content files inside the content directories will automatically be reflected in the content browser.</summary>
	public bool bMonitorContentDirectories;
	///<summary>AutoReimportDirectories_DEPRECATED</summary>
	public TArray<string> AutoReimportDirectories_DEPRECATED;
	///<summary>Lists every directory to monitor for content changes. Can be virtual package paths (eg /Game/ or /MyPlugin/), or absolute paths on disk.</summary>
	public TArray<FAutoReimportDirectoryConfig> AutoReimportDirectorySettings;
	///<summary>Specifies an amount of time to wait before a specific file change is considered for auto reimport</summary>
	public float AutoReimportThreshold;
	///<summary>When enabled, newly added source content files will be automatically imported into new assets.</summary>
	public bool bAutoCreateAssets;
	///<summary>When enabled, deleting a source content file will automatically prompt the deletion of any related assets.</summary>
	public bool bAutoDeleteAssets;
	///<summary>When enabled, changes to monitored directories since UE was closed will be detected on restart.</summary>
	public bool bDetectChangesOnStartup;
	///<summary>Whether to prompt the user to import detected changes.</summary>
	public bool bPromptBeforeAutoImporting;
	///<summary>Internal setting to control whether we should ask the user whether we should automatically delete source files when their assets are deleted</summary>
	public bool bDeleteSourceFilesWithAssets;
	///<summary>Deprecated properties - we automatically monitor all source file types that are supported by in memory factories now</summary>
	public bool bAutoReimportTextures_DEPRECATED;
	///<summary>bAutoReimportCSV_DEPRECATED</summary>
	public bool bAutoReimportCSV_DEPRECATED;
	///<summary>Whether to mark blueprints dirty if they are automatically migrated during loads</summary>
	public bool bDirtyMigratedBlueprints;
	///<summary>Whether to automatically save after a time interval</summary>
	public bool bAutoSaveEnable;
	///<summary>Whether to automatically save maps during an autosave</summary>
	public bool bAutoSaveMaps;
	///<summary>Whether to automatically save content packages during an autosave</summary>
	public bool bAutoSaveContent;
	///<summary>What method should be used when performing an autosave?</summary>
	public EAutoSaveMethod AutoSaveMethod;
	///<summary>The time interval after which to auto save</summary>
	public int AutoSaveTimeMinutes;
	///<summary>The minimum number of seconds to wait after the last user interactions (with the editor) before auto-save can trigger</summary>
	public int AutoSaveInteractionDelayInSeconds;
	///<summary>The number of seconds warning before an autosave</summary>
	public int AutoSaveWarningInSeconds;
	///<summary>How many auto save files to keep around</summary>
	public int AutoSaveMaxBackups;
	///<summary>Whether to automatically checkout on asset modification</summary>
	public bool bAutomaticallyCheckoutOnAssetModification;
	///<summary>Whether to automatically prompt for SCC checkout on asset modification</summary>
	public bool bPromptForCheckoutOnAssetModification;
	///<summary>Auto add files to source control</summary>
	public bool bSCCAutoAddNewFiles;
	///<summary>Use global source control login settings, rather than per-project. Changing this will require you to login again</summary>
	public bool bSCCUseGlobalSettings;
	///<summary>Specifies the file path to the tool to be used for diffing text files</summary>
	public FFilePath TextDiffToolPath;
}
