#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorMiscSettings.h")]
///<summary>Configure miscellaneous settings for the Level Editor.</summary>
public partial class ULevelEditorMiscSettings : UDeveloperSettings {
// LevelEditorMiscSettings
	public bool bAutoApplyLightingEnable;
	public bool bBSPAutoUpdate;
	public bool bAutoMoveBSPPivotOffset;
	public bool bNavigationAutoUpdate;
	public bool bReplaceRespectsScale;
	public bool bAvoidRelabelOnPasteSelected;
	public bool bAllowBackgroundAudio;
	public bool bCreateNewAudioDeviceForPlayInEditor;
	public bool bEnableRealTimeAudio;
	public float EditorVolumeLevel;
	public bool bEnableEditorSounds;
	public UClass DefaultLevelStreamingClass;
	public bool bPromptWhenAddingToLevelBeforeCheckout;
	public bool bPromptWhenAddingToLevelOutsideBounds;
	public float PercentageThresholdForPrompt;
	public FVector MinimumBoundsForCheckingSize;
	public FDirectoryPath EditorScreenshotSaveDirectory;
}
