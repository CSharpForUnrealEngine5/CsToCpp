namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGameplayEffect</summary>
[CppInclude("GameplayEffect.h")]
public partial class UGameplayEffect : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Policy for the duration of this effect</summary>
	public EGameplayEffectDurationType DurationPolicy;
	///<summary>Duration in seconds. 0.0 for instantaneous effects; -1.0 for infinite duration.</summary>
	public FGameplayEffectModifierMagnitude DurationMagnitude;
	///<summary>Period in seconds. 0.0 for non-periodic effects</summary>
	public FScalableFloat Period;
	///<summary>If true, the effect executes on application and then at every period interval. If false, no execution occurs until the first period elapses.</summary>
	public bool bExecutePeriodicEffectOnApplication;
	///<summary>PeriodicInhibitionPolicy</summary>
	public EGameplayEffectPeriodInhibitionRemovedPolicy PeriodicInhibitionPolicy;
	///<summary>Array of modifiers that will affect the target of this effect</summary>
	public TArray<FGameplayModifierInfo> Modifiers;
	///<summary>Executions</summary>
	public TArray<FGameplayEffectExecutionDefinition> Executions;
	///<summary>Probability that this gameplay effect will be applied to the target actor (0.0 for never, 1.0 for always)</summary>
	public FScalableFloat ChanceToApplyToTarget;
	///<summary>ApplicationRequirements</summary>
	public TArray<UClass> ApplicationRequirements;
	///<summary>Deprecated. Use ConditionalGameplayEffects instead</summary>
	public TArray<UClass> TargetEffectClasses_DEPRECATED;
	///<summary>other gameplay effects that will be applied to the target of this effect if this effect applies</summary>
	public TArray<FConditionalGameplayEffect> ConditionalGameplayEffects;
	///<summary>Effects to apply when a stacking effect &quot;overflows&quot; its stack count through another attempted application. Added whether the overflow application succeeds or not.</summary>
	public TArray<UClass> OverflowEffects;
	///<summary>If true, stacking attempts made while at the stack count will fail, resulting in the duration and context not being refreshed</summary>
	public bool bDenyOverflowApplication;
	///<summary>If true, the entire stack of the effect will be cleared once it overflows</summary>
	public bool bClearStackOnOverflow;
	///<summary>Effects to apply when this effect is made to expire prematurely (like via a forced removal, clear tags, etc.); Only works for effects with a duration</summary>
	public TArray<UClass> PrematureExpirationEffectClasses;
	///<summary>Effects to apply when this effect expires naturally via its duration; Only works for effects with a duration</summary>
	public TArray<UClass> RoutineExpirationEffectClasses;
	///<summary>If true, cues will only trigger when GE modifiers succeed being applied (whether through modifiers or executions)</summary>
	public bool bRequireModifierSuccessToTriggerCues;
	///<summary>If true, GameplayCues will only be triggered for the first instance in a stacking GameplayEffect.</summary>
	public bool bSuppressStackingCues;
	///<summary>Cues to trigger non-simulated reactions in response to this GameplayEffect such as sounds, particle effects, etc</summary>
	public TArray<FGameplayEffectCue> GameplayCues;
	///<summary>Data for the UI representation of this effect. This should include things like text, icons, etc. Not available in server-only builds.</summary>
	public UGameplayEffectUIData UIData;
	///<summary>The GameplayEffect&#39;s Tags: tags the the GE *has* and DOES NOT give to the actor.</summary>
	public FInheritedTagContainer InheritableGameplayEffectTags;
	///<summary>These tags are applied to the actor I am applied to</summary>
	public FInheritedTagContainer InheritableOwnedTagsContainer;
	///<summary>These blocked ability tags are applied to the actor I am applied to</summary>
	public FInheritedTagContainer InheritableBlockedAbilityTagsContainer;
	///<summary>Once Applied, these tags requirements are used to determined if the GameplayEffect is &quot;on&quot; or &quot;off&quot;. A GameplayEffect can be off and do nothing, but still applied.</summary>
	public FGameplayTagRequirements OngoingTagRequirements;
	///<summary>Tag requirements for this GameplayEffect to be applied to a target. This is pass/fail at the time of application. If fail, this GE fails to apply.</summary>
	public FGameplayTagRequirements ApplicationTagRequirements;
	///<summary>Tag requirements that if met will remove this effect. Also prevents effect application.</summary>
	public FGameplayTagRequirements RemovalTagRequirements;
	///<summary>GameplayEffects that *have* tags in this container will be cleared upon effect application.</summary>
	public FInheritedTagContainer RemoveGameplayEffectsWithTags;
	///<summary>Grants the owner immunity from these source tags.</summary>
	public FGameplayTagRequirements GrantedApplicationImmunityTags;
	///<summary>Grants immunity to GameplayEffects that match this query. Queries are more powerful but slightly slower than GrantedApplicationImmunityTags.</summary>
	public FGameplayEffectQuery GrantedApplicationImmunityQuery;
	///<summary>On Application of an effect, any active effects with this this query that matches against the added effect will be removed. Queries are more powerful but slightly slower than RemoveGameplayEffectsWithTags.</summary>
	public FGameplayEffectQuery RemoveGameplayEffectQuery;
	///<summary>How this GameplayEffect stacks with other instances of this same GameplayEffect</summary>
	public EGameplayEffectStackingType StackingType;
	///<summary>Stack limit for StackingType</summary>
	public int StackLimitCount;
	///<summary>Policy for how the effect duration should be refreshed while stacking</summary>
	public EGameplayEffectStackingDurationPolicy StackDurationRefreshPolicy;
	///<summary>Policy for how the effect period should be reset (or not) while stacking</summary>
	public EGameplayEffectStackingPeriodPolicy StackPeriodResetPolicy;
	///<summary>Policy for how to handle duration expiring on this gameplay effect</summary>
	public EGameplayEffectStackingExpirationPolicy StackExpirationPolicy;
	///<summary>Granted abilities</summary>
	public TArray<FGameplayAbilitySpecDef> GrantedAbilities;
}
