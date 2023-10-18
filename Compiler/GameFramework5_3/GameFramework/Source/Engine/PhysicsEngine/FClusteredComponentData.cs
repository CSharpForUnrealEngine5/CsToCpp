namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ClusterUnionComponent.h")]
public partial struct FClusteredComponentData {
	public TWeakObjectPtr<UClusterUnionReplicatedProxyComponent> ReplicatedProxyComponent;
	public bool bWasReplicating;
	public bool bPendingDeletion;
}
