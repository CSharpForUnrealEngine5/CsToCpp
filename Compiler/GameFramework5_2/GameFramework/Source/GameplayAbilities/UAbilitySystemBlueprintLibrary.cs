#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilitySystemBlueprintLibrary.h")]
///<summary>Blueprint library for ability system. Many of these functions are useful to call from native as well</summary>
public partial class UAbilitySystemBlueprintLibrary : UBlueprintFunctionLibrary {
// AbilitySystemBlueprintLibrary
	public static UAbilitySystemComponent GetAbilitySystemComponent(AActor Actor) { return default; }
	public static void SendGameplayEventToActor(AActor Actor,FGameplayTag EventTag,FGameplayEventData Payload) {}
	public static bool IsValid(FGameplayAttribute Attribute) { return default; }
	public static float GetFloatAttribute(AActor Actor,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	public static float GetFloatAttributeFromAbilitySystemComponent(UAbilitySystemComponent AbilitySystem,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	public static float GetFloatAttributeBase(AActor Actor,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	public static float GetFloatAttributeBaseFromAbilitySystemComponent(UAbilitySystemComponent AbilitySystemComponent,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute) { return default; }
	public static float EvaluateAttributeValueWithTags(UAbilitySystemComponent AbilitySystem,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,bool bSuccess) { return default; }
	public static float EvaluateAttributeValueWithTagsAndBase(UAbilitySystemComponent AbilitySystem,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,float BaseValue,bool bSuccess) { return default; }
	public static bool EqualEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA,FGameplayAttribute AttributeB) { return default; }
	public static bool NotEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA,FGameplayAttribute AttributeB) { return default; }
	public static string GetDebugStringFromGameplayAttribute(FGameplayAttribute Attribute) { return default; }
	public static FGameplayAbilityTargetDataHandle AppendTargetDataHandle(FGameplayAbilityTargetDataHandle TargetHandle,FGameplayAbilityTargetDataHandle HandleToAdd) { return default; }
	public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromLocations(FGameplayAbilityTargetingLocationInfo SourceLocation,FGameplayAbilityTargetingLocationInfo TargetLocation) { return default; }
	public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromHitResult(FHitResult HitResult) { return default; }
	public static int GetDataCountFromTargetData(FGameplayAbilityTargetDataHandle TargetData) { return default; }
	public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromActor(AActor Actor) { return default; }
	public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromActorArray(TArray<AActor> ActorArray,bool OneTargetPerHandle) { return default; }
	public static FGameplayAbilityTargetDataHandle FilterTargetData(FGameplayAbilityTargetDataHandle TargetDataHandle,FGameplayTargetDataFilterHandle ActorFilterClass) { return default; }
	public static FGameplayTargetDataFilterHandle MakeFilterHandle(FGameplayTargetDataFilter Filter,AActor FilterActor) { return default; }
	public static FGameplayEffectSpecHandle MakeSpecHandle(UGameplayEffect InGameplayEffect,AActor InInstigator,AActor InEffectCauser,float InLevel/*=1.0f*/) { return default; }
	public static FGameplayEffectSpecHandle CloneSpecHandle(AActor InNewInstigator,AActor InEffectCauser,FGameplayEffectSpecHandle GameplayEffectSpecHandle_Clone) { return default; }
	public static TArray<AActor> GetActorsFromTargetData(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public static TArray<AActor> GetAllActorsFromTargetData(FGameplayAbilityTargetDataHandle TargetData) { return default; }
	public static bool DoesTargetDataContainActor(FGameplayAbilityTargetDataHandle TargetData,int Index,AActor Actor) { return default; }
	public static bool TargetDataHasActor(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public static bool TargetDataHasHitResult(FGameplayAbilityTargetDataHandle HitResult,int Index) { return default; }
	public static FHitResult GetHitResultFromTargetData(FGameplayAbilityTargetDataHandle HitResult,int Index) { return default; }
	public static bool TargetDataHasOrigin(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public static FTransform GetTargetDataOrigin(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public static bool TargetDataHasEndPoint(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public static FVector GetTargetDataEndPoint(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public static FTransform GetTargetDataEndPointTransform(FGameplayAbilityTargetDataHandle TargetData,int Index) { return default; }
	public static bool EffectContextIsValid(FGameplayEffectContextHandle EffectContext) { return default; }
	public static bool EffectContextIsInstigatorLocallyControlled(FGameplayEffectContextHandle EffectContext) { return default; }
	public static FHitResult EffectContextGetHitResult(FGameplayEffectContextHandle EffectContext) { return default; }
	public static bool EffectContextHasHitResult(FGameplayEffectContextHandle EffectContext) { return default; }
	public static void EffectContextAddHitResult(FGameplayEffectContextHandle EffectContext,FHitResult HitResult,bool bReset) {}
	public static FVector EffectContextGetOrigin(FGameplayEffectContextHandle EffectContext) { return default; }
	public static void EffectContextSetOrigin(FGameplayEffectContextHandle EffectContext,FVector Origin) {}
	public static AActor EffectContextGetInstigatorActor(FGameplayEffectContextHandle EffectContext) { return default; }
	public static AActor EffectContextGetOriginalInstigatorActor(FGameplayEffectContextHandle EffectContext) { return default; }
	public static AActor EffectContextGetEffectCauser(FGameplayEffectContextHandle EffectContext) { return default; }
	public static UObject EffectContextGetSourceObject(FGameplayEffectContextHandle EffectContext) { return default; }
	public static bool IsInstigatorLocallyControlled(FGameplayCueParameters Parameters) { return default; }
	public static bool IsInstigatorLocallyControlledPlayer(FGameplayCueParameters Parameters) { return default; }
	public static int GetActorCount(FGameplayCueParameters Parameters) { return default; }
	public static AActor GetActorByIndex(FGameplayCueParameters Parameters,int Index) { return default; }
	public static FHitResult GetHitResult(FGameplayCueParameters Parameters) { return default; }
	public static bool HasHitResult(FGameplayCueParameters Parameters) { return default; }
	public static void ForwardGameplayCueToTarget(object /*TargetCueInterface*/ TargetCueInterface,EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	public static AActor GetInstigatorActor(FGameplayCueParameters Parameters) { return default; }
	public static FTransform GetInstigatorTransform(FGameplayCueParameters Parameters) { return default; }
	public static FVector GetOrigin(FGameplayCueParameters Parameters) { return default; }
	public static bool GetGameplayCueEndLocationAndNormal(AActor TargetActor,FGameplayCueParameters Parameters,FVector Location,FVector Normal) { return default; }
	public static bool GetGameplayCueDirection(AActor TargetActor,FGameplayCueParameters Parameters,FVector Direction) { return default; }
	public static bool DoesGameplayCueMeetTagRequirements(FGameplayCueParameters Parameters,FGameplayTagRequirements SourceTagReqs,FGameplayTagRequirements TargetTagReqs) { return default; }
	public static FGameplayCueParameters MakeGameplayCueParameters(float NormalizedMagnitude,float RawMagnitude,FGameplayEffectContextHandle EffectContext,FGameplayTag MatchedTagName,FGameplayTag OriginalTag,FGameplayTagContainer AggregatedSourceTags,FGameplayTagContainer AggregatedTargetTags,FVector Location,FVector Normal,AActor Instigator,AActor EffectCauser,UObject SourceObject,UPhysicalMaterial PhysicalMaterial,int GameplayEffectLevel,int AbilityLevel,USceneComponent TargetAttachComponent,bool bReplicateLocationWhenUsingMinimalRepProxy) { return default; }
	public static void BreakGameplayCueParameters(FGameplayCueParameters Parameters,float NormalizedMagnitude,float RawMagnitude,FGameplayEffectContextHandle EffectContext,FGameplayTag MatchedTagName,FGameplayTag OriginalTag,FGameplayTagContainer AggregatedSourceTags,FGameplayTagContainer AggregatedTargetTags,FVector Location,FVector Normal,AActor Instigator,AActor EffectCauser,UObject SourceObject,UPhysicalMaterial PhysicalMaterial,int GameplayEffectLevel,int AbilityLevel,USceneComponent TargetAttachComponent,bool bReplicateLocationWhenUsingMinimalRepProxy) {}
	public static FGameplayEffectSpecHandle AssignSetByCallerMagnitude(FGameplayEffectSpecHandle SpecHandle,string DataName,float Magnitude) { return default; }
	public static FGameplayEffectSpecHandle AssignTagSetByCallerMagnitude(FGameplayEffectSpecHandle SpecHandle,FGameplayTag DataTag,float Magnitude) { return default; }
	public static FGameplayEffectSpecHandle SetDuration(FGameplayEffectSpecHandle SpecHandle,float Duration) { return default; }
	public static FGameplayEffectSpecHandle AddGrantedTag(FGameplayEffectSpecHandle SpecHandle,FGameplayTag NewGameplayTag) { return default; }
	public static FGameplayEffectSpecHandle AddGrantedTags(FGameplayEffectSpecHandle SpecHandle,FGameplayTagContainer NewGameplayTags) { return default; }
	public static FGameplayEffectSpecHandle AddAssetTag(FGameplayEffectSpecHandle SpecHandle,FGameplayTag NewGameplayTag) { return default; }
	public static FGameplayEffectSpecHandle AddAssetTags(FGameplayEffectSpecHandle SpecHandle,FGameplayTagContainer NewGameplayTags) { return default; }
	public static FGameplayEffectSpecHandle AddLinkedGameplayEffectSpec(FGameplayEffectSpecHandle SpecHandle,FGameplayEffectSpecHandle LinkedGameplayEffectSpec) { return default; }
	public static FGameplayEffectSpecHandle AddLinkedGameplayEffect(FGameplayEffectSpecHandle SpecHandle,UClass LinkedGameplayEffect) { return default; }
	public static FGameplayEffectSpecHandle SetStackCount(FGameplayEffectSpecHandle SpecHandle,int StackCount) { return default; }
	public static FGameplayEffectSpecHandle SetStackCountToMax(FGameplayEffectSpecHandle SpecHandle) { return default; }
	public static FGameplayEffectContextHandle GetEffectContext(FGameplayEffectSpecHandle SpecHandle) { return default; }
	public static TArray<FGameplayEffectSpecHandle> GetAllLinkedGameplayEffectSpecHandles(FGameplayEffectSpecHandle SpecHandle) { return default; }
	public static bool AddLooseGameplayTags(AActor Actor,FGameplayTagContainer GameplayTags,bool bShouldReplicate/*=false*/) { return default; }
	public static bool RemoveLooseGameplayTags(AActor Actor,FGameplayTagContainer GameplayTags,bool bShouldReplicate/*=false*/) { return default; }
	public static float GetModifiedAttributeMagnitude(FGameplayEffectSpecHandle SpecHandle,FGameplayAttribute Attribute) { return default; }
	public static int GetActiveGameplayEffectStackCount(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public static int GetActiveGameplayEffectStackLimitCount(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public static float GetActiveGameplayEffectStartTime(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public static float GetActiveGameplayEffectExpectedEndTime(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public static float GetActiveGameplayEffectTotalDuration(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public static float GetActiveGameplayEffectRemainingDuration(UObject WorldContextObject,FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public static string GetActiveGameplayEffectDebugString(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public static UGameplayEffectUIData GetGameplayEffectUIData(UClass EffectClass,UClass DataType) { return default; }
	public static bool EqualEqual_ActiveGameplayEffectHandle(FActiveGameplayEffectHandle A,FActiveGameplayEffectHandle B) { return default; }
	public static bool NotEqual_ActiveGameplayEffectHandle(FActiveGameplayEffectHandle A,FActiveGameplayEffectHandle B) { return default; }
	public static UGameplayEffect GetGameplayEffectFromActiveEffectHandle(FActiveGameplayEffectHandle ActiveHandle) { return default; }
	public static UGameplayAbility GetGameplayAbilityFromSpecHandle(UAbilitySystemComponent AbilitySystem,FGameplayAbilitySpecHandle AbilitySpecHandle,bool bIsInstance) { return default; }
	public static bool EqualEqual_GameplayAbilitySpecHandle(FGameplayAbilitySpecHandle A,FGameplayAbilitySpecHandle B) { return default; }
	public static bool NotEqual_GameplayAbilitySpecHandle(FGameplayAbilitySpecHandle A,FGameplayAbilitySpecHandle B) { return default; }
}
