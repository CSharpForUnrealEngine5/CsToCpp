#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkeletalMeshComponent.h")]
///<summary>SkeletalMeshComponent is used to create an instance of an animated SkeletalMesh asset.</summary>
public partial class USkeletalMeshComponent : USkinnedMeshComponent {
// SkeletalMeshComponent
	public USkeletalMesh SkeletalMeshAsset;
	public  void SetSkeletalMeshAsset(USkeletalMesh NewMesh) {}
	public  USkeletalMesh GetSkeletalMeshAsset() { return default; }
	public UAnimBlueprint AnimationBlueprint_DEPRECATED;
	public UAnimBlueprintGeneratedClass AnimBlueprintGeneratedClass;
	public UClass AnimClass;
	public UAnimInstance AnimScriptInstance;
	public TArray<UAnimInstance> SubInstances;
	public UAnimInstance PostProcessAnimInstance;
	public  void ToggleDisablePostProcessBlueprint() {}
	public  bool GetDisablePostProcessBlueprint() { return default; }
	public  void SetDisablePostProcessBlueprint(bool bInDisablePostProcess) {}
	public FSingleAnimationPlayData AnimationData;
	public FVector RootBoneTranslation;
	public FVector LineCheckBoundsScale;
	public TArray<UAnimInstance> LinkedInstances;
	public TArray<FTransform> CachedBoneSpaceTransforms;
	public TArray<FTransform> CachedComponentSpaceTransforms;
	public  bool GetFloatAttribute_Ref(string BoneName,string AttributeName,float OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	public  bool GetTransformAttribute_Ref(string BoneName,string AttributeName,FTransform OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	public  bool GetIntegerAttribute_Ref(string BoneName,string AttributeName,int OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	public  bool GetStringAttribute_Ref(string BoneName,string AttributeName,string OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	public  bool GetFloatAttribute(string BoneName,string AttributeName,float DefaultValue,float OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	public  bool GetTransformAttribute(string BoneName,string AttributeName,FTransform DefaultValue,FTransform OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	public  bool GetIntegerAttribute(string BoneName,string AttributeName,int DefaultValue,int OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	public  bool GetStringAttribute(string BoneName,string AttributeName,string DefaultValue,string OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	public float GlobalAnimRateScale;
	public EKinematicBonesUpdateToPhysics KinematicBonesUpdateType;
	public EPhysicsTransformUpdateMode PhysicsTransformUpdateMode;
	public EAnimationMode AnimationMode;
	public bool bDisablePostProcessBlueprint;
	public bool bUpdateOverlapsOnAnimationFinalize;
	public bool bHasValidBodies;
	public bool bBlendPhysics;
	public bool bEnablePhysicsOnDedicatedServer;
	public bool bUpdateMeshWhenKinematic;
	public bool bUpdateJointsFromAnimation;
	public bool bAllowClothActors;
	public bool bDisableClothSimulation;
	public bool bDisableRigidBodyAnimNode;
	public bool bAllowAnimCurveEvaluation;
	public bool bDisableAnimCurves_DEPRECATED;
	public bool bCollideWithEnvironment;
	public bool bCollideWithAttachedChildren;
	public bool bForceCollisionUpdate;
	public bool bLocalSpaceSimulation;
	public bool bResetAfterTeleport;
	public bool bDeferKinematicBoneUpdate;
	public bool bNoSkeletonUpdate;
	public bool bPauseAnims;
	public bool bUseRefPoseOnInitAnim;
	public bool bEnablePerPolyCollision;
	public bool bForceRefpose;
	public bool bOnlyAllowAutonomousTickPose;
	public bool bIsAutonomousTickPose;
	public bool bOldForceRefPose;
	public bool bShowPrePhysBones;
	public bool bRequiredBonesUpToDate;
	public bool bAnimTreeInitialised;
	public bool bIncludeComponentLocationIntoBounds;
	public bool bEnableLineCheckWithBounds;
	public bool bPropagateCurvesToFollowers;
	public bool bSkipKinematicUpdateWhenInterpolating;
	public bool bSkipBoundsUpdateWhenInterpolating;
	public bool bUpdateAnimationInEditor;
	public bool bUpdateClothInEditor;
	public bool bOverrideDefaultAnimatingRig;
	public bool bNeedsQueuedAnimEventsDispatched;
	public ushort CachedAnimCurveUidVersion;
	public float ClothBlendWeight;
	public bool bWaitForParallelClothTask;
	public TArray<string> DisallowedAnimCurves;
	public UBodySetup BodySetup;
	public float ClothMaxDistanceScale;
	public FConstraintBrokenSignature OnConstraintBroken;
	public FPlasticDeformationEventSignature OnPlasticDeformation;
	public UClass ClothingSimulationFactory;
	public  void SetAnimClass(UClass NewClass) {}
	public  UClass GetAnimClass() { return default; }
	public  UAnimInstance GetAnimInstance() { return default; }
	public  UAnimInstance GetPostProcessInstance() { return default; }
	public  UAnimInstance GetLinkedAnimGraphInstanceByTag(string InTag) { return default; }
	public  void GetLinkedAnimGraphInstancesByTag(string InTag,TArray<UAnimInstance> OutLinkedInstances) {}
	public  void LinkAnimGraphByTag(string InTag,UClass InClass) {}
	public  void LinkAnimClassLayers(UClass InClass) {}
	public  void UnlinkAnimClassLayers(UClass InClass) {}
	public  UAnimInstance GetLinkedAnimLayerInstanceByGroup(string InGroup) { return default; }
	public  UAnimInstance GetLinkedAnimLayerInstanceByClass(UClass InClass) { return default; }
	public  bool HasValidAnimationInstance() { return default; }
	public  void ResetAnimInstanceDynamics(ETeleportType InTeleportType/*=ETeleportType.ResetPhysics*/) {}
	public  void SetAnimationMode(EAnimationMode InAnimationMode) {}
	public  EAnimationMode GetAnimationMode() { return default; }
	public  void PlayAnimation(UAnimationAsset NewAnimToPlay,bool bLooping) {}
	public  void SetAnimation(UAnimationAsset NewAnimToPlay) {}
	public  void Play(bool bLooping) {}
	public  void Stop() {}
	public  bool IsPlaying() { return default; }
	public  void SetPosition(float InPos,bool bFireNotifies/*=true*/) {}
	public  float GetPosition() { return default; }
	public  void SetPlayRate(float Rate) {}
	public  float GetPlayRate() { return default; }
	public  void OverrideAnimationData(UAnimationAsset InAnimToPlay,bool bIsLooping/*=true*/,bool bIsPlaying/*=true*/,float Position/*=0.0f*/,float PlayRate/*=1.0f*/) {}
	public  void SetMorphTarget(string MorphTargetName,float Value,bool bRemoveZeroWeight/*=true*/) {}
	public  void ClearMorphTargets() {}
	public  float GetMorphTarget(string MorphTargetName) { return default; }
	public  void SnapshotPose(FPoseSnapshot Snapshot) {}
	public  void SetAllowClothActors(bool bInAllow) {}
	public  bool GetAllowClothActors() { return default; }
	public  float GetClothMaxDistanceScale() { return default; }
	public  void SetClothMaxDistanceScale(float Scale) {}
	public  void ForceClothNextUpdateTeleport() {}
	public  void ForceClothNextUpdateTeleportAndReset() {}
	public  void SuspendClothingSimulation() {}
	public  void ResumeClothingSimulation() {}
	public  bool IsClothingSimulationSuspended() { return default; }
	public  void ResetClothTeleportMode() {}
	public  void BindClothToLeaderPoseComponent() {}
	public  void UnbindClothFromLeaderPoseComponent(bool bRestoreSimulationSpace/*=true*/) {}
	public  void SetAllowRigidBodyAnimNode(bool bInAllow,bool bReinitAnim/*=true*/) {}
	public  bool GetAllowRigidBodyAnimNode() { return default; }
	public  void SetUpdateAnimationInEditor(bool NewUpdateState) {}
	public  void SetUpdateClothInEditor(bool NewUpdateState) {}
	public  void SetDisableAnimCurves(bool bInDisableAnimCurves) {}
	public  bool GetDisableAnimCurves() { return default; }
	public  void SetAllowAnimCurveEvaluation(bool bInAllow) {}
	public  bool GetAllowedAnimCurveEvaluate() { return default; }
	public  void AllowAnimCurveEvaluation(string NameOfCurve,bool bAllow) {}
	public  void ResetAllowedAnimCurveEvaluation() {}
	public  void SetAllowedAnimCurvesEvaluation(TArray<string> List,bool bAllow) {}
	public  float GetTeleportRotationThreshold() { return default; }
	public  void SetTeleportRotationThreshold(float Threshold) {}
	public  float GetTeleportDistanceThreshold() { return default; }
	public  void SetTeleportDistanceThreshold(float Threshold) {}
	public float TeleportDistanceThreshold;
	public float TeleportRotationThreshold;
	public uint LastPoseTickFrame;
	public  UClothingSimulationInteractor GetClothingSimulationInteractor() { return default; }
	public UClothingSimulationInteractor ClothingInteractor;
	public FOnAnimInitialized OnAnimInitialized;
	public  void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision,string BoneName/*=NAME_None*/) {}
	public  void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision,string BoneName/*=NAME_None*/,bool bIncludeSelf/*=true*/) {}
	public  void SetEnableBodyGravity(bool bEnableGravity,string BoneName) {}
	public  bool IsBodyGravityEnabled(string BoneName) { return default; }
	public  void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity,string BoneName,bool bIncludeSelf/*=true*/) {}
	public  bool K2_GetClosestPointOnPhysicsAsset(FVector WorldPosition,FVector ClosestWorldPosition,FVector Normal,string BoneName,float Distance) { return default; }
	public  float GetBoneMass(string BoneName/*=NAME_None*/,bool bScaleMass/*=true*/) { return default; }
	public  FVector GetSkeletalCenterOfMass() { return default; }
	public  void AddForceToAllBodiesBelow(FVector Force,string BoneName/*=NAME_None*/,bool bAccelChange/*=false*/,bool bIncludeSelf/*=true*/) {}
	public  void AddImpulseToAllBodiesBelow(FVector Impulse,string BoneName/*=NAME_None*/,bool bVelChange/*=false*/,bool bIncludeSelf/*=true*/) {}
	public  void TermBodiesBelow(string ParentBoneName) {}
	public  void SetAllBodiesSimulatePhysics(bool bNewSimulate) {}
	public  void SetPhysicsBlendWeight(float PhysicsBlendWeight) {}
	public  void SetEnablePhysicsBlending(bool bNewBlendPhysics) {}
	public  void SetAllBodiesBelowPhysicsDisabled(string InBoneName,bool bDisabled,bool bIncludeSelf/*=true*/) {}
	public  void SetAllBodiesBelowLinearVelocity(string InBoneName,FVector LinearVelocity,bool bIncludeSelf/*=true*/) {}
	public  FVector GetBoneLinearVelocity(string InBoneName) { return default; }
	public  void SetAllBodiesBelowSimulatePhysics(string InBoneName,bool bNewSimulate,bool bIncludeSelf/*=true*/) {}
	public  void ResetAllBodiesSimulatePhysics() {}
	public  void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight,bool bSkipCustomPhysicsType/*=false*/) {}
	public  void SetAllBodiesBelowPhysicsBlendWeight(string InBoneName,float PhysicsBlendWeight,bool bSkipCustomPhysicsType/*=false*/,bool bIncludeSelf/*=true*/) {}
	public  void AccumulateAllBodiesBelowPhysicsBlendWeight(string InBoneName,float AddPhysicsBlendWeight,bool bSkipCustomPhysicsType/*=false*/) {}
	public  void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType/*=false*/) {}
	public  void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType/*=false*/) {}
	public  void SetAllMotorsAngularDriveParams(float InSpring,float InDamping,float InForceLimit,bool bSkipCustomPhysicsType/*=false*/) {}
	public  void SetConstraintProfile(string JointName,string ProfileName,bool bDefaultIfNotFound/*=false*/) {}
	public  void SetConstraintProfileForAll(string ProfileName,bool bDefaultIfNotFound/*=false*/) {}
	public  string FindConstraintBoneName(int ConstraintIndex) { return default; }
	public  void BreakConstraint(FVector Impulse,FVector HitLocation,string InBoneName) {}
	public  FConstraintInstanceAccessor GetConstraintByName(string ConstraintName,bool bIncludesTerminated) { return default; }
	public  void GetConstraints(bool bIncludesTerminated,TArray<FConstraintInstanceAccessor> OutConstraints) {}
	public  void GetConstraintsFromBody(string BodyName,bool bParentConstraints,bool bChildConstraints,bool bIncludesTerminated,TArray<FConstraintInstanceAccessor> OutConstraints) {}
	public  void SetAngularLimits(string InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle) {}
	public  void GetCurrentJointAngles(string InBoneName,float Swing1Angle,float TwistAngle,float Swing2Angle) {}
	public UAnimSequence SequenceToPlay_DEPRECATED;
	public UAnimationAsset AnimToPlay_DEPRECATED;
	public bool bDefaultLooping_DEPRECATED;
	public bool bDefaultPlaying_DEPRECATED;
	public float DefaultPosition_DEPRECATED;
	public float DefaultPlayRate_DEPRECATED;
	public TSoftObjectPtr<UObject> DefaultAnimatingRigOverride;
	public  void SetDefaultAnimatingRigOverride(TSoftObjectPtr<UObject> InAnimatingRig) {}
	public  TSoftObjectPtr<UObject> GetDefaultAnimatingRigOverride() { return default; }
	public  TSoftObjectPtr<UObject> GetDefaultAnimatingRig() { return default; }
}
