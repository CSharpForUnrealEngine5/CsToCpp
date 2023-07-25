#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>FGameplayModifierInfo</summary>
public partial struct FGameplayModifierInfo {
// GameplayModifierInfo
	public FGameplayAttribute Attribute;
	public byte ModifierOp;
	public FGameplayEffectModifierMagnitude ModifierMagnitude;
	public FGameplayModEvaluationChannelSettings EvaluationChannelSettings;
	public FGameplayTagRequirements SourceTags;
	public FGameplayTagRequirements TargetTags;
}
