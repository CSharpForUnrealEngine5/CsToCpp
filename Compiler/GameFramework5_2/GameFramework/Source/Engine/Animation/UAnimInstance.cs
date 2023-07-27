#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimInstance.h")]
public partial class UAnimInstance : UObject {
// AnimInstance
	public USkeleton CurrentSkeleton;
	public ERootMotionMode RootMotionMode;
	public bool bUseMultiThreadedAnimationUpdate;
	public bool bUsingCopyPoseFromMesh;
	public bool bReceiveNotifiesFromLinkedInstances;
	public bool bPropagateNotifiesToLinkedInstances;
	public bool bUseMainInstanceMontageEvaluationData;
	public bool bQueueMontageEvents;
	public  APawn TryGetPawnOwner() { return default; }
	public  void SavePoseSnapshot(string SnapshotName) {}
	public  void RemovePoseSnapshot(string SnapshotName) {}
	public  void SnapshotPose(FPoseSnapshot Snapshot) {}
	public  bool GetReceiveNotifiesFromLinkedInstances() { return default; }
	public  void SetReceiveNotifiesFromLinkedInstances(bool bSet) {}
	public  bool GetPropagateNotifiesToLinkedInstances() { return default; }
	public  void SetPropagateNotifiesToLinkedInstances(bool bSet) {}
	public  bool IsUsingMainInstanceMontageEvaluationData() { return default; }
	public  void SetUseMainInstanceMontageEvaluationData(bool bSet) {}
	public  AActor GetOwningActor() { return default; }
	public  USkeletalMeshComponent GetOwningComponent() { return default; }
	public  void BlueprintInitializeAnimation() {}
	public  void BlueprintUpdateAnimation(float DeltaTimeX) {}
	public  void BlueprintPostEvaluateAnimation() {}
	public  void BlueprintBeginPlay() {}
	public  void BlueprintLinkedAnimationLayersInitialized() {}
	public  void BlueprintThreadSafeUpdateAnimation(float DeltaTime) {}
	public  UAnimMontage PlaySlotAnimationAsDynamicMontage(UAnimSequenceBase Asset,string SlotNodeName,float BlendInTime/*=0.25f*/,float BlendOutTime/*=0.25f*/,float InPlayRate/*=1.0f*/,int LoopCount/*=1*/,float BlendOutTriggerTime/*=-1.0f*/,float InTimeToStartMontageAt/*=0.0f*/) { return default; }
	public  UAnimMontage PlaySlotAnimationAsDynamicMontage_WithBlendArgs(UAnimSequenceBase Asset,string SlotNodeName,FAlphaBlendArgs BlendIn,FAlphaBlendArgs BlendOut,float InPlayRate/*=1.0f*/,int LoopCount/*=1*/,float BlendOutTriggerTime/*=-1.0f*/,float InTimeToStartMontageAt/*=0.0f*/) { return default; }
	public  UAnimMontage PlaySlotAnimationAsDynamicMontage_WithBlendSettings(UAnimSequenceBase Asset,string SlotNodeName,FMontageBlendSettings BlendInSettings,FMontageBlendSettings BlendOutSettings,float InPlayRate/*=1.0f*/,int LoopCount/*=1*/,float BlendOutTriggerTime/*=-1.0f*/,float InTimeToStartMontageAt/*=0.0f*/) { return default; }
	public  void StopSlotAnimation(float InBlendOutTime/*=0.25f*/,string SlotNodeName/*=NAME_None*/) {}
	public  bool IsPlayingSlotAnimation(UAnimSequenceBase Asset,string SlotNodeName) { return default; }
	public  float Montage_Play(UAnimMontage MontageToPlay,float InPlayRate/*=1.0f*/,EMontagePlayReturnType ReturnValueType/*=EMontagePlayReturnType.MontageLength*/,float InTimeToStartMontageAt/*=0.0f*/,bool bStopAllMontages/*=true*/) { return default; }
	public  float Montage_PlayWithBlendIn(UAnimMontage MontageToPlay,FAlphaBlendArgs BlendIn,float InPlayRate/*=1.0f*/,EMontagePlayReturnType ReturnValueType/*=EMontagePlayReturnType.MontageLength*/,float InTimeToStartMontageAt/*=0.0f*/,bool bStopAllMontages/*=true*/) { return default; }
	public  float Montage_PlayWithBlendSettings(UAnimMontage MontageToPlay,FMontageBlendSettings BlendInSettings,float InPlayRate/*=1.0f*/,EMontagePlayReturnType ReturnValueType/*=EMontagePlayReturnType.MontageLength*/,float InTimeToStartMontageAt/*=0.0f*/,bool bStopAllMontages/*=true*/) { return default; }
	public  void Montage_Stop(float InBlendOutTime,UAnimMontage Montage/*=NULL*/) {}
	public  void Montage_StopWithBlendOut(FAlphaBlendArgs BlendOut,UAnimMontage Montage/*=nullptr*/) {}
	public  void Montage_StopWithBlendSettings(FMontageBlendSettings BlendOutSettings,UAnimMontage Montage/*=nullptr*/) {}
	public  void Montage_StopGroupByName(float InBlendOutTime,string GroupName) {}
	public  void Montage_Pause(UAnimMontage Montage/*=NULL*/) {}
	public  void Montage_Resume(UAnimMontage Montage) {}
	public  void Montage_JumpToSection(string SectionName,UAnimMontage Montage/*=NULL*/) {}
	public  void Montage_JumpToSectionsEnd(string SectionName,UAnimMontage Montage/*=NULL*/) {}
	public  void Montage_SetNextSection(string SectionNameToChange,string NextSection,UAnimMontage Montage/*=NULL*/) {}
	public  void Montage_SetPlayRate(UAnimMontage Montage,float NewPlayRate/*=1.0f*/) {}
	public  bool Montage_IsActive(UAnimMontage Montage) { return default; }
	public  bool Montage_IsPlaying(UAnimMontage Montage) { return default; }
	public  string Montage_GetCurrentSection(UAnimMontage Montage/*=NULL*/) { return default; }
	public  float Montage_GetPosition(UAnimMontage Montage) { return default; }
	public  void Montage_SetPosition(UAnimMontage Montage,float NewPosition) {}
	public  bool Montage_GetIsStopped(UAnimMontage Montage) { return default; }
	public  float Montage_GetBlendTime(UAnimMontage Montage) { return default; }
	public  float Montage_GetPlayRate(UAnimMontage Montage) { return default; }
	public  float Montage_GetEffectivePlayRate(UAnimMontage Montage) { return default; }
	public  void MontageSync_Follow(UAnimMontage MontageFollower,UAnimInstance OtherAnimInstance,UAnimMontage MontageLeader) {}
	public  void MontageSync_StopFollowing(UAnimMontage MontageFollower) {}
	public  bool IsAnyMontagePlaying() { return default; }
	public  UAnimMontage GetCurrentActiveMontage() { return default; }
	public FOnMontageBlendingOutStartedMCDelegate OnMontageBlendingOut;
	public FOnMontageStartedMCDelegate OnMontageStarted;
	public FOnMontageEndedMCDelegate OnMontageEnded;
	public FOnAllMontageInstancesEndedMCDelegate OnAllMontageInstancesEnded;
	public  UAnimInstance GetLinkedAnimGraphInstanceByTag(string InTag) { return default; }
	public  void GetLinkedAnimGraphInstancesByTag(string InTag,TArray<UAnimInstance> OutLinkedInstances) {}
	public  void LinkAnimGraphByTag(string InTag,UClass InClass) {}
	public  void LinkAnimClassLayers(UClass InClass) {}
	public  void UnlinkAnimClassLayers(UClass InClass) {}
	public  UAnimInstance GetLinkedAnimLayerInstanceByGroup(string InGroup) { return default; }
	public  void GetLinkedAnimLayerInstancesByGroup(string InGroup,TArray<UAnimInstance> OutLinkedInstances) {}
	public  UAnimInstance GetLinkedAnimLayerInstanceByGroupAndClass(string InGroup,UClass InClass) { return default; }
	public  UAnimInstance GetLinkedAnimLayerInstanceByClass(UClass InClass) { return default; }
	public  void RequestSlotGroupInertialization(string InSlotGroupName,float Duration,UBlendProfile BlendProfile/*=nullptr*/) {}
	public  void SetRootMotionMode(ERootMotionMode Value) {}
	public  float GetInstanceAssetPlayerLength(int AssetPlayerIndex) { return default; }
	public  float GetInstanceAssetPlayerTime(int AssetPlayerIndex) { return default; }
	public  float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex) { return default; }
	public  float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex) { return default; }
	public  float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex) { return default; }
	public  float GetInstanceMachineWeight(int MachineIndex) { return default; }
	public  float GetInstanceStateWeight(int MachineIndex,int StateIndex) { return default; }
	public  float GetInstanceCurrentStateElapsedTime(int MachineIndex) { return default; }
	public  float GetInstanceTransitionCrossfadeDuration(int MachineIndex,int TransitionIndex) { return default; }
	public  float GetInstanceTransitionTimeElapsed(int MachineIndex,int TransitionIndex) { return default; }
	public  float GetInstanceTransitionTimeElapsedFraction(int MachineIndex,int TransitionIndex) { return default; }
	public  float GetRelevantAnimTimeRemaining(int MachineIndex,int StateIndex) { return default; }
	public  float GetRelevantAnimTimeRemainingFraction(int MachineIndex,int StateIndex) { return default; }
	public  float GetRelevantAnimLength(int MachineIndex,int StateIndex) { return default; }
	public  float GetRelevantAnimTime(int MachineIndex,int StateIndex) { return default; }
	public  float GetRelevantAnimTimeFraction(int MachineIndex,int StateIndex) { return default; }
	public  bool WasAnimNotifyStateActiveInAnyState(UClass AnimNotifyStateType) { return default; }
	public  bool WasAnimNotifyStateActiveInStateMachine(int MachineIndex,UClass AnimNotifyStateType) { return default; }
	public  bool WasAnimNotifyStateActiveInSourceState(int MachineIndex,int StateIndex,UClass AnimNotifyStateType) { return default; }
	public  bool WasAnimNotifyTriggeredInSourceState(int MachineIndex,int StateIndex,UClass AnimNotifyType) { return default; }
	public  bool WasAnimNotifyNameTriggeredInSourceState(int MachineIndex,int StateIndex,string NotifyName) { return default; }
	public  bool WasAnimNotifyTriggeredInStateMachine(int MachineIndex,UClass AnimNotifyType) { return default; }
	public  bool WasAnimNotifyNameTriggeredInStateMachine(int MachineIndex,string NotifyName) { return default; }
	public  bool WasAnimNotifyTriggeredInAnyState(UClass AnimNotifyType) { return default; }
	public  bool WasAnimNotifyNameTriggeredInAnyState(string NotifyName) { return default; }
	public  float GetCurveValue(string CurveName) { return default; }
	public  bool GetCurveValueWithDefault(string CurveName,float DefaultValue,float OutValue) { return default; }
	public  void GetActiveCurveNames(EAnimCurveType CurveType,TArray<string> OutNames) {}
	public  void GetAllCurveNames(TArray<string> OutNames) {}
	public  string GetCurrentStateName(int MachineIndex) { return default; }
	public  void SetMorphTarget(string MorphTargetName,float Value) {}
	public  void ClearMorphTargets() {}
	public  float CalculateDirection(FVector Velocity,FRotator BaseRotation) { return default; }
	public  void LockAIResources(bool bLockMovement,bool LockAILogic) {}
	public  void UnlockAIResources(bool bUnlockMovement,bool UnlockAILogic) {}
	public  bool GetTimeToClosestMarker(string SyncGroup,string MarkerName,float OutMarkerTime) { return default; }
	public  bool HasMarkerBeenHitThisFrame(string SyncGroup,string MarkerName) { return default; }
	public  bool IsSyncGroupBetweenMarkers(string InSyncGroupName,string PreviousMarker,string NextMarker,bool bRespectMarkerOrder/*=true*/) { return default; }
	public  FMarkerSyncAnimPosition GetSyncGroupPosition(string InSyncGroupName) { return default; }
	public  bool RequestTransitionEvent(string EventName,double RequestTimeout,ETransitionRequestQueueMode QueueMode,ETransitionRequestOverwriteMode OverwriteMode) { return default; }
	public  void ClearTransitionEvents(string EventName) {}
	public  void ClearAllTransitionEvents() {}
	public  bool QueryTransitionEvent(int MachineIndex,int TransitionIndex,string EventName) { return default; }
	public  bool QueryAndMarkTransitionEvent(int MachineIndex,int TransitionIndex,string EventName) { return default; }
	public FSoftClassPath PostCompileValidationClassName;
	public  void ResetDynamics(ETeleportType InTeleportType) {}
	public FAnimNotifyQueue NotifyQueue;
	public TArray<FAnimNotifyEvent> ActiveAnimNotifyState;
	public TArray<FAnimNotifyEventReference> ActiveAnimNotifyEventReference;
	public  float GetDeltaSeconds() { return default; }
}
