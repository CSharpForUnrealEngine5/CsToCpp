#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct representing modifier info used exclusively for &quot;scoped&quot; executions that happen instantaneously. These are</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectExecutionScopedModifierInfo {
	public FGameplayEffectAttributeCaptureDefinition CapturedAttribute;
	public FGameplayTag TransientAggregatorIdentifier;
	public EGameplayEffectScopedModifierAggregatorType AggregatorType;
	public EGameplayModOp ModifierOp;
	public FGameplayEffectModifierMagnitude ModifierMagnitude;
	public FGameplayModEvaluationChannelSettings EvaluationChannelSettings;
	public FGameplayTagRequirements SourceTags;
	public FGameplayTagRequirements TargetTags;
}
