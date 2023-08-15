namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds the state of a world at a given time. This asset can be used to rollback certain properties in a UWorld.</summary>
[CppInclude("Data/LevelSnapshot.h")]
public partial class ULevelSnapshot : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the name of this snapshot.</summary>
	public void SetSnapshotName(FName InSnapshotName) {}
	///<summary>SetSnapshotDescription</summary>
	public void SetSnapshotDescription(string InSnapshotDescription) {}
	///<summary>GetMapPath</summary>
	public FSoftObjectPath GetMapPath() { return default; }
	///<summary>GetCaptureTime</summary>
	public FDateTime GetCaptureTime() { return default; }
	///<summary>GetSnapshotName</summary>
	public FName GetSnapshotName() { return default; }
	///<summary>GetSnapshotDescription</summary>
	public string GetSnapshotDescription() { return default; }
	///<summary>Transient package that contains the world. Exists so calls to MarkPackageDirty, called e.g. by AActor::Modify, do not mark the snapshot dirty.</summary>
	public UPackage TransientWorldPackage;
	///<summary>The root world, equivalent to the persistent world, we will be adding temporary actors to</summary>
	public UWorld RootSnapshotWorld;
	///<summary>Sublevels of RootSnapshotWorld</summary>
	public TArray<UWorld> SnapshotSublevels;
	///<summary>The saved snapshot data</summary>
	public FWorldSnapshotData SerializedData;
	///<summary>Holds all loaded objects</summary>
	public FSnapshotDataCache Cache;
	///<summary>Only used in non-editor builds (should be wrapped in !WITH_EDITORONLY_DATA but UHT does not allow it).</summary>
	public bool bIsDiffCacheEnabled;
	///<summary>Caches whether an actor was diffed already</summary>
	public TMap<TWeakObjectPtr<AActor>,ECachedDiffResult> CachedDiffedActors;
	///<summary>Path of the map that the snapshot was taken in</summary>
	public FSoftObjectPath MapPath;
	///<summary>UTC Time that the snapshot was taken</summary>
	public FDateTime CaptureTime;
	///<summary>User defined name for the snapshot, can differ from the actual asset name.</summary>
	public FName SnapshotName;
	///<summary>User defined description of the snapshot</summary>
	public string SnapshotDescription;
}
