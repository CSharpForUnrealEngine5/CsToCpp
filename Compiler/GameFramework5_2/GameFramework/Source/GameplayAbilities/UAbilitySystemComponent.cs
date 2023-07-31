#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The core ActorComponent for interfacing with the GameplayAbilities System</summary>
[CppInclude("AbilitySystemComponent.h")]
public partial class UAbilitySystemComponent : UGameplayTasksComponent {
	///<summary>UGameplayAbility*, Ability,</summary>
	public  void FAbilityAbilityKey(int InputID) {}
	///<summary>Used to register callbacks to confirm/cancel input</summary>
	public  void FAbilityConfirmOrCancel() {}
	///<summary>K2_InitStats</summary>
	public  void K2_InitStats(UClass Attributes,UDataTable DataTable) {}
	///<summary>Returns a list of all attributes for this abilty system component</summary>
	public  void GetAllAttributes(TArray<FGameplayAttribute> OutAttributes) {}
	///<summary>Returns a reference to the Attribute Set instance, if one exists in this component</summary>
	public  UAttributeSet GetAttributeSet(UClass AttributeSetClass) { return default; }
	///<summary>Returns the current value of the given gameplay attribute, or zero if the attribute is not found.</summary>
	public  float GetGameplayAttributeValue(FGameplayAttribute Attribute,bool bFound) { return default; }
	///<summary>DefaultStartingData</summary>
	public TArray<FAttributeDefaults> DefaultStartingData;
	///<summary>The linked Anim Instance that this component will play montages in. Use NAME_None for the main anim instance.</summary>
	public string AffectedAnimInstanceTag;
	///<summary>Applies a previously created gameplay effect spec to a target</summary>
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectSpecToTarget(FGameplayEffectSpecHandle SpecHandle,UAbilitySystemComponent Target) { return default; }
	///<summary>Applies a previously created gameplay effect spec to this component</summary>
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectSpecToSelf(FGameplayEffectSpecHandle SpecHandle) { return default; }
	///<summary>Removes GameplayEffect by Handle. StacksToRemove=-1 will remove all stacks.</summary>
	public  bool RemoveActiveGameplayEffect(FActiveGameplayEffectHandle Handle,int StacksToRemove/*=-1*/) { return default; }
	///<summary>Remove active gameplay effects whose backing definition are the specified gameplay effect class</summary>
	public  void RemoveActiveGameplayEffectBySourceEffect(UClass GameplayEffect,UAbilitySystemComponent InstigatorAbilitySystemComponent,int StacksToRemove/*=-1*/) {}
	///<summary>Get an outgoing GameplayEffectSpec that is ready to be applied to other things.</summary>
	public  FGameplayEffectSpecHandle MakeOutgoingSpec(UClass GameplayEffectClass,float Level,FGameplayEffectContextHandle Context) { return default; }
	///<summary>Create an EffectContext for the owner of this AbilitySystemComponent</summary>
	public  FGameplayEffectContextHandle MakeEffectContext() { return default; }
	///<summary>Get the count of the specified source effect on the ability system component. For non-stacking effects, this is the sum of all active instances.</summary>
	public  int GetGameplayEffectCount(UClass SourceGameplayEffect,UAbilitySystemComponent OptionalInstigatorFilterComponent,bool bEnforceOnGoingCheck/*=true*/) { return default; }
	///<summary>Get the count of the specified source effect on the ability system component. For non-stacking effects, this is the sum of all active instances.</summary>
	public  int GetGameplayEffectCount_IfLoaded(TSoftObjectPtr<UClass> SoftSourceGameplayEffect,UAbilitySystemComponent OptionalInstigatorFilterComponent,bool bEnforceOnGoingCheck/*=true*/) { return default; }
	///<summary>Dynamically update the set-by-caller magnitude for an active gameplay effect</summary>
	public  void UpdateActiveGameplayEffectSetByCallerMagnitude(FActiveGameplayEffectHandle ActiveHandle,FGameplayTag SetByCallerTag,float NewValue) {}
	///<summary>Dynamically update multiple set-by-caller magnitudes for an active gameplay effect</summary>
	public  void UpdateActiveGameplayEffectSetByCallerMagnitudes(FActiveGameplayEffectHandle ActiveHandle,TMap<FGameplayTag,float> NewSetByCallerValues) {}
	///<summary>Updates the level of an already applied gameplay effect. The intention is that this is &#39;seemless&#39; and doesnt behave like removing/reapplying</summary>
	public  void SetActiveGameplayEffectLevel(FActiveGameplayEffectHandle ActiveHandle,int NewLevel) {}
	///<summary>Updates the level of an already applied gameplay effect. The intention is that this is &#39;seemless&#39; and doesnt behave like removing/reapplying</summary>
	public  void SetActiveGameplayEffectLevelUsingQuery(FGameplayEffectQuery Query,int NewLevel) {}
	///<summary>Raw accessor to ask the magnitude of a gameplay effect, not necessarily always correct. How should outside code (UI, etc) ask things like &#39;how much is this gameplay effect modifying my damage by&#39;</summary>
	public  float GetGameplayEffectMagnitude(FActiveGameplayEffectHandle Handle,FGameplayAttribute Attribute) { return default; }
	///<summary>Returns the current count of the given gameplay tag.</summary>
	public  int GetGameplayTagCount(FGameplayTag GameplayTag) { return default; }
	///<summary>Internal Attribute that modifies the duration of gameplay effects created by this component</summary>
	public float OutgoingDuration;
	///<summary>Internal Attribute that modifies the duration of gameplay effects applied to this component</summary>
	public float IncomingDuration;
	///<summary>Apply a gameplay effect to passed in target</summary>
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectToTarget(UClass GameplayEffectClass,UAbilitySystemComponent Target,float Level,FGameplayEffectContextHandle Context) { return default; }
	///<summary>Apply a gameplay effect to self</summary>
	public  FActiveGameplayEffectHandle BP_ApplyGameplayEffectToSelf(UClass GameplayEffectClass,float Level,FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Returns list of active effects, for a query</summary>
	public  TArray<FActiveGameplayEffectHandle> GetActiveEffects(FGameplayEffectQuery Query) { return default; }
	///<summary>Returns list of active effects that have all of the passed in tags</summary>
	public  TArray<FActiveGameplayEffectHandle> GetActiveEffectsWithAllTags(FGameplayTagContainer Tags) { return default; }
	///<summary>Removes all active effects that contain any of the tags in Tags</summary>
	public  int RemoveActiveEffectsWithTags(FGameplayTagContainer Tags) { return default; }
	///<summary>Removes all active effects with captured source tags that contain any of the tags in Tags</summary>
	public  int RemoveActiveEffectsWithSourceTags(FGameplayTagContainer Tags) { return default; }
	///<summary>Removes all active effects that apply any of the tags in Tags</summary>
	public  int RemoveActiveEffectsWithAppliedTags(FGameplayTagContainer Tags) { return default; }
	///<summary>Removes all active effects that grant any of the tags in Tags</summary>
	public  int RemoveActiveEffectsWithGrantedTags(FGameplayTagContainer Tags) { return default; }
	///<summary>Do not call these functions directly, call the wrappers on GameplayCueManager instead</summary>
	public  void NetMulticast_InvokeGameplayCueExecuted_FromSpec(FGameplayEffectSpecForRPC Spec,FPredictionKey PredictionKey) {}
	///<summary>NetMulticast_InvokeGameplayCueExecuted</summary>
	public  void NetMulticast_InvokeGameplayCueExecuted(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayEffectContextHandle EffectContext) {}
	///<summary>NetMulticast_InvokeGameplayCuesExecuted</summary>
	public  void NetMulticast_InvokeGameplayCuesExecuted(FGameplayTagContainer GameplayCueTags,FPredictionKey PredictionKey,FGameplayEffectContextHandle EffectContext) {}
	///<summary>NetMulticast_InvokeGameplayCueExecuted_WithParams</summary>
	public  void NetMulticast_InvokeGameplayCueExecuted_WithParams(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayCueParameters GameplayCueParameters) {}
	///<summary>NetMulticast_InvokeGameplayCuesExecuted_WithParams</summary>
	public  void NetMulticast_InvokeGameplayCuesExecuted_WithParams(FGameplayTagContainer GameplayCueTags,FPredictionKey PredictionKey,FGameplayCueParameters GameplayCueParameters) {}
	///<summary>NetMulticast_InvokeGameplayCueAdded</summary>
	public  void NetMulticast_InvokeGameplayCueAdded(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayEffectContextHandle EffectContext) {}
	///<summary>NetMulticast_InvokeGameplayCueAdded_WithParams</summary>
	public  void NetMulticast_InvokeGameplayCueAdded_WithParams(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayCueParameters Parameters) {}
	///<summary>NetMulticast_InvokeGameplayCueAddedAndWhileActive_FromSpec</summary>
	public  void NetMulticast_InvokeGameplayCueAddedAndWhileActive_FromSpec(FGameplayEffectSpecForRPC Spec,FPredictionKey PredictionKey) {}
	///<summary>NetMulticast_InvokeGameplayCueAddedAndWhileActive_WithParams</summary>
	public  void NetMulticast_InvokeGameplayCueAddedAndWhileActive_WithParams(FGameplayTag GameplayCueTag,FPredictionKey PredictionKey,FGameplayCueParameters GameplayCueParameters) {}
	///<summary>NetMulticast_InvokeGameplayCuesAddedAndWhileActive_WithParams</summary>
	public  void NetMulticast_InvokeGameplayCuesAddedAndWhileActive_WithParams(FGameplayTagContainer GameplayCueTags,FPredictionKey PredictionKey,FGameplayCueParameters GameplayCueParameters) {}
	///<summary>Allows polling to see if a GameplayCue is active. We expect most GameplayCue handling to be event based, but some cases we may need to check if a GamepalyCue is active (Animation Blueprint for example)</summary>
	public  bool IsGameplayCueActive(FGameplayTag GameplayCueTag) { return default; }
	///<summary>Grants a Gameplay Ability and returns its handle.</summary>
	public  FGameplayAbilitySpecHandle K2_GiveAbility(UClass AbilityClass,int Level/*=0*/,int InputID/*=-1*/) { return default; }
	///<summary>Grants a Gameplay Ability, activates it once, and removes it.</summary>
	public  FGameplayAbilitySpecHandle K2_GiveAbilityAndActivateOnce(UClass AbilityClass,int Level/*=0*/,int InputID/*=-1*/) { return default; }
	///<summary>Wipes all &#39;given&#39; abilities. This will be ignored if the actor is not authoritative.</summary>
	public  void ClearAllAbilities() {}
	///<summary>Clears all abilities bound to a given Input ID</summary>
	public  void ClearAllAbilitiesWithInputID(int InputID/*=0*/) {}
	///<summary>Removes the specified ability.</summary>
	public  void ClearAbility(FGameplayAbilitySpecHandle Handle) {}
	///<summary>Attempts to activate every gameplay ability that matches the given tag and DoesAbilitySatisfyTagRequirements().</summary>
	public  bool TryActivateAbilitiesByTag(FGameplayTagContainer GameplayTagContainer,bool bAllowRemoteActivation/*=true*/) { return default; }
	///<summary>Attempts to activate the ability that is passed in. This will check costs and requirements before doing so.</summary>
	public  bool TryActivateAbilityByClass(UClass InAbilityToActivate,bool bAllowRemoteActivation/*=true*/) { return default; }
	///<summary>Attempts to activate the given ability, will check costs and requirements before doing so.</summary>
	public  bool TryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate,bool bAllowRemoteActivation/*=true*/) { return default; }
	///<summary>Returns an array with all granted ability handles</summary>
	public  void GetAllAbilities(TArray<FGameplayAbilitySpecHandle> OutAbilityHandles) {}
	///<summary>Returns an array with all abilities that match the provided tags</summary>
	public  void FindAllAbilitiesWithTags(TArray<FGameplayAbilitySpecHandle> OutAbilityHandles,FGameplayTagContainer Tags,bool bExactMatch/*=true*/) {}
	///<summary>Returns an array with all abilities that match the provided Gameplay Tag Query</summary>
	public  void FindAllAbilitiesMatchingQuery(TArray<FGameplayAbilitySpecHandle> OutAbilityHandles,FGameplayTagQuery Query) {}
	///<summary>Returns an array with all abilities bound to an Input ID value</summary>
	public  void FindAllAbilitiesWithInputID(TArray<FGameplayAbilitySpecHandle> OutAbilityHandles,int InputID/*=0*/) {}
	///<summary>Ask the server to send ability system debug information back to the client, via ClientPrintDebug_Response</summary>
	public  void ServerPrintDebug_Request() {}
	///<summary>Same as ServerPrintDebug_Request but this includes the client debug strings so that the server can embed them in replays</summary>
	public  void ServerPrintDebug_RequestWithStrings(TArray<string> Strings) {}
	///<summary>ClientPrintDebug_Response</summary>
	public  void ClientPrintDebug_Response(TArray<string> Strings,int GameFlags) {}
	///<summary>ClientDebugStrings</summary>
	public TArray<string> ClientDebugStrings;
	///<summary>ServerDebugStrings</summary>
	public TArray<string> ServerDebugStrings;
	///<summary>OnRep_ClientDebugString</summary>
	public  void OnRep_ClientDebugString() {}
	///<summary>OnRep_ServerDebugString</summary>
	public  void OnRep_ServerDebugString() {}
	///<summary>ServerAbilityRPCBatch</summary>
	public  void ServerAbilityRPCBatch(FServerAbilityRPCBatch BatchInfo) {}
	///<summary>This is meant to be used to inhibit activating an ability from an input perspective. (E.g., the menu is pulled up, another game mechanism is consuming all input, etc)</summary>
	public  bool GetUserAbilityActivationInhibited() { return default; }
	///<summary>Disable or Enable a local user from being able to activate abilities. This should only be used for input/UI etc related inhibition. Do not use for game mechanics.</summary>
	public  void SetUserAbilityActivationInhibited(bool NewInhibit) {}
	///<summary>Rather activation is currently inhibited</summary>
	public bool UserAbilityActivationInhibited;
	///<summary>When enabled GameplayCue RPCs will be routed through the AvatarActor&#39;s IAbilitySystemReplicationProxyInterface rather than this component</summary>
	public bool ReplicationProxyEnabled;
	///<summary>Suppress all ability granting through GEs on this component</summary>
	public bool bSuppressGrantAbility;
	///<summary>Suppress all GameplayCues on this component</summary>
	public bool bSuppressGameplayCues;
	///<summary>List of currently active targeting actors</summary>
	public TArray<AGameplayAbilityTargetActor> SpawnedTargetActors;
	///<summary>* Sends a local player Input Pressed event with the provided Input ID, notifying any bound abilities</summary>
	public  void PressInputID(int InputID) {}
	///<summary>Sends a local player Input Released event with the provided Input ID, notifying any bound abilities</summary>
	public  void ReleaseInputID(int InputID) {}
	///<summary>Sends a local player Input Confirm event, notifying abilities</summary>
	public  void InputConfirm() {}
	///<summary>Sends a local player Input Cancel event, notifying abilities</summary>
	public  void InputCancel() {}
	///<summary>Any active targeting actors will be told to stop and return current targeting data</summary>
	public  void TargetConfirm() {}
	///<summary>Any active targeting actors will be stopped and canceled, not returning any targeting data</summary>
	public  void TargetCancel() {}
	///<summary>The actor that owns this component logically</summary>
	public AActor OwnerActor;
	///<summary>The actor that is the physical representation used for abilities. Can be NULL</summary>
	public AActor AvatarActor;
	///<summary>OnRep_OwningActor</summary>
	public  void OnRep_OwningActor() {}
	///<summary>OnAvatarActorDestroyed</summary>
	public  void OnAvatarActorDestroyed(AActor InActor) {}
	///<summary>OnOwnerActorDestroyed</summary>
	public  void OnOwnerActorDestroyed(AActor InActor) {}
	///<summary>OnSpawnedAttributesEndPlayed</summary>
	public  void OnSpawnedAttributesEndPlayed(AActor InActor,EEndPlayReason EndPlayReason) {}
	///<summary>Replicates the Generic Replicated Event to the server.</summary>
	public  void ServerSetReplicatedEvent(EAbilityGenericReplicatedEvent EventType,FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey,FPredictionKey CurrentPredictionKey) {}
	///<summary>Replicates the Generic Replicated Event to the server with payload.</summary>
	public  void ServerSetReplicatedEventWithPayload(EAbilityGenericReplicatedEvent EventType,FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey,FPredictionKey CurrentPredictionKey,FVector_NetQuantize100 VectorPayload) {}
	///<summary>Replicates the Generic Replicated Event to the client.</summary>
	public  void ClientSetReplicatedEvent(EAbilityGenericReplicatedEvent EventType,FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey) {}
	///<summary>Replicates targeting data to the server</summary>
	public  void ServerSetReplicatedTargetData(FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey,FGameplayAbilityTargetDataHandle ReplicatedTargetDataHandle,FGameplayTag ApplicationTag,FPredictionKey CurrentPredictionKey) {}
	///<summary>Replicates to the server that targeting has been cancelled</summary>
	public  void ServerSetReplicatedTargetDataCancelled(FGameplayAbilitySpecHandle AbilityHandle,FPredictionKey AbilityOriginalPredictionKey,FPredictionKey CurrentPredictionKey) {}
	///<summary>Direct Input state replication. These will be called if bReplicateInputDirectly is true on the ability and is generally not a good thing to use. (Instead, prefer to use Generic Replicated Events).</summary>
	public  void ServerSetInputPressed(FGameplayAbilitySpecHandle AbilityHandle) {}
	///<summary>ServerSetInputReleased</summary>
	public  void ServerSetInputReleased(FGameplayAbilitySpecHandle AbilityHandle) {}
	///<summary>The abilities we can activate.</summary>
	public FGameplayAbilitySpecContainer ActivatableAbilities;
	///<summary>AllReplicatedInstancedAbilities</summary>
	public TArray<UGameplayAbility> AllReplicatedInstancedAbilities;
	///<summary>OnRep_ActivateAbilities</summary>
	public  void OnRep_ActivateAbilities() {}
	///<summary>ServerTryActivateAbility</summary>
	public  void ServerTryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate,bool InputPressed,FPredictionKey PredictionKey) {}
	///<summary>ServerTryActivateAbilityWithEventData</summary>
	public  void ServerTryActivateAbilityWithEventData(FGameplayAbilitySpecHandle AbilityToActivate,bool InputPressed,FPredictionKey PredictionKey,FGameplayEventData TriggerEventData) {}
	///<summary>ClientTryActivateAbility</summary>
	public  void ClientTryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate) {}
	///<summary>ServerEndAbility</summary>
	public  void ServerEndAbility(FGameplayAbilitySpecHandle AbilityToEnd,FGameplayAbilityActivationInfo ActivationInfo,FPredictionKey PredictionKey) {}
	///<summary>ClientEndAbility</summary>
	public  void ClientEndAbility(FGameplayAbilitySpecHandle AbilityToEnd,FGameplayAbilityActivationInfo ActivationInfo) {}
	///<summary>ServerCancelAbility</summary>
	public  void ServerCancelAbility(FGameplayAbilitySpecHandle AbilityToCancel,FGameplayAbilityActivationInfo ActivationInfo) {}
	///<summary>ClientCancelAbility</summary>
	public  void ClientCancelAbility(FGameplayAbilitySpecHandle AbilityToCancel,FGameplayAbilityActivationInfo ActivationInfo) {}
	///<summary>ClientActivateAbilityFailed</summary>
	public  void ClientActivateAbilityFailed(FGameplayAbilitySpecHandle AbilityToActivate,short PredictionKey) {}
	///<summary>ClientActivateAbilitySucceed</summary>
	public  void ClientActivateAbilitySucceed(FGameplayAbilitySpecHandle AbilityToActivate,FPredictionKey PredictionKey) {}
	///<summary>ClientActivateAbilitySucceedWithEventData</summary>
	public  void ClientActivateAbilitySucceedWithEventData(FGameplayAbilitySpecHandle AbilityToActivate,FPredictionKey PredictionKey,FGameplayEventData TriggerEventData) {}
	///<summary>Data structure for replicating montage info to simulated clients</summary>
	public FGameplayAbilityRepAnimMontage RepAnimMontageInfo;
	///<summary>Cached value of rather this is a simulated actor</summary>
	public bool bCachedIsNetSimulated;
	///<summary>Set if montage rep happens while we don&#39;t have the animinstance associated with us yet</summary>
	public bool bPendingMontageRep;
	///<summary>Data structure for montages that were instigated locally (everything if server, predictive if client. replicated if simulated proxy)</summary>
	public FGameplayAbilityLocalAnimMontage LocalAnimMontageInfo;
	///<summary>OnRep_ReplicatedAnimMontage</summary>
	public  void OnRep_ReplicatedAnimMontage() {}
	///<summary>RPC function called from CurrentMontageSetNextSectopnName, replicates to other clients</summary>
	public  void ServerCurrentMontageSetNextSectionName(UAnimMontage ClientAnimMontage,float ClientPosition,string SectionName,string NextSectionName) {}
	///<summary>RPC function called from CurrentMontageJumpToSection, replicates to other clients</summary>
	public  void ServerCurrentMontageJumpToSectionName(UAnimMontage ClientAnimMontage,string SectionName) {}
	///<summary>RPC function called from CurrentMontageSetPlayRate, replicates to other clients</summary>
	public  void ServerCurrentMontageSetPlayRate(UAnimMontage ClientAnimMontage,float InPlayRate) {}
	///<summary>Contains all of the gameplay effects that are currently active on this component</summary>
	public FActiveGameplayEffectsContainer ActiveGameplayEffects;
	///<summary>List of all active gameplay cues, including ones applied manually</summary>
	public FActiveGameplayCueContainer ActiveGameplayCues;
	///<summary>Replicated gameplaycues when in minimal replication mode. These are cues that would come normally come from ActiveGameplayEffects</summary>
	public FActiveGameplayCueContainer MinimalReplicationGameplayCues;
	///<summary>Tracks abilities that are blocked based on input binding. An ability is blocked if BlockedAbilityBindings[InputID] &gt; 0</summary>
	public TArray<byte> BlockedAbilityBindings;
	///<summary>MinimalReplicationTags</summary>
	public FMinimalReplicationTagCountMap MinimalReplicationTags;
	///<summary>List of attribute sets</summary>
	public TArray<UAttributeSet> SpawnedAttributes;
	///<summary>OnRep_SpawnedAttributes</summary>
	public  void OnRep_SpawnedAttributes(TArray<UAttributeSet> PreviousSpawnedAttributes) {}
	///<summary>Container used for replicating loose gameplay tags</summary>
	public FMinimalReplicationTagCountMap ReplicatedLooseTags;
	///<summary>PredictionKeys, see more info in GameplayPrediction.h. This has to come *last* in all replicated properties on the AbilitySystemComponent to ensure OnRep/callback order.</summary>
	public FReplicatedPredictionKeyMap ReplicatedPredictionKeyMap;
}
