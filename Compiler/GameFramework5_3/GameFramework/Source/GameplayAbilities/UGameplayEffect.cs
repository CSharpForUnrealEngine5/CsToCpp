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
	///<summary>If true, the effect executes on application and then at every period interval. If false, no execution occurs until the first period elapses. // EditCondition in FGameplayEffectDetails</summary>
	public bool bExecutePeriodicEffectOnApplication;
	///<summary>How we should respond when a periodic gameplay effect is no longer inhibited // EditCondition in FGameplayEffectDetails</summary>
	public EGameplayEffectPeriodInhibitionRemovedPolicy PeriodicInhibitionPolicy;
	///<summary>Array of modifiers that will affect the target of this effect</summary>
	public TArray<FGameplayModifierInfo> Modifiers;
	///<summary>Array of executions that will affect the target of this effect</summary>
	public TArray<FGameplayEffectExecutionDefinition> Executions;
	///<summary>ChanceToApplyToTarget_DEPRECATED</summary>
	public FScalableFloat ChanceToApplyToTarget_DEPRECATED;
	///<summary>ApplicationRequirements_DEPRECATED</summary>
	public TArray<UClass> ApplicationRequirements_DEPRECATED;
	///<summary>ConditionalGameplayEffects</summary>
	public TArray<FConditionalGameplayEffect> ConditionalGameplayEffects;
	///<summary>Effects to apply when a stacking effect &quot;overflows&quot; its stack count through another attempted application. Added whether the overflow application succeeds or not.</summary>
	public TArray<UClass> OverflowEffects;
	///<summary>If true, stacking attempts made while at the stack count will fail, resulting in the duration and context not being refreshed</summary>
	public bool bDenyOverflowApplication;
	///<summary>If true, the entire stack of the effect will be cleared once it overflows</summary>
	public bool bClearStackOnOverflow;
	///<summary>PrematureExpirationEffectClasses</summary>
	public TArray<UClass> PrematureExpirationEffectClasses;
	///<summary>RoutineExpirationEffectClasses</summary>
	public TArray<UClass> RoutineExpirationEffectClasses;
	///<summary>If true, cues will only trigger when GE modifiers succeed being applied (whether through modifiers or executions)</summary>
	public bool bRequireModifierSuccessToTriggerCues;
	///<summary>If true, GameplayCues will only be triggered for the first instance in a stacking GameplayEffect.</summary>
	public bool bSuppressStackingCues;
	///<summary>Cues to trigger non-simulated reactions in response to this GameplayEffect such as sounds, particle effects, etc</summary>
	public TArray<FGameplayEffectCue> GameplayCues;
	///<summary>UIData</summary>
	public UGameplayEffectUIData UIData;
	///<summary>InheritableGameplayEffectTags</summary>
	public FInheritedTagContainer InheritableGameplayEffectTags;
	///<summary>InheritableOwnedTagsContainer</summary>
	public FInheritedTagContainer InheritableOwnedTagsContainer;
	///<summary>InheritableBlockedAbilityTagsContainer</summary>
	public FInheritedTagContainer InheritableBlockedAbilityTagsContainer;
	///<summary>OngoingTagRequirements</summary>
	public FGameplayTagRequirements OngoingTagRequirements;
	///<summary>ApplicationTagRequirements</summary>
	public FGameplayTagRequirements ApplicationTagRequirements;
	///<summary>RemovalTagRequirements</summary>
	public FGameplayTagRequirements RemovalTagRequirements;
	///<summary>RemoveGameplayEffectsWithTags</summary>
	public FInheritedTagContainer RemoveGameplayEffectsWithTags;
	///<summary>GrantedApplicationImmunityTags</summary>
	public FGameplayTagRequirements GrantedApplicationImmunityTags;
	///<summary>GrantedApplicationImmunityQuery</summary>
	public FGameplayEffectQuery GrantedApplicationImmunityQuery;
	///<summary>RemoveGameplayEffectQuery</summary>
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
	///<summary>GrantedAbilities</summary>
	public TArray<FGameplayAbilitySpecDef> GrantedAbilities;
	///<summary>These Gameplay Effect Components define how this Gameplay Effect behaves when applied</summary>
	public TArray<UGameplayEffectComponent> GEComponents;
	///<summary>Allow us to show the Status of the class (valid configurations or invalid configurations) while configuring in the Editor</summary>
	public FText EditorStatusText;
	///<summary>The saved version of this package (the value is not inherited from its parents). See: SetVersion and GetVersion.</summary>
	public FGameplayEffectVersion DataVersion;
}
