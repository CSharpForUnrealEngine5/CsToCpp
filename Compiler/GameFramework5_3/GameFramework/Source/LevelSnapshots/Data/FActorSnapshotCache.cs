namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/SnapshotDataCache.h")]
public partial struct FActorSnapshotCache {
	public TWeakObjectPtr<AActor> CachedSnapshotActor;
	public bool bReceivedSerialisation;
	public TArray<int> ObjectDependencies;
}
