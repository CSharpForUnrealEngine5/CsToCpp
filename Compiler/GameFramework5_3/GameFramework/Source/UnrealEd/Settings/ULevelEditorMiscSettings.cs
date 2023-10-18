namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configure miscellaneous settings for the Level Editor.</summary>
[CppInclude("Settings/LevelEditorMiscSettings.h")]
public partial class ULevelEditorMiscSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If checked lighting will be automatically applied to the level after a static lighting build is complete.</summary>
	public bool bAutoApplyLightingEnable;
	///<summary>If true, BSP will auto-update</summary>
	public bool bBSPAutoUpdate;
	///<summary>If true, the pivot offset for BSP will be automatically moved to stay centered on its vertices</summary>
	public bool bAutoMoveBSPPivotOffset;
	///<summary>If true, Navigation will auto-update</summary>
	public bool bNavigationAutoUpdate;
	///<summary>If enabled, replacing actors will respect the scale of the original actor.  Otherwise, the replaced actors will have a scale of 1.0</summary>
	public bool bReplaceRespectsScale;
	///<summary>If enabled, will avoid relabeling actors in UUnrealEdEngine::edactPasteSelected</summary>
	public bool bAvoidRelabelOnPasteSelected;
	///<summary>If enabled, will force checking references during a delete. Note: disabling this is for advanced usage only and not recommended.</summary>
	public bool bCheckReferencesOnDelete;
	///<summary>If checked audio playing in the editor will continue to play even if the editor is in the background</summary>
	public bool bAllowBackgroundAudio;
	///<summary>If checked, will create a new audio engine instance for the play-in-editor window. Otherwise, will re-use the audio device used in content browser.</summary>
	public bool bCreateNewAudioDeviceForPlayInEditor;
	///<summary>If true audio will be enabled in the editor. Does not affect PIE *</summary>
	public bool bEnableRealTimeAudio;
	///<summary>Global volume setting for the editor</summary>
	public float EditorVolumeLevel;
	///<summary>Enables audio feedback for certain operations in Unreal Editor, such as entering and exiting Play mode</summary>
	public bool bEnableEditorSounds;
	///<summary>The default level streaming class to use when adding new streaming levels</summary>
	public UClass DefaultLevelStreamingClass;
	///<summary>bPromptWhenAddingToLevelBeforeCheckout</summary>
	public bool bPromptWhenAddingToLevelBeforeCheckout;
	///<summary>bPromptWhenAddingToLevelOutsideBounds</summary>
	public bool bPromptWhenAddingToLevelOutsideBounds;
	///<summary>PercentageThresholdForPrompt</summary>
	public float PercentageThresholdForPrompt;
	///<summary>MinimumBoundsForCheckingSize</summary>
	public FVector MinimumBoundsForCheckingSize;
	///<summary>The save directory for newly created screenshots</summary>
	public FDirectoryPath EditorScreenshotSaveDirectory;
}
