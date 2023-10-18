namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GeometryCollectionComponent</summary>
[CppInclude("GeometryCollection/GeometryCollectionComponent.h")]
public partial class UGeometryCollectionComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Chaos RBD Solver override. Will use the world&#39;s default solver actor if null.</summary>
	public AChaosSolverActor ChaosSolverActor;
	///<summary>Get local bounds of the geometry collection</summary>
	public FBox GetLocalBounds() { return default; }
	///<summary>Apply an external strain to specific piece of the geometry collection</summary>
	public void ApplyExternalStrain(int ItemIndex,FVector Location,float Radius/*=0f*/,int PropagationDepth/*=0*/,float PropagationFactor/*=1f*/,float Strain/*=0f*/) {}
	///<summary>Apply an internal strain to specific piece of the geometry collection</summary>
	public void ApplyInternalStrain(int ItemIndex,FVector Location,float Radius/*=0f*/,int PropagationDepth/*=0*/,float PropagationFactor/*=1f*/,float Strain/*=0f*/) {}
	///<summary>Crumbe a cluster into all its pieces</summary>
	public void CrumbleCluster(int ItemIndex) {}
	///<summary>Crumbe active clusters for this entire geometry collection</summary>
	public void CrumbleActiveClusters() {}
	///<summary>Set a piece or cluster to be anchored or not</summary>
	public void SetAnchoredByIndex(int Index,bool bAnchored) {}
	///<summary>Set all pieces within a world space bounding box to be anchored or not</summary>
	public void SetAnchoredByBox(FBox WorldSpaceBox,bool bAnchored,int MaxLevel/*=-1*/) {}
	///<summary>Set all pieces within a world transformed bounding box to be anchored or not</summary>
	public void SetAnchoredByTransformedBox(FBox Box,FTransform Transform,bool bAnchored,int MaxLevel/*=-1*/) {}
	///<summary>this will remove anchors on all the pieces ( including the static and kinematic initial states ones ) of the geometry colection</summary>
	public void RemoveAllAnchors() {}
	///<summary>Apply linear velocity on breaking pieces for a specific cluster</summary>
	public void ApplyBreakingLinearVelocity(int ItemIndex,FVector LinearVelocity) {}
	///<summary>Apply linear velocity on breaking pieces for a specific cluster</summary>
	public void ApplyBreakingAngularVelocity(int ItemIndex,FVector AngularVelocity) {}
	///<summary>Apply linear velocity on specific piece</summary>
	public void ApplyLinearVelocity(int ItemIndex,FVector LinearVelocity) {}
	///<summary>Apply angular velocity on specific piece</summary>
	public void ApplyAngularVelocity(int ItemIndex,FVector AngularVelocity) {}
	///<summary>Get the initial level of a specific piece</summary>
	public int GetInitialLevel(int ItemIndex) { return default; }
	///<summary>Get the root item index of the hierarchy</summary>
	public int GetRootIndex() { return default; }
	///<summary>Get the root item initial transform in world space</summary>
	public FTransform GetRootInitialTransform() { return default; }
	///<summary>Get the root item current world transform</summary>
	public FTransform GetRootCurrentTransform() { return default; }
	///<summary>Get the initial rest transforms in component (local) space  space,</summary>
	public TArray<FTransform> GetInitialLocalRestTransforms() { return default; }
	///<summary>Set the local rest transform, this may be different from the rest collection</summary>
	public void SetLocalRestTransforms(TArray<FTransform> Transforms,bool bOnlyLeaves) {}
	///<summary>Get mass and extent of a specific piece</summary>
	public void GetMassAndExtents(int ItemIndex,float OutMass,FBox OutExtents) {}
	///<summary>RestCollection</summary>
	public void SetRestCollection(UGeometryCollection RestCollectionIn,bool bApplyAssetDefaults/*=true*/) {}
	///<summary>RestCollection</summary>
	public string GetDebugInfo() { return default; }
	///<summary>SetEnableDamageFromCollision</summary>
	public void SetEnableDamageFromCollision(bool bValue) {}
	///<summary>SetAbandonedParticleCollisionProfileName</summary>
	public void SetAbandonedParticleCollisionProfileName(FName CollisionProfile) {}
	///<summary>SetPerLevelCollisionProfileNames</summary>
	public void SetPerLevelCollisionProfileNames(TArray<FName> ProfileNames) {}
	///<summary>SetPerParticleCollisionProfileName</summary>
	public void SetPerParticleCollisionProfileName(TArray<int> BoneIds,FName ProfileName) {}
	///<summary>RestCollection</summary>
	public UGeometryCollection RestCollection;
	///<summary>Apply default values from asset ( damage related data and physics material )</summary>
	public void ApplyAssetDefaults() {}
	///<summary>InitializationFields</summary>
	public TArray<AFieldSystemActor> InitializationFields;
	///<summary>Simulating_DEPRECATED</summary>
	public bool Simulating_DEPRECATED;
	///<summary>ObjectType defines how to initialize the rigid objects state, Kinematic, Sleeping, Dynamic.</summary>
	public EObjectStateTypeEnum ObjectType;
	///<summary>GravityGroupIndex</summary>
	public int GravityGroupIndex;
	///<summary>If ForceMotionBlur is on, motion blur will always be active, even if the GeometryCollection is at rest.</summary>
	public bool bForceMotionBlur;
	///<summary>EnableClustering</summary>
	public bool EnableClustering;
	///<summary>Maximum level for cluster breaks.</summary>
	public int ClusterGroupIndex;
	///<summary>Maximum level for cluster breaks.</summary>
	public int MaxClusterLevel;
	///<summary>The maximum level to create rigid bodies that could be simulated.</summary>
	public int MaxSimulatedLevel;
	///<summary>Damage model to use for evaluating destruction.</summary>
	public EDamageModelTypeEnum DamageModel;
	///<summary>DamageThreshold</summary>
	public TArray<float> DamageThreshold;
	///<summary>GetDamageThreshold</summary>
	public TArray<float> GetDamageThreshold() { return default; }
	///<summary>SetDamageThreshold</summary>
	public void SetDamageThreshold(TArray<float> InDamageThreshold) {}
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
	public void ApplyKinematicField(float Radius,FVector Position) {}
	///<summary>AddPhysicsField</summary>
	public void ApplyPhysicsField(bool Enabled,EGeometryCollectionPhysicsTypeEnum Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	///<summary>Blueprint event</summary>
	public void FNotifyGeometryCollectionPhysicsStateChange(UGeometryCollectionComponent FracturedComponent) {}
	///<summary>NotifyGeometryCollectionPhysicsStateChange</summary>
	public FNotifyGeometryCollectionPhysicsStateChange NotifyGeometryCollectionPhysicsStateChange;
	///<summary>FNotifyGeometryCollectionPhysicsLoadingStateChange</summary>
	public void FNotifyGeometryCollectionPhysicsLoadingStateChange(UGeometryCollectionComponent FracturedComponent) {}
	///<summary>NotifyGeometryCollectionPhysicsLoadingStateChange</summary>
	public FNotifyGeometryCollectionPhysicsLoadingStateChange NotifyGeometryCollectionPhysicsLoadingStateChange;
	///<summary>Changes whether or not this component will get future break notifications.</summary>
	public void SetNotifyBreaks(bool bNewNotifyBreaks) {}
	///<summary>Changes whether or not this component will get future removal notifications.</summary>
	public void SetNotifyRemovals(bool bNewNotifyRemovals) {}
	///<summary>Changes whether or not this component will get future crumbling notifications.</summary>
	public void SetNotifyCrumblings(bool bNewNotifyCrumblings,bool bNewCrumblingEventIncludesChildren/*=false*/) {}
	///<summary>Changes whether or not this component will get future global break notifications.</summary>
	public void SetNotifyGlobalBreaks(bool bNewNotifyGlobalBreaks) {}
	///<summary>Changes whether or not this component will get future global collision notifications.</summary>
	public void SetNotifyGlobalCollision(bool bNewNotifyGlobalCollisions) {}
	///<summary>Changes whether or not this component will get future global removal notifications.</summary>
	public void SetNotifyGlobalRemovals(bool bNewNotifyGlobalRemovals) {}
	///<summary>Changes whether or not this component will get future global crumbling notifications.</summary>
	public void SetNotifyGlobalCrumblings(bool bNewNotifyGlobalCrumblings,bool bGlobalNewCrumblingEventIncludesChildren) {}
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
	public void ReceivePhysicsCollision(FChaosPhysicsCollisionInfo CollisionInfo) {}
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
	///<summary>If true, this component will generate breaking events that will be listened by the global event relay.</summary>
	public bool bNotifyGlobalBreaks;
	///<summary>If true, this component will generate collision events  that will be listened by the global event relay.</summary>
	public bool bNotifyGlobalCollisions;
	///<summary>If true, this component will generate removal events  that will be listened by the global event relay.</summary>
	public bool bNotifyGlobalRemovals;
	///<summary>If true, this component will generate crumbling events  that will be listened by the global event relay.</summary>
	public bool bNotifyGlobalCrumblings;
	///<summary>If this and bNotifyGlobalCrumblings are true, the crumbling events will contain released children indices.</summary>
	public bool bGlobalCrumblingEventIncludesChildren;
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
	///<summary>Deprecated for CustomRendererType.</summary>
	public AGeometryCollectionISMPoolActor ISMPool_DEPRECATED;
	///<summary>Deprecated for CustomRendererType.</summary>
	public bool bAutoAssignISMPool_DEPRECATED;
	///<summary>If true, CustomRendererType will be used. If false, CustomRendererType comes from the RestCollection.</summary>
	public bool bOverrideCustomRenderer;
	///<summary>Custom class type that will be used to render the geometry collection instead of using the native rendering.</summary>
	public UClass CustomRendererType;
	///<summary>A custom renderer object created from CustomRenderType.</summary>
	public UGeometryCollectionExternalRenderInterface CustomRenderer;
	///<summary>Per-instance override to enable/disable replication for the geometry collection</summary>
	public bool bEnableReplication;
	///<summary>Enables use of ReplicationAbandonAfterLevel to stop providing network updates to</summary>
	public bool bEnableAbandonAfterLevel;
	///<summary>Whether abandoned particles on the client should continue to have collision (i.e.</summary>
	public FName AbandonedCollisionProfileName;
	///<summary>A per-level collision profile name. If the name is set to NONE or an invalid collision profile, nothing will be changed.</summary>
	public TArray<FName> CollisionProfilePerLevel;
	///<summary>If replicating - the cluster level to stop sending corrections for geometry collection chunks.</summary>
	public int ReplicationAbandonClusterLevel_DEPRECATED;
	///<summary>If replicating - the cluster level after which replication will not happen</summary>
	public int ReplicationAbandonAfterLevel;
	///<summary>If replicating - the maximum level where clusters will have their position and velocity send over to the client for tracking and correcting</summary>
	public int ReplicationMaxPositionAndVelocityCorrectionLevel;
	///<summary>RepData</summary>
	public FGeometryCollectionRepData RepData;
	///<summary>Called post solve to allow authoritative components to update their replication data</summary>
	public void OnRep_RepData() {}
	///<summary>SelectedBones</summary>
	public TArray<int> SelectedBones;
	///<summary>HighlightedBones</summary>
	public TArray<int> HighlightedBones;
	///<summary>Temporary storage for body setup in order to initialise a dummy body instance</summary>
	public UBodySetup DummyBodySetup;
	///<summary>Tracked editor actor that owns the original component so we can write back recorded caches</summary>
	public AActor EditorActor;
	///<summary>Event dispatcher for break, crumble, removal and collision events</summary>
	public UChaosGameplayEventDispatcher EventDispatcher;
	///<summary>The information of all the embedded instanced static meshes</summary>
	public TArray<UInstancedStaticMeshComponent> EmbeddedGeometryComponents;
	///<summary>return true if the root cluster is not longer active at runtime</summary>
	public bool IsRootBroken() { return default; }
}
