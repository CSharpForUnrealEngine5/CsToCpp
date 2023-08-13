namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Caches data for re-use.</summary>
[CppInclude("Data/SnapshotDataCache.h")]
public partial struct FSnapshotDataCache {
	public TMap<FSoftObjectPath,FActorSnapshotCache> ActorCache;
	public TMap<FSoftObjectPath,FSubobjectSnapshotCache> SubobjectCache;
	public TArray<UObject> ArchetypeObjects;
}
