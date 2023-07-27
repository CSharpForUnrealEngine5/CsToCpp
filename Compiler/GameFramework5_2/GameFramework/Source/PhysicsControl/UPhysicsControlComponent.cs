#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlComponent.h")]
///<summary>This is the main Physics Control Component class which manages Controls and Body Modifiers associated</summary>
public partial class UPhysicsControlComponent : USceneComponent {
// PhysicsControlComponent
	public  string CreateControl(UMeshComponent ParentMeshComponent,string ParentBoneName,UMeshComponent ChildMeshComponent,string ChildBoneName,FPhysicsControlData ControlData,FPhysicsControlTarget ControlTarget,FPhysicsControlSettings ControlSettings,string Set,bool bEnabled/*=true*/) { return default; }
	public  bool CreateNamedControl(string Name,UMeshComponent ParentMeshComponent,string ParentBoneName,UMeshComponent ChildMeshComponent,string ChildBoneName,FPhysicsControlData ControlData,FPhysicsControlTarget ControlTarget,FPhysicsControlSettings ControlSettings,string Set,bool bEnabled/*=true*/) { return default; }
	public  TArray<string> CreateControlsFromSkeletalMeshBelow(USkeletalMeshComponent SkeletalMeshComponent,string BoneName,bool bIncludeSelf,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,string Set,bool bEnabled/*=true*/) { return default; }
	public  TArray<string> CreateControlsFromSkeletalMeshAndConstraintProfileBelow(USkeletalMeshComponent SkeletalMeshComponent,string BoneName,bool bIncludeSelf,string ConstraintProfile,string Set,bool bEnabled/*=true*/) { return default; }
	public  TArray<string> CreateControlsFromSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent,TArray<string> BoneNames,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,string Set,bool bEnabled/*=true*/) { return default; }
	public  TArray<string> CreateControlsFromSkeletalMeshAndConstraintProfile(USkeletalMeshComponent SkeletalMeshComponent,TArray<string> BoneNames,string ConstraintProfile,string Set,bool bEnabled/*=true*/) { return default; }
	public  TMap<string,FPhysicsControlLimbBones> GetLimbBonesFromSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent,TArray<FPhysicsControlLimbSetupData> LimbSetupData) { return default; }
	public  TMap<string,FPhysicsControlNames> CreateControlsFromLimbBones(FPhysicsControlNames AllControls,TMap<string,FPhysicsControlLimbBones> LimbBones,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,bool bEnabled/*=true*/) { return default; }
	public  TMap<string,FPhysicsControlNames> CreateControlsFromLimbBonesAndConstraintProfile(FPhysicsControlNames AllControls,TMap<string,FPhysicsControlLimbBones> LimbBones,string ConstraintProfile,bool bEnabled/*=true*/) { return default; }
	public  bool DestroyControl(string Name) { return default; }
	public  void DestroyControls(TArray<string> Names) {}
	public  void DestroyControlsInSet(string Set) {}
	public  bool SetControlData(string Name,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) { return default; }
	public  void SetControlDatas(TArray<string> Names,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) {}
	public  void SetControlDatasInSet(string Set,FPhysicsControlData ControlData,bool bEnableControl/*=true*/) {}
	public  bool SetControlMultiplier(string Name,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) { return default; }
	public  void SetControlMultipliers(TArray<string> Names,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) {}
	public  void SetControlMultipliersInSet(string Set,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl/*=true*/) {}
	public  bool SetControlLinearData(string Name,float Strength/*=1.0f*/,float DampingRatio/*=1.0f*/,float ExtraDamping/*=0.0f*/,float MaxForce/*=0.0f*/,bool bEnableControl/*=true*/) { return default; }
	public  bool SetControlAngularData(string Name,float Strength/*=1.0f*/,float DampingRatio/*=1.0f*/,float ExtraDamping/*=0.0f*/,float MaxTorque/*=0.0f*/,bool bEnableControl/*=true*/) { return default; }
	public  bool SetControlPoint(string Name,FVector Position) { return default; }
	public  bool ResetControlPoint(string Name) { return default; }
	public  bool SetControlTarget(string Name,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) { return default; }
	public  void SetControlTargets(TArray<string> Names,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) {}
	public  void SetControlTargetsInSet(string Set,FPhysicsControlTarget ControlTarget,bool bEnableControl/*=true*/) {}
	public  bool SetControlTargetPositionAndOrientation(string Name,FVector Position,FRotator Orientation,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	public  bool SetControlTargetPosition(string Name,FVector Position,float VelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	public  bool SetControlTargetOrientation(string Name,FRotator Orientation,float AngularVelocityDeltaTime,bool bEnableControl/*=true*/,bool bApplyControlPointToTarget/*=false*/) { return default; }
	public  bool SetControlTargetPoses(string Name,FVector ParentPosition,FRotator ParentOrientation,FVector ChildPosition,FRotator ChildOrientation,float VelocityDeltaTime,bool bEnableControl/*=true*/) { return default; }
	public  bool SetControlUseSkeletalAnimation(string Name,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) { return default; }
	public  void SetControlsUseSkeletalAnimation(TArray<string> Names,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) {}
	public  void SetControlsInSetUseSkeletalAnimation(string Set,bool bUseSkeletalAnimation/*=true*/,float SkeletalAnimationVelocityMultiplier/*=1.0f*/) {}
	public  bool SetControlEnabled(string Name,bool bEnable/*=true*/) { return default; }
	public  void SetControlsEnabled(TArray<string> Names,bool bEnable/*=true*/) {}
	public  void SetControlsInSetEnabled(string Set,bool bEnable/*=true*/) {}
	public  bool SetControlAutoDisable(string Name,bool bAutoDisable) { return default; }
	public  void SetControlsAutoDisable(TArray<string> Names,bool bAutoDisable) {}
	public  void SetControlsInSetAutoDisable(string Set,bool bAutoDisable) {}
	public  bool SetControlDisableCollision(string Name,bool bDisableCollision) { return default; }
	public  void SetControlsDisableCollision(TArray<string> Names,bool bDisableCollision) {}
	public  void SetControlsInSetDisableCollision(string Set,bool bDisableCollision) {}
	public  bool GetControlData(string Name,FPhysicsControlData ControlData) { return default; }
	public  bool GetControlMultiplier(string Name,FPhysicsControlMultiplier ControlMultiplier) { return default; }
	public  bool GetControlTarget(string Name,FPhysicsControlTarget ControlTarget) { return default; }
	public  bool GetControlAutoDisable(string Name) { return default; }
	public  bool GetControlEnabled(string Name) { return default; }
	public  string CreateBodyModifier(UMeshComponent MeshComponent,string BoneName,string Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/) { return default; }
	public  bool CreateNamedBodyModifier(string Name,UMeshComponent MeshComponent,string BoneName,string Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/) { return default; }
	public  TArray<string> CreateBodyModifiersFromSkeletalMeshBelow(USkeletalMeshComponent SkeletalMeshComponent,string BoneName,bool bIncludeSelf,string Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/) { return default; }
	public  TMap<string,FPhysicsControlNames> CreateBodyModifiersFromLimbBones(FPhysicsControlNames AllBodyModifiers,TMap<string,FPhysicsControlLimbBones> LimbBones,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/,float GravityMultiplier/*=1.0f*/,bool bUseSkeletalAnimation/*=true*/) { return default; }
	public  bool DestroyBodyModifier(string Name) { return default; }
	public  void DestroyBodyModifiers(TArray<string> Names) {}
	public  void DestroyBodyModifiersInSet(string Set) {}
	public  bool SetBodyModifierKinematicTarget(string Name,FVector KinematicTargetPosition,FRotator KinematicTargetOrienation,bool bMakeKinematic) { return default; }
	public  bool SetBodyModifierMovementType(string Name,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) { return default; }
	public  void SetBodyModifiersMovementType(TArray<string> Names,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) {}
	public  void SetBodyModifiersInSetMovementType(string Set,EPhysicsMovementType MovementType/*=EPhysicsMovementType.Simulated*/) {}
	public  bool SetBodyModifierCollisionType(string Name,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) { return default; }
	public  void SetBodyModifiersCollisionType(TArray<string> Names,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) {}
	public  void SetBodyModifiersInSetCollisionType(string Set,ECollisionEnabled CollisionType/*=ECollisionEnabled.QueryAndPhysics*/) {}
	public  bool SetBodyModifierGravityMultiplier(string Name,float GravityMultiplier/*=1.0f*/) { return default; }
	public  void SetBodyModifiersGravityMultiplier(TArray<string> Names,float GravityMultiplier/*=1.0f*/) {}
	public  void SetBodyModifiersInSetGravityMultiplier(string Set,float GravityMultiplier/*=1.0f*/) {}
	public  bool SetBodyModifierUseSkeletalAnimation(string Name,bool bUseSkeletalAnimation) { return default; }
	public  void SetBodyModifiersUseSkeletalAnimation(TArray<string> Names,bool bUseSkeletalAnimation) {}
	public  void SetBodyModifiersInSetUseSkeletalAnimation(string Set,bool bUseSkeletalAnimation) {}
	public  void CreateControlsAndBodyModifiersFromLimbBones(FPhysicsControlNames AllWorldSpaceControls,TMap<string,FPhysicsControlNames> LimbWorldSpaceControls,FPhysicsControlNames AllParentSpaceControls,TMap<string,FPhysicsControlNames> LimbParentSpaceControls,FPhysicsControlNames AllBodyModifiers,TMap<string,FPhysicsControlNames> LimbBodyModifiers,USkeletalMeshComponent SkeletalMeshComponent,TArray<FPhysicsControlLimbSetupData> LimbSetupData,FPhysicsControlData WorldSpaceControlData,FPhysicsControlSettings WorldSpaceControlSettings,bool bEnableWorldSpaceControls,FPhysicsControlData ParentSpaceControlData,FPhysicsControlSettings ParentSpaceControlSettings,bool bEnableParentSpaceControls,EPhysicsMovementType PhysicsMovementType/*=EPhysicsMovementType.Static*/,float GravityMultiplier/*=1.0f*/) {}
	public  void AddControlToSet(FPhysicsControlNames NewSet,string Control,string Set) {}
	public  void AddControlsToSet(FPhysicsControlNames NewSet,TArray<string> Controls,string Set) {}
	public  TArray<string> GetAllControlNames() { return default; }
	public  TArray<string> GetControlNamesInSet(string Set) { return default; }
	public  TArray<string> GetAllBodyModifierNames() { return default; }
	public  TArray<string> GetBodyModifierNamesInSet(string Set) { return default; }
	public  void AddBodyModifierToSet(FPhysicsControlNames NewSet,string BodyModifier,string Set) {}
	public  void AddBodyModifiersToSet(FPhysicsControlNames NewSet,TArray<string> BodyModifiers,string Set) {}
	public  TArray<string> GetSetsContainingControl(string Control) { return default; }
	public  TArray<string> GetSetsContainingBodyModifier(string Control) { return default; }
	public float TeleportDistanceThreshold;
	public float TeleportRotationThreshold;
	public bool bShowDebugVisualization;
	public float VisualizationSizeScale;
	public bool bShowDebugControlList;
	public string DebugControlDetailFilter;
	public bool bShowDebugBodyModifierList;
	public string DebugBodyModifierDetailFilter;
	public float VelocityPredictionTime;
	public int MaxNumControlsOrModifiersPerName;
}
