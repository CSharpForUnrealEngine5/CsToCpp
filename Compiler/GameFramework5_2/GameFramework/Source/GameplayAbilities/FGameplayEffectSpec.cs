#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>GameplayEffect Specification. Tells us:</summary>
public partial struct FGameplayEffectSpec {
// GameplayEffectSpec
	public UGameplayEffect Def;
	public TArray<FGameplayEffectModifiedAttribute> ModifiedAttributes;
	public FGameplayEffectAttributeCaptureSpecContainer CapturedRelevantAttributes;
	public float Duration;
	public float Period;
	public float ChanceToApplyToTarget;
	public FTagContainerAggregator CapturedSourceTags;
	public FTagContainerAggregator CapturedTargetTags;
	public FGameplayTagContainer DynamicGrantedTags;
	public FGameplayTagContainer DynamicAssetTags;
	public TArray<FModifierSpec> Modifiers;
	public int StackCount;
	public bool bCompletedSourceAttributeCapture;
	public bool bCompletedTargetAttributeCapture;
	public bool bDurationLocked;
	public TArray<FGameplayAbilitySpecDef> GrantedAbilitySpecs;
	public FGameplayEffectContextHandle EffectContext;
	public float Level;
}
