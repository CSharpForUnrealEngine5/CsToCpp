#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint library for ability system. Many of these functions are useful to call from native as well</summary>
[CppInclude("AbilitySystemBlueprintLibrary.h")]
public partial class UAbilitySystemBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Tries to find an ability system component on the actor, will use AbilitySystemInterface or fall back to a component search</summary>
	public static UAbilitySystemComponent GetAbilitySystemComponent(AActor Actor) { return default; }
	///<summary>This function can be used to trigger an ability on the actor in question with useful payload data.</summary>
	public static void SendGameplayEventToActor(AActor Actor,FGameplayTag EventTag,FGameplayEventData Payload) {}
	///<summary>Returns true if the attribute actually exists</summary>
	public static bool IsValid(FGameplayAttribute Attribute) { return default; }
	///<summary>Returns the value of Attribute from the ability system component belonging to Actor.</summary>
	public static float GetFloatAttribute(AActor Actor,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	///<summary>Returns the value of Attribute from the ability system component AbilitySystem.</summary>
	public static float GetFloatAttributeFromAbilitySystemComponent(UAbilitySystemComponent AbilitySystem,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	///<summary>Returns the base value of Attribute from the ability system component belonging to Actor.</summary>
	public static float GetFloatAttributeBase(AActor Actor,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	///<summary>Returns the base value of Attribute from the ability system component AbilitySystemComponent.</summary>
	public static float GetFloatAttributeBaseFromAbilitySystemComponent(UAbilitySystemComponent AbilitySystemComponent,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	///<summary>Returns the value of Attribute from the ability system component AbilitySystem after evaluating it with source and target tags. bSuccess indicates the success or failure of this operation.</summary>
	public static float EvaluateAttributeValueWithTags(UAbilitySystemComponent AbilitySystem,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,bool bSuccess) { return default; }
	///<summary>Returns the value of Attribute from the ability system component AbilitySystem after evaluating it with source and target tags using the passed in base value instead of the real base value. bSuccess indicates the success or failure of this operation.</summary>
	public static float EvaluateAttributeValueWithTagsAndBase(UAbilitySystemComponent AbilitySystem,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,float BaseValue,bool bSuccess) { return default; }
	///<summary>Simple equality operator for gameplay attributes</summary>
	public static bool EqualEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA,FGameplayAttribute AttributeB) { return default; }
	///<summary>Simple inequality operator for gameplay attributes</summary>
	public static bool NotEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA,FGameplayAttribute AttributeB) { return default; }
	///<summary>Returns FString representation of a gameplay attribute&#39;s set class and name, in the form of AttrSetName.AttrName (or just AttrName if not part of a set).</summary>
	public static string GetDebugStringFromGameplayAttribute(FGameplayAttribute Attribute) { return default; }
	///<summary>Copies targets from HandleToAdd to TargetHandle</summary>
	public static FGameplayAbilityTargetDataHandle AppendTargetDataHandle(FGameplayAbilityTargetDataHandle TargetHandle,FGameplayAbilityTargetDataHandle HandleToAdd) { return default; }
	///<summary>Creates a target data with a source and destination location</summary>
	public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromLocations(FGameplayAbilityTargetingLocationInfo SourceLocation,FGameplayAbilityTargetingLocationInfo TargetLocation) { return default; }
	///<summary>Creates a target data with a single hit result</summary>
	public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromHitResult(FHitResult HitResult) { return default; }
	///<summary>Returns number of target data objects, not necessarily number of distinct targets</summary>
	public static int GetDataCountFromTargetData(FGameplayAbilityTargetDataHandle TargetData) { return default; }
	///<summary>Creates single actor target data</summary>
	public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromActor(AActor Actor) { return default; }
	///<summary>Creates actor array target data</summary>
	public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromActorArray(TArray<AActor> ActorArray,bool OneTargetPerHandle) { return default; }
	///<summary>Create a new target data handle with filtration performed on the data</summary>
	public static FGameplayAbilityTargetDataHandle FilterTargetData(FGameplayAbilityTargetDataHandle TargetDataHandle,FGameplayTargetDataFilterHandle ActorFilterClass) { return default; }
	///<summary>Create a handle for filtering target data, filling out all fields</summary>
	public static FGameplayTargetDataFilterHandle MakeFilterHandle(FGameplayTargetDataFilter Filter,AActor FilterActor) { return default; }
	///<summary>Create a spec handle, filling out all fields</summary>
	public static FGameplayEffectSpecHandle MakeSpecHandle(UGameplayEffect InGameplayEffect,AActor InInstigator,AActor InEffectCauser,float InLevel/*=1.0f*/) { return default; }
	///<summary>Create a spec handle, cloning another</summary>
	public static FGameplayEffectSpecHandle CloneSpecHandle(AActor InNewInstigator,AActor InEffectCauser,FGameplayEffectSpecHandle GameplayEffectSpecHandle_Clone) { return default; }
	///<summary>Returns all actors targeted, for a given index</summary>
	public static TArray<AActor> GetActorsFromTargetData(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	///<summary>Returns all actors targeted</summary>
	public static TArray<AActor> GetAllActorsFromTargetData(FGameplayAbilityTargetDataHandle TargetData) { return default; }
	///<summary>Returns true if the given TargetData has the actor passed in targeted</summary>
	public static bool DoesTargetDataContainActor(FGameplayAbilityTargetDataHandle TargetData,int Index,AActor Actor) { return default; }
	///<summary>Returns true if the given TargetData has at least 1 actor targeted</summary>
	public static bool TargetDataHasActor(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	///<summary>Returns true if the target data has a hit result</summary>
	public static bool TargetDataHasHitResult(FGameplayAbilityTargetDataHandle HitResult,int Index) { return default; }
	///<summary>Returns the hit result for a given index if it exists</summary>
	public static FHitResult GetHitResultFromTargetData(FGameplayAbilityTargetDataHandle HitResult,int Index) { return default; }
	///<summary>Returns true if the target data has an origin</summary>
	public static bool TargetDataHasOrigin(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	///<summary>Returns the origin for a given index if it exists</summary>
	public static FTransform GetTargetDataOrigin(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	///<summary>Returns true if the target data has an end point</summary>
	public static bool TargetDataHasEndPoint(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	///<summary>Returns the end point for a given index if it exists</summary>
	public static FVector GetTargetDataEndPoint(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	///<summary>Returns the end point transform for a given index if it exists</summary>
	public static FTransform GetTargetDataEndPointTransform(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	///<summary>Returns true if this context has ever been initialized</summary>
	public static bool EffectContextIsValid(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Returns true if the ability system component that instigated this is locally controlled</summary>
	public static bool EffectContextIsInstigatorLocallyControlled(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Extracts a hit result from the effect context if it is set</summary>
	public static FHitResult EffectContextGetHitResult(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Returns true if there is a valid hit result inside the effect context</summary>
	public static bool EffectContextHasHitResult(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Adds a hit result to the effect context</summary>
	public static void EffectContextAddHitResult(FGameplayEffectContextHandle EffectContext,FHitResult HitResult,bool bReset) {}
	///<summary>Gets the location the effect originated from</summary>
	public static FVector EffectContextGetOrigin(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Sets the location the effect originated from</summary>
	public static void EffectContextSetOrigin(FGameplayEffectContextHandle EffectContext,FVector Origin) {}
	///<summary>Gets the instigating actor (that holds the ability system component) of the EffectContext</summary>
	public static AActor EffectContextGetInstigatorActor(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Gets the original instigator actor that started the chain of events to cause this effect</summary>
	public static AActor EffectContextGetOriginalInstigatorActor(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Gets the physical actor that caused the effect, possibly a projectile or weapon</summary>
	public static AActor EffectContextGetEffectCauser(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Gets the source object of the effect.</summary>
	public static UObject EffectContextGetSourceObject(FGameplayEffectContextHandle EffectContext) { return default; }
	///<summary>Returns true if the ability system component that spawned this cue is locally controlled</summary>
	public static bool IsInstigatorLocallyControlled(FGameplayCueParameters Parameters) { return default; }
	///<summary>Returns true if the ability system component that spawned this cue is locally controlled and a player</summary>
	public static bool IsInstigatorLocallyControlledPlayer(FGameplayCueParameters Parameters) { return default; }
	///<summary>Returns number of actors stored in the Effect Context used by this cue</summary>
	public static int GetActorCount(FGameplayCueParameters Parameters) { return default; }
	///<summary>Returns actor stored in the Effect Context used by this cue</summary>
	public static AActor GetActorByIndex(FGameplayCueParameters Parameters,int Index) { return default; }
	///<summary>Returns a hit result stored in the effect context if valid</summary>
	public static FHitResult GetHitResult(FGameplayCueParameters Parameters) { return default; }
	///<summary>Checks if the effect context has a hit reslt stored inside</summary>
	public static bool HasHitResult(FGameplayCueParameters Parameters) { return default; }
	///<summary>Forwards the gameplay cue to another gameplay cue interface object</summary>
	public static void ForwardGameplayCueToTarget(object /*TargetCueInterface*/ TargetCueInterface,EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	///<summary>Gets the instigating actor (that holds the ability system component) of the GameplayCue</summary>
	public static AActor GetInstigatorActor(FGameplayCueParameters Parameters) { return default; }
	///<summary>Gets instigating world location</summary>
	public static FTransform GetInstigatorTransform(FGameplayCueParameters Parameters) { return default; }
	///<summary>Gets instigating world location</summary>
	public static FVector GetOrigin(FGameplayCueParameters Parameters) { return default; }
	///<summary>Gets the best end location and normal for this gameplay cue. If there is hit result data, it will return this. Otherwise it will return the target actor&#39;s location/rotation. If none of this is available, it will return false.</summary>
	public static bool GetGameplayCueEndLocationAndNormal(AActor TargetActor,FGameplayCueParameters Parameters,FVector Location,FVector Normal) { return default; }
	///<summary>Gets the best normalized effect direction for this gameplay cue. This is useful for effects that require the direction of an enemy attack. Returns true if a valid direction could be calculated.</summary>
	public static bool GetGameplayCueDirection(AActor TargetActor,FGameplayCueParameters Parameters,FVector Direction) { return default; }
	///<summary>Returns true if the aggregated source and target tags from the effect spec meets the tag requirements</summary>
	public static bool DoesGameplayCueMeetTagRequirements(FGameplayCueParameters Parameters,FGameplayTagRequirements SourceTagReqs,FGameplayTagRequirements TargetTagReqs) { return default; }
	///<summary>Native make, to avoid having to deal with quantized vector types</summary>
	public static FGameplayCueParameters MakeGameplayCueParameters(float NormalizedMagnitude,float RawMagnitude,FGameplayEffectContextHandle EffectContext,FGameplayTag MatchedTagName,FGameplayTag OriginalTag,FGameplayTagContainer AggregatedSourceTags,FGameplayTagContainer AggregatedTargetTags,FVector Location,FVector Normal,AActor Instigator,AActor EffectCauser,UObject SourceObject,UPhysicalMaterial PhysicalMaterial,int GameplayEffectLevel,int AbilityLevel,USceneComponent TargetAttachComponent,bool bReplicateLocationWhenUsingMinimalRepProxy) { return default; }
	///<summary>Native break, to avoid having to deal with quantized vector types</summary>
	public static void BreakGameplayCueParameters(FGameplayCueParameters Parameters,float NormalizedMagnitude,float RawMagnitude,FGameplayEffectContextHandle EffectContext,FGameplayTag MatchedTagName,FGameplayTag OriginalTag,FGameplayTagContainer AggregatedSourceTags,FGameplayTagContainer AggregatedTargetTags,FVector Location,FVector Normal,AActor Instigator,AActor EffectCauser,UObject SourceObject,UPhysicalMaterial PhysicalMaterial,int GameplayEffectLevel,int AbilityLevel,USceneComponent TargetAttachComponent,bool bReplicateLocationWhenUsingMinimalRepProxy) {}
	///<summary>Sets a raw name Set By Caller magnitude value, the tag version should normally be used</summary>
	public static FGameplayEffectSpecHandle AssignSetByCallerMagnitude(FGameplayEffectSpecHandle SpecHandle,string DataName,float Magnitude) { return default; }
	///<summary>Sets a gameplay tag Set By Caller magnitude value</summary>
	public static FGameplayEffectSpecHandle AssignTagSetByCallerMagnitude(FGameplayEffectSpecHandle SpecHandle,FGameplayTag DataTag,float Magnitude) { return default; }
	///<summary>Manually sets the duration on a specific effect</summary>
	public static FGameplayEffectSpecHandle SetDuration(FGameplayEffectSpecHandle SpecHandle,float Duration) { return default; }
	///<summary>This instance of the effect will now grant NewGameplayTag to the object that this effect is applied to</summary>
	public static FGameplayEffectSpecHandle AddGrantedTag(FGameplayEffectSpecHandle SpecHandle,FGameplayTag NewGameplayTag) { return default; }
	///<summary>This instance of the effect will now grant NewGameplayTags to the object that this effect is applied to</summary>
	public static FGameplayEffectSpecHandle AddGrantedTags(FGameplayEffectSpecHandle SpecHandle,FGameplayTagContainer NewGameplayTags) { return default; }
	///<summary>Adds NewGameplayTag to this instance of the effect</summary>
	public static FGameplayEffectSpecHandle AddAssetTag(FGameplayEffectSpecHandle SpecHandle,FGameplayTag NewGameplayTag) { return default; }
	///<summary>Adds NewGameplayTags to this instance of the effect</summary>
	public static FGameplayEffectSpecHandle AddAssetTags(FGameplayEffectSpecHandle SpecHandle,FGameplayTagContainer NewGameplayTags) { return default; }
	///<summary>Adds LinkedGameplayEffectSpec to SpecHandles. LinkedGameplayEffectSpec will be applied when/if SpecHandle is applied successfully. LinkedGameplayEffectSpec will not be modified here. Returns the ORIGINAL SpecHandle (legacy decision)</summary>
	public static FGameplayEffectSpecHandle AddLinkedGameplayEffectSpec(FGameplayEffectSpecHandle SpecHandle,FGameplayEffectSpecHandle LinkedGameplayEffectSpec) { return default; }
	///<summary>Adds LinkedGameplayEffect to SpecHandles. LinkedGameplayEffectSpec will be applied when/if SpecHandle is applied successfully. This will initialize the LinkedGameplayEffect&#39;s Spec for you. Returns to NEW linked spec in case you want to add more to it.</summary>
	public static FGameplayEffectSpecHandle AddLinkedGameplayEffect(FGameplayEffectSpecHandle SpecHandle,UClass LinkedGameplayEffect) { return default; }
	///<summary>Sets the GameplayEffectSpec&#39;s StackCount to the specified amount (prior to applying)</summary>
	public static FGameplayEffectSpecHandle SetStackCount(FGameplayEffectSpecHandle SpecHandle,int StackCount) { return default; }
	///<summary>Sets the GameplayEffectSpec&#39;s StackCount to the max stack count defined in the GameplayEffect definition</summary>
	public static FGameplayEffectSpecHandle SetStackCountToMax(FGameplayEffectSpecHandle SpecHandle) { return default; }
	///<summary>Gets the GameplayEffectSpec&#39;s effect context handle</summary>
	public static FGameplayEffectContextHandle GetEffectContext(FGameplayEffectSpecHandle SpecHandle) { return default; }
	///<summary>Returns handles for all Linked GE Specs that SpecHandle may apply. Useful if you want to append additional information to them.</summary>
	public static TArray<FGameplayEffectSpecHandle> GetAllLinkedGameplayEffectSpecHandles(FGameplayEffectSpecHandle SpecHandle) { return default; }
	///<summary>Manually adds a set of tags to a given actor, and optionally replicates them.</summary>
	public static bool AddLooseGameplayTags(AActor Actor,FGameplayTagContainer GameplayTags,bool bShouldReplicate/*=false*/) { return default; }
	///<summary>Manually removes a set of tags from a given actor, with optional replication.</summary>
	public static bool RemoveLooseGameplayTags(AActor Actor,FGameplayTagContainer GameplayTags,bool bShouldReplicate/*=false*/) { return default; }
	///<summary>Gets the magnitude of change for an attribute on an APPLIED GameplayEffectSpec.</summary>
	public static float GetModifiedAttributeMagnitude(FGameplayEffectSpecHandle SpecHandle,FGameplayAttribute Attribute) { return default; }
	///<summary>Returns current stack count of an active Gameplay Effect. Will return 0 if the GameplayEffect is no longer valid.</summary>
	public static int GetActiveGameplayEffectStackCount(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	///<summary>Returns stack limit count of an active Gameplay Effect. Will return 0 if the GameplayEffect is no longer valid.</summary>
	public static int GetActiveGameplayEffectStackLimitCount(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	///<summary>Returns the start time (time which the GE was added) for a given GameplayEffect</summary>
	public static float GetActiveGameplayEffectStartTime(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	///<summary>Returns the expected end time (when we think the GE will expire) for a given GameplayEffect (note someone could remove or change it before that happens!)</summary>
	public static float GetActiveGameplayEffectExpectedEndTime(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	///<summary>Returns the total duration for a given GameplayEffect</summary>
	public static float GetActiveGameplayEffectTotalDuration(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	///<summary>Returns the total duration for a given GameplayEffect, basically ExpectedEndTime - Current Time</summary>
	public static float GetActiveGameplayEffectRemainingDuration(UObject WorldContextObject,FActiveGameplayEffectHandle ActiveHandle) { return default; }
	///<summary>Returns a debug string for display</summary>
	public static string GetActiveGameplayEffectDebugString(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	///<summary>Returns the UI data for a gameplay effect class (if any)</summary>
	public static UGameplayEffectUIData GetGameplayEffectUIData(UClass EffectClass,UClass DataType) { return default; }
	///<summary>Equality operator for two Active Gameplay Effect Handles</summary>
	public static bool EqualEqual_ActiveGameplayEffectHandle(FActiveGameplayEffectHandle A,FActiveGameplayEffectHandle B) { return default; }
	///<summary>Inequality operator for two Active Gameplay Effect Handles</summary>
	public static bool NotEqual_ActiveGameplayEffectHandle(FActiveGameplayEffectHandle A,FActiveGameplayEffectHandle B) { return default; }
	///<summary>Returns the Gameplay Effect CDO from an active handle.</summary>
	public static UGameplayEffect GetGameplayEffectFromActiveEffectHandle(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	///<summary>Provides the Gameplay Ability object associated with an Ability Spec Handle</summary>
	public static UGameplayAbility GetGameplayAbilityFromSpecHandle(UAbilitySystemComponent AbilitySystem,FGameplayAbilitySpecHandle AbilitySpecHandle,bool bIsInstance) { return default; }
	///<summary>Equality operator for two Gameplay Ability Spec Handles</summary>
	public static bool EqualEqual_GameplayAbilitySpecHandle(FGameplayAbilitySpecHandle A,FGameplayAbilitySpecHandle B) { return default; }
	///<summary>Inequality operator for two Gameplay Ability Spec Handles</summary>
	public static bool NotEqual_GameplayAbilitySpecHandle(FGameplayAbilitySpecHandle A,FGameplayAbilitySpecHandle B) { return default; }
}
