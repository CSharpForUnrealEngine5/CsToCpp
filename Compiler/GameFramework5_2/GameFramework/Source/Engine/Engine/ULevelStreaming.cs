#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class of container object encapsulating data required for streaming and providing</summary>
[CppInclude("Engine/LevelStreaming.h")]
public partial class ULevelStreaming : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Deprecated name of the package containing the level to load. Use GetWorldAsset() or GetWorldAssetPackageFName() instead.</summary>
	public string PackageName_DEPRECATED;
	///<summary>The reference to the world containing the level to load</summary>
	public TSoftObjectPtr<UWorld> WorldAsset;
	///<summary>The relative priority of considering the streaming level. Changing the priority will not interrupt the currently considered level, but will affect the next time a level is being selected for evaluation.</summary>
	public int StreamingPriority;
	///<summary>If this isn&#39;t Name_None, then we load from this package on disk to the new package named PackageName</summary>
	public string PackageNameToLoad;
	///<summary>LOD versions of this level</summary>
	public TArray<string> LODPackageNames;
	///<summary>Transform applied to actors after loading.</summary>
	public FTransform LevelTransform;
	///<summary>Applied to LoadedLevel</summary>
	public bool bClientOnlyVisible;
	///<summary>Requested LOD. Non LOD sub-levels have Index = -1</summary>
	public int LevelLODIndex;
	///<summary>Whether this level should be visible in the Editor</summary>
	public bool bShouldBeVisibleInEditor;
	///<summary>Whether the level should be visible if it is loaded</summary>
	public bool bShouldBeVisible;
	///<summary>Whether the level should be loaded</summary>
	public bool bShouldBeLoaded;
	///<summary>Whether this level is locked; that is, its actors are read-only.</summary>
	public bool bLocked;
	///<summary>Whether this level only contains static actors that aren&#39;t affected by gameplay or replication.</summary>
	public bool bIsStatic;
	///<summary>Whether we want to force a blocking load</summary>
	public bool bShouldBlockOnLoad;
	///<summary>Whether we want to force a blocking unload</summary>
	public bool bShouldBlockOnUnload;
	///<summary>Whether this level streaming object should be ignored by world composition distance streaming,</summary>
	public bool bDisableDistanceStreaming;
	///<summary>If true, will be drawn on the &#39;level streaming status&#39; map (STAT LEVELMAP console command)</summary>
	public bool bDrawOnLevelStatusMap;
	///<summary>Deprecated level color used for visualization.</summary>
	public FColor DrawColor_DEPRECATED;
	///<summary>The level color used for visualization. (Show -&gt; Advanced -&gt; Level Coloration)</summary>
	public FLinearColor LevelColor;
	///<summary>The level streaming volumes bound to this level.</summary>
	public TArray<ALevelStreamingVolume> EditorStreamingVolumes;
	///<summary>Cooldown time in seconds between volume-based unload requests.  Used in preventing spurious unload requests.</summary>
	public float MinTimeBetweenVolumeUnloadRequests;
	///<summary>List of keywords to filter on in the level browser</summary>
	public TArray<string> Keywords;
	///<summary>Sets the should be visible flag and marks the streaming level as requiring consideration.</summary>
	public  void SetShouldBeVisible(bool bInShouldBeVisible) {}
	///<summary>Virtual that can be overridden to change whether a streaming level should be loaded.</summary>
	public  void SetShouldBeLoaded(bool bInShouldBeLoaded) {}
	///<summary>Sets the world composition level LOD index and marks the streaming level as requiring consideration.</summary>
	public  void SetLevelLODIndex(int LODIndex) {}
	///<summary>Sets the relative priority of considering the streaming level. Changing the priority will not interrupt the currently considered level, but will affect the next time a level is being selected for evaluation.</summary>
	public  void SetPriority(int NewPriority) {}
	///<summary>Returns if the streaming level has requested to be unloaded and removed.</summary>
	public  bool GetIsRequestingUnloadAndRemoval() { return default; }
	///<summary>Sets if the streaming level should be unloaded and removed.</summary>
	public  void SetIsRequestingUnloadAndRemoval(bool bInIsRequestingUnloadAndRemoval) {}
	///<summary>Gets the package name for the world asset referred to by this level streaming as an FName</summary>
	public  string GetWorldAssetPackageFName() { return default; }
	///<summary>Return whether this level should be present in memory which in turn tells the</summary>
	public  bool ShouldBeLoaded() { return default; }
	///<summary>Gets a pointer to the LoadedLevel value</summary>
	public  ULevel GetLoadedLevel() { return default; }
	///<summary>Returns whether streaming level is visible</summary>
	public  bool IsLevelVisible() { return default; }
	///<summary>Returns whether streaming level is loaded</summary>
	public  bool IsLevelLoaded() { return default; }
	///<summary>Returns whether level has streaming state change pending</summary>
	public  bool IsStreamingStatePending() { return default; }
	///<summary>Creates a new instance of this streaming level with a provided unique instance name</summary>
	public  ULevelStreaming CreateInstance(string UniqueInstanceName) { return default; }
	///<summary>Returns the Level Script Actor of the level if the level is loaded and valid</summary>
	public  ALevelScriptActor GetLevelScriptActor() { return default; }
	///<summary>Called when level is streamed in</summary>
	public FLevelStreamingLoadedStatus OnLevelLoaded;
	///<summary>Called when level is streamed out</summary>
	public FLevelStreamingLoadedStatus OnLevelUnloaded;
	///<summary>Called when level is added to the world and is visible</summary>
	public FLevelStreamingVisibilityStatus OnLevelShown;
	///<summary>Called when level is no longer visible, may not be removed from world yet</summary>
	public FLevelStreamingVisibilityStatus OnLevelHidden;
	///<summary>Pointer to Level object if currently loaded/ streamed in.</summary>
	public ULevel LoadedLevel;
	///<summary>Pointer to a Level object that was previously active and was replaced with a new LoadedLevel (for LOD switching)</summary>
	public ULevel PendingUnloadLevel;
	///<summary>The folder path for this level within the world browser. This is only available in editor builds.</summary>
	public string FolderPath;
}
