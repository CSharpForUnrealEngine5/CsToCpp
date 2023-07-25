#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/SnapshotDataCache.h")]
///<summary>Caches data for re-use.</summary>
public partial struct FSnapshotDataCache {
// SnapshotDataCache
	public TMap<FSoftObjectPath,FActorSnapshotCache> ActorCache;
	public TMap<FSoftObjectPath,FSubobjectSnapshotCache> SubobjectCache;
	public TArray<UObject> ArchetypeObjects;
}
