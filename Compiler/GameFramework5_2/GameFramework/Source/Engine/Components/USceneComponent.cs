#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SceneComponent.h")]
///<summary>A SceneComponent has a transform and supports attachment, but has no rendering or collision capabilities.</summary>
public partial class USceneComponent : UActorComponent {
// SceneComponent
	public TWeakObjectPtr<APhysicsVolume> PhysicsVolume;
	public USceneComponent AttachParent;
	public string AttachSocketName;
	public TArray<USceneComponent> AttachChildren;
	public TArray<USceneComponent> ClientAttachedChildren;
	public FVector RelativeLocation;
	public FRotator RelativeRotation;
	public FVector RelativeScale3D;
	public FVector ComponentVelocity;
	public bool bComponentToWorldUpdated;
	public bool bAbsoluteLocation;
	public bool bAbsoluteRotation;
	public bool bAbsoluteScale;
	public bool bVisible;
	public bool bShouldBeAttached;
	public bool bShouldSnapLocationWhenAttached;
	public bool bShouldSnapRotationWhenAttached;
	public bool bShouldSnapScaleWhenAttached;
	public bool bShouldUpdatePhysicsVolume;
	public bool bHiddenInGame;
	public bool bBoundsChangeTriggersStreamingDataRebuild;
	public bool bUseAttachParentBound;
	public bool bComputeFastLocalBounds;
	public bool bComputeBoundsOnceForGame;
	public bool bComputedBoundsOnceForGame;
	public  bool GetShouldUpdatePhysicsVolume() { return default; }
	public  void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume) {}
	public bool bIsNotRenderAttachmentRoot;
	public bool bVisualizeComponent;
	public EComponentMobility Mobility;
	public EDetailMode DetailMode;
	public FPhysicsVolumeChanged PhysicsVolumeChangedDelegate;
	public USceneComponent ReplacementSceneComponent;
	public  void OnRep_Transform() {}
	public  void OnRep_AttachParent() {}
	public  void OnRep_AttachChildren() {}
	public  void OnRep_AttachSocketName() {}
	public  void OnRep_Visibility(bool OldValue) {}
	public  void K2_SetRelativeLocation(FVector NewLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_SetRelativeRotation(FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_SetRelativeTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  FTransform GetRelativeTransform() { return default; }
	public  void ResetRelativeTransform() {}
	public  void SetRelativeScale3D(FVector NewScale3D) {}
	public  void K2_AddRelativeLocation(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_AddRelativeRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_AddLocalOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_AddLocalRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_AddLocalTransform(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_SetWorldLocation(FVector NewLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_SetWorldRotation(FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void SetWorldScale3D(FVector NewScale) {}
	public  void K2_SetWorldTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_AddWorldOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_AddWorldRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_AddWorldTransform(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void K2_AddWorldTransformKeepScale(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  FVector K2_GetComponentLocation() { return default; }
	public  FRotator K2_GetComponentRotation() { return default; }
	public  FVector K2_GetComponentScale() { return default; }
	public  FTransform K2_GetComponentToWorld() { return default; }
	public  FVector GetForwardVector() { return default; }
	public  FVector GetUpVector() { return default; }
	public  FVector GetRightVector() { return default; }
	public  bool IsSimulatingPhysics(string BoneName/*=NAME_None*/) { return default; }
	public  bool IsAnySimulatingPhysics() { return default; }
	public  USceneComponent GetAttachParent() { return default; }
	public  string GetAttachSocketName() { return default; }
	public  void GetParentComponents(TArray<USceneComponent> Parents) {}
	public  int GetNumChildrenComponents() { return default; }
	public  USceneComponent GetChildComponent(int ChildIndex) { return default; }
	public  void GetChildrenComponents(bool bIncludeAllDescendants,TArray<USceneComponent> Children) {}
	public  bool K2_AttachTo(USceneComponent InParent,string InSocketName/*=NAME_None*/,EAttachLocation AttachType/*=EAttachLocation.KeepRelativeOffset*/,bool bWeldSimulatedBodies/*=true*/) { return default; }
	public  bool K2_AttachToComponent(USceneComponent Parent,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies) { return default; }
	public  void DetachFromParent(bool bMaintainWorldPosition/*=false*/,bool bCallModify/*=true*/) {}
	public  void K2_DetachFromComponent(EDetachmentRule LocationRule/*=EDetachmentRule.KeepRelative*/,EDetachmentRule RotationRule/*=EDetachmentRule.KeepRelative*/,EDetachmentRule ScaleRule/*=EDetachmentRule.KeepRelative*/,bool bCallModify/*=true*/) {}
	public  TArray<string> GetAllSocketNames() { return default; }
	public  FTransform GetSocketTransform(string InSocketName,ERelativeTransformSpace TransformSpace/*=RTS_World*/) { return default; }
	public  FVector GetSocketLocation(string InSocketName) { return default; }
	public  FRotator GetSocketRotation(string InSocketName) { return default; }
	public  FQuat GetSocketQuaternion(string InSocketName) { return default; }
	public  bool DoesSocketExist(string InSocketName) { return default; }
	public  FVector GetComponentVelocity() { return default; }
	public  bool IsVisible() { return default; }
	public  void SetVisibility(bool bNewVisibility,bool bPropagateToChildren/*=false*/) {}
	public  void ToggleVisibility(bool bPropagateToChildren/*=false*/) {}
	public  void SetHiddenInGame(bool NewHidden,bool bPropagateToChildren/*=false*/) {}
	public  APhysicsVolume GetPhysicsVolume() { return default; }
	public  void K2_SetRelativeLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void SetAbsolute(bool bNewAbsoluteLocation/*=false*/,bool bNewAbsoluteRotation/*=false*/,bool bNewAbsoluteScale/*=false*/) {}
	public  void K2_SetWorldLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public  void SetMobility(EComponentMobility NewMobility) {}
}
