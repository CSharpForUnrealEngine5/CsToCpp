#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AssetManager.h")]
///<summary>A singleton UObject that is responsible for loading and unloading PrimaryAssets, and maintaining game-specific asset references</summary>
public partial class UAssetManager : UObject {
// AssetManager
	public TArray<UObject> ObjectReferenceList;
	public bool bIsGlobalAsyncScanEnvironment;
	public bool bShouldGuessTypeAndName;
	public bool bShouldUseSynchronousLoad;
	public bool bIsLoadingFromPakFiles;
	public bool bShouldAcquireMissingChunksOnLoad;
	public bool bOnlyCookProductionAssets;
	public int NumBulkScanRequests;
	public bool bIsPrimaryAssetDirectoryCurrent;
	public bool bIsManagementDatabaseCurrent;
	public bool bUpdateManagementDatabaseAfterScan;
	public bool bIncludeOnlyOnDiskAssets;
	public bool bHasCompletedInitialScan;
	public int NumberOfSpawnedNotifications;
}
