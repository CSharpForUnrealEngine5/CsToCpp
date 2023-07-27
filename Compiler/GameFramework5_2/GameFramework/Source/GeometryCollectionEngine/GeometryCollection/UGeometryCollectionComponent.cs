#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionComponent.h")]
///<summary>GeometryCollectionComponent</summary>
public partial class UGeometryCollectionComponent : UMeshComponent {
// GeometryCollectionComponent
	public AChaosSolverActor ChaosSolverActor;
	public  FBox GetLocalBounds() { return default; }
	public  void ApplyExternalStrain(int ItemIndex,FVector Location,float Radius/*=0f*/,int PropagationDepth/*=0*/,float PropagationFactor/*=1f*/,float Strain/*=0f*/) {}
	public  void ApplyInternalStrain(int ItemIndex,FVector Location,float Radius/*=0f*/,int PropagationDepth/*=0*/,float PropagationFactor/*=1f*/,float Strain/*=0f*/) {}
	public  void CrumbleCluster(int ItemIndex) {}
	public  void CrumbleActiveClusters() {}
	public  void SetAnchoredByIndex(int Index,bool bAnchored) {}
	public  void SetAnchoredByBox(FBox WorldSpaceBox,bool bAnchored,int MaxLevel/*=-1*/) {}
	public  void SetAnchoredByTransformedBox(FBox Box,FTransform Transform,bool bAnchored,int MaxLevel/*=-1*/) {}
	public  void RemoveAllAnchors() {}
	public  void ApplyBreakingLinearVelocity(int ItemIndex,FVector LinearVelocity) {}
	public  void ApplyBreakingAngularVelocity(int ItemIndex,FVector AngularVelocity) {}
	public  void ApplyLinearVelocity(int ItemIndex,FVector LinearVelocity) {}
	public  void ApplyAngularVelocity(int ItemIndex,FVector AngularVelocity) {}
	public  int GetInitialLevel(int ItemIndex) { return default; }
	public  int GetRootIndex() { return default; }
	public  void GetMassAndExtents(int ItemIndex,float OutMass,FBox OutExtents) {}
	public  void SetRestCollection(UGeometryCollection RestCollectionIn) {}
	public  string GetDebugInfo() { return default; }
	public  void SetEnableDamageFromCollision(bool bValue) {}
	public UGeometryCollection RestCollection;
	public TArray<AFieldSystemActor> InitializationFields;
	public bool Simulating_DEPRECATED;
	public EObjectStateTypeEnum ObjectType;
	public bool bForceMotionBlur;
	public bool EnableClustering;
	public int ClusterGroupIndex;
	public int MaxClusterLevel;
	public TArray<float> DamageThreshold;
	public bool bUseSizeSpecificDamageThreshold;
	public FGeometryCollectionDamagePropagationData DamagePropagationData;
	public bool bEnableDamageFromCollision;
	public bool bAllowRemovalOnSleep;
	public bool bAllowRemovalOnBreak;
	public EClusterConnectionTypeEnum ClusterConnectionType_DEPRECATED;
	public int CollisionGroup;
	public float CollisionSampleFraction;
	public float LinearEtherDrag_DEPRECATED;
	public float AngularEtherDrag_DEPRECATED;
	public UChaosPhysicalMaterial PhysicalMaterial_DEPRECATED;
	public EInitialVelocityTypeEnum InitialVelocityType;
	public FVector InitialLinearVelocity;
	public FVector InitialAngularVelocity;
	public UPhysicalMaterial PhysicalMaterialOverride_DEPRECATED;
	public FGeomComponentCacheParameters CacheParameters;
	public TArray<FTransform> RestTransforms;
	public  void ApplyKinematicField(float Radius,FVector Position) {}
	public  void ApplyPhysicsField(bool Enabled,EGeometryCollectionPhysicsTypeEnum Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	public  void FNotifyGeometryCollectionPhysicsStateChange(UGeometryCollectionComponent FracturedComponent) {}
	public FNotifyGeometryCollectionPhysicsStateChange NotifyGeometryCollectionPhysicsStateChange;
	public  void FNotifyGeometryCollectionPhysicsLoadingStateChange(UGeometryCollectionComponent FracturedComponent) {}
	public FNotifyGeometryCollectionPhysicsLoadingStateChange NotifyGeometryCollectionPhysicsLoadingStateChange;
	public  void SetNotifyBreaks(bool bNewNotifyBreaks) {}
	public  void SetNotifyRemovals(bool bNewNotifyRemovals) {}
	public  void SetNotifyCrumblings(bool bNewNotifyCrumblings,bool bNewCrumblingEventIncludesChildren/*=false*/) {}
	public FOnChaosBreakEvent OnChaosBreakEvent;
	public FOnChaosRemovalEvent OnChaosRemovalEvent;
	public FOnChaosCrumblingEvent OnChaosCrumblingEvent;
	public float DesiredCacheTime;
	public bool CachePlayback;
	public FOnChaosPhysicsCollision OnChaosPhysicsCollision;
	public  void ReceivePhysicsCollision(FChaosPhysicsCollisionInfo CollisionInfo) {}
	public bool bNotifyBreaks;
	public bool bNotifyCollisions;
	public bool bNotifyTrailing;
	public bool bNotifyRemovals;
	public bool bNotifyCrumblings;
	public bool bCrumblingEventIncludesChildren;
	public bool bStoreVelocities;
	public bool bShowBoneColors;
	public bool bUseRootProxyForNavigation;
	public bool bUpdateNavigationInTick;
	public bool bEnableRunTimeDataCollection;
	public FGuid RunTimeDataCollectionGuid;
	public AGeometryCollectionISMPoolActor ISMPool;
	public bool bEnableReplication;
	public bool bEnableAbandonAfterLevel;
	public int ReplicationAbandonClusterLevel_DEPRECATED;
	public int ReplicationAbandonAfterLevel;
	public FGeometryCollectionRepData RepData;
	public TArray<int> SelectedBones;
	public TArray<int> HighlightedBones;
	public UBodySetup DummyBodySetup;
	public AActor EditorActor;
	public TArray<UInstancedStaticMeshComponent> EmbeddedGeometryComponents;
}
