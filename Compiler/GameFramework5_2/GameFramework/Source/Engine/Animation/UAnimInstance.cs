namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimInstance.h")]
public partial class UAnimInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>This is used to extract animation. If Mesh exists, this will be overwritten by Mesh-&gt;Skeleton</summary>
	public USkeleton CurrentSkeleton;
	///<summary>Sets where this blueprint pulls Root Motion from</summary>
	public ERootMotionMode RootMotionMode;
	///<summary>Allows this anim instance to update its native update, blend tree, montages and asset players on</summary>
	public bool bUseMultiThreadedAnimationUpdate;
	///<summary>If this AnimInstance has nodes using &#39;CopyPoseFromMesh&#39; this will be true.</summary>
	public bool bUsingCopyPoseFromMesh;
	///<summary>Whether to process notifies from any linked anim instances</summary>
	public bool bReceiveNotifiesFromLinkedInstances;
	///<summary>Whether to propagate notifies to any linked anim instances</summary>
	public bool bPropagateNotifiesToLinkedInstances;
	///<summary>If true, linked instances will use the main instance&#39;s montage data. (i.e. playing a montage on a main instance will play it on the linked layer too.)</summary>
	public bool bUseMainInstanceMontageEvaluationData;
	///<summary>True when Montages are being ticked, and Montage Events should be queued.</summary>
	public bool bQueueMontageEvents;
	///<summary>kismet event functions</summary>
	public virtual APawn TryGetPawnOwner() { return default; }
	///<summary>Takes a snapshot of the current skeletal mesh component pose &amp; saves it internally.</summary>
	public virtual void SavePoseSnapshot(FName SnapshotName) {}
	///<summary>Remove a previously saved pose snapshot from the internal snapshot cache</summary>
	public void RemovePoseSnapshot(FName SnapshotName) {}
	///<summary>Takes a snapshot of the current skeletal mesh component pose and saves it to the specified snapshot.</summary>
	public virtual void SnapshotPose(FPoseSnapshot Snapshot) {}
	///<summary>Get whether to process notifies from any linked anim instances</summary>
	public bool GetReceiveNotifiesFromLinkedInstances() { return default; }
	///<summary>Set whether to process notifies from any linked anim instances</summary>
	public void SetReceiveNotifiesFromLinkedInstances(bool bSet) {}
	///<summary>Get whether to propagate notifies to any linked anim instances</summary>
	public bool GetPropagateNotifiesToLinkedInstances() { return default; }
	///<summary>Set whether to propagate notifies to any linked anim instances</summary>
	public void SetPropagateNotifiesToLinkedInstances(bool bSet) {}
	///<summary>IsUsingMainInstanceMontageEvaluationData</summary>
	public bool IsUsingMainInstanceMontageEvaluationData() { return default; }
	///<summary>SetUseMainInstanceMontageEvaluationData</summary>
	public void SetUseMainInstanceMontageEvaluationData(bool bSet) {}
	///<summary>Returns the owning actor of this AnimInstance</summary>
	public AActor GetOwningActor() { return default; }
	///<summary>Returns the skeletal mesh component that has created this AnimInstance</summary>
	public USkeletalMeshComponent GetOwningComponent() { return default; }
	///<summary>Executed when the Animation is initialized</summary>
	public void BlueprintInitializeAnimation() {}
	///<summary>Executed when the Animation is updated</summary>
	public void BlueprintUpdateAnimation(float DeltaTimeX) {}
	///<summary>Executed after the Animation is evaluated</summary>
	public void BlueprintPostEvaluateAnimation() {}
	///<summary>Executed when begin play is called on the owning component</summary>
	public void BlueprintBeginPlay() {}
	///<summary>Executed when the all Linked Animation Layers are initialized</summary>
	public void BlueprintLinkedAnimationLayersInitialized() {}
	///<summary>Executed when the Animation Blueprint is updated on a worker thread, just prior to graph update</summary>
	public void BlueprintThreadSafeUpdateAnimation(float DeltaTime) {}
	///<summary>Play normal animation asset on the slot node by creating a dynamic UAnimMontage. You can only play one asset (whether montage or animsequence) at a time per SlotGroup.</summary>
	public UAnimMontage PlaySlotAnimationAsDynamicMontage(UAnimSequenceBase Asset,FName SlotNodeName,float BlendInTime/*=0.25f*/,float BlendOutTime/*=0.25f*/,float InPlayRate/*=1.0f*/,int LoopCount/*=1*/,float BlendOutTriggerTime/*=-1.0f*/,float InTimeToStartMontageAt/*=0.0f*/) { return default; }
	///<summary>Play normal animation asset on the slot node by creating a dynamic UAnimMontage with blend in arguments. You can only play one asset (whether montage or animsequence) at a time per SlotGroup.</summary>
	public UAnimMontage PlaySlotAnimationAsDynamicMontage_WithBlendArgs(UAnimSequenceBase Asset,FName SlotNodeName,FAlphaBlendArgs BlendIn,FAlphaBlendArgs BlendOut,float InPlayRate/*=1.0f*/,int LoopCount/*=1*/,float BlendOutTriggerTime/*=-1.0f*/,float InTimeToStartMontageAt/*=0.0f*/) { return default; }
	///<summary>Play normal animation asset on the slot node by creating a dynamic UAnimMontage with blend in settings. You can only play one asset (whether montage or animsequence) at a time per SlotGroup.</summary>
	public UAnimMontage PlaySlotAnimationAsDynamicMontage_WithBlendSettings(UAnimSequenceBase Asset,FName SlotNodeName,FMontageBlendSettings BlendInSettings,FMontageBlendSettings BlendOutSettings,float InPlayRate/*=1.0f*/,int LoopCount/*=1*/,float BlendOutTriggerTime/*=-1.0f*/,float InTimeToStartMontageAt/*=0.0f*/) { return default; }
	///<summary>Stops currently playing slot animation slot or all</summary>
	public void StopSlotAnimation(float InBlendOutTime/*=0.25f*/,FName SlotNodeName/*=NAME_None*/) {}
	///<summary>Return true if it&#39;s playing the slot animation</summary>
	public bool IsPlayingSlotAnimation(UAnimSequenceBase Asset,FName SlotNodeName) { return default; }
	///<summary>Plays an animation montage. Returns the length of the animation montage in seconds. Returns 0.f if failed to play.</summary>
	public float Montage_Play(UAnimMontage MontageToPlay,float InPlayRate/*=1.0f*/,EMontagePlayReturnType ReturnValueType/*=EMontagePlayReturnType.MontageLength*/,float InTimeToStartMontageAt/*=0.0f*/,bool bStopAllMontages/*=true*/) { return default; }
	///<summary>Plays an animation montage. Same as Montage_Play, but you can specify an AlphaBlend for Blend In settings.</summary>
	public float Montage_PlayWithBlendIn(UAnimMontage MontageToPlay,FAlphaBlendArgs BlendIn,float InPlayRate/*=1.0f*/,EMontagePlayReturnType ReturnValueType/*=EMontagePlayReturnType.MontageLength*/,float InTimeToStartMontageAt/*=0.0f*/,bool bStopAllMontages/*=true*/) { return default; }
	///<summary>Plays an animation montage. Same as Montage_Play, but you can overwrite all of the montage&#39;s default blend in settings.</summary>
	public float Montage_PlayWithBlendSettings(UAnimMontage MontageToPlay,FMontageBlendSettings BlendInSettings,float InPlayRate/*=1.0f*/,EMontagePlayReturnType ReturnValueType/*=EMontagePlayReturnType.MontageLength*/,float InTimeToStartMontageAt/*=0.0f*/,bool bStopAllMontages/*=true*/) { return default; }
	///<summary>Stopped montages will blend out using their montage asset&#39;s BlendOut, with InBlendOutTime as the BlendTime</summary>
	public void Montage_Stop(float InBlendOutTime,UAnimMontage Montage/*=NULL*/) {}
	///<summary>Same as Montage_Stop. Uses values from the AlphaBlendArgs. Other settings come from the montage asset</summary>
	public void Montage_StopWithBlendOut(FAlphaBlendArgs BlendOut,UAnimMontage Montage/*=nullptr*/) {}
	///<summary>Same as Montage_Stop, but all blend settings are provided instead of using the ones on the montage asset</summary>
	public void Montage_StopWithBlendSettings(FMontageBlendSettings BlendOutSettings,UAnimMontage Montage/*=nullptr*/) {}
	///<summary>Stops all active montages belonging to a group.</summary>
	public void Montage_StopGroupByName(float InBlendOutTime,FName GroupName) {}
	///<summary>Pauses the animation montage. If reference is NULL, it will pause ALL active montages.</summary>
	public void Montage_Pause(UAnimMontage Montage/*=NULL*/) {}
	///<summary>Resumes a paused animation montage. If reference is NULL, it will resume ALL active montages.</summary>
	public void Montage_Resume(UAnimMontage Montage) {}
	///<summary>Makes a montage jump to a named section. If Montage reference is NULL, it will do that to all active montages.</summary>
	public void Montage_JumpToSection(FName SectionName,UAnimMontage Montage/*=NULL*/) {}
	///<summary>Makes a montage jump to the end of a named section. If Montage reference is NULL, it will do that to all active montages.</summary>
	public void Montage_JumpToSectionsEnd(FName SectionName,UAnimMontage Montage/*=NULL*/) {}
	///<summary>Relink new next section AFTER SectionNameToChange in run-time</summary>
	public void Montage_SetNextSection(FName SectionNameToChange,FName NextSection,UAnimMontage Montage/*=NULL*/) {}
	///<summary>Change AnimMontage play rate. NewPlayRate = 1.0 is the default playback rate.</summary>
	public void Montage_SetPlayRate(UAnimMontage Montage,float NewPlayRate/*=1.0f*/) {}
	///<summary>Returns true if the animation montage is active. If the Montage reference is NULL, it will return true if any Montage is active.</summary>
	public bool Montage_IsActive(UAnimMontage Montage) { return default; }
	///<summary>Returns true if the animation montage is currently active and playing.</summary>
	public bool Montage_IsPlaying(UAnimMontage Montage) { return default; }
	///<summary>Returns the name of the current animation montage section.</summary>
	public FName Montage_GetCurrentSection(UAnimMontage Montage/*=NULL*/) { return default; }
	///<summary>Get Current Montage Position</summary>
	public float Montage_GetPosition(UAnimMontage Montage) { return default; }
	///<summary>Set position.</summary>
	public void Montage_SetPosition(UAnimMontage Montage,float NewPosition) {}
	///<summary>return true if Montage is not currently active. (not valid or blending out)</summary>
	public bool Montage_GetIsStopped(UAnimMontage Montage) { return default; }
	///<summary>Get the current blend time of the Montage.</summary>
	public float Montage_GetBlendTime(UAnimMontage Montage) { return default; }
	///<summary>Get PlayRate for Montage. This does not account for RateScale, so it may not reflect the actual play rate seen in game (see Montage_GetEffectivePlayRate).</summary>
	public float Montage_GetPlayRate(UAnimMontage Montage) { return default; }
	///<summary>Get scaled PlayRate for Montage. This accounts for RateScale, so it will reflect the actual play rate seen in game.</summary>
	public float Montage_GetEffectivePlayRate(UAnimMontage Montage) { return default; }
	///<summary>Synchronize a montage to another anim instance&#39;s montage. Both montages must be playing already</summary>
	public void MontageSync_Follow(UAnimMontage MontageFollower,UAnimInstance OtherAnimInstance,UAnimMontage MontageLeader) {}
	///<summary>Stop following the montage&#39;s leader in this anim instance</summary>
	public void MontageSync_StopFollowing(UAnimMontage MontageFollower) {}
	///<summary>Returns true if any montage is playing currently. Doesn&#39;t mean it&#39;s active though, it could be blending out.</summary>
	public bool IsAnyMontagePlaying() { return default; }
	///<summary>Get a current Active Montage in this AnimInstance.</summary>
	public UAnimMontage GetCurrentActiveMontage() { return default; }
	///<summary>Called when a montage starts blending out, whether interrupted or finished</summary>
	public FOnMontageBlendingOutStartedMCDelegate OnMontageBlendingOut;
	///<summary>Called when a montage has started</summary>
	public FOnMontageStartedMCDelegate OnMontageStarted;
	///<summary>Called when a montage has ended, whether interrupted or finished</summary>
	public FOnMontageEndedMCDelegate OnMontageEnded;
	///<summary>Called when all Montage instances have ended.</summary>
	public FOnAllMontageInstancesEndedMCDelegate OnAllMontageInstancesEnded;
	///<summary>Runs through all nodes, attempting to find the first linked instance by name/tag</summary>
	public UAnimInstance GetLinkedAnimGraphInstanceByTag(FName InTag) { return default; }
	///<summary>GetLinkedAnimGraphInstancesByTag</summary>
	public void GetLinkedAnimGraphInstancesByTag(FName InTag,TArray<UAnimInstance> OutLinkedInstances) {}
	///<summary>Runs through all nodes, attempting to find a linked instance by name/tag, then sets the class of each node if the tag matches</summary>
	public void LinkAnimGraphByTag(FName InTag,UClass InClass) {}
	///<summary>Runs through all layer nodes, attempting to find layer nodes that are implemented by the specified class, then sets up a linked instance of the class for each.</summary>
	public virtual void LinkAnimClassLayers(UClass InClass) {}
	///<summary>Runs through all layer nodes, attempting to find layer nodes that are currently running the specified class, then resets each to its default value.</summary>
	public virtual void UnlinkAnimClassLayers(UClass InClass) {}
	///<summary>Gets the layer linked instance corresponding to the specified group</summary>
	public UAnimInstance GetLinkedAnimLayerInstanceByGroup(FName InGroup) { return default; }
	///<summary>Runs through all nodes, attempting to find all distinct layer linked instances in the group</summary>
	public void GetLinkedAnimLayerInstancesByGroup(FName InGroup,TArray<UAnimInstance> OutLinkedInstances) {}
	///<summary>Gets layer linked instance that matches group and class</summary>
	public UAnimInstance GetLinkedAnimLayerInstanceByGroupAndClass(FName InGroup,UClass InClass) { return default; }
	///<summary>Gets the first layer linked instance corresponding to the specified class</summary>
	public UAnimInstance GetLinkedAnimLayerInstanceByClass(UClass InClass) { return default; }
	///<summary>Requests an inertial blend during the next anim graph update. Requires your anim graph to have a slot node belonging to the specified group name</summary>
	public void RequestSlotGroupInertialization(FName InSlotGroupName,float Duration,UBlendProfile BlendProfile/*=nullptr*/) {}
	///<summary>Set RootMotionMode</summary>
	public void SetRootMotionMode(ERootMotionMode Value) {}
	///<summary>Gets the length in seconds of the asset referenced in an asset player node</summary>
	public float GetInstanceAssetPlayerLength(int AssetPlayerIndex) { return default; }
	///<summary>Get the current accumulated time in seconds for an asset player node</summary>
	public float GetInstanceAssetPlayerTime(int AssetPlayerIndex) { return default; }
	///<summary>Get the current accumulated time as a fraction for an asset player node</summary>
	public float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex) { return default; }
	///<summary>Get the time in seconds from the end of an animation in an asset player node</summary>
	public float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex) { return default; }
	///<summary>Get the time as a fraction of the asset length of an animation in an asset player node</summary>
	public float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex) { return default; }
	///<summary>Get the blend weight of a specified state machine</summary>
	public float GetInstanceMachineWeight(int MachineIndex) { return default; }
	///<summary>Get the blend weight of a specified state</summary>
	public float GetInstanceStateWeight(int MachineIndex,int StateIndex) { return default; }
	///<summary>Get the current elapsed time of a state within the specified state machine</summary>
	public float GetInstanceCurrentStateElapsedTime(int MachineIndex) { return default; }
	///<summary>Get the crossfade duration of a specified transition</summary>
	public float GetInstanceTransitionCrossfadeDuration(int MachineIndex,int TransitionIndex) { return default; }
	///<summary>Get the elapsed time in seconds of a specified transition</summary>
	public float GetInstanceTransitionTimeElapsed(int MachineIndex,int TransitionIndex) { return default; }
	///<summary>Get the elapsed time as a fraction of the crossfade duration of a specified transition</summary>
	public float GetInstanceTransitionTimeElapsedFraction(int MachineIndex,int TransitionIndex) { return default; }
	///<summary>Get the time remaining in seconds for the most relevant animation in the source state</summary>
	public float GetRelevantAnimTimeRemaining(int MachineIndex,int StateIndex) { return default; }
	///<summary>Get the time remaining as a fraction of the duration for the most relevant animation in the source state</summary>
	public float GetRelevantAnimTimeRemainingFraction(int MachineIndex,int StateIndex) { return default; }
	///<summary>Get the length in seconds of the most relevant animation in the source state</summary>
	public float GetRelevantAnimLength(int MachineIndex,int StateIndex) { return default; }
	///<summary>Get the current accumulated time in seconds for the most relevant animation in the source state</summary>
	public float GetRelevantAnimTime(int MachineIndex,int StateIndex) { return default; }
	///<summary>Get the current accumulated time as a fraction of the length of the most relevant animation in the source state</summary>
	public float GetRelevantAnimTimeFraction(int MachineIndex,int StateIndex) { return default; }
	///<summary>Get whether a particular notify state was active in any state machine last tick.</summary>
	public bool WasAnimNotifyStateActiveInAnyState(UClass AnimNotifyStateType) { return default; }
	///<summary>Get whether a particular notify state is active in a specific state machine last tick.</summary>
	public bool WasAnimNotifyStateActiveInStateMachine(int MachineIndex,UClass AnimNotifyStateType) { return default; }
	///<summary>Get whether a particular notify state is active in a specific state last tick.</summary>
	public bool WasAnimNotifyStateActiveInSourceState(int MachineIndex,int StateIndex,UClass AnimNotifyStateType) { return default; }
	///<summary>Get whether the most relevant animation was in a particular notify state last tick.</summary>
	public bool WasAnimNotifyTriggeredInSourceState(int MachineIndex,int StateIndex,UClass AnimNotifyType) { return default; }
	///<summary>Get whether the most relevant animation triggered the animation notify with the specified name last tick..</summary>
	public bool WasAnimNotifyNameTriggeredInSourceState(int MachineIndex,int StateIndex,FName NotifyName) { return default; }
	///<summary>Get whether a particular notify type was active in a specific state machine last tick.</summary>
	public bool WasAnimNotifyTriggeredInStateMachine(int MachineIndex,UClass AnimNotifyType) { return default; }
	///<summary>Get whether the given state machine triggered the animation notify with the specified name last tick.</summary>
	public bool WasAnimNotifyNameTriggeredInStateMachine(int MachineIndex,FName NotifyName) { return default; }
	///<summary>Get whether an animation notify of a given type was triggered last tick.</summary>
	public bool WasAnimNotifyTriggeredInAnyState(UClass AnimNotifyType) { return default; }
	///<summary>Get whether the animation notify with the specified name triggered last tick.</summary>
	public bool WasAnimNotifyNameTriggeredInAnyState(FName NotifyName) { return default; }
	///<summary>Returns the value of a named curve.</summary>
	public float GetCurveValue(FName CurveName) { return default; }
	///<summary>Returns whether a named curve was found, its value, and a default value when it&#39;s not found.</summary>
	public bool GetCurveValueWithDefault(FName CurveName,float DefaultValue,float OutValue) { return default; }
	///<summary>This returns last up-to-date list of active curve names</summary>
	public void GetActiveCurveNames(EAnimCurveType CurveType,TArray<FName> OutNames) {}
	///<summary>This returns all curve names</summary>
	public void GetAllCurveNames(TArray<FName> OutNames) {}
	///<summary>Returns the name of a currently active state in a state machine.</summary>
	public FName GetCurrentStateName(int MachineIndex) { return default; }
	///<summary>Sets a morph target to a certain weight.</summary>
	public void SetMorphTarget(FName MorphTargetName,float Value) {}
	///<summary>Clears the current morph targets.</summary>
	public void ClearMorphTargets() {}
	///<summary>CalculateDirection</summary>
	public float CalculateDirection(FVector Velocity,FRotator BaseRotation) { return default; }
	///<summary>locks indicated AI resources of animated pawn</summary>
	public void LockAIResources(bool bLockMovement,bool LockAILogic) {}
	///<summary>unlocks indicated AI resources of animated pawn. Will unlock only animation-locked resources.</summary>
	public void UnlockAIResources(bool bUnlockMovement,bool UnlockAILogic) {}
	///<summary>--- AI communication end ---</summary>
	public bool GetTimeToClosestMarker(FName SyncGroup,FName MarkerName,float OutMarkerTime) { return default; }
	///<summary>HasMarkerBeenHitThisFrame</summary>
	public bool HasMarkerBeenHitThisFrame(FName SyncGroup,FName MarkerName) { return default; }
	///<summary>IsSyncGroupBetweenMarkers</summary>
	public bool IsSyncGroupBetweenMarkers(FName InSyncGroupName,FName PreviousMarker,FName NextMarker,bool bRespectMarkerOrder/*=true*/) { return default; }
	///<summary>GetSyncGroupPosition</summary>
	public FMarkerSyncAnimPosition GetSyncGroupPosition(FName InSyncGroupName) { return default; }
	///<summary>Attempts to queue a transition request, returns true if the request was successful</summary>
	public bool RequestTransitionEvent(FName EventName,double RequestTimeout,ETransitionRequestQueueMode QueueMode,ETransitionRequestOverwriteMode OverwriteMode) { return default; }
	///<summary>Removes all queued transition requests with the given event name</summary>
	public void ClearTransitionEvents(FName EventName) {}
	///<summary>Removes all queued transition requests</summary>
	public void ClearAllTransitionEvents() {}
	///<summary>Returns whether or not the given event transition request has been queued</summary>
	public bool QueryTransitionEvent(int MachineIndex,int TransitionIndex,FName EventName) { return default; }
	///<summary>Behaves like QueryTransitionEvent but additionally marks the event for consumption</summary>
	public bool QueryAndMarkTransitionEvent(int MachineIndex,int TransitionIndex,FName EventName) { return default; }
	///<summary>Name of Class to do Post Compile Validation.</summary>
	public FSoftClassPath PostCompileValidationClassName;
	///<summary>Reset any dynamics running simulation-style updates (e.g. on teleport, time skip etc.)</summary>
	public void ResetDynamics(ETeleportType InTeleportType) {}
	///<summary>Animation Notifies that has been triggered in the latest tick *</summary>
	public FAnimNotifyQueue NotifyQueue;
	///<summary>Currently Active AnimNotifyState, stored as a copy of the event as we need to</summary>
	public TArray<FAnimNotifyEvent> ActiveAnimNotifyState;
	///<summary>ActiveAnimNotifyEventReference</summary>
	public TArray<FAnimNotifyEventReference> ActiveAnimNotifyEventReference;
	///<summary>Get the current delta time</summary>
	public float GetDeltaSeconds() { return default; }
}
