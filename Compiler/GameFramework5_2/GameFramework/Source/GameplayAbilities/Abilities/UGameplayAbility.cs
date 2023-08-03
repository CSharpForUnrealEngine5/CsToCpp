#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abilities define custom gameplay logic that can be activated by players or external game logic</summary>
[CppInclude("Abilities/GameplayAbility.h")]
public partial class UGameplayAbility : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the actor info associated with this ability, has cached pointers to useful objects</summary>
	public  FGameplayAbilityActorInfo GetActorInfo() { return default; }
	///<summary>Returns the actor that owns this ability, which may not have a physical location</summary>
	public  AActor GetOwningActorFromActorInfo() { return default; }
	///<summary>Returns the physical actor that is executing this ability. May be null</summary>
	public  AActor GetAvatarActorFromActorInfo() { return default; }
	///<summary>Convenience method for abilities to get skeletal mesh component - useful for aiming abilities</summary>
	public  USkeletalMeshComponent GetOwningComponentFromActorInfo() { return default; }
	///<summary>Returns the AbilitySystemComponent that is activating this ability</summary>
	public  UAbilitySystemComponent GetAbilitySystemComponentFromActorInfo() { return default; }
	///<summary>Retrieves the EffectContext of the GameplayEffect that granted this ability. Can only be called on instanced abilities.</summary>
	public  FGameplayEffectContextHandle GetGrantedByEffectContext() { return default; }
	///<summary>Generates a GameplayEffectContextHandle from our owner and an optional TargetData.</summary>
	public  FGameplayEffectContextHandle GetContextFromOwner(FGameplayAbilityTargetDataHandle OptionalTargetData) { return default; }
	///<summary>Convenience method for abilities to get outgoing gameplay effect specs (for example, to pass on to projectiles to apply to whoever they hit)</summary>
	public  FGameplayEffectSpecHandle MakeOutgoingGameplayEffectSpec(UClass GameplayEffectClass,float Level/*=1.0f*/) { return default; }
	///<summary>True if the owning actor is locally controlled, true in single player</summary>
	public  bool IsLocallyControlled() { return default; }
	///<summary>K2_HasAuthority</summary>
	public  bool K2_HasAuthority() { return default; }
	///<summary>Returns the time in seconds remaining on the currently active cooldown.</summary>
	public  float GetCooldownTimeRemaining() { return default; }
	///<summary>Sets rather ability block flags are enabled or disabled. Only valid on instanced abilities</summary>
	public  void SetShouldBlockOtherAbilities(bool bShouldBlockAbilities) {}
	///<summary>Call from Blueprint to cancel the ability naturally</summary>
	public  void K2_CancelAbility() {}
	///<summary>Sets whether the ability should ignore cancel requests. Only valid on instanced abilities</summary>
	public  void SetCanBeCanceled(bool bCanBeCanceled) {}
	///<summary>Attempts to commit the ability (spend resources, etc). This our last chance to fail. Child classes that override ActivateAbility must call this themselves!</summary>
	public  bool K2_CommitAbility() { return default; }
	///<summary>Attempts to commit the ability&#39;s cooldown only. If BroadcastCommitEvent is true, it will broadcast the commit event that tasks like WaitAbilityCommit are listening for.</summary>
	public  bool K2_CommitAbilityCooldown(bool BroadcastCommitEvent/*=false*/,bool ForceCooldown/*=false*/) { return default; }
	///<summary>Attempts to commit the ability&#39;s cost only. If BroadcastCommitEvent is true, it will broadcast the commit event that tasks like WaitAbilityCommit are listening for.</summary>
	public  bool K2_CommitAbilityCost(bool BroadcastCommitEvent/*=false*/) { return default; }
	///<summary>Checks the ability&#39;s cooldown, but does not apply it.</summary>
	public  bool K2_CheckAbilityCooldown() { return default; }
	///<summary>Checks the ability&#39;s cost, but does not apply it.</summary>
	public  bool K2_CheckAbilityCost() { return default; }
	///<summary>BP event called from CommitAbility</summary>
	public  void K2_CommitExecute() {}
	///<summary>Returns the currently playing montage for this ability, if any</summary>
	public  UAnimMontage GetCurrentMontage() { return default; }
	///<summary>Returns current level of the Ability</summary>
	public  int GetAbilityLevel() { return default; }
	///<summary>Returns current ability level for non instanced abilities. You must call this version in these contexts!</summary>
	public  int GetAbilityLevel_BP(FGameplayAbilitySpecHandle Handle,FGameplayAbilityActorInfo ActorInfo) { return default; }
	///<summary>Retrieves the SourceObject associated with this ability. Can only be called on instanced abilities.</summary>
	public  UObject GetCurrentSourceObject() { return default; }
	///<summary>Retrieves the SourceObject associated with this ability. Callable on non instanced</summary>
	public  UObject GetSourceObject_BP(FGameplayAbilitySpecHandle Handle,FGameplayAbilityActorInfo ActorInfo) { return default; }
	///<summary>Invalidates the current prediction key. This should be used in cases where there is a valid prediction window, but the server is doing logic that only it can do, and afterwards performs an action that the client could predict (had the client been able to run the server-only code prior).</summary>
	public  void InvalidateClientPredictionKey() {}
	///<summary>Removes the GameplayEffect that granted this ability. Can only be called on instanced abilities.</summary>
	public  void RemoveGrantedByEffect() {}
	///<summary>This ability has these tags</summary>
	public FGameplayTagContainer AbilityTags;
	///<summary>If true, this ability will always replicate input press/release events to the server.</summary>
	public bool bReplicateInputDirectly;
	///<summary>Set when the remote instance of this ability has ended (but the local instance may still be running or finishing up</summary>
	public bool RemoteInstanceEnded;
	///<summary>Returns true if this ability can be activated right now. Has no side effects</summary>
	public  bool K2_ShouldAbilityRespondToEvent(FGameplayAbilityActorInfo ActorInfo,FGameplayEventData Payload) { return default; }
	///<summary>Sends a gameplay event, also creates a prediction window</summary>
	public  void SendGameplayEvent(FGameplayTag EventTag,FGameplayEventData Payload) {}
	///<summary>Returns true if this ability can be activated right now. Has no side effects</summary>
	public  bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo,FGameplayAbilitySpecHandle Handle,FGameplayTagContainer RelevantTags) { return default; }
	///<summary>The main function that defines what an ability does.</summary>
	public  void K2_ActivateAbility() {}
	///<summary>K2_ActivateAbilityFromEvent</summary>
	public  void K2_ActivateAbilityFromEvent(FGameplayEventData EventData) {}
	///<summary>Call from blueprints to forcibly end the ability without canceling it. This will replicate the end ability to the client or server which can interrupt tasks</summary>
	public  void K2_EndAbility() {}
	///<summary>Call from blueprints to end the ability naturally. This will only end predicted abilities locally, allowing it end naturally on the client or server</summary>
	public  void K2_EndAbilityLocally() {}
	///<summary>Blueprint event, will be called if an ability ends normally or abnormally</summary>
	public  void K2_OnEndAbility(bool bWasCancelled) {}
	///<summary>Apply a gameplay effect to the owner of this ability</summary>
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectToOwner(UClass GameplayEffectClass,int GameplayEffectLevel/*=1*/,int Stacks/*=1*/) { return default; }
	///<summary>Apply a previously created gameplay effect spec to the owner of this ability</summary>
	public  FActiveGameplayEffectHandle K2_ApplyGameplayEffectSpecToOwner(FGameplayEffectSpecHandle EffectSpecHandle) { return default; }
	///<summary>Apply a gameplay effect to a Target</summary>
	public  TArray<FActiveGameplayEffectHandle> BP_ApplyGameplayEffectToTarget(FGameplayAbilityTargetDataHandle TargetData,UClass GameplayEffectClass,int GameplayEffectLevel/*=1*/,int Stacks/*=1*/) { return default; }
	///<summary>Apply a previously created gameplay effect spec to a target</summary>
	public  TArray<FActiveGameplayEffectHandle> K2_ApplyGameplayEffectSpecToTarget(FGameplayEffectSpecHandle EffectSpecHandle,FGameplayAbilityTargetDataHandle TargetData) { return default; }
	///<summary>Removes GameplayEffects from owner which match the given asset level tags</summary>
	public  void BP_RemoveGameplayEffectFromOwnerWithAssetTags(FGameplayTagContainer WithAssetTags,int StacksToRemove/*=-1*/) {}
	///<summary>Removes GameplayEffects from owner which grant the given tags</summary>
	public  void BP_RemoveGameplayEffectFromOwnerWithGrantedTags(FGameplayTagContainer WithGrantedTags,int StacksToRemove/*=-1*/) {}
	///<summary>Removes GameplayEffect from owner that match the given handle</summary>
	public  void BP_RemoveGameplayEffectFromOwnerWithHandle(FActiveGameplayEffectHandle Handle,int StacksToRemove/*=-1*/) {}
	///<summary>Invoke a gameplay cue on the ability owner</summary>
	public  void K2_ExecuteGameplayCue(FGameplayTag GameplayCueTag,FGameplayEffectContextHandle Context) {}
	///<summary>Invoke a gameplay cue on the ability owner, with extra parameters</summary>
	public  void K2_ExecuteGameplayCueWithParams(FGameplayTag GameplayCueTag,FGameplayCueParameters GameplayCueParameters) {}
	///<summary>Adds a persistent gameplay cue to the ability owner. Optionally will remove if ability ends</summary>
	public  void K2_AddGameplayCue(FGameplayTag GameplayCueTag,FGameplayEffectContextHandle Context,bool bRemoveOnAbilityEnd/*=true*/) {}
	///<summary>Adds a persistent gameplay cue to the ability owner. Optionally will remove if ability ends</summary>
	public  void K2_AddGameplayCueWithParams(FGameplayTag GameplayCueTag,FGameplayCueParameters GameplayCueParameter,bool bRemoveOnAbilityEnd/*=true*/) {}
	///<summary>Removes a persistent gameplay cue from the ability owner</summary>
	public  void K2_RemoveGameplayCue(FGameplayTag GameplayCueTag) {}
	///<summary>How an ability replicates state/events to everyone on the network. Replication is not required for NetExecutionPolicy.</summary>
	public EGameplayAbilityReplicationPolicy ReplicationPolicy;
	///<summary>How the ability is instanced when executed. This limits what an ability can do in its implementation.</summary>
	public EGameplayAbilityInstancingPolicy InstancingPolicy;
	///<summary>If this is set, the server-side version of the ability can be canceled by the client-side version. The client-side version can always be canceled by the server.</summary>
	public bool bServerRespectsRemoteAbilityCancellation;
	///<summary>if true, and trying to activate an already active instanced ability, end it and re-trigger it.</summary>
	public bool bRetriggerInstancedAbility;
	///<summary>This is information specific to this instance of the ability. E.g, whether it is predicting, authoring, confirmed, etc.</summary>
	public FGameplayAbilityActivationInfo CurrentActivationInfo;
	///<summary>Information specific to this instance of the ability, if it was activated by an event</summary>
	public FGameplayEventData CurrentEventData;
	///<summary>How does an ability execute on the network. Does a client &quot;ask and predict&quot;, &quot;ask and wait&quot;, &quot;don&#39;t ask (just do it)&quot;.</summary>
	public EGameplayAbilityNetExecutionPolicy NetExecutionPolicy;
	///<summary>What protections does this ability have? Should the client be allowed to request changes to the execution of the ability?</summary>
	public EGameplayAbilityNetSecurityPolicy NetSecurityPolicy;
	///<summary>This GameplayEffect represents the cost (mana, stamina, etc) of the ability. It will be applied when the ability is committed.</summary>
	public UClass CostGameplayEffectClass;
	///<summary>Triggers to determine if this ability should execute in response to an event</summary>
	public TArray<FAbilityTriggerData> AbilityTriggers;
	///<summary>This GameplayEffect represents the cooldown. It will be applied when the ability is committed and the ability cannot be used again until it is expired.</summary>
	public UClass CooldownGameplayEffectClass;
	///<summary>Abilities with these tags are cancelled when this ability is executed</summary>
	public FGameplayTagContainer CancelAbilitiesWithTag;
	///<summary>Abilities with these tags are blocked while this ability is active</summary>
	public FGameplayTagContainer BlockAbilitiesWithTag;
	///<summary>Tags to apply to activating owner while this ability is active. These are replicated if ReplicateActivationOwnedTags is enabled in AbilitySystemGlobals.</summary>
	public FGameplayTagContainer ActivationOwnedTags;
	///<summary>This ability can only be activated if the activating actor/component has all of these tags</summary>
	public FGameplayTagContainer ActivationRequiredTags;
	///<summary>This ability is blocked if the activating actor/component has any of these tags</summary>
	public FGameplayTagContainer ActivationBlockedTags;
	///<summary>This ability can only be activated if the source actor/component has all of these tags</summary>
	public FGameplayTagContainer SourceRequiredTags;
	///<summary>This ability is blocked if the source actor/component has any of these tags</summary>
	public FGameplayTagContainer SourceBlockedTags;
	///<summary>This ability can only be activated if the target actor/component has all of these tags</summary>
	public FGameplayTagContainer TargetRequiredTags;
	///<summary>This ability is blocked if the target actor/component has any of these tags</summary>
	public FGameplayTagContainer TargetBlockedTags;
	///<summary>Finds all currently active tasks named InstanceName and confirms them. What this means depends on the individual task. By default, this does nothing other than ending if bEndTask is true.</summary>
	public  void ConfirmTaskByInstanceName(string InstanceName,bool bEndTask) {}
	///<summary>Add any task with this instance name to a list to be ended (not canceled) next frame.  See also CancelTaskByInstanceName.</summary>
	public  void EndTaskByInstanceName(string InstanceName) {}
	///<summary>Add any task with this instance name to a list to be canceled (not ended) next frame.  See also EndTaskByInstanceName.</summary>
	public  void CancelTaskByInstanceName(string InstanceName) {}
	///<summary>Ends any active ability state task with the given name. If name is &#39;None&#39; all active states will be ended (in an arbitrary order).</summary>
	public  void EndAbilityState(string OptionalStateNameToEnd) {}
	///<summary>List of currently active tasks, do not modify directly</summary>
	public TArray<UGameplayTask> ActiveTasks;
	///<summary>Immediately jumps the active montage to a section</summary>
	public  void MontageJumpToSection(string SectionName) {}
	///<summary>Sets pending section on active montage</summary>
	public  void MontageSetNextSectionName(string FromSectionName,string ToSectionName) {}
	///<summary>Stops the current animation montage.</summary>
	public  void MontageStop(float OverrideBlendOutTime/*=-1.0f*/) {}
	///<summary>Active montage being played by this ability</summary>
	public UAnimMontage CurrentMontage;
	///<summary>Creates a target location from where the owner avatar is</summary>
	public  FGameplayAbilityTargetingLocationInfo MakeTargetLocationInfoFromOwnerActor() { return default; }
	///<summary>Creates a target location from a socket on the owner avatar&#39;s skeletal mesh</summary>
	public  FGameplayAbilityTargetingLocationInfo MakeTargetLocationInfoFromOwnerSkeletalMeshComponent(string SocketName) { return default; }
	///<summary>True if the ability is currently active. For instance per owner abilities</summary>
	public bool bIsActive;
	///<summary>True if the end ability has been called, but has not yet completed.</summary>
	public bool bIsAbilityEnding;
	///<summary>True if the ability is currently cancelable, if not will only be canceled by hard EndAbility calls</summary>
	public bool bIsCancelable;
	///<summary>True if the ability block flags are currently enabled</summary>
	public bool bIsBlockingOtherAbilities;
	///<summary>Flag that is set by AbilitySystemComponent::OnRemoveAbility to indicate the ability needs to be cleaned up in AbilitySystemComponent::NotifyAbilityEnded</summary>
	public bool bMarkPendingKillOnAbilityEnd;
}
