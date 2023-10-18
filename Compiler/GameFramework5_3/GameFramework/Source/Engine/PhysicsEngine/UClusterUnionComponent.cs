namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This does the bulk of the work exposing a physics cluster union to the game thread.</summary>
[CppInclude("PhysicsEngine/ClusterUnionComponent.h")]
public partial class UClusterUnionComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>AddComponentToCluster</summary>
	public void AddComponentToCluster(UPrimitiveComponent InComponent,TArray<int> BoneIds) {}
	///<summary>RemoveComponentFromCluster</summary>
	public void RemoveComponentFromCluster(UPrimitiveComponent InComponent) {}
	///<summary>GetPrimitiveComponents</summary>
	public TArray<UPrimitiveComponent> GetPrimitiveComponents() { return default; }
	///<summary>GetActors</summary>
	public TArray<AActor> GetActors() { return default; }
	///<summary>SetIsAnchored</summary>
	public void SetIsAnchored(bool bIsAnchored) {}
	///<summary>IsComponentAdded</summary>
	public bool IsComponentAdded(UPrimitiveComponent Component) { return default; }
	///<summary>OnComponentAddedEvent</summary>
	public FOnClusterUnionAddedComponent OnComponentAddedEvent;
	///<summary>OnComponentRemovedEvent</summary>
	public FOnClusterUnionRemovedComponent OnComponentRemovedEvent;
	///<summary>OnComponentBoundsChangedEvent</summary>
	public FOnClusterUnionBoundsChanged OnComponentBoundsChangedEvent;
	///<summary>This should only be called on the client when replication happens.</summary>
	public void ForceSetChildToParent(UPrimitiveComponent InComponent,TArray<int> BoneIds,TArray<FTransform> ChildToParent) {}
	///<summary>These are the statically clustered components. These should</summary>
	public TArray<FComponentReference> ClusteredComponentsReferences;
	///<summary>Given a unique index of a particle that we&#39;re adding to the cluster union - map it back to the component that owns it.</summary>
	public TMap<int,FClusterUnionParticleCandidateData> UniqueIdxToComponent;
	///<summary>Data that can be changed at runtime to keep state about the cluster union consistent between the server and client.</summary>
	public FClusterUnionReplicatedData ReplicatedRigidState;
	///<summary>Handles changes to ReplicatedRigidState. Note that this function does not handle replication of X/R since we make use</summary>
	public void OnRep_RigidState() {}
	///<summary>Need to handle the fact that this component may or may not be initialized prior to the components referenced in</summary>
	public void HandleComponentPhysicsStateChange(UPrimitiveComponent ChangedComponent,EComponentPhysicsStateChange StateChange) {}
	///<summary>Once in the cluster union, if the component&#39;s physics state is destroyed, we should remove it from the cluster union.</summary>
	public void HandleComponentPhysicsStateChangePostAddIntoClusterUnion(UPrimitiveComponent ChangedComponent,EComponentPhysicsStateChange StateChange) {}
	///<summary>Whether or not this code is running on the server.</summary>
	public bool IsAuthority() { return default; }
}
