namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This component lets us store replicated information about how any particular UPrimitiveComponent</summary>
[CppInclude("PhysicsEngine/ClusterUnionReplicatedProxyComponent.h")]
public partial class UClusterUnionReplicatedProxyComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>GetParentClusterUnionComponent</summary>
	public UClusterUnionComponent GetParentClusterUnionComponent() { return default; }
	///<summary>SetParentClusterUnion</summary>
	public void SetParentClusterUnion(UClusterUnionComponent InComponent) {}
	///<summary>SetChildClusteredComponent</summary>
	public void SetChildClusteredComponent(UPrimitiveComponent InComponent) {}
	///<summary>SetParticleBoneIds</summary>
	public void SetParticleBoneIds(TArray<int> InIds) {}
	///<summary>SetParticleChildToParent</summary>
	public void SetParticleChildToParent(int BoneId,FTransform ChildToParent) {}
	///<summary>MarkPendingDeletion</summary>
	public void MarkPendingDeletion() {}
	///<summary>IsPendingDeletion</summary>
	public bool IsPendingDeletion() { return default; }
	///<summary>OnRep_ParentClusterUnion</summary>
	public void OnRep_ParentClusterUnion() {}
	///<summary>OnRep_ChildClusteredComponent</summary>
	public void OnRep_ChildClusteredComponent() {}
	///<summary>OnRep_ParticleBoneIds</summary>
	public void OnRep_ParticleBoneIds() {}
	///<summary>OnRep_ParticleChildToParents</summary>
	public void OnRep_ParticleChildToParents() {}
	///<summary>ParentClusterUnion</summary>
	public TWeakObjectPtr<UClusterUnionComponent> ParentClusterUnion;
	///<summary>bNetUpdateParentClusterUnion</summary>
	public bool bNetUpdateParentClusterUnion;
	///<summary>ChildClusteredComponent</summary>
	public TWeakObjectPtr<UPrimitiveComponent> ChildClusteredComponent;
	///<summary>bNetUpdateChildClusteredComponent</summary>
	public bool bNetUpdateChildClusteredComponent;
	///<summary>ParticleBoneIds</summary>
	public TArray<int> ParticleBoneIds;
	///<summary>bNetUpdateParticleBoneIds</summary>
	public bool bNetUpdateParticleBoneIds;
	///<summary>ParticleChildToParents</summary>
	public TArray<FTransform> ParticleChildToParents;
	///<summary>bNetUpdateParticleChildToParents</summary>
	public bool bNetUpdateParticleChildToParents;
	///<summary>bIsPendingDeletion</summary>
	public bool bIsPendingDeletion;
}
