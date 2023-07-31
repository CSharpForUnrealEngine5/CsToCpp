#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A singleton UObject that is responsible for loading and unloading PrimaryAssets, and maintaining game-specific asset references</summary>
[CppInclude("Engine/AssetManager.h")]
public partial class UAssetManager : UObject {
	///<summary>List of UObjects that are being kept from being GCd, derived from the asset type map. Arrays are currently more efficient than Sets</summary>
	public TArray<UObject> ObjectReferenceList;
	///<summary>True if we are running a build that is already scanning assets globally so we can perhaps avoid scanning paths synchronously</summary>
	public bool bIsGlobalAsyncScanEnvironment;
	///<summary>True if PrimaryAssetType/Name will be implied for loading assets that don&#39;t have it saved on disk. Won&#39;t work for all projects</summary>
	public bool bShouldGuessTypeAndName;
	///<summary>True if we should always use synchronous loads, this speeds up cooking</summary>
	public bool bShouldUseSynchronousLoad;
	///<summary>True if we are loading from pak files</summary>
	public bool bIsLoadingFromPakFiles;
	///<summary>True if the chunk install interface should be queries before loading assets</summary>
	public bool bShouldAcquireMissingChunksOnLoad;
	///<summary>If true, DevelopmentCook assets will error when they are cooked</summary>
	public bool bOnlyCookProductionAssets;
	///<summary>&gt;0 if we are currently in bulk scanning mode</summary>
	public int NumBulkScanRequests;
	///<summary>True if asset data is current, if false it will need to rescan before PIE</summary>
	public bool bIsPrimaryAssetDirectoryCurrent;
	///<summary>True if the asset management database is up to date</summary>
	public bool bIsManagementDatabaseCurrent;
	///<summary>True if the asset management database should be updated after scan completes</summary>
	public bool bUpdateManagementDatabaseAfterScan;
	///<summary>True if only on-disk assets should be searched by the asset registry</summary>
	public bool bIncludeOnlyOnDiskAssets;
	///<summary>True if we have passed the initial asset registry/type scan</summary>
	public bool bHasCompletedInitialScan;
	///<summary>Number of notifications seen in this update</summary>
	public int NumberOfSpawnedNotifications;
}
