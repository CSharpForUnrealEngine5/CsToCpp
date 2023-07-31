#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/SnapshotDataCache.h")]
public partial struct FActorSnapshotCache {
	public TWeakObjectPtr<AActor> CachedSnapshotActor;
	public bool bReceivedSerialisation;
	public TArray<int> ObjectDependencies;
}
