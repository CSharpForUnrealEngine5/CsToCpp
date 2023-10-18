namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A SceneComponent has a transform and supports attachment, but has no rendering or collision capabilities.</summary>
[CppInclude("Components/SceneComponent.h")]
public partial class USceneComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Physics Volume in which this SceneComponent is located *</summary>
	public TWeakObjectPtr<APhysicsVolume> PhysicsVolume;
	///<summary>What we are currently attached to. If valid, RelativeLocation etc. are used relative to this object</summary>
	public USceneComponent AttachParent;
	///<summary>Optional socket name on AttachParent that we are attached to.</summary>
	public FName AttachSocketName;
	///<summary>List of child SceneComponents that are attached to us.</summary>
	public TArray<USceneComponent> AttachChildren;
	///<summary>Set of attached SceneComponents that were attached by the client so we can fix up AttachChildren when it is replicated to us.</summary>
	public TArray<USceneComponent> ClientAttachedChildren;
	///<summary>Location of the component relative to its parent</summary>
	public FVector RelativeLocation;
	///<summary>Rotation of the component relative to its parent</summary>
	public FRotator RelativeRotation;
	///<summary>Non-uniform scaling of the component relative to its parent.</summary>
	public FVector RelativeScale3D;
	///<summary>Velocity of the component.</summary>
	public FVector ComponentVelocity;
	///<summary>True if we have ever updated ComponentToWorld based on RelativeLocation/Rotation/Scale. Used at startup to make sure it is initialized.</summary>
	public bool bComponentToWorldUpdated;
	///<summary>If RelativeLocation should be considered relative to the world, rather than the parent</summary>
	public bool bAbsoluteLocation;
	///<summary>If RelativeRotation should be considered relative to the world, rather than the parent</summary>
	public bool bAbsoluteRotation;
	///<summary>If RelativeScale3D should be considered relative to the world, rather than the parent</summary>
	public bool bAbsoluteScale;
	///<summary>Whether to completely draw the primitive; if false, the primitive is not drawn, does not cast a shadow.</summary>
	public bool bVisible;
	///<summary>Whether or not we should be attached.</summary>
	public bool bShouldBeAttached;
	///<summary>bShouldSnapLocationWhenAttached</summary>
	public bool bShouldSnapLocationWhenAttached;
	///<summary>bShouldSnapRotationWhenAttached</summary>
	public bool bShouldSnapRotationWhenAttached;
	///<summary>bShouldSnapScaleWhenAttached</summary>
	public bool bShouldSnapScaleWhenAttached;
	///<summary>Whether or not the cached PhysicsVolume this component overlaps should be updated when the component is moved.</summary>
	public bool bShouldUpdatePhysicsVolume;
	///<summary>Whether to hide the primitive in game, if the primitive is Visible.</summary>
	public bool bHiddenInGame;
	///<summary>If true, a change in the bounds of the component will call trigger a streaming data rebuild</summary>
	public bool bBoundsChangeTriggersStreamingDataRebuild;
	///<summary>If true, this component uses its parents bounds when attached.</summary>
	public bool bUseAttachParentBound;
	///<summary>If true, this component will use its current bounds transformed back into local space instead of calling CalcBounds with an identity transform.</summary>
	public bool bComputeFastLocalBounds;
	///<summary>If true, this component will cache its bounds during cooking or in PIE and never recompute it again. This is for components that are known to be static.</summary>
	public bool bComputeBoundsOnceForGame;
	///<summary>If true, this component has already cached its bounds during cooking or in PIE and will never recompute it again.</summary>
	public bool bComputedBoundsOnceForGame;
	///<summary>Gets whether or not the cached PhysicsVolume this component overlaps should be updated when the component is moved.</summary>
	public bool GetShouldUpdatePhysicsVolume() { return default; }
	///<summary>Sets whether or not the cached PhysicsVolume this component overlaps should be updated when the component is moved.</summary>
	public void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume) {}
	///<summary>If true, this component stops the the walk up the attachment chain in GetActorPositionForRenderer(). Instead this component&#39;s child will be used as the attachment root.</summary>
	public bool bIsNotRenderAttachmentRoot;
	///<summary>This component should create a sprite component for visualization in the editor</summary>
	public bool bVisualizeComponent;
	///<summary>How often this component is allowed to move, used to make various optimizations. Only safe to set in constructor.</summary>
	public EComponentMobility Mobility;
	///<summary>If detail mode is &gt;= system detail mode, primitive won&#39;t be rendered.</summary>
	public EDetailMode DetailMode;
	///<summary>Delegate that will be called when PhysicsVolume has been changed *</summary>
	public FPhysicsVolumeChanged PhysicsVolumeChangedDelegate;
	///<summary>@todo_ow: This is needed because of order of registration of Actors</summary>
	public USceneComponent ReplacementSceneComponent;
	///<summary>OnRep_Transform</summary>
	public void OnRep_Transform() {}
	///<summary>OnRep_AttachParent</summary>
	public void OnRep_AttachParent() {}
	///<summary>OnRep_AttachChildren</summary>
	public void OnRep_AttachChildren() {}
	///<summary>OnRep_AttachSocketName</summary>
	public void OnRep_AttachSocketName() {}
	///<summary>OnRep_Visibility</summary>
	public void OnRep_Visibility(bool OldValue) {}
	///<summary>Set the location of the component relative to its parent</summary>
	public void K2_SetRelativeLocation(FVector NewLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set the rotation of the component relative to its parent</summary>
	public void K2_SetRelativeRotation(FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set the transform of the component relative to its parent</summary>
	public void K2_SetRelativeTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Returns the transform of the component relative to its parent</summary>
	public FTransform GetRelativeTransform() { return default; }
	///<summary>Reset the transform of the component relative to its parent. Sets relative location to zero, relative rotation to no rotation, and Scale to 1.</summary>
	public void ResetRelativeTransform() {}
	///<summary>Set the non-uniform scale of the component relative to its parent</summary>
	public void SetRelativeScale3D(FVector NewScale3D) {}
	///<summary>Adds a delta to the translation of the component relative to its parent</summary>
	public void K2_AddRelativeLocation(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta the rotation of the component relative to its parent</summary>
	public void K2_AddRelativeRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the location of the component in its local reference frame</summary>
	public void K2_AddLocalOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the rotation of the component in its local reference frame</summary>
	public void K2_AddLocalRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the transform of the component in its local reference frame. Scale is unchanged.</summary>
	public void K2_AddLocalTransform(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Put this component at the specified location in world space. Updates relative location to achieve the final world location.</summary>
	public void K2_SetWorldLocation(FVector NewLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>* Put this component at the specified rotation in world space. Updates relative rotation to achieve the final world rotation.</summary>
	public void K2_SetWorldRotation(FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set the relative scale of the component to put it at the supplied scale in world space.</summary>
	public void SetWorldScale3D(FVector NewScale) {}
	///<summary>Set the transform of the component in world space.</summary>
	public void K2_SetWorldTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the location of the component in world space.</summary>
	public void K2_AddWorldOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the rotation of the component in world space.</summary>
	public void K2_AddWorldRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the transform of the component in world space. Ignores scale and sets it to (1,1,1).</summary>
	public void K2_AddWorldTransform(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the transform of the component in world space. Scale is unchanged.</summary>
	public void K2_AddWorldTransformKeepScale(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Return location of the component, in world space</summary>
	public FVector K2_GetComponentLocation() { return default; }
	///<summary>Returns rotation of the component, in world space.</summary>
	public FRotator K2_GetComponentRotation() { return default; }
	///<summary>Returns scale of the component, in world space.</summary>
	public FVector K2_GetComponentScale() { return default; }
	///<summary>Get the current component-to-world transform for this component</summary>
	public FTransform K2_GetComponentToWorld() { return default; }
	///<summary>Get the forward (X) unit direction vector from this component, in world space.</summary>
	public FVector GetForwardVector() { return default; }
	///<summary>Get the up (Z) unit direction vector from this component, in world space.</summary>
	public FVector GetUpVector() { return default; }
	///<summary>Get the right (Y) unit direction vector from this component, in world space.</summary>
	public FVector GetRightVector() { return default; }
	///<summary>Returns whether the specified body is currently using physics simulation</summary>
	public virtual bool IsSimulatingPhysics(FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Returns whether the specified body is currently using physics simulation</summary>
	public virtual bool IsAnySimulatingPhysics() { return default; }
	///<summary>Get the SceneComponent we are attached to.</summary>
	public USceneComponent GetAttachParent() { return default; }
	///<summary>Get the socket we are attached to.</summary>
	public FName GetAttachSocketName() { return default; }
	///<summary>Gets all attachment parent components up to and including the root component</summary>
	public void GetParentComponents(TArray<USceneComponent> Parents) {}
	///<summary>Gets the number of attached children components</summary>
	public int GetNumChildrenComponents() { return default; }
	///<summary>Gets the attached child component at the specified location</summary>
	public USceneComponent GetChildComponent(int ChildIndex) { return default; }
	///<summary>Gets all components that are attached to this component, possibly recursively</summary>
	public void GetChildrenComponents(bool bIncludeAllDescendants,TArray<USceneComponent> Children) {}
	///<summary>K2_AttachTo</summary>
	public bool K2_AttachTo(USceneComponent InParent,FName InSocketName/*=NAME_None*/,EAttachLocation AttachType/*=EAttachLocation.KeepRelativeOffset*/,bool bWeldSimulatedBodies/*=true*/) { return default; }
	///<summary>Attach this component to another scene component, optionally at a named socket. It is valid to call this on components whether or not they have been Registered.</summary>
	public bool K2_AttachToComponent(USceneComponent Parent,FName SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies) { return default; }
	///<summary>DetachFromParent</summary>
	public virtual void DetachFromParent(bool bMaintainWorldPosition/*=false*/,bool bCallModify/*=true*/) {}
	///<summary>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo)</summary>
	public void K2_DetachFromComponent(EDetachmentRule LocationRule/*=EDetachmentRule.KeepRelative*/,EDetachmentRule RotationRule/*=EDetachmentRule.KeepRelative*/,EDetachmentRule ScaleRule/*=EDetachmentRule.KeepRelative*/,bool bCallModify/*=true*/) {}
	///<summary>Gets the names of all the sockets on the component.</summary>
	public TArray<FName> GetAllSocketNames() { return default; }
	///<summary>Get world-space socket transform.</summary>
	public virtual FTransform GetSocketTransform(FName InSocketName,ERelativeTransformSpace TransformSpace/*=RTS_World*/) { return default; }
	///<summary>Get world-space socket or bone location.</summary>
	public virtual FVector GetSocketLocation(FName InSocketName) { return default; }
	///<summary>Get world-space socket or bone  FRotator rotation.</summary>
	public virtual FRotator GetSocketRotation(FName InSocketName) { return default; }
	///<summary>Get world-space socket or bone FQuat rotation.</summary>
	public virtual FQuat GetSocketQuaternion(FName InSocketName) { return default; }
	///<summary>Return true if socket with the given name exists</summary>
	public virtual bool DoesSocketExist(FName InSocketName) { return default; }
	///<summary>Get velocity of the component: either ComponentVelocity, or the velocity of the physics body if simulating physics.</summary>
	public virtual FVector GetComponentVelocity() { return default; }
	///<summary>Returns true if this component is visible in the current context</summary>
	public virtual bool IsVisible() { return default; }
	///<summary>Set visibility of the component, if during game use this to turn on/off</summary>
	public void SetVisibility(bool bNewVisibility,bool bPropagateToChildren/*=false*/) {}
	///<summary>Toggle visibility of the component</summary>
	public void ToggleVisibility(bool bPropagateToChildren/*=false*/) {}
	///<summary>Changes the value of bHiddenInGame, if false this will disable Visibility during gameplay</summary>
	public void SetHiddenInGame(bool NewHidden,bool bPropagateToChildren/*=false*/) {}
	///<summary>Get the PhysicsVolume overlapping this component.</summary>
	public APhysicsVolume GetPhysicsVolume() { return default; }
	///<summary>Set the location and rotation of the component relative to its parent</summary>
	public void K2_SetRelativeLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set which parts of the relative transform should be relative to parent, and which should be relative to world</summary>
	public void SetAbsolute(bool bNewAbsoluteLocation/*=false*/,bool bNewAbsoluteRotation/*=false*/,bool bNewAbsoluteScale/*=false*/) {}
	///<summary>Set the relative location and rotation of the component to put it at the supplied pose in world space.</summary>
	public void K2_SetWorldLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set how often this component is allowed to move during runtime. Causes a component re-register if the component is already registered</summary>
	public virtual void SetMobility(EComponentMobility NewMobility) {}
}
