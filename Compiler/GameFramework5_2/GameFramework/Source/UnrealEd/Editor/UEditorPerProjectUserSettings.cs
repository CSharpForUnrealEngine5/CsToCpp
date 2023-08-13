namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/EditorPerProjectUserSettings.h")]
public partial class UEditorPerProjectUserSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, any newly opened UI menus, menu bars, and toolbars will show the developer hooks that would accept extensions</summary>
	public bool bDisplayUIExtensionPoints;
	///<summary>If enabled, tooltips linked to documentation will show the developer the link bound to that UI item</summary>
	public bool bDisplayDocumentationLink;
	///<summary>, Category=DeveloperTools</summary>
	public bool bDisplayActionListItemRefIds;
	///<summary>If enabled, behavior tree debugger will collect its data even when all behavior tree editor windows are closed</summary>
	public bool bAlwaysGatherBehaviorTreeDebuggerData;
	///<summary>If enabled, blackboard keys displayed in blackboard editor and key selector will be sorted in alphabetical order .</summary>
	public bool bDisplayBlackboardKeysInAlphabeticalOrder;
	///<summary>When enabled, Engine Version Number is displayed in the ProjectBadge</summary>
	public bool bDisplayEngineVersionInBadge;
	///<summary>When enabled, use SimplygonSwarm Module / server to create proxies</summary>
	public bool bUseSimplygonSwarm;
	///<summary>Server IP for the distributed Simplygon server</summary>
	public string SimplygonServerIP;
	///<summary>Enable swarm debugging features. Temp ssf files are not removed. Detailed message printing</summary>
	public bool bEnableSwarmDebugging;
	///<summary>Time between JSON net requests for Simplygon Swarm</summary>
	public uint SimplygonSwarmDelay;
	///<summary>Number of concurrent swarm jobs to execute. This is independent of the main job queue.</summary>
	public uint SwarmNumOfConcurrentJobs;
	///<summary>SwarmMaxUploadChunkSizeInMB</summary>
	public uint SwarmMaxUploadChunkSizeInMB;
	///<summary>Folder in which Simplygon Swarm will store intermediate texture and mesh data that is uploaded to the Swarm</summary>
	public string SwarmIntermediateFolder;
	///<summary>If enabled, any newly added classes will be automatically compiled and trigger a hot-reload of the module they were added to</summary>
	public bool bAutomaticallyHotReloadNewClasses;
	///<summary>If enabled, the compile message log window will open if there is a compiler error on Hot Reload</summary>
	public bool bShowCompilerLogOnCompileError;
	///<summary>If enabled, the fbx parser will keep the fbx namespaces, otherwise the namespace will be append to fbx node.</summary>
	public bool bKeepFbxNamespace;
	///<summary>If enabled, the fbx option dialog will show when user re-import a fbx</summary>
	public bool bShowImportDialogAtReimport;
	///<summary>Specify a project data source folder to store relative source file path to ease the re-import process</summary>
	public FDirectoryPath DataSourceFolder;
	///<summary>If enabled, export level with attachment hierarchy set</summary>
	public bool bKeepAttachHierarchy;
	///<summary>If enabled, will compare an animation&#39;s sequence length and curves against the old data and inform the user if something changed</summary>
	public bool bAnimationReimportWarnings;
	///<summary>Select to make Distributions use the curves, not the baked lookup tables.</summary>
	public bool bUseCurvesForDistributions;
	///<summary>Controls the minimum value at which the property matrix editor will display a loading bar when pasting values</summary>
	public int PropertyMatrix_NumberOfPasteOperationsBeforeWarning;
	///<summary>bSCSEditorShowGrid</summary>
	public bool bSCSEditorShowGrid;
	///<summary>bSCSEditorShowFloor</summary>
	public bool bSCSEditorShowFloor;
	///<summary>If enabled, the Editor will attempt to get the users attention whenever a UAT task (such as cooking or packaging) is completed</summary>
	public bool bGetAttentionOnUATCompletion;
	///<summary>Always build UAT\UBT before launching the game. It will decrease iteration times if disabled</summary>
	public bool bAlwaysBuildUAT;
	///<summary>How fast the SCS viewport camera moves</summary>
	public int SCSViewportCameraSpeed;
	///<summary>Controls whether packages which are checked-out are automatically fully loaded at startup</summary>
	public bool bAutoloadCheckedOutPackages;
	///<summary>If this is true, the user will not be asked to fully load a package before saving or before creating a new object</summary>
	public bool bSuppressFullyLoadPrompt;
	///<summary>True if user should be allowed to select translucent objects in perspective viewports</summary>
	public bool bAllowSelectTranslucent;
	///<summary>If this is true, all of an actors&#39; components will be drawn when the actor or one of its component is selected</summary>
	public bool bShowSelectionSubcomponents;
	///<summary>BlueprintFavorites</summary>
	public UBlueprintPaletteFavorites BlueprintFavorites;
	///<summary>Per project user settings for which asset viewer profile should be used</summary>
	public int AssetViewerProfileIndex;
	///<summary>AssetViewerProfileName</summary>
	public string AssetViewerProfileName;
	///<summary>The feature level we should use when loading or creating a new world</summary>
	public int PreviewFeatureLevel;
	///<summary>The platform name to preview, or NAME_None if there is no preview platform</summary>
	public string PreviewPlatformName;
	///<summary>The shader format to preview, or NAME_None if there is no preview platform</summary>
	public string PreviewShaderFormatName;
	///<summary>The shader platform to preview, or NAME_None if there is no preview platform</summary>
	public string PreviewShaderPlatformName;
	///<summary>Is feature level preview currently active</summary>
	public bool bPreviewFeatureLevelActive;
	///<summary>bPreviewFeatureLevelWasDefault</summary>
	public bool bPreviewFeatureLevelWasDefault;
	///<summary>PreviewDeviceProfileName</summary>
	public string PreviewDeviceProfileName;
}
