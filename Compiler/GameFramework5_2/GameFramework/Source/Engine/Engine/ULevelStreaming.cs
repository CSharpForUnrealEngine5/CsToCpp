#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LevelStreaming.h")]
///<summary>Abstract base class of container object encapsulating data required for streaming and providing</summary>
public partial class ULevelStreaming : UObject {
// LevelStreaming
	public string PackageName_DEPRECATED;
	public TSoftObjectPtr<UWorld> WorldAsset;
	public int StreamingPriority;
	public string PackageNameToLoad;
	public TArray<string> LODPackageNames;
	public FTransform LevelTransform;
	public bool bClientOnlyVisible;
	public int LevelLODIndex;
	public bool bShouldBeVisibleInEditor;
	public bool bShouldBeVisible;
	public bool bShouldBeLoaded;
	public bool bLocked;
	public bool bIsStatic;
	public bool bShouldBlockOnLoad;
	public bool bShouldBlockOnUnload;
	public bool bDisableDistanceStreaming;
	public bool bDrawOnLevelStatusMap;
	public FColor DrawColor_DEPRECATED;
	public FLinearColor LevelColor;
	public TArray<ALevelStreamingVolume> EditorStreamingVolumes;
	public float MinTimeBetweenVolumeUnloadRequests;
	public TArray<string> Keywords;
	public  void SetShouldBeVisible(bool bInShouldBeVisible) {}
	public  void SetShouldBeLoaded(bool bInShouldBeLoaded) {}
	public  void SetLevelLODIndex(int LODIndex) {}
	public  void SetPriority(int NewPriority) {}
	public  bool GetIsRequestingUnloadAndRemoval() { return default; }
	public  void SetIsRequestingUnloadAndRemoval(bool bInIsRequestingUnloadAndRemoval) {}
	public  string GetWorldAssetPackageFName() { return default; }
	public  bool ShouldBeLoaded() { return default; }
	public  ULevel GetLoadedLevel() { return default; }
	public  bool IsLevelVisible() { return default; }
	public  bool IsLevelLoaded() { return default; }
	public  bool IsStreamingStatePending() { return default; }
	public  ULevelStreaming CreateInstance(string UniqueInstanceName) { return default; }
	public  ALevelScriptActor GetLevelScriptActor() { return default; }
	public FLevelStreamingLoadedStatus OnLevelLoaded;
	public FLevelStreamingLoadedStatus OnLevelUnloaded;
	public FLevelStreamingVisibilityStatus OnLevelShown;
	public FLevelStreamingVisibilityStatus OnLevelHidden;
	public ULevel LoadedLevel;
	public ULevel PendingUnloadLevel;
	public string FolderPath;
}
