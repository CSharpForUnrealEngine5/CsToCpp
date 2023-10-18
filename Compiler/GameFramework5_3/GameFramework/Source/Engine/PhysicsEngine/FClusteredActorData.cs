namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ClusterUnionComponent.h")]
public partial struct FClusteredActorData {
	public TSet<TWeakObjectPtr<UPrimitiveComponent>> Components;
	public bool bWasReplicatingMovement;
}
