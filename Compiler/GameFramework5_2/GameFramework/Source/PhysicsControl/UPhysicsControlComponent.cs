#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the main Physics Control Component class which manages Controls and Body Modifiers associated</summary>
[CppInclude("PhysicsControlComponent.h")]
public partial class UPhysicsControlComponent : USceneComponent {
	///<summary>Creates a new control for mesh components</summary>
	public  string CreateControl(UMeshComponent ParentMeshComponent,string ParentBoneName,UMeshComponent ChildMeshComponent,string ChildBoneName,FPhysicsControlData ControlData,FPhysicsControlTarget ControlTarget,FPhysicsControlSettings ControlSettings,string Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a new control for mesh components</summary>
	public  bool CreateNamedControl(string Name,UMeshComponent ParentMeshComponent,string ParentBoneName,UMeshComponent ChildMeshComponent,string ChildBoneName,FPhysicsControlData ControlData,FPhysicsControlTarget ControlTarget,FPhysicsControlSettings ControlSettings,string Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of controls controlling a skeletal mesh</summary>
	public  TArray<string> CreateControlsFromSkeletalMeshBelow(USkeletalMeshComponent SkeletalMeshComponent,string BoneName,bool bIncludeSelf,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,string Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of ParentSpace controls controlling a skeletal mesh, initializing</summary>
	public  TArray<string> CreateControlsFromSkeletalMeshAndConstraintProfileBelow(USkeletalMeshComponent SkeletalMeshComponent,string BoneName,bool bIncludeSelf,string ConstraintProfile,string Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of controls controlling a skeletal mesh</summary>
	public  TArray<string> CreateControlsFromSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent,TArray<string> BoneNames,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,string Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of ParentSpace controls controlling a skeletal mesh, initializing them</summary>
	public  TArray<string> CreateControlsFromSkeletalMeshAndConstraintProfile(USkeletalMeshComponent SkeletalMeshComponent,TArray<string> BoneNames,string ConstraintProfile,string Set,bool bEnabled/*=true*/) { return default; }
	///<summary>Calculates which bones belong to which limb in a skeletal mesh</summary>
	public  TMap<string,FPhysicsControlLimbBones> GetLimbBonesFromSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent,TArray<FPhysicsControlLimbSetupData> LimbSetupData) { return default; }
	///<summary>Creates a collection of controls controlling a skeletal mesh, grouped together in limbs</summary>
	public  TMap<string,FPhysicsControlNames> CreateControlsFromLimbBones(FPhysicsControlNames AllControls,TMap<string,FPhysicsControlLimbBones> LimbBones,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,bool bEnabled/*=true*/) { return default; }
	///<summary>Creates a collection of ParentSpace controls controlling a skeletal mesh, grouped together in limbs, initializing</summary>
	public  TMap<string,FPhysicsControlNames> CreateControlsFromLimbBonesAndConstraintProfile(FPhysicsControlNames AllControls,TMap<string,FPhysicsControlLimbBones> LimbBones,string ConstraintProfile,bool bEnabled/*=true*/) { return default; }
	///<summary>Destroys a control</summary>
	public  bool DestroyControl(string Name) { return default; }
	///<summary>Destroys all controls</summary>
	public  void DestroyControls(TArray<string> Names) {}
	///<summary>Destroys all controls in a set</summary>
	public  void DestroyControlsInSet(string Set) {}
	///<summary>Modifies an existing control data - i.e. the strengths etc of the control driving towards the target</summary>
	public  bool SetControlData(string Name,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) { return default; }
	///<summary>Modifies existing control data - i.e. the strengths etc of the controls driving towards the targets</summary>
	public  void SetControlDatas(TArray<string> Names,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) {}
	///<summary>Modifies existing control data - i.e. the strengths etc of the controls driving towards the targets</summary>
	public  void SetControlDatasInSet(string Set,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) {}
	///<summary>Modifies an existing control data using the multipliers</summary>
	public  bool SetControlMultiplier(string Name,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) { return default; }
	///<summary>Modifies existing control data using the multipliers</summary>
	public  void SetControlMultipliers(TArray<string> Names,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) {}
	///<summary>Modifies existing control data using the multipliers</summary>
	public  void SetControlMultipliersInSet(string Set,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) {}
	///<summary>Modifies an existing control&#39;s linear data - i.e. the strengths etc of the control driving towards the target</summary>
	public  bool SetControlLinearData(string Name,float Strength/*=1.0f*/,float DampingRatio/*=1.0f*/,float ExtraDamping/*=0.0f*/,float MaxForce/*=0.0f*/,bool bEnableControl/*=true*/) { return default; }
	///<summary>Modifies an existing control&#39;s angular data - i.e. the strengths etc of the control driving towards the target</summary>
	public  bool SetControlAngularData(string Name,float Strength/*=1.0f*/,float DampingRatio/*=1.0f*/,float ExtraDamping/*=0.0f*/,float MaxTorque/*=0.0f*/,bool bEnableControl/*=true*/) { return default; }
	///<summary>Sets the point at which controls will &quot;push&quot; the child object.</summary>
	public  bool SetControlPoint(string Name,FVector Position) { return default; }
	///<summary>Resets the control point to the center of mass of the mesh</summary>
	public  bool ResetControlPoint(string Name) { return default; }
	///<summary>Modifies an existing control target - i.e. what it is driving towards, relative to the parent object</summary>
	public  bool SetControlTarget(string Name,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) { return default; }
	///<summary>Modifies existing control targets - i.e. what they are driving towards, relative to the parent objects</summary>
	public  void SetControlTargets(TArray<string> Names,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) {}
	///<summary>Modifies existing control targets - i.e. what they are driving towards, relative to the parent objects</summary>
	public  void SetControlTargetsInSet(string Set,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) {}
	///<summary>Modifies an existing control target - i.e. what it is driving towards, relative to the parent object</summary>
	public  bool SetControlTargetPositionAndOrientation(string Name,FVector Position,FRotator Orientation,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Modifies an existing control target - i.e. what it is driving towards, relative to the parent object</summary>
	public  bool SetControlTargetPosition(string Name,FVector Position,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Modifies an existing control target - i.e. what it is driving towards, relative to the parent object</summary>
	public  bool SetControlTargetOrientation(string Name,FRotator Orientation,float AngularVelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	///<summary>Calculates and sets an existing control target. This takes the &quot;virtual&quot; position/orientation of the parent</summary>
	public  bool SetControlTargetPoses(string Name,FVector ParentPosition,FRotator ParentOrientation,FVector ChildPosition,FRotator ChildOrientation,float VelocityDeltaTime,bool bEnableControl/*=true*/) { return default; }
	///<summary>Sets whether or not the control should use skeletal animation for the targets</summary>
	public  bool SetControlUseSkeletalAnimation(string Name,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) { return default; }
	///<summary>Sets whether or not the controls should use skeletal animation for the targets</summary>
	public  void SetControlsUseSkeletalAnimation(TArray<string> Names,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) {}
	///<summary>Sets whether or not the controls should use skeletal animation for the targets</summary>
	public  void SetControlsInSetUseSkeletalAnimation(string Set,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) {}
	///<summary>Activates or deactivates a control</summary>
	public  bool SetControlEnabled(string Name,bool bEnable/*=true*/) { return default; }
	///<summary>Activates or deactivates controls</summary>
	public  void SetControlsEnabled(TArray<string> Names,bool bEnable/*=true*/) {}
	///<summary>Activates or deactivates controls</summary>
	public  void SetControlsInSetEnabled(string Set,bool bEnable/*=true*/) {}
	///<summary>@param Name The name of the control to modify.</summary>
	public  bool SetControlAutoDisable(string Name,bool bAutoDisable) { return default; }
	///<summary>@param Names The names of the controls to modify.</summary>
	public  void SetControlsAutoDisable(TArray<string> Names,bool bAutoDisable) {}
	///<summary>@param Set The set of controls to modify. Standard sets will include &quot;All&quot;, &quot;WorldSpace&quot;,</summary>
	public  void SetControlsInSetAutoDisable(string Set,bool bAutoDisable) {}
	///<summary>@param Name The name of the control to modify.</summary>
	public  bool SetControlDisableCollision(string Name,bool bDisableCollision) { return default; }
	///<summary>@param Names The names of the controls to modify.</summary>
	public  void SetControlsDisableCollision(TArray<string> Names,bool bDisableCollision) {}
	///<summary>@param Set The set of controls to modify. Standard sets will include &quot;All&quot;, &quot;WorldSpace&quot;,</summary>
	public  void SetControlsInSetDisableCollision(string Set,bool bDisableCollision) {}
	///<summary>@param Name     The name of the control to access.</summary>
	public  bool GetControlData(string Name,FPhysicsControlData ControlData) { return default; }
	///<summary>@param Name     The name of the control to access.</summary>
	public  bool GetControlMultiplier(string Name,FPhysicsControlMultiplier ControlMultiplier) { return default; }
	///<summary>@param Name     The name of the control to access.</summary>
	public  bool GetControlTarget(string Name,FPhysicsControlTarget ControlTarget) { return default; }
	///<summary>@param Name        The name of the control to access.</summary>
	public  bool GetControlAutoDisable(string Name) { return default; }
	///<summary>@param Name        The name of the control to access.</summary>
	public  bool GetControlEnabled(string Name) { return default; }
	///<summary>Creates a new body modifier for mesh components</summary>
	public  string CreateBodyModifier(UMeshComponent MeshComponent,string BoneName,string Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/) { return default; }
	///<summary>Creates a new body modifier for mesh components</summary>
	public  bool CreateNamedBodyModifier(string Name,UMeshComponent MeshComponent,string BoneName,string Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/) { return default; }
	///<summary>Creates new body modifiers for skeletal mesh components</summary>
	public  TArray<string> CreateBodyModifiersFromSkeletalMeshBelow(USkeletalMeshComponent SkeletalMeshComponent,string BoneName,bool bIncludeSelf,string Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/) { return default; }
	///<summary>Creates a collection of controls controlling a skeletal mesh, grouped together in limbs</summary>
	public  TMap<string,FPhysicsControlNames> CreateBodyModifiersFromLimbBones(FPhysicsControlNames AllBodyModifiers,TMap<string,FPhysicsControlLimbBones> LimbBones,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/) { return default; }
	///<summary>Destroys a BodyModifier</summary>
	public  bool DestroyBodyModifier(string Name) { return default; }
	///<summary>Destroys BodyModifiers</summary>
	public  void DestroyBodyModifiers(TArray<string> Names) {}
	///<summary>Destroys BodyModifiers</summary>
	public  void DestroyBodyModifiersInSet(string Set) {}
	///<summary>Sets the kinematic target transform for a body modifier.</summary>
	public  bool SetBodyModifierKinematicTarget(string Name,FVector KinematicTargetPosition,FRotator KinematicTargetOrienation,bool bMakeKinematic) { return default; }
	///<summary>Sets the movement type for a body modifier</summary>
	public  bool SetBodyModifierMovementType(string Name,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) { return default; }
	///<summary>Sets the movement type for body modifiers</summary>
	public  void SetBodyModifiersMovementType(TArray<string> Names,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) {}
	///<summary>Sets the movement type for body modifiers</summary>
	public  void SetBodyModifiersInSetMovementType(string Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) {}
	///<summary>Sets the collision type for a body modifier</summary>
	public  bool SetBodyModifierCollisionType(string Name,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) { return default; }
	///<summary>Sets the collision type for body modifiers</summary>
	public  void SetBodyModifiersCollisionType(TArray<string> Names,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) {}
	///<summary>Sets the collision type for body modifiers</summary>
	public  void SetBodyModifiersInSetCollisionType(string Set,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) {}
	///<summary>Sets the gravity multiplier for a body modifier</summary>
	public  bool SetBodyModifierGravityMultiplier(string Name,float GravityMultiplier/*=1.0f*/) { return default; }
	///<summary>Sets the gravity multiplier for body modifiers</summary>
	public  void SetBodyModifiersGravityMultiplier(TArray<string> Names,float GravityMultiplier/*=1.0f*/) {}
	///<summary>Sets the gravity multiplier for body modifiers</summary>
	public  void SetBodyModifiersInSetGravityMultiplier(string Set,float GravityMultiplier/*=1.0f*/) {}
	///<summary>Sets whether a body modifier should use skeletal animation for its kinematic targets</summary>
	public  bool SetBodyModifierUseSkeletalAnimation(string Name,bool bUseSkeletalAnimation) { return default; }
	///<summary>Sets whether body modifiers should use skeletal animation for their kinematic targets</summary>
	public  void SetBodyModifiersUseSkeletalAnimation(TArray<string> Names,bool bUseSkeletalAnimation) {}
	///<summary>Sets whether body modifiers should use skeletal animation for their kinematic targets</summary>
	public  void SetBodyModifiersInSetUseSkeletalAnimation(string Set,bool bUseSkeletalAnimation) {}
	///<summary>Creates a collections of controls and body modifiers for a character, based on the description passed in.</summary>
	public  void CreateControlsAndBodyModifiersFromLimbBones(FPhysicsControlNames AllWorldSpaceControls,TMap<string,FPhysicsControlNames> LimbWorldSpaceControls,FPhysicsControlNames AllParentSpaceControls,TMap<string,FPhysicsControlNames> LimbParentSpaceControls,FPhysicsControlNames AllBodyModifiers,TMap<string,FPhysicsControlNames> LimbBodyModifiers,USkeletalMeshComponent SkeletalMeshComponent,TArray<FPhysicsControlLimbSetupData> LimbSetupData,FPhysicsControlData WorldSpaceControlData,FPhysicsControlSettings WorldSpaceControlSettings,bool bEnableWorldSpaceControls,FPhysicsControlData ParentSpaceControlData,FPhysicsControlSettings ParentSpaceControlSettings,bool bEnableParentSpaceControls,EPhysicsMovementType PhysicsMovementType/*=EPhysicsMovementType.Static*/,float GravityMultiplier/*=1.0f*/) {}
	///<summary>Adds a Control to a Set. This will add a new set if necessary. For example, you might</summary>
	public  void AddControlToSet(FPhysicsControlNames NewSet,string Control,string Set) {}
	///<summary>Adds Controls to a Set. This will add a new set if necessary. For example, you might</summary>
	public  void AddControlsToSet(FPhysicsControlNames NewSet,TArray<string> Controls,string Set) {}
	///<summary>Returns a reference to all the control names that have been created.</summary>
	public  TArray<string> GetAllControlNames() { return default; }
	///<summary>Returns a reference to all the control names that have been created and are in the specified</summary>
	public  TArray<string> GetControlNamesInSet(string Set) { return default; }
	///<summary>Returns a reference to all the body modifier names that have been created.</summary>
	public  TArray<string> GetAllBodyModifierNames() { return default; }
	///<summary>Returns a reference to all the body modifier names that have been created and are in the specified</summary>
	public  TArray<string> GetBodyModifierNamesInSet(string Set) { return default; }
	///<summary>Adds a BodyModifier to a Set. This will add a new set if necessary. For example, you might</summary>
	public  void AddBodyModifierToSet(FPhysicsControlNames NewSet,string BodyModifier,string Set) {}
	///<summary>Adds BodyModifiers to a Set. This will add a new set if necessary. For example, you might</summary>
	public  void AddBodyModifiersToSet(FPhysicsControlNames NewSet,TArray<string> BodyModifiers,string Set) {}
	///<summary>Returns the names of all sets containing the control (may be empty - e.g. if it doesn&#39;t exist)</summary>
	public  TArray<string> GetSetsContainingControl(string Control) { return default; }
	///<summary>Returns the names of all sets containing the body modifier (may be empty - e.g. if it doesn&#39;t exist)</summary>
	public  TArray<string> GetSetsContainingBodyModifier(string Control) { return default; }
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
