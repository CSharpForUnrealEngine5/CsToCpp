#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilitySystemBlueprintLibrary.h")]
///<summary>Blueprint library for ability system. Many of these functions are useful to call from native as well</summary>
public partial class UAbilitySystemBlueprintLibrary : UBlueprintFunctionLibrary {
// AbilitySystemBlueprintLibrary
	public UObject GetAbilitySystemComponent(UObject Actor) { return default; }
	public void SendGameplayEventToActor(UObject Actor,FGameplayTag EventTag,FGameplayEventData Payload) {}
	public bool IsValid(FGameplayAttribute Attribute) { return default; }
	public float GetFloatAttribute(UObject Actor,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	public float GetFloatAttributeFromAbilitySystemComponent(UObject AbilitySystem,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	public float GetFloatAttributeBase(UObject Actor,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	public float GetFloatAttributeBaseFromAbilitySystemComponent(UObject AbilitySystemComponent,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	public float EvaluateAttributeValueWithTags(UObject AbilitySystem,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,bool bSuccess) { return default; }
	public float EvaluateAttributeValueWithTagsAndBase(UObject AbilitySystem,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,float BaseValue,bool bSuccess) { return default; }
	public bool EqualEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA,FGameplayAttribute AttributeB) { return default; }
	public bool NotEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA,FGameplayAttribute AttributeB) { return default; }
	public string GetDebugStringFromGameplayAttribute(FGameplayAttribute Attribute) { return default; }
	public FGameplayAbilityTargetDataHandle AppendTargetDataHandle(FGameplayAbilityTargetDataHandle TargetHandle,FGameplayAbilityTargetDataHandle HandleToAdd) { return default; }
	public FGameplayAbilityTargetDataHandle AbilityTargetDataFromLocations(FGameplayAbilityTargetingLocationInfo SourceLocation,FGameplayAbilityTargetingLocationInfo TargetLocation) { return default; }
	public FGameplayAbilityTargetDataHandle AbilityTargetDataFromHitResult(FHitResult HitResult) { return default; }
	public int GetDataCountFromTargetData(FGameplayAbilityTargetDataHandle TargetData) { return default; }
	public FGameplayAbilityTargetDataHandle AbilityTargetDataFromActor(UObject Actor) { return default; }
	public FGameplayAbilityTargetDataHandle AbilityTargetDataFromActorArray(TArray<UObject> ActorArray,bool OneTargetPerHandle) { return default; }
	public FGameplayAbilityTargetDataHandle FilterTargetData(FGameplayAbilityTargetDataHandle TargetDataHandle,FGameplayTargetDataFilterHandle ActorFilterClass) { return default; }
	public FGameplayTargetDataFilterHandle MakeFilterHandle(FGameplayTargetDataFilter Filter,UObject FilterActor) { return default; }
	public FGameplayEffectSpecHandle MakeSpecHandle(UObject InGameplayEffect,UObject InInstigator,UObject InEffectCauser,float InLevel/*=1.0f*/) { return default; }
	public FGameplayEffectSpecHandle CloneSpecHandle(UObject InNewInstigator,UObject InEffectCauser,FGameplayEffectSpecHandle GameplayEffectSpecHandle_Clone) { return default; }
	public TArray<UObject> GetActorsFromTargetData(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public TArray<UObject> GetAllActorsFromTargetData(FGameplayAbilityTargetDataHandle TargetData) { return default; }
	public bool DoesTargetDataContainActor(FGameplayAbilityTargetDataHandle TargetData,int Index,UObject Actor) { return default; }
	public bool TargetDataHasActor(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public bool TargetDataHasHitResult(FGameplayAbilityTargetDataHandle HitResult,int Index) { return default; }
	public FHitResult GetHitResultFromTargetData(FGameplayAbilityTargetDataHandle HitResult,int Index) { return default; }
	public bool TargetDataHasOrigin(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public FTransform GetTargetDataOrigin(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public bool TargetDataHasEndPoint(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public FVector GetTargetDataEndPoint(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public FTransform GetTargetDataEndPointTransform(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public bool EffectContextIsValid(FGameplayEffectContextHandle EffectContext) { return default; }
	public bool EffectContextIsInstigatorLocallyControlled(FGameplayEffectContextHandle EffectContext) { return default; }
	public FHitResult EffectContextGetHitResult(FGameplayEffectContextHandle EffectContext) { return default; }
	public bool EffectContextHasHitResult(FGameplayEffectContextHandle EffectContext) { return default; }
	public void EffectContextAddHitResult(FGameplayEffectContextHandle EffectContext,FHitResult HitResult,bool bReset) {}
	public FVector EffectContextGetOrigin(FGameplayEffectContextHandle EffectContext) { return default; }
	public void EffectContextSetOrigin(FGameplayEffectContextHandle EffectContext,FVector Origin) {}
	public UObject EffectContextGetInstigatorActor(FGameplayEffectContextHandle EffectContext) { return default; }
	public UObject EffectContextGetOriginalInstigatorActor(FGameplayEffectContextHandle EffectContext) { return default; }
	public UObject EffectContextGetEffectCauser(FGameplayEffectContextHandle EffectContext) { return default; }
	public UObject EffectContextGetSourceObject(FGameplayEffectContextHandle EffectContext) { return default; }
	public bool IsInstigatorLocallyControlled(FGameplayCueParameters Parameters) { return default; }
	public bool IsInstigatorLocallyControlledPlayer(FGameplayCueParameters Parameters) { return default; }
	public int GetActorCount(FGameplayCueParameters Parameters) { return default; }
	public UObject GetActorByIndex(FGameplayCueParameters Parameters,int Index) { return default; }
	public FHitResult GetHitResult(FGameplayCueParameters Parameters) { return default; }
	public bool HasHitResult(FGameplayCueParameters Parameters) { return default; }
	public void ForwardGameplayCueToTarget(object /*TargetCueInterface*/ TargetCueInterface,EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	public UObject GetInstigatorActor(FGameplayCueParameters Parameters) { return default; }
	public FTransform GetInstigatorTransform(FGameplayCueParameters Parameters) { return default; }
	public FVector GetOrigin(FGameplayCueParameters Parameters) { return default; }
	public bool GetGameplayCueEndLocationAndNormal(UObject TargetActor,FGameplayCueParameters Parameters,FVector Location,FVector Normal) { return default; }
	public bool GetGameplayCueDirection(UObject TargetActor,FGameplayCueParameters Parameters,FVector Direction) { return default; }
	public bool DoesGameplayCueMeetTagRequirements(FGameplayCueParameters Parameters,FGameplayTagRequirements SourceTagReqs,FGameplayTagRequirements TargetTagReqs) { return default; }
	public FGameplayCueParameters MakeGameplayCueParameters(float NormalizedMagnitude,float RawMagnitude,FGameplayEffectContextHandle EffectContext,FGameplayTag MatchedTagName,FGameplayTag OriginalTag,FGameplayTagContainer AggregatedSourceTags,FGameplayTagContainer AggregatedTargetTags,FVector Location,FVector Normal,UObject Instigator,UObject EffectCauser,UObject SourceObject,UObject PhysicalMaterial,int GameplayEffectLevel,int AbilityLevel,UObject TargetAttachComponent,bool bReplicateLocationWhenUsingMinimalRepProxy) { return default; }
	public void BreakGameplayCueParameters(FGameplayCueParameters Parameters,float NormalizedMagnitude,float RawMagnitude,FGameplayEffectContextHandle EffectContext,FGameplayTag MatchedTagName,FGameplayTag OriginalTag,FGameplayTagContainer AggregatedSourceTags,FGameplayTagContainer AggregatedTargetTags,FVector Location,FVector Normal,UObject Instigator,UObject EffectCauser,UObject SourceObject,UObject PhysicalMaterial,int GameplayEffectLevel,int AbilityLevel,UObject TargetAttachComponent,bool bReplicateLocationWhenUsingMinimalRepProxy) {}
	public FGameplayEffectSpecHandle AssignSetByCallerMagnitude(FGameplayEffectSpecHandle SpecHandle,string DataName,float Magnitude) { return default; }
	public FGameplayEffectSpecHandle AssignTagSetByCallerMagnitude(FGameplayEffectSpecHandle SpecHandle,FGameplayTag DataTag,float Magnitude) { return default; }
	public FGameplayEffectSpecHandle SetDuration(FGameplayEffectSpecHandle SpecHandle,float Duration) { return default; }
	public FGameplayEffectSpecHandle AddGrantedTag(FGameplayEffectSpecHandle SpecHandle,FGameplayTag NewGameplayTag) { return default; }
	public FGameplayEffectSpecHandle AddGrantedTags(FGameplayEffectSpecHandle SpecHandle,FGameplayTagContainer NewGameplayTags) { return default; }
	public FGameplayEffectSpecHandle AddAssetTag(FGameplayEffectSpecHandle SpecHandle,FGameplayTag NewGameplayTag) { return default; }
	public FGameplayEffectSpecHandle AddAssetTags(FGameplayEffectSpecHandle SpecHandle,FGameplayTagContainer NewGameplayTags) { return default; }
	public FGameplayEffectSpecHandle AddLinkedGameplayEffectSpec(FGameplayEffectSpecHandle SpecHandle,FGameplayEffectSpecHandle LinkedGameplayEffectSpec) { return default; }
	public FGameplayEffectSpecHandle AddLinkedGameplayEffect(FGameplayEffectSpecHandle SpecHandle,UClass LinkedGameplayEffect) { return default; }
	public FGameplayEffectSpecHandle SetStackCount(FGameplayEffectSpecHandle SpecHandle,int StackCount) { return default; }
	public FGameplayEffectSpecHandle SetStackCountToMax(FGameplayEffectSpecHandle SpecHandle) { return default; }
	public FGameplayEffectContextHandle GetEffectContext(FGameplayEffectSpecHandle SpecHandle) { return default; }
	public TArray<FGameplayEffectSpecHandle> GetAllLinkedGameplayEffectSpecHandles(FGameplayEffectSpecHandle SpecHandle) { return default; }
	public bool AddLooseGameplayTags(UObject Actor,FGameplayTagContainer GameplayTags,bool bShouldReplicate/*=false*/) { return default; }
	public bool RemoveLooseGameplayTags(UObject Actor,FGameplayTagContainer GameplayTags,bool bShouldReplicate/*=false*/) { return default; }
	public float GetModifiedAttributeMagnitude(FGameplayEffectSpecHandle SpecHandle,FGameplayAttribute Attribute) { return default; }
	public int GetActiveGameplayEffectStackCount(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public int GetActiveGameplayEffectStackLimitCount(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public float GetActiveGameplayEffectStartTime(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public float GetActiveGameplayEffectExpectedEndTime(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public float GetActiveGameplayEffectTotalDuration(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public float GetActiveGameplayEffectRemainingDuration(UObject WorldContextObject,FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public string GetActiveGameplayEffectDebugString(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public UObject GetGameplayEffectUIData(UClass EffectClass,UClass DataType) { return default; }
	public bool EqualEqual_ActiveGameplayEffectHandle(FActiveGameplayEffectHandle A,FActiveGameplayEffectHandle B) { return default; }
	public bool NotEqual_ActiveGameplayEffectHandle(FActiveGameplayEffectHandle A,FActiveGameplayEffectHandle B) { return default; }
	public UObject GetGameplayEffectFromActiveEffectHandle(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public UObject GetGameplayAbilityFromSpecHandle(UObject AbilitySystem,FGameplayAbilitySpecHandle AbilitySpecHandle,bool bIsInstance) { return default; }
	public bool EqualEqual_GameplayAbilitySpecHandle(FGameplayAbilitySpecHandle A,FGameplayAbilitySpecHandle B) { return default; }
	public bool NotEqual_GameplayAbilitySpecHandle(FGameplayAbilitySpecHandle A,FGameplayAbilitySpecHandle B) { return default; }
}
