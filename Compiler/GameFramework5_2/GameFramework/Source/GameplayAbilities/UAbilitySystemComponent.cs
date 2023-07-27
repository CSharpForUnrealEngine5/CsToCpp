#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilitySystemComponent.h")]
///<summary>The core ActorComponent for interfacing with the GameplayAbilities System</summary>
public partial class UAbilitySystemComponent : UGameplayTasksComponent {
// AbilitySystemComponent
	public  void FAbilityAbilityKey(int InputID) {}
	public  void FAbilityConfirmOrCancel() {}
	public  void K2_InitStats(UClass Attributes,UDataTable DataTable) {}
	public  void GetAllAttributes(TArray<FGameplayAttribute> OutAttributes) {}
	public  UAttributeSet GetAttributeSet(UClass AttributeSetClass) { return default; }
	public  float GetGameplayAttributeValue(FGameplayAttribute Attribute,bool bFound) { return default; }
	public TArray<FAttributeDefaults> DefaultStartingData;
	public string AffectedAnimInstanceTag;
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectSpecToTarget(FGameplayEffectSpecHandle SpecHandle,UAbilitySystemComponent Target) { return default; }
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectSpecToSelf(FGameplayEffectSpecHandle SpecHandle) { return default; }
	public  bool RemoveActiveGameplayEffect(FActiveGameplayEffectHandle Handle,int StacksToRemove/*=-1*/) { return default; }
	public  void RemoveActiveGameplayEffectBySourceEffect(UClass GameplayEffect,UAbilitySystemComponent InstigatorAbilitySystemComponent,int StacksToRemove/*=-1*/) {}
	public  FGameplayEffectSpecHandle MakeOutgoingSpec(UClass GameplayEffectClass,float Level,FGameplayEffectContextHandle Context) { return default; }
	public  FGameplayEffectContextHandle MakeEffectContext() { return default; }
	public  int GetGameplayEffectCount(UClass SourceGameplayEffect,UAbilitySystemComponent OptionalInstigatorFilterComponent,bool bEnforceOnGoingCheck/*=true*/) { return default; }
	public  int GetGameplayEffectCount_IfLoaded(TSoftObjectPtr<UClass> SoftSourceGameplayEffect,UAbilitySystemComponent OptionalInstigatorFilterComponent,bool bEnforceOnGoingCheck/*=true*/) { return default; }
	public  void UpdateActiveGameplayEffectSetByCallerMagnitude(FActiveGameplayEffectHandle ActiveHandle,FGameplayTag SetByCallerTag,float NewValue) {}
	public  void UpdateActiveGameplayEffectSetByCallerMagnitudes(FActiveGameplayEffectHandle ActiveHandle,TMap<FGameplayTag,float> NewSetByCallerValues) {}
	public  void SetActiveGameplayEffectLevel(FActiveGameplayEffectHandle ActiveHandle,int NewLevel) {}
	public  void SetActiveGameplayEffectLevelUsingQuery(FGameplayEffectQuery Query,int NewLevel) {}
	public  float GetGameplayEffectMagnitude(FActiveGameplayEffectHandle Handle,FGameplayAttribute Attribute) { return default; }
	public  int GetGameplayTagCount(FGameplayTag GameplayTag) { return default; }
	public float OutgoingDuration;
	public float IncomingDuration;
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectToTarget(UClass GameplayEffectClass,UAbilitySystemComponent Target,float Level,FGameplayEffectContextHandle Context) { return default; }
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectToSelf(UClass GameplayEffectClass,float Level,FGameplayEffectContextHandle EffectContext) { return default; }
	public  TArray<FActiveGameplayEffectHandle> GetActiveEffects(FGameplayEffectQuery Query) { return default; }
	public  TArray<FActiveGameplayEffectHandle> GetActiveEffectsWithAllTags(FGameplayTagContainer Tags) { return default; }
	public  int RemoveActiveEffectsWithTags(FGameplayTagContainer Tags) { return default; }
	public  int RemoveActiveEffectsWithSourceTags(FGameplayTagContainer Tags) { return default; }
	public  int RemoveActiveEffectsWithAppliedTags(FGameplayTagContainer Tags) { return default; }
	public  int RemoveActiveEffectsWithGrantedTags(FGameplayTagContainer Tags) { return default; }
	public  void NetMulticast_InvokeGameplayCueExecuted_FromSpec(FGameplayEffectSpecForRPC Spec,FPredictionKey PredictionKey) {}
	public  void NetMulticast_InvokeGameplayCueExecuted(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayEffectContextHandle EffectContext) {}
	public  void NetMulticast_InvokeGameplayCuesExecuted(FGameplayTagContainer GameplayCueTags,FPredictionKey PredictionKey,FGameplayEffectContextHandle EffectContext) {}
	public  void NetMulticast_InvokeGameplayCueExecuted_WithParams(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayCueParameters GameplayCueParameters) {}
	public  void NetMulticast_InvokeGameplayCuesExecuted_WithParams(FGameplayTagContainer GameplayCueTags,FPredictionKey PredictionKey,FGameplayCueParameters GameplayCueParameters) {}
	public  void NetMulticast_InvokeGameplayCueAdded(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayEffectContextHandle EffectContext) {}
	public  void NetMulticast_InvokeGameplayCueAdded_WithParams(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayCueParameters Parameters) {}
	public  void NetMulticast_InvokeGameplayCueAddedAndWhileActive_FromSpec(FGameplayEffectSpecForRPC Spec,FPredictionKey PredictionKey) {}
	public  void NetMulticast_InvokeGameplayCueAddedAndWhileActive_WithParams(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayCueParameters GameplayCueParameters) {}
	public  void NetMulticast_InvokeGameplayCuesAddedAndWhileActive_WithParams(FGameplayTagContainer GameplayCueTags,FPredictionKey PredictionKey,FGameplayCueParameters GameplayCueParameters) {}
	public  bool IsGameplayCueActive(FGameplayTag GameplayCueTag) { return default; }
	public  FGameplayAbilitySpecHandle K2_GiveAbility(UClass AbilityClass,int Level/*=0*/,int InputID/*=-1*/) { return default; }
	public  FGameplayAbilitySpecHandle K2_GiveAbilityAndActivateOnce(UClass AbilityClass,int Level/*=0*/,int InputID/*=-1*/) { return default; }
	public  void ClearAllAbilities() {}
	public  void ClearAllAbilitiesWithInputID(int InputID/*=0*/) {}
	public  void ClearAbility(FGameplayAbilitySpecHandle Handle) {}
	public  bool TryActivateAbilitiesByTag(FGameplayTagContainer GameplayTagContainer,bool bAllowRemoteActivation/*=true*/) { return default; }
	public  bool TryActivateAbilityByClass(UClass InAbilityToActivate,bool bAllowRemoteActivation/*=true*/) { return default; }
	public  bool TryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate,bool bAllowRemoteActivation/*=true*/) { return default; }
	public  void GetAllAbilities(TArray<FGameplayAbilitySpecHandle> OutAbilityHandles) {}
	public  void FindAllAbilitiesWithTags(TArray<FGameplayAbilitySpecHandle> OutAbilityHandles,FGameplayTagContainer Tags,bool bExactMatch/*=true*/) {}
	public  void FindAllAbilitiesMatchingQuery(TArray<FGameplayAbilitySpecHandle> OutAbilityHandles,FGameplayTagQuery Query) {}
	public  void FindAllAbilitiesWithInputID(TArray<FGameplayAbilitySpecHandle> OutAbilityHandles,int InputID/*=0*/) {}
	public  void ServerPrintDebug_Request() {}
	public  void ServerPrintDebug_RequestWithStrings(TArray<string> Strings) {}
	public  void ClientPrintDebug_Response(TArray<string> Strings,int GameFlags) {}
	public TArray<string> ClientDebugStrings;
	public TArray<string> ServerDebugStrings;
	public  void OnRep_ClientDebugString() {}
	public  void OnRep_ServerDebugString() {}
	public  void ServerAbilityRPCBatch(FServerAbilityRPCBatch BatchInfo) {}
	public  bool GetUserAbilityActivationInhibited() { return default; }
	public  void SetUserAbilityActivationInhibited(bool NewInhibit) {}
	public bool UserAbilityActivationInhibited;
	public bool ReplicationProxyEnabled;
	public bool bSuppressGrantAbility;
	public bool bSuppressGameplayCues;
	public TArray<AGameplayAbilityTargetActor> SpawnedTargetActors;
	public  void PressInputID(int InputID) {}
	public  void ReleaseInputID(int InputID) {}
	public  void InputConfirm() {}
	public  void InputCancel() {}
	public  void TargetConfirm() {}
	public  void TargetCancel() {}
	public AActor OwnerActor;
	public AActor AvatarActor;
	public  void OnRep_OwningActor() {}
	public  void OnAvatarActorDestroyed(AActor InActor) {}
	public  void OnOwnerActorDestroyed(AActor InActor) {}
	public  void OnSpawnedAttributesEndPlayed(AActor InActor,EEndPlayReason EndPlayReason) {}
	public  void ServerSetReplicatedEvent(EAbilityGenericReplicatedEvent EventType,FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey,FPredictionKey CurrentPredictionKey) {}
	public  void ServerSetReplicatedEventWithPayload(EAbilityGenericReplicatedEvent EventType,FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey,FPredictionKey CurrentPredictionKey,FVector_NetQuantize100 VectorPayload) {}
	public  void ClientSetReplicatedEvent(EAbilityGenericReplicatedEvent EventType,FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey) {}
	public  void ServerSetReplicatedTargetData(FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey,FGameplayAbilityTargetDataHandle ReplicatedTargetDataHandle,FGameplayTag ApplicationTag,FPredictionKey CurrentPredictionKey) {}
	public  void ServerSetReplicatedTargetDataCancelled(FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey,FPredictionKey CurrentPredictionKey) {}
	public  void ServerSetInputPressed(FGameplayAbilitySpecHandle AbilityHandle) {}
	public  void ServerSetInputReleased(FGameplayAbilitySpecHandle AbilityHandle) {}
	public FGameplayAbilitySpecContainer ActivatableAbilities;
	public TArray<UGameplayAbility> AllReplicatedInstancedAbilities;
	public  void OnRep_ActivateAbilities() {}
	public  void ServerTryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate,bool InputPressed,FPredictionKey PredictionKey) {}
	public  void ServerTryActivateAbilityWithEventData(FGameplayAbilitySpecHandle AbilityToActivate,bool InputPressed,FPredictionKey PredictionKey,FGameplayEventData TriggerEventData) {}
	public  void ClientTryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate) {}
	public  void ServerEndAbility(FGameplayAbilitySpecHandle AbilityToEnd,FGameplayAbilityActivationInfo ActivationInfo,FPredictionKey PredictionKey) {}
	public  void ClientEndAbility(FGameplayAbilitySpecHandle AbilityToEnd,FGameplayAbilityActivationInfo ActivationInfo) {}
	public  void ServerCancelAbility(FGameplayAbilitySpecHandle AbilityToCancel,FGameplayAbilityActivationInfo ActivationInfo) {}
	public  void ClientCancelAbility(FGameplayAbilitySpecHandle AbilityToCancel,FGameplayAbilityActivationInfo ActivationInfo) {}
	public  void ClientActivateAbilityFailed(FGameplayAbilitySpecHandle AbilityToActivate,short PredictionKey) {}
	public  void ClientActivateAbilitySucceed(FGameplayAbilitySpecHandle AbilityToActivate,FPredictionKey PredictionKey) {}
	public  void ClientActivateAbilitySucceedWithEventData(FGameplayAbilitySpecHandle AbilityToActivate,FPredictionKey PredictionKey,FGameplayEventData TriggerEventData) {}
	public FGameplayAbilityRepAnimMontage RepAnimMontageInfo;
	public bool bCachedIsNetSimulated;
	public bool bPendingMontageRep;
	public FGameplayAbilityLocalAnimMontage LocalAnimMontageInfo;
	public  void OnRep_ReplicatedAnimMontage() {}
	public  void ServerCurrentMontageSetNextSectionName(UAnimMontage ClientAnimMontage,float ClientPosition,string SectionName,string NextSectionName) {}
	public  void ServerCurrentMontageJumpToSectionName(UAnimMontage ClientAnimMontage,string SectionName) {}
	public  void ServerCurrentMontageSetPlayRate(UAnimMontage ClientAnimMontage,float InPlayRate) {}
	public FActiveGameplayEffectsContainer ActiveGameplayEffects;
	public FActiveGameplayCueContainer ActiveGameplayCues;
	public FActiveGameplayCueContainer MinimalReplicationGameplayCues;
	public TArray<byte> BlockedAbilityBindings;
	public FMinimalReplicationTagCountMap MinimalReplicationTags;
	public TArray<UAttributeSet> SpawnedAttributes;
	public  void OnRep_SpawnedAttributes(TArray<UAttributeSet> PreviousSpawnedAttributes) {}
	public FMinimalReplicationTagCountMap ReplicatedLooseTags;
	public FReplicatedPredictionKeyMap ReplicatedPredictionKeyMap;
}
