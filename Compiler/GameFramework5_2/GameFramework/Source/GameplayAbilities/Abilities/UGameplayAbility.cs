#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbility.h")]
///<summary>Abilities define custom gameplay logic that can be activated by players or external game logic</summary>
public partial class UGameplayAbility : UObject {
// GameplayAbility
	public  FGameplayAbilityActorInfo GetActorInfo() { return default; }
	public  AActor GetOwningActorFromActorInfo() { return default; }
	public  AActor GetAvatarActorFromActorInfo() { return default; }
	public  USkeletalMeshComponent GetOwningComponentFromActorInfo() { return default; }
	public  UAbilitySystemComponent GetAbilitySystemComponentFromActorInfo() { return default; }
	public  FGameplayEffectContextHandle GetGrantedByEffectContext() { return default; }
	public  FGameplayEffectContextHandle GetContextFromOwner(FGameplayAbilityTargetDataHandle OptionalTargetData) { return default; }
	public  FGameplayEffectSpecHandle MakeOutgoingGameplayEffectSpec(UClass GameplayEffectClass,float Level/*=1.0f*/) { return default; }
	public  bool IsLocallyControlled() { return default; }
	public  bool K2_HasAuthority() { return default; }
	public  float GetCooldownTimeRemaining() { return default; }
	public  void SetShouldBlockOtherAbilities(bool bShouldBlockAbilities) {}
	public  void K2_CancelAbility() {}
	public  void SetCanBeCanceled(bool bCanBeCanceled) {}
	public  bool K2_CommitAbility() { return default; }
	public  bool K2_CommitAbilityCooldown(bool BroadcastCommitEvent/*=false*/,bool ForceCooldown/*=false*/) { return default; }
	public  bool K2_CommitAbilityCost(bool BroadcastCommitEvent/*=false*/) { return default; }
	public  bool K2_CheckAbilityCooldown() { return default; }
	public  bool K2_CheckAbilityCost() { return default; }
	public  void K2_CommitExecute() {}
	public  UAnimMontage GetCurrentMontage() { return default; }
	public  int GetAbilityLevel() { return default; }
	public  int GetAbilityLevel_BP(FGameplayAbilitySpecHandle Handle,FGameplayAbilityActorInfo ActorInfo) { return default; }
	public  UObject GetCurrentSourceObject() { return default; }
	public  UObject GetSourceObject_BP(FGameplayAbilitySpecHandle Handle,FGameplayAbilityActorInfo ActorInfo) { return default; }
	public  void InvalidateClientPredictionKey() {}
	public  void RemoveGrantedByEffect() {}
	public FGameplayTagContainer AbilityTags;
	public bool bReplicateInputDirectly;
	public bool RemoteInstanceEnded;
	public  bool K2_ShouldAbilityRespondToEvent(FGameplayAbilityActorInfo ActorInfo,FGameplayEventData Payload) { return default; }
	public  void SendGameplayEvent(FGameplayTag EventTag,FGameplayEventData Payload) {}
	public  bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo,FGameplayAbilitySpecHandle Handle,FGameplayTagContainer RelevantTags) { return default; }
	public  void K2_ActivateAbility() {}
	public  void K2_ActivateAbilityFromEvent(FGameplayEventData EventData) {}
	public  void K2_EndAbility() {}
	public  void K2_EndAbilityLocally() {}
	public  void K2_OnEndAbility(bool bWasCancelled) {}
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectToOwner(UClass GameplayEffectClass,int GameplayEffectLevel/*=1*/,int Stacks/*=1*/) { return default; }
	public  FActiveGameplayEffectHandle K2_ApplyGameplayEffectSpecToOwner(FGameplayEffectSpecHandle EffectSpecHandle) { return default; }
	public  TArray<FActiveGameplayEffectHandle> BP_ApplyGameplayEffectToTarget(FGameplayAbilityTargetDataHandle TargetData,UClass GameplayEffectClass,int GameplayEffectLevel/*=1*/,int Stacks/*=1*/) { return default; }
	public  TArray<FActiveGameplayEffectHandle> K2_ApplyGameplayEffectSpecToTarget(FGameplayEffectSpecHandle EffectSpecHandle,FGameplayAbilityTargetDataHandle TargetData) { return default; }
	public  void BP_RemoveGameplayEffectFromOwnerWithAssetTags(FGameplayTagContainer WithAssetTags,int StacksToRemove/*=-1*/) {}
	public  void BP_RemoveGameplayEffectFromOwnerWithGrantedTags(FGameplayTagContainer WithGrantedTags,int StacksToRemove/*=-1*/) {}
	public  void BP_RemoveGameplayEffectFromOwnerWithHandle(FActiveGameplayEffectHandle Handle,int StacksToRemove/*=-1*/) {}
	public  void K2_ExecuteGameplayCue(FGameplayTag GameplayCueTag,FGameplayEffectContextHandle Context) {}
	public  void K2_ExecuteGameplayCueWithParams(FGameplayTag GameplayCueTag,FGameplayCueParameters GameplayCueParameters) {}
	public  void K2_AddGameplayCue(FGameplayTag GameplayCueTag,FGameplayEffectContextHandle Context,bool bRemoveOnAbilityEnd/*=true*/) {}
	public  void K2_AddGameplayCueWithParams(FGameplayTag GameplayCueTag,FGameplayCueParameters GameplayCueParameter,bool bRemoveOnAbilityEnd/*=true*/) {}
	public  void K2_RemoveGameplayCue(FGameplayTag GameplayCueTag) {}
	public EGameplayAbilityReplicationPolicy ReplicationPolicy;
	public EGameplayAbilityInstancingPolicy InstancingPolicy;
	public bool bServerRespectsRemoteAbilityCancellation;
	public bool bRetriggerInstancedAbility;
	public FGameplayAbilityActivationInfo CurrentActivationInfo;
	public FGameplayEventData CurrentEventData;
	public EGameplayAbilityNetExecutionPolicy NetExecutionPolicy;
	public EGameplayAbilityNetSecurityPolicy NetSecurityPolicy;
	public UClass CostGameplayEffectClass;
	public TArray<FAbilityTriggerData> AbilityTriggers;
	public UClass CooldownGameplayEffectClass;
	public FGameplayTagContainer CancelAbilitiesWithTag;
	public FGameplayTagContainer BlockAbilitiesWithTag;
	public FGameplayTagContainer ActivationOwnedTags;
	public FGameplayTagContainer ActivationRequiredTags;
	public FGameplayTagContainer ActivationBlockedTags;
	public FGameplayTagContainer SourceRequiredTags;
	public FGameplayTagContainer SourceBlockedTags;
	public FGameplayTagContainer TargetRequiredTags;
	public FGameplayTagContainer TargetBlockedTags;
	public  void ConfirmTaskByInstanceName(string InstanceName,bool bEndTask) {}
	public  void EndTaskByInstanceName(string InstanceName) {}
	public  void CancelTaskByInstanceName(string InstanceName) {}
	public  void EndAbilityState(string OptionalStateNameToEnd) {}
	public TArray<UGameplayTask> ActiveTasks;
	public  void MontageJumpToSection(string SectionName) {}
	public  void MontageSetNextSectionName(string FromSectionName,string ToSectionName) {}
	public  void MontageStop(float OverrideBlendOutTime/*=-1.0f*/) {}
	public UAnimMontage CurrentMontage;
	public  FGameplayAbilityTargetingLocationInfo MakeTargetLocationInfoFromOwnerActor() { return default; }
	public  FGameplayAbilityTargetingLocationInfo MakeTargetLocationInfoFromOwnerSkeletalMeshComponent(string SocketName) { return default; }
	public bool bIsActive;
	public bool bIsAbilityEnding;
	public bool bIsCancelable;
	public bool bIsBlockingOtherAbilities;
	public bool bMarkPendingKillOnAbilityEnd;
}
