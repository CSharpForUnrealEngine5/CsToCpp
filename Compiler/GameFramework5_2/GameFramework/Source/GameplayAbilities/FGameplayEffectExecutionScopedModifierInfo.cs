#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Struct representing modifier info used exclusively for "scoped" executions that happen instantaneously. These are</summary>
public partial struct FGameplayEffectExecutionScopedModifierInfo {
// GameplayEffectExecutionScopedModifierInfo
	public FGameplayEffectAttributeCaptureDefinition CapturedAttribute;
	public FGameplayTag TransientAggregatorIdentifier;
	public EGameplayEffectScopedModifierAggregatorType AggregatorType;
	public EGameplayModOp ModifierOp;
	public FGameplayEffectModifierMagnitude ModifierMagnitude;
	public FGameplayModEvaluationChannelSettings EvaluationChannelSettings;
	public FGameplayTagRequirements SourceTags;
	public FGameplayTagRequirements TargetTags;
}
