#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/SnapshotDataCache.h")]
public partial struct FActorSnapshotCache {
// ActorSnapshotCache
	public TWeakObjectPtr<AActor> CachedSnapshotActor;
	public bool bReceivedSerialisation;
	public TArray<int> ObjectDependencies;
}
