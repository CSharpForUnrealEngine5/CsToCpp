namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayModifierInfo</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayModifierInfo {
	public FGameplayAttribute Attribute;
	public EGameplayModOp ModifierOp;
	public FGameplayEffectModifierMagnitude ModifierMagnitude;
	public FGameplayModEvaluationChannelSettings EvaluationChannelSettings;
	public FGameplayTagRequirements SourceTags;
	public FGameplayTagRequirements TargetTags;
}
