#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorLoadingSavingSettings.h")]
///<summary>Implements the Level Editor's loading and saving settings.</summary>
public partial class UEditorLoadingSavingSettings : UObject {
// EditorLoadingSavingSettings
	public ELoadLevelAtStartup LoadLevelAtStartup;
	public bool bForceCompilationAtStartup;
	public bool bRestoreOpenAssetTabsOnRestart;
	public bool bEnableSourceControlCompatabilityCheck_DEPRECATED;
	public bool bMonitorContentDirectories;
	public TArray<string> AutoReimportDirectories_DEPRECATED;
	public TArray<FAutoReimportDirectoryConfig> AutoReimportDirectorySettings;
	public float AutoReimportThreshold;
	public bool bAutoCreateAssets;
	public bool bAutoDeleteAssets;
	public bool bDetectChangesOnStartup;
	public bool bPromptBeforeAutoImporting;
	public bool bDeleteSourceFilesWithAssets;
	public bool bAutoReimportTextures_DEPRECATED;
	public bool bAutoReimportCSV_DEPRECATED;
	public bool bDirtyMigratedBlueprints;
	public bool bAutoSaveEnable;
	public bool bAutoSaveMaps;
	public bool bAutoSaveContent;
	public EAutoSaveMethod AutoSaveMethod;
	public int AutoSaveTimeMinutes;
	public int AutoSaveInteractionDelayInSeconds;
	public int AutoSaveWarningInSeconds;
	public int AutoSaveMaxBackups;
	public bool bAutomaticallyCheckoutOnAssetModification;
	public bool bPromptForCheckoutOnAssetModification;
	public bool bSCCAutoAddNewFiles;
	public bool bSCCUseGlobalSettings;
	public FFilePath TextDiffToolPath;
}
