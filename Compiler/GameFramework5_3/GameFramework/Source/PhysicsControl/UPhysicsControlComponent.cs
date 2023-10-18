namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the main Physics Control Component class which manages Controls and Body Modifiers associated</summary>
[CppInclude("PhysicsControlComponent.h")]
public partial class UPhysicsControlComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Allows manual ticking so that your code can run in between updating the target caches and updating</summary>
	public void UpdateTargetCaches(float DeltaTime) {}
	///<summary>Allows manual ticking so that your code can run in between updating the target caches and updating</summary>
	public void UpdateControls(float DeltaTime) {}
	///<summary>Creates a new control for mesh components</summary>
	public FName CreateControl(UMeshComponent ParentMeshComponent,FName ParentBoneName,UMeshComponent ChildMeshComponent,FName ChildBoneName,FPhysicsControlData ControlData,FPhysicsControlTarget ControlTarget,FPhysicsControlSettings ControlSettings,FName Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a new control for mesh components</summary>
	public bool CreateNamedControl(FName Name,UMeshComponent ParentMeshComponent,FName ParentBoneName,UMeshComponent ChildMeshComponent,FName ChildBoneName,FPhysicsControlData ControlData,FPhysicsControlTarget ControlTarget,FPhysicsControlSettings ControlSettings,FName Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of controls controlling a skeletal mesh</summary>
	public TArray<FName> CreateControlsFromSkeletalMeshBelow(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName,bool bIncludeSelf,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,FName Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of ParentSpace controls controlling a skeletal mesh, initializing</summary>
	public TArray<FName> CreateControlsFromSkeletalMeshAndConstraintProfileBelow(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName,bool bIncludeSelf,FName ConstraintProfile,FName Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of controls controlling a skeletal mesh</summary>
	public TArray<FName> CreateControlsFromSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent,TArray<FName> BoneNames,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,FName Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of ParentSpace controls controlling a skeletal mesh, initializing them</summary>
	public TArray<FName> CreateControlsFromSkeletalMeshAndConstraintProfile(USkeletalMeshComponent SkeletalMeshComponent,TArray<FName> BoneNames,FName ConstraintProfile,FName Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Calculates which bones belong to which limb in a skeletal mesh</summary>
	public TMap<FName,FPhysicsControlLimbBones> GetLimbBonesFromSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent,TArray<FPhysicsControlLimbSetupData> LimbSetupData) { return default; }
	///<summary>Creates a collection of controls controlling a skeletal mesh, grouped together in limbs</summary>
	public TMap<FName,FPhysicsControlNames> CreateControlsFromLimbBones(FPhysicsControlNames AllControls,TMap<FName,FPhysicsControlLimbBones> LimbBones,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of ParentSpace controls controlling a skeletal mesh, grouped together in limbs, initializing</summary>
	public TMap<FName,FPhysicsControlNames> CreateControlsFromLimbBonesAndConstraintProfile(FPhysicsControlNames AllControls,TMap<FName,FPhysicsControlLimbBones> LimbBones,FName ConstraintProfile,bool bEnabled/*=true*/) { return default; }
	///<summary>Destroys a control</summary>
	public bool DestroyControl(FName Name) { return default; }
	///<summary>Destroys all controls</summary>
	public void DestroyControls(TArray<FName> Names) {}
	///<summary>Destroys all controls in a set</summary>
	public void DestroyControlsInSet(FName Set) {}
	///<summary>Modifies an existing control data - i.e. the strengths etc of the control driving towards the target</summary>
	public bool SetControlData(FName Name,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) { return default; }
	///<summary>Modifies existing control data - i.e. the strengths etc of the controls driving towards the targets</summary>
	public void SetControlDatas(TArray<FName> Names,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) {}
	///<summary>Modifies existing control data - i.e. the strengths etc of the controls driving towards the targets</summary>
	public void SetControlDatasInSet(FName Set,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) {}
	///<summary>Modifies an existing control data using the multipliers</summary>
	public bool SetControlMultiplier(FName Name,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) { return default; }
	///<summary>Modifies existing control data using the multipliers</summary>
	public void SetControlMultipliers(TArray<FName> Names,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) {}
	///<summary>Modifies existing control data using the multipliers</summary>
	public void SetControlMultipliersInSet(FName Set,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) {}
	///<summary>Modifies an existing control&#39;s linear data - i.e. the strengths etc of the control driving towards the target</summary>
	public bool SetControlLinearData(FName Name,float Strength/*=1.0f*/,float DampingRatio/*=1.0f*/,float ExtraDamping/*=0.0f*/,float MaxForce/*=0.0f*/,bool bEnableControl/*=true*/) { return default; }
	///<summary>Modifies an existing control&#39;s angular data - i.e. the strengths etc of the control driving towards the target</summary>
	public bool SetControlAngularData(FName Name,float Strength/*=1.0f*/,float DampingRatio/*=1.0f*/,float ExtraDamping/*=0.0f*/,float MaxTorque/*=0.0f*/,bool bEnableControl/*=true*/) { return default; }
	///<summary>Sets the point at which controls will &quot;push&quot; the child object.</summary>
	public bool SetControlPoint(FName Name,FVector Position) { return default; }
	///<summary>Resets the control point to the center of mass of the mesh</summary>
	public bool ResetControlPoint(FName Name) { return default; }
	///<summary>Modifies an existing control target - i.e. what it is driving towards, relative to the parent object</summary>
	public bool SetControlTarget(FName Name,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) { return default; }
	///<summary>Modifies existing control targets - i.e. what they are driving towards, relative to the parent objects</summary>
	public void SetControlTargets(TArray<FName> Names,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) {}
	///<summary>Modifies existing control targets - i.e. what they are driving towards, relative to the parent objects</summary>
	public void SetControlTargetsInSet(FName Set,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) {}
	///<summary>Modifies an existing control target - i.e. what it is driving towards, relative to the parent object</summary>
	public bool SetControlTargetPositionAndOrientation(FName Name,FVector Position,FRotator Orientation,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Calls SetControlTargetPositionAndOrientation for each of the control names</summary>
	public void SetControlTargetPositionsAndOrientations(TArray<FName> Names,FVector Position,FRotator Orientation,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) {}
	///<summary>Calls SetControlTargetPositionAndOrientation for each control in the set</summary>
	public void SetControlTargetPositionsAndOrientationsInSet(FName SetName,FVector Position,FRotator Orientation,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) {}
	///<summary>Modifies an existing control target - i.e. what it is driving towards, relative to the parent object</summary>
	public bool SetControlTargetPosition(FName Name,FVector Position,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Calls SetControlTargetPosition for each of the control names</summary>
	public void SetControlTargetPositions(TArray<FName> Names,FVector Position,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) {}
	///<summary>Calls SetControlTargetPosition for each of the controls in the set</summary>
	public void SetControlTargetPositionsInSet(FName SetName,FVector Position,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) {}
	///<summary>Modifies an existing control target - i.e. what it is driving towards, relative to the parent object</summary>
	public bool SetControlTargetOrientation(FName Name,FRotator Orientation,float AngularVelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Calls SetControlTargetOrientation for each of the control names</summary>
	public void SetControlTargetOrientations(TArray<FName> Names,FRotator Orientation,float AngularVelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) {}
	///<summary>Calls SetControlTargetOrientation for each of the controls in the set</summary>
	public void SetControlTargetOrientationsInSet(FName SetName,FRotator Orientation,float AngularVelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) {}
	///<summary>Calls SetControlTargetPosition for each element of the control names and positions. These array should match</summary>
	public bool SetControlTargetPositionsFromArray(TArray<FName> Names,TArray<FVector> Positions,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Calls SetControlTargetPosition for each element of the control names and positions. These array should match</summary>
	public bool SetControlTargetOrientationsFromArray(TArray<FName> Names,TArray<FRotator> Orientations,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Calls SetControlTargetPositionAndOrientation for each element of the control names, positions and orientations.</summary>
	public bool SetControlTargetPositionsAndOrientationsFromArray(TArray<FName> Names,TArray<FVector> Positions,TArray<FRotator> Orientations,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Calculates and sets an existing control target. This takes the &quot;virtual&quot; position/orientation of the parent</summary>
	public bool SetControlTargetPoses(FName Name,FVector ParentPosition,FRotator ParentOrientation,FVector ChildPosition,FRotator ChildOrientation,float VelocityDeltaTime,bool bEnableControl/*=true*/) { return default; }
	///<summary>Sets whether or not the control should use skeletal animation for the targets</summary>
	public bool SetControlUseSkeletalAnimation(FName Name,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) { return default; }
	///<summary>Sets whether or not the controls should use skeletal animation for the targets</summary>
	public void SetControlsUseSkeletalAnimation(TArray<FName> Names,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) {}
	///<summary>Sets whether or not the controls should use skeletal animation for the targets</summary>
	public void SetControlsInSetUseSkeletalAnimation(FName Set,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) {}
	///<summary>Activates or deactivates a control</summary>
	public bool SetControlEnabled(FName Name,bool bEnable/*=true*/) { return default; }
	///<summary>Activates or deactivates controls</summary>
	public void SetControlsEnabled(TArray<FName> Names,bool bEnable/*=true*/) {}
	///<summary>Activates or deactivates controls</summary>
	public void SetControlsInSetEnabled(FName Set,bool bEnable/*=true*/) {}
	///<summary>@param Name The name of the control to modify.</summary>
	public bool SetControlAutoDisable(FName Name,bool bAutoDisable) { return default; }
	///<summary>@param Names The names of the controls to modify.</summary>
	public void SetControlsAutoDisable(TArray<FName> Names,bool bAutoDisable) {}
	///<summary>@param Set The set of controls to modify. Standard sets will include &quot;All&quot;, &quot;WorldSpace&quot;,</summary>
	public void SetControlsInSetAutoDisable(FName Set,bool bAutoDisable) {}
	///<summary>@param Name The name of the control to modify.</summary>
	public bool SetControlDisableCollision(FName Name,bool bDisableCollision) { return default; }
	///<summary>@param Names The names of the controls to modify.</summary>
	public void SetControlsDisableCollision(TArray<FName> Names,bool bDisableCollision) {}
	///<summary>@param Set The set of controls to modify. Standard sets will include &quot;All&quot;, &quot;WorldSpace&quot;,</summary>
	public void SetControlsInSetDisableCollision(FName Set,bool bDisableCollision) {}
	///<summary>@param Name     The name of the control to access.</summary>
	public bool GetControlData(FName Name,FPhysicsControlData ControlData) { return default; }
	///<summary>@param Name     The name of the control to access.</summary>
	public bool GetControlMultiplier(FName Name,FPhysicsControlMultiplier ControlMultiplier) { return default; }
	///<summary>@param Name     The name of the control to access.</summary>
	public bool GetControlTarget(FName Name,FPhysicsControlTarget ControlTarget) { return default; }
	///<summary>@param Name        The name of the control to access.</summary>
	public bool GetControlAutoDisable(FName Name) { return default; }
	///<summary>@param Name        The name of the control to access.</summary>
	public bool GetControlEnabled(FName Name) { return default; }
	///<summary>Creates a new body modifier for mesh components</summary>
	public FName CreateBodyModifier(UMeshComponent MeshComponent,FName BoneName,FName Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,float PhysicsBlendWeight/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/,bool bUpdateKinematicFromSimulation/*=true*/) { return default; }
	///<summary>Creates a new body modifier for mesh components</summary>
	public bool CreateNamedBodyModifier(FName Name,UMeshComponent MeshComponent,FName BoneName,FName Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,float PhysicsBlendWeight/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/,bool bUpdateKinematicFromSimulation/*=true*/) { return default; }
	///<summary>Creates new body modifiers for skeletal mesh components</summary>
	public TArray<FName> CreateBodyModifiersFromSkeletalMeshBelow(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName,bool bIncludeSelf,FName Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,float PhysicsBlendWeight/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/,bool bUpdateKinematicFromSimulation/*=true*/) { return default; }
	///<summary>Creates a collection of controls controlling a skeletal mesh, grouped together in limbs</summary>
	public TMap<FName,FPhysicsControlNames> CreateBodyModifiersFromLimbBones(FPhysicsControlNames AllBodyModifiers,TMap<FName,FPhysicsControlLimbBones> LimbBones,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,float PhysicsBlendWeight/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/,bool bUpdateKinematicFromSimulation/*=true*/) { return default; }
	///<summary>Destroys a BodyModifier</summary>
	public bool DestroyBodyModifier(FName Name) { return default; }
	///<summary>Destroys BodyModifiers</summary>
	public void DestroyBodyModifiers(TArray<FName> Names) {}
	///<summary>Destroys BodyModifiers</summary>
	public void DestroyBodyModifiersInSet(FName Set) {}
	///<summary>Sets the kinematic target transform for a body modifier.</summary>
	public bool SetBodyModifierKinematicTarget(FName Name,FVector KinematicTargetPosition,FRotator KinematicTargetOrienation,bool bMakeKinematic) { return default; }
	///<summary>Sets the movement type for a body modifier</summary>
	public bool SetBodyModifierMovementType(FName Name,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) { return default; }
	///<summary>Sets the movement type for body modifiers</summary>
	public void SetBodyModifiersMovementType(TArray<FName> Names,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) {}
	///<summary>Sets the movement type for body modifiers</summary>
	public void SetBodyModifiersInSetMovementType(FName Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) {}
	///<summary>Sets the collision type for a body modifier</summary>
	public bool SetBodyModifierCollisionType(FName Name,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) { return default; }
	///<summary>Sets the collision type for body modifiers</summary>
	public void SetBodyModifiersCollisionType(TArray<FName> Names,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) {}
	///<summary>Sets the collision type for body modifiers</summary>
	public void SetBodyModifiersInSetCollisionType(FName Set,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) {}
	///<summary>Sets the gravity multiplier for a body modifier</summary>
	public bool SetBodyModifierGravityMultiplier(FName Name,float GravityMultiplier/*=1.0f*/) { return default; }
	///<summary>Sets the gravity multiplier for body modifiers</summary>
	public void SetBodyModifiersGravityMultiplier(TArray<FName> Names,float GravityMultiplier/*=1.0f*/) {}
	///<summary>Sets the gravity multiplier for body modifiers</summary>
	public void SetBodyModifiersInSetGravityMultiplier(FName Set,float GravityMultiplier/*=1.0f*/) {}
	///<summary>Sets the physics blend weight for a body modifier</summary>
	public bool SetBodyModifierPhysicsBlendWeight(FName Name,float PhysicsBlendWeight/*=1.0f*/) { return default; }
	///<summary>Sets the physics blend weight for body modifiers</summary>
	public void SetBodyModifiersPhysicsBlendWeight(TArray<FName> Names,float PhysicsBlendWeight/*=1.0f*/) {}
	///<summary>Sets the physics blend weight for body modifiers</summary>
	public void SetBodyModifiersInSetPhysicsBlendWeight(FName Set,float PhysicsBlendWeight/*=1.0f*/) {}
	///<summary>Sets whether a body modifier should use skeletal animation for its kinematic targets</summary>
	public bool SetBodyModifierUseSkeletalAnimation(FName Name,bool bUseSkeletalAnimation) { return default; }
	///<summary>Sets whether body modifiers should use skeletal animation for their kinematic targets</summary>
	public void SetBodyModifiersUseSkeletalAnimation(TArray<FName> Names,bool bUseSkeletalAnimation) {}
	///<summary>Sets whether body modifiers should use skeletal animation for their kinematic targets</summary>
	public void SetBodyModifiersInSetUseSkeletalAnimation(FName Set,bool bUseSkeletalAnimation) {}
	///<summary>Sets whether a body modifier should update kinematics from the simulation results</summary>
	public bool SetBodyModifierUpdateKinematicFromSimulation(FName Name,bool bUpdateKinematicFromSimulation) { return default; }
	///<summary>Sets whether body modifiers should update kinematics from the simulation results</summary>
	public void SetBodyModifiersUpdateKinematicFromSimulation(TArray<FName> Names,bool bUpdateKinematicFromSimulation) {}
	///<summary>Sets whether body modifiers should update kinematics from the simulation results</summary>
	public void SetBodyModifiersInSetUpdateKinematicFromSimulation(FName Set,bool bUpdateKinematicFromSimulation) {}
	///<summary>Creates a collections of controls and body modifiers for a character, based on the description passed in.</summary>
	public void CreateControlsAndBodyModifiersFromLimbBones(FPhysicsControlNames AllWorldSpaceControls,TMap<FName,FPhysicsControlNames> LimbWorldSpaceControls,FPhysicsControlNames AllParentSpaceControls,TMap<FName,FPhysicsControlNames> LimbParentSpaceControls,FPhysicsControlNames AllBodyModifiers,TMap<FName,FPhysicsControlNames> LimbBodyModifiers,USkeletalMeshComponent SkeletalMeshComponent,TArray<FPhysicsControlLimbSetupData> LimbSetupData,FPhysicsControlData WorldSpaceControlData,FPhysicsControlSettings WorldSpaceControlSettings,bool bEnableWorldSpaceControls,FPhysicsControlData ParentSpaceControlData,FPhysicsControlSettings ParentSpaceControlSettings,bool bEnableParentSpaceControls,EPhysicsMovementType PhysicsMovementType/*=EPhysicsMovementType.Static*/,float GravityMultiplier/*=1.0f*/,float PhysicsBlendWeight/*=1.0f*/) {}
	///<summary>Adds a Control to a Set. This will add a new set if necessary. For example, you might</summary>
	public void AddControlToSet(FPhysicsControlNames NewSet,FName Control,FName Set) {}
	///<summary>Adds Controls to a Set. This will add a new set if necessary. For example, you might</summary>
	public void AddControlsToSet(FPhysicsControlNames NewSet,TArray<FName> Controls,FName Set) {}
	///<summary>Returns a reference to all the control names that have been created.</summary>
	public TArray<FName> GetAllControlNames() { return default; }
	///<summary>Returns a reference to all the control names that have been created and are in the specified</summary>
	public TArray<FName> GetControlNamesInSet(FName Set) { return default; }
	///<summary>Returns a reference to all the body modifier names that have been created.</summary>
	public TArray<FName> GetAllBodyModifierNames() { return default; }
	///<summary>Returns a reference to all the body modifier names that have been created and are in the specified</summary>
	public TArray<FName> GetBodyModifierNamesInSet(FName Set) { return default; }
	///<summary>Adds a BodyModifier to a Set. This will add a new set if necessary. For example, you might</summary>
	public void AddBodyModifierToSet(FPhysicsControlNames NewSet,FName BodyModifier,FName Set) {}
	///<summary>Adds BodyModifiers to a Set. This will add a new set if necessary. For example, you might</summary>
	public void AddBodyModifiersToSet(FPhysicsControlNames NewSet,TArray<FName> BodyModifiers,FName Set) {}
	///<summary>Returns the names of all sets containing the control (may be empty - e.g. if it doesn&#39;t exist)</summary>
	public TArray<FName> GetSetsContainingControl(FName Control) { return default; }
	///<summary>Returns the names of all sets containing the body modifier (may be empty - e.g. if it doesn&#39;t exist)</summary>
	public TArray<FName> GetSetsContainingBodyModifier(FName Control) { return default; }
	///<summary>Gets the transforms of the requested bones that will be used as targets (in world space). Targets for bones</summary>
	public TArray<FTransform> GetCachedBoneTransforms(USkeletalMeshComponent SkeletalMeshComponent,TArray<FName> BoneNames) { return default; }
	///<summary>Gets the positions of the requested bones that will be used as targets (in world space). Targets for bones</summary>
	public TArray<FVector> GetCachedBonePositions(USkeletalMeshComponent SkeletalMeshComponent,TArray<FName> BoneNames) { return default; }
	///<summary>Gets the orientations of the requested bones that will be used as targets (in world space). Targets for bones</summary>
	public TArray<FRotator> GetCachedBoneOrientations(USkeletalMeshComponent SkeletalMeshComponent,TArray<FName> BoneNames) { return default; }
	///<summary>Gets the linear velocities of the requested bones that will be used as targets (in world space). Target</summary>
	public TArray<FVector> GetCachedBoneVelocities(USkeletalMeshComponent SkeletalMeshComponent,TArray<FName> BoneNames) { return default; }
	///<summary>Gets the angular velocities of the requested bones that will be used as targets (in world space). Target</summary>
	public TArray<FVector> GetCachedBoneAngularVelocities(USkeletalMeshComponent SkeletalMeshComponent,TArray<FName> BoneNames) { return default; }
	///<summary>Gets the transforms of the requested bone that will be used as a target (in world space). Targets for bones</summary>
	public FTransform GetCachedBoneTransform(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName) { return default; }
	///<summary>Gets the position of the requested bone that will be used as a target (in world space). Targets for bones</summary>
	public FVector GetCachedBonePosition(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName) { return default; }
	///<summary>Gets the orientation of the requested bone that will be used as a target (in world space). Targets for bones</summary>
	public FRotator GetCachedBoneOrientation(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName) { return default; }
	///<summary>Gets the linear velocity of the requested bone that will be used as a target (in world space). Target</summary>
	public FVector GetCachedBoneVelocity(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName) { return default; }
	///<summary>Gets the angular velocity of the requested bone that will be used as a target (in world space). Target</summary>
	public FVector GetCachedBoneAngularVelocity(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName) { return default; }
	///<summary>This allows the caller to override the target that will have been calculated and cached at the start of</summary>
	public bool SetCachedBoneData(USkeletalMeshComponent SkeletalMeshComponent,FName BoneName,FTransform TM,FVector Velocity,FVector AngularVelocity) { return default; }
	///<summary>This flags the body associated with the modifier to set (using teleport) its position and velocity to</summary>
	public bool ResetBodyModifierToCachedBoneTransform(FName Name,EResetToCachedTargetBehavior Behavior/*=EResetToCachedTargetBehavior.ResetImmediately*/) { return default; }
	///<summary>Calls ResetBodyModifierToCachedTarget for each of the body modifiers</summary>
	public void ResetBodyModifiersToCachedBoneTransforms(TArray<FName> Names,EResetToCachedTargetBehavior Behavior/*=EResetToCachedTargetBehavior.ResetImmediately*/) {}
	///<summary>Calls ResetBodyModifierToCachedTarget for each of the body modifiers in the set</summary>
	public void ResetBodyModifiersInSetToCachedBoneTransforms(FName SetName,EResetToCachedTargetBehavior Behavior/*=EResetToCachedTargetBehavior.ResetImmediately*/) {}
	///<summary>If the component moves by more than this distance then it is treated as a teleport,</summary>
	public float TeleportDistanceThreshold;
	///<summary>If the component rotates by more than this angle (in degrees) then it is treated as a teleport,</summary>
	public float TeleportRotationThreshold;
	///<summary>Visualize the controls when this component is selected</summary>
	public bool bShowDebugVisualization;
	///<summary>Size of the gizmos etc used during visualization</summary>
	public float VisualizationSizeScale;
	///<summary>Display all the controls and their basic properties when this component is selected</summary>
	public bool bShowDebugControlList;
	///<summary>Display detailed info for controls containing this string (if non-empty) when this component is selected</summary>
	public string DebugControlDetailFilter;
	///<summary>Display all the body modifiers and their basic properties when this component is selected</summary>
	public bool bShowDebugBodyModifierList;
	///<summary>Display detailed info for body modifiers containing this string (if non-empty) when this component is selected</summary>
	public string DebugBodyModifierDetailFilter;
	///<summary>The time used when &quot;predicting&quot; the target position/orientation. Zero will disable the visualization</summary>
	public float VelocityPredictionTime;
	///<summary>Upper limit on the number of controls or modifiers that will be created using the same name (which</summary>
	public int MaxNumControlsOrModifiersPerName;
}
