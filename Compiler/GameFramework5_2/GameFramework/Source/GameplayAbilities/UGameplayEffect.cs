#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>UGameplayEffect</summary>
public partial class UGameplayEffect : UObject {
// GameplayEffect
	public EGameplayEffectDurationType DurationPolicy;
	public FGameplayEffectModifierMagnitude DurationMagnitude;
	public FScalableFloat Period;
	public bool bExecutePeriodicEffectOnApplication;
	public EGameplayEffectPeriodInhibitionRemovedPolicy PeriodicInhibitionPolicy;
	public TArray<FGameplayModifierInfo> Modifiers;
	public TArray<FGameplayEffectExecutionDefinition> Executions;
	public FScalableFloat ChanceToApplyToTarget;
	public TArray<UClass> ApplicationRequirements;
	public TArray<UClass> TargetEffectClasses_DEPRECATED;
	public TArray<FConditionalGameplayEffect> ConditionalGameplayEffects;
	public TArray<UClass> OverflowEffects;
	public bool bDenyOverflowApplication;
	public bool bClearStackOnOverflow;
	public TArray<UClass> PrematureExpirationEffectClasses;
	public TArray<UClass> RoutineExpirationEffectClasses;
	public bool bRequireModifierSuccessToTriggerCues;
	public bool bSuppressStackingCues;
	public TArray<FGameplayEffectCue> GameplayCues;
	public UGameplayEffectUIData UIData;
	public FInheritedTagContainer InheritableGameplayEffectTags;
	public FInheritedTagContainer InheritableOwnedTagsContainer;
	public FInheritedTagContainer InheritableBlockedAbilityTagsContainer;
	public FGameplayTagRequirements OngoingTagRequirements;
	public FGameplayTagRequirements ApplicationTagRequirements;
	public FGameplayTagRequirements RemovalTagRequirements;
	public FInheritedTagContainer RemoveGameplayEffectsWithTags;
	public FGameplayTagRequirements GrantedApplicationImmunityTags;
	public FGameplayEffectQuery GrantedApplicationImmunityQuery;
	public FGameplayEffectQuery RemoveGameplayEffectQuery;
	public EGameplayEffectStackingType StackingType;
	public int StackLimitCount;
	public EGameplayEffectStackingDurationPolicy StackDurationRefreshPolicy;
	public EGameplayEffectStackingPeriodPolicy StackPeriodResetPolicy;
	public EGameplayEffectStackingExpirationPolicy StackExpirationPolicy;
	public TArray<FGameplayAbilitySpecDef> GrantedAbilities;
}
