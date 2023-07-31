#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GeometryCollectionComponent</summary>
[CppInclude("GeometryCollection/GeometryCollectionComponent.h")]
public partial class UGeometryCollectionComponent : UMeshComponent {
	///<summary>Chaos RBD Solver override. Will use the world&#39;s default solver actor if null.</summary>
	public AChaosSolverActor ChaosSolverActor;
	///<summary>Get local bounds of the geometry collection</summary>
	public  FBox GetLocalBounds() { return default; }
	///<summary>Apply an external strain to specific piece of the geometry collection</summary>
	public  void ApplyExternalStrain(int ItemIndex,FVector Location,float Radius/*=0f*/,int PropagationDepth/*=0*/,float PropagationFactor/*=1f*/,float Strain/*=0f*/) {}
	///<summary>Apply an internal strain to specific piece of the geometry collection</summary>
	public  void ApplyInternalStrain(int ItemIndex,FVector Location,float Radius/*=0f*/,int PropagationDepth/*=0*/,float PropagationFactor/*=1f*/,float Strain/*=0f*/) {}
	///<summary>Crumbe a cluster into all its pieces</summary>
	public  void CrumbleCluster(int ItemIndex) {}
	///<summary>Crumbe active clusters for this entire geometry collection</summary>
	public  void CrumbleActiveClusters() {}
	///<summary>Set a piece or cluster to be anchored or not</summary>
	public  void SetAnchoredByIndex(int Index,bool bAnchored) {}
	///<summary>Set all pieces within a world space bounding box to be anchored or not</summary>
	public  void SetAnchoredByBox(FBox WorldSpaceBox,bool bAnchored,int MaxLevel/*=-1*/) {}
	///<summary>Set all pieces within a world transformed bounding box to be anchored or not</summary>
	public  void SetAnchoredByTransformedBox(FBox Box,FTransform Transform,bool bAnchored,int MaxLevel/*=-1*/) {}
	///<summary>this will remove anchors on all the pieces ( including the static and kinematic initial states ones ) of the geometry colection</summary>
	public  void RemoveAllAnchors() {}
	///<summary>Apply linear velocity on breaking pieces for a specific cluster</summary>
	public  void ApplyBreakingLinearVelocity(int ItemIndex,FVector LinearVelocity) {}
	///<summary>Apply linear velocity on breaking pieces for a specific cluster</summary>
	public  void ApplyBreakingAngularVelocity(int ItemIndex,FVector AngularVelocity) {}
	///<summary>Apply linear velocity on specific piece</summary>
	public  void ApplyLinearVelocity(int ItemIndex,FVector LinearVelocity) {}
	///<summary>Apply angular velocity on specific piece</summary>
	public  void ApplyAngularVelocity(int ItemIndex,FVector AngularVelocity) {}
	///<summary>Get the initial level of a specific piece</summary>
	public  int GetInitialLevel(int ItemIndex) { return default; }
	///<summary>Get the root item index of the hierarchy</summary>
	public  int GetRootIndex() { return default; }
	///<summary>Get mass and extent of a specific piece</summary>
	public  void GetMassAndExtents(int ItemIndex,float OutMass,FBox OutExtents) {}
	///<summary>RestCollection</summary>
	public  void SetRestCollection(UGeometryCollection RestCollectionIn) {}
	///<summary>RestCollection</summary>
	public  string GetDebugInfo() { return default; }
	///<summary>SetEnableDamageFromCollision</summary>
	public  void SetEnableDamageFromCollision(bool bValue) {}
	///<summary>RestCollection</summary>
	public UGeometryCollection RestCollection;
	///<summary>InitializationFields</summary>
	public TArray<AFieldSystemActor> InitializationFields;
	///<summary>Simulating_DEPRECATED</summary>
	public bool Simulating_DEPRECATED;
	///<summary>ObjectType defines how to initialize the rigid objects state, Kinematic, Sleeping, Dynamic.</summary>
	public EObjectStateTypeEnum ObjectType;
	///<summary>If ForceMotionBlur is on, motion blur will always be active, even if the GeometryCollection is at rest.</summary>
	public bool bForceMotionBlur;
	///<summary>EnableClustering</summary>
	public bool EnableClustering;
	///<summary>Maximum level for cluster breaks.</summary>
	public int ClusterGroupIndex;
	///<summary>Maximum level for cluster breaks.</summary>
	public int MaxClusterLevel;
	///<summary>DamageThreshold</summary>
	public TArray<float> DamageThreshold;
	///<summary>Damage threshold for clusters at different levels.</summary>
	public bool bUseSizeSpecificDamageThreshold;
	///<summary>Data about how damage propagation shoudl behave.</summary>
	public FGeometryCollectionDamagePropagationData DamagePropagationData;
	///<summary>Whether or not collisions against this geometry collection will apply strain which could cause the geometry collection to fracture.</summary>
	public bool bEnableDamageFromCollision;
	///<summary>Allow removal on sleep for the instance if the rest collection has it enabled</summary>
	public bool bAllowRemovalOnSleep;
	///<summary>Allow removal on break for the instance if the rest collection has it enabled</summary>
	public bool bAllowRemovalOnBreak;
	///<summary>ClusterConnectionType_DEPRECATED</summary>
	public EClusterConnectionTypeEnum ClusterConnectionType_DEPRECATED;
	///<summary>CollisionGroup</summary>
	public int CollisionGroup;
	///<summary>Fraction of collision sample particles to keep</summary>
	public float CollisionSampleFraction;
	///<summary>Uniform linear ether drag.</summary>
	public float LinearEtherDrag_DEPRECATED;
	///<summary>Uniform angular ether drag.</summary>
	public float AngularEtherDrag_DEPRECATED;
	///<summary>Physical Properties</summary>
	public UChaosPhysicalMaterial PhysicalMaterial_DEPRECATED;
	///<summary>InitialVelocityType</summary>
	public EInitialVelocityTypeEnum InitialVelocityType;
	///<summary>InitialLinearVelocity</summary>
	public FVector InitialLinearVelocity;
	///<summary>InitialAngularVelocity</summary>
	public FVector InitialAngularVelocity;
	///<summary>PhysicalMaterialOverride_DEPRECATED</summary>
	public UPhysicalMaterial PhysicalMaterialOverride_DEPRECATED;
	///<summary>CacheParameters</summary>
	public FGeomComponentCacheParameters CacheParameters;
	///<summary>Optional transforms to initialize scene proxy if difference from the RestCollection.</summary>
	public TArray<FTransform> RestTransforms;
	///<summary>SetDynamicState</summary>
	public  void ApplyKinematicField(float Radius,FVector Position) {}
	///<summary>AddPhysicsField</summary>
	public  void ApplyPhysicsField(bool Enabled,EGeometryCollectionPhysicsTypeEnum Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	///<summary>Blueprint event</summary>
	public  void FNotifyGeometryCollectionPhysicsStateChange(UGeometryCollectionComponent FracturedComponent) {}
	///<summary>NotifyGeometryCollectionPhysicsStateChange</summary>
	public FNotifyGeometryCollectionPhysicsStateChange NotifyGeometryCollectionPhysicsStateChange;
	///<summary>FNotifyGeometryCollectionPhysicsLoadingStateChange</summary>
	public  void FNotifyGeometryCollectionPhysicsLoadingStateChange(UGeometryCollectionComponent FracturedComponent) {}
	///<summary>NotifyGeometryCollectionPhysicsLoadingStateChange</summary>
	public FNotifyGeometryCollectionPhysicsLoadingStateChange NotifyGeometryCollectionPhysicsLoadingStateChange;
	///<summary>Changes whether or not this component will get future break notifications.</summary>
	public  void SetNotifyBreaks(bool bNewNotifyBreaks) {}
	///<summary>Changes whether or not this component will get future removal notifications.</summary>
	public  void SetNotifyRemovals(bool bNewNotifyRemovals) {}
	///<summary>Changes whether or not this component will get future break notifications.</summary>
	public  void SetNotifyCrumblings(bool bNewNotifyCrumblings,bool bNewCrumblingEventIncludesChildren/*=false*/) {}
	///<summary>OnChaosBreakEvent</summary>
	public FOnChaosBreakEvent OnChaosBreakEvent;
	///<summary>OnChaosRemovalEvent</summary>
	public FOnChaosRemovalEvent OnChaosRemovalEvent;
	///<summary>OnChaosCrumblingEvent</summary>
	public FOnChaosCrumblingEvent OnChaosCrumblingEvent;
	///<summary>DesiredCacheTime</summary>
	public float DesiredCacheTime;
	///<summary>CachePlayback</summary>
	public bool CachePlayback;
	///<summary>OnChaosPhysicsCollision</summary>
	public FOnChaosPhysicsCollision OnChaosPhysicsCollision;
	///<summary>ReceivePhysicsCollision</summary>
	public  void ReceivePhysicsCollision(FChaosPhysicsCollisionInfo CollisionInfo) {}
	///<summary>If true, this component will generate breaking events that other systems may subscribe to.</summary>
	public bool bNotifyBreaks;
	///<summary>If true, this component will generate collision events that other systems may subscribe to.</summary>
	public bool bNotifyCollisions;
	///<summary>If true, this component will generate trailing events that other systems may subscribe to.</summary>
	public bool bNotifyTrailing;
	///<summary>If true, this component will generate removal events that other systems may subscribe to.</summary>
	public bool bNotifyRemovals;
	///<summary>If true, this component will generate crumbling events that other systems may subscribe to.</summary>
	public bool bNotifyCrumblings;
	///<summary>If this and bNotifyCrumblings are true, the crumbling events will contain released children indices.</summary>
	public bool bCrumblingEventIncludesChildren;
	///<summary>If true, this component will save linear and angular velocities on its DynamicCollection.</summary>
	public bool bStoreVelocities;
	///<summary>Display Bone Colors instead of assigned materials</summary>
	public bool bShowBoneColors;
	///<summary>bUseRootProxyForNavigation</summary>
	public bool bUseRootProxyForNavigation;
	///<summary>bUpdateNavigationInTick</summary>
	public bool bUpdateNavigationInTick;
	///<summary>bEnableRunTimeDataCollection</summary>
	public bool bEnableRunTimeDataCollection;
	///<summary>RunTimeDataCollectionGuid</summary>
	public FGuid RunTimeDataCollectionGuid;
	///<summary>ISM pool to use to render the geometry collection - only works for unfractured geometry collections</summary>
	public AGeometryCollectionISMPoolActor ISMPool;
	///<summary>Per-instance override to enable/disable replication for the geometry collection</summary>
	public bool bEnableReplication;
	///<summary>Enables use of ReplicationAbandonAfterLevel to stop providing network updates to</summary>
	public bool bEnableAbandonAfterLevel;
	///<summary>If replicating - the cluster level to stop sending corrections for geometry collection chunks.</summary>
	public int ReplicationAbandonClusterLevel_DEPRECATED;
	///<summary>If replicating - the cluster level after which replication will not happen</summary>
	public int ReplicationAbandonAfterLevel;
	///<summary>RepData</summary>
	public FGeometryCollectionRepData RepData;
	///<summary>SelectedBones</summary>
	public TArray<int> SelectedBones;
	///<summary>HighlightedBones</summary>
	public TArray<int> HighlightedBones;
	///<summary>Temporary storage for body setup in order to initialise a dummy body instance</summary>
	public UBodySetup DummyBodySetup;
	///<summary>Tracked editor actor that owns the original component so we can write back recorded caches</summary>
	public AActor EditorActor;
	///<summary>The information of all the embedded instanced static meshes</summary>
	public TArray<UInstancedStaticMeshComponent> EmbeddedGeometryComponents;
}
