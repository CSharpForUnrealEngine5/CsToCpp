#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Actor.h")]
///<summary>Actor is the base class for an Object that can be placed or spawned in a level.</summary>
public partial class AActor : UObject {
// Actor
	public FActorTickFunction PrimaryActorTick;
	public bool bNetTemporary;
	public bool bOnlyRelevantToOwner;
	public bool bAlwaysRelevant;
	public void OnRep_ReplicateMovement() {}
	public bool bReplicateMovement;
	public bool bCallPreReplication;
	public bool bCallPreReplicationForReplay;
	public bool bHidden;
	public bool bTearOff;
	public bool bForceNetAddressable;
	public bool bIsInEditingLevelInstance;
	public void TearOff() {}
	public bool bExchangedRoles;
	public bool bNetLoadOnClient;
	public bool bNetUseOwnerRelevancy;
	public bool bRelevantForNetworkReplays;
	public bool bRelevantForLevelBounds;
	public bool bReplayRewindable;
	public bool bAllowTickBeforeBeginPlay;
	public bool bAutoDestroyWhenFinished;
	public bool bCanBeDamaged;
	public bool bBlockInput;
	public bool bCollideWhenPlacing;
	public bool bFindCameraComponentWhenViewTarget;
	public bool bGenerateOverlapEventsDuringLevelStreaming;
	public bool bIgnoresOriginShifting;
	public bool bEnableAutoLODGeneration;
	public bool bIsEditorOnlyActor;
	public bool bActorSeamlessTraveled;
	public void SetAutoDestroyWhenFinished(bool bVal) {}
	public bool bReplicates;
	public void OnRep_Owner() {}
	public bool bCanBeInCluster;
	public bool bAllowReceiveTickEventOnDedicatedServer;
	public bool bReplicateUsingRegisteredSubObjectList;
	public bool bActorEnableCollision;
	public bool bActorIsBeingDestroyed;
	public bool bAsyncPhysicsTickEnabled;
	public EActorUpdateOverlapsMethod UpdateOverlapsMethodDuringLevelStreaming;
	public EActorUpdateOverlapsMethod DefaultUpdateOverlapsMethodDuringLevelStreaming;
	public void SetReplicates(bool bInReplicates) {}
	public void SetReplicateMovement(bool bInReplicateMovement) {}
	public ENetRole GetLocalRole() { return default; }
	public ENetRole GetRemoteRole() { return default; }
	public float InitialLifeSpan;
	public float CustomTimeDilation;
	public byte RemoteRole;
	public int RayTracingGroupId;
	public EActorGridPlacement GridPlacement_DEPRECATED;
	public string RuntimeGrid;
	public FRepAttachment AttachmentReplication;
	public FRepMovement ReplicatedMovement;
	public AActor Owner;
	public string NetDriverName;
	public void OnRep_AttachmentReplication() {}
	public byte Role;
	public byte NetDormancy;
	public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod;
	public byte AutoReceiveInput;
	public int InputPriority;
	public UInputComponent InputComponent;
	public float NetCullDistanceSquared;
	public int NetTag;
	public float NetUpdateFrequency;
	public float MinNetUpdateFrequency;
	public float NetPriority;
	public APawn Instigator;
	public void OnRep_Instigator() {}
	public TArray<AActor> Children;
	public USceneComponent RootComponent;
	public FVector PivotOffset;
	public void SetRayTracingGroupId(int InRaytracingGroupId) {}
	public int GetRayTracingGroupId() { return default; }
	public UHLODLayer HLODLayer;
	public TArray<string> Layers;
	public TWeakObjectPtr<AActor> ParentComponentActor_DEPRECATED;
	public TWeakObjectPtr<UChildActorComponent> ParentComponent;
	public FGuid ActorGuid;
	public FGuid ContentBundleGuid;
	public TArray<FActorDataLayer> DataLayers;
	public TArray<UDataLayerAsset> DataLayerAssets;
	public AActor GroupActor;
	public float SpriteScale;
	public ulong HiddenEditorViews;
	public string ActorLabel;
	public string FolderPath;
	public FGuid FolderGuid;
	public bool bHiddenEd;
	public bool bIsEditorPreviewActor;
	public bool bHiddenEdLayer;
	public bool bHiddenEdLevel;
	public bool bLockLocation;
	public bool bActorLabelEditable;
	public bool bEditable;
	public bool bListedInSceneOutliner;
	public bool bOptimizeBPComponentData;
	public bool bCanPlayFromHere;
	public bool bIsSpatiallyLoaded;
	public bool bHiddenEdTemporary;
	public bool bForceExternalActorLevelReferenceForPIE;
	public TArray<string> Tags;
	public FTakeAnyDamageSignature OnTakeAnyDamage;
	public FTakePointDamageSignature OnTakePointDamage;
	public FTakeRadialDamageSignature OnTakeRadialDamage;
	public FActorBeginOverlapSignature OnActorBeginOverlap;
	public FActorEndOverlapSignature OnActorEndOverlap;
	public FActorBeginCursorOverSignature OnBeginCursorOver;
	public FActorEndCursorOverSignature OnEndCursorOver;
	public FActorOnClickedSignature OnClicked;
	public FActorOnReleasedSignature OnReleased;
	public FActorOnInputTouchBeginSignature OnInputTouchBegin;
	public FActorOnInputTouchEndSignature OnInputTouchEnd;
	public FActorBeginTouchOverSignature OnInputTouchEnter;
	public FActorEndTouchOverSignature OnInputTouchLeave;
	public FActorHitSignature OnActorHit;
	public void EnableInput(UObject PlayerController) {}
	public void CreateInputComponent(UClass InputComponentToCreate) {}
	public void DisableInput(UObject PlayerController) {}
	public float GetInputAxisValue(string InputAxisName) { return default; }
	public float GetInputAxisKeyValue(FKey InputAxisKey) { return default; }
	public FVector GetInputVectorAxisValue(FKey InputAxisKey) { return default; }
	public UObject GetInstigator() { return default; }
	public UObject GetInstigatorController() { return default; }
	public FTransform GetTransform() { return default; }
	public FVector K2_GetActorLocation() { return default; }
	public bool K2_SetActorLocation(FVector NewLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) { return default; }
	public FRotator K2_GetActorRotation() { return default; }
	public FVector GetActorForwardVector() { return default; }
	public FVector GetActorUpVector() { return default; }
	public FVector GetActorRightVector() { return default; }
	public void GetActorBounds(bool bOnlyCollidingComponents,FVector Origin,FVector BoxExtent,bool bIncludeFromChildActors/*=false*/) {}
	public UObject K2_GetRootComponent() { return default; }
	public FVector GetVelocity() { return default; }
	public bool K2_SetActorRotation(FRotator NewRotation,bool bTeleportPhysics) { return default; }
	public bool K2_SetActorLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) { return default; }
	public void SetActorScale3D(FVector NewScale3D) {}
	public FVector GetActorScale3D() { return default; }
	public float GetDistanceTo(UObject OtherActor) { return default; }
	public float GetSquaredDistanceTo(UObject OtherActor) { return default; }
	public float GetHorizontalDistanceTo(UObject OtherActor) { return default; }
	public float GetSquaredHorizontalDistanceTo(UObject OtherActor) { return default; }
	public float GetVerticalDistanceTo(UObject OtherActor) { return default; }
	public float GetDotProductTo(UObject OtherActor) { return default; }
	public float GetHorizontalDotProductTo(UObject OtherActor) { return default; }
	public void K2_AddActorWorldOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddActorWorldRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddActorWorldTransform(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddActorWorldTransformKeepScale(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public bool K2_SetActorTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) { return default; }
	public void K2_AddActorLocalOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddActorLocalRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddActorLocalTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_SetActorRelativeLocation(FVector NewRelativeLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_SetActorRelativeRotation(FRotator NewRelativeRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_SetActorRelativeTransform(FTransform NewRelativeTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void SetActorRelativeScale3D(FVector NewRelativeScale) {}
	public FVector GetActorRelativeScale3D() { return default; }
	public void SetActorHiddenInGame(bool bNewHidden) {}
	public void SetActorEnableCollision(bool bNewActorEnableCollision) {}
	public bool GetActorEnableCollision() { return default; }
	public void K2_DestroyActor() {}
	public bool HasAuthority() { return default; }
	public UObject AddComponent(string TemplateName,bool bManualAttachment,FTransform RelativeTransform,UObject ComponentTemplateContext,bool bDeferredFinish/*=false*/) { return default; }
	public UObject AddComponentByClass(UClass Class,bool bManualAttachment,FTransform RelativeTransform,bool bDeferredFinish) { return default; }
	public void FinishAddComponent(UObject Component,bool bManualAttachment,FTransform RelativeTransform) {}
	public void K2_AttachRootComponentTo(UObject InParent,string InSocketName/*=NAME_None*/,EAttachLocation AttachLocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bWeldSimulatedBodies/*=true*/) {}
	public bool K2_AttachToComponent(UObject Parent,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies) { return default; }
	public void K2_AttachRootComponentToActor(UObject InParentActor,string InSocketName/*=NAME_None*/,EAttachLocation AttachLocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bWeldSimulatedBodies/*=true*/) {}
	public bool K2_AttachToActor(UObject ParentActor,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies) { return default; }
	public void DetachRootComponentFromParent(bool bMaintainWorldPosition/*=true*/) {}
	public void K2_DetachFromActor(EDetachmentRule LocationRule/*=EDetachmentRule.KeepRelative*/,EDetachmentRule RotationRule/*=EDetachmentRule.KeepRelative*/,EDetachmentRule ScaleRule/*=EDetachmentRule.KeepRelative*/) {}
	public bool ActorHasTag(string Tag) { return default; }
	public float GetActorTimeDilation() { return default; }
	public void AddTickPrerequisiteActor(UObject PrerequisiteActor) {}
	public void AddTickPrerequisiteComponent(UObject PrerequisiteComponent) {}
	public void RemoveTickPrerequisiteActor(UObject PrerequisiteActor) {}
	public void RemoveTickPrerequisiteComponent(UObject PrerequisiteComponent) {}
	public bool GetTickableWhenPaused() { return default; }
	public void SetTickableWhenPaused(bool bTickableWhenPaused) {}
	public float GetGameTimeSinceCreation() { return default; }
	public void ReceiveBeginPlay() {}
	public void ReceiveEndPlay(EEndPlayReason EndPlayReason) {}
	public bool IsActorBeingDestroyed() { return default; }
	public void ReceiveAnyDamage(float Damage,UObject DamageType,UObject InstigatedBy,UObject DamageCauser) {}
	public void ReceiveRadialDamage(float DamageReceived,UObject DamageType,FVector Origin,FHitResult HitInfo,UObject InstigatedBy,UObject DamageCauser) {}
	public void ReceivePointDamage(float Damage,UObject DamageType,FVector HitLocation,FVector HitNormal,UObject HitComponent,string BoneName,FVector ShotFromDirection,UObject InstigatedBy,UObject DamageCauser,FHitResult HitInfo) {}
	public void ReceiveTick(float DeltaSeconds) {}
	public void ReceiveAsyncPhysicsTick(float DeltaSeconds,float SimSeconds) {}
	public void ReceiveActorBeginOverlap(UObject OtherActor) {}
	public void ReceiveActorEndOverlap(UObject OtherActor) {}
	public void ReceiveActorBeginCursorOver() {}
	public void ReceiveActorEndCursorOver() {}
	public void ReceiveActorOnClicked(FKey ButtonPressed) {}
	public void ReceiveActorOnReleased(FKey ButtonReleased) {}
	public void ReceiveActorOnInputTouchBegin(ETouchIndex FingerIndex) {}
	public void ReceiveActorOnInputTouchEnd(ETouchIndex FingerIndex) {}
	public void ReceiveActorOnInputTouchEnter(ETouchIndex FingerIndex) {}
	public void ReceiveActorOnInputTouchLeave(ETouchIndex FingerIndex) {}
	public void GetOverlappingActors(TArray<UObject> OverlappingActors,UClass ClassFilter/*=nullptr*/) {}
	public void GetOverlappingComponents(TArray<UObject> OverlappingComponents) {}
	public void ReceiveHit(UObject MyComp,UObject Other,UObject OtherComp,bool bSelfMoved,FVector HitLocation,FVector HitNormal,FVector NormalImpulse,FHitResult Hit) {}
	public void SetLifeSpan(float InLifespan) {}
	public float GetLifeSpan() { return default; }
	public void UserConstructionScript() {}
	public void ReceiveDestroyed() {}
	public FActorDestroyedSignature OnDestroyed;
	public FActorEndPlaySignature OnEndPlay;
	public bool IsHiddenEdAtStartup() { return default; }
	public bool IsHiddenEd() { return default; }
	public void SetIsTemporarilyHiddenInEditor(bool bIsHidden) {}
	public bool IsTemporarilyHiddenInEditor(bool bIncludeParent/*=false*/) { return default; }
	public bool IsEditable() { return default; }
	public bool IsSelectable() { return default; }
	public string GetDefaultActorLabel() { return default; }
	public string GetActorLabel(bool bCreateIfNone/*=true*/) { return default; }
	public void SetActorLabel(string NewActorLabel,bool bMarkDirty/*=true*/) {}
	public string GetFolderPath() { return default; }
	public void SetFolderPath(string NewFolderPath) {}
	public void SetActorTickEnabled(bool bEnabled) {}
	public bool IsActorTickEnabled() { return default; }
	public void SetActorTickInterval(float TickInterval) {}
	public float GetActorTickInterval() { return default; }
	public void OnRep_ReplicatedMovement() {}
	public void SetOwner(UObject NewOwner) {}
	public UObject GetOwner() { return default; }
	public bool IsOverlappingActor(UObject Other) { return default; }
	public void SetNetDormancy(ENetDormancy NewDormancy) {}
	public void FlushNetDormancy() {}
	public bool IsChildActor() { return default; }
	public void GetAllChildActors(TArray<UObject> ChildActors,bool bIncludeDescendants/*=true*/) {}
	public UObject GetParentComponent() { return default; }
	public UObject GetParentActor() { return default; }
	public bool K2_TeleportTo(FVector DestLocation,FRotator DestRotation) { return default; }
	public UObject GetLevel() { return default; }
	public FTransform GetLevelTransform() { return default; }
	public UObject GetAttachParentActor() { return default; }
	public string GetAttachParentSocketName() { return default; }
	public void GetAttachedActors(TArray<UObject> OutActors,bool bResetArray/*=true*/,bool bRecursivelyIncludeAttachedActors/*=false*/) {}
	public void SetTickGroup(ETickingGroup NewTickGroup) {}
	public void K2_OnBecomeViewTarget(UObject PC) {}
	public void K2_OnEndViewTarget(UObject PC) {}
	public void K2_OnReset() {}
	public bool WasRecentlyRendered(float Tolerance/*=0.2f*/) { return default; }
	public void ForceNetUpdate() {}
	public void PrestreamTextures(float Seconds,bool bEnableStreaming,int CinematicTextureGroups/*=0*/) {}
	public void GetActorEyesViewPoint(FVector OutLocation,FRotator OutRotation) {}
	public UObject GetComponentByClass(UClass ComponentClass) { return default; }
	public TArray<UObject> K2_GetComponentsByClass(UClass ComponentClass) { return default; }
	public TArray<UObject> GetComponentsByTag(UClass ComponentClass,string Tag) { return default; }
	public TArray<UObject> GetComponentsByInterface(UClass Interface) { return default; }
	public TArray<UActorComponent> InstanceComponents;
	public TArray<UActorComponent> BlueprintCreatedComponents;
	public void MakeNoise(float Loudness/*=1.0f*/,UObject NoiseInstigator/*=nullptr*/,FVector NoiseLocation/*=FVector.ZeroVector*/,float MaxRange/*=0.0f*/,string Tag/*=NAME_None*/) {}
}
