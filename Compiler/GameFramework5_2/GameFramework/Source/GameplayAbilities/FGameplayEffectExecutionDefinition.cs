#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Struct representing the definition of a custom execution for a gameplay effect.</summary>
public partial struct FGameplayEffectExecutionDefinition {
// GameplayEffectExecutionDefinition
	public UClass CalculationClass;
	public FGameplayTagContainer PassedInTags;
	public TArray<FGameplayEffectExecutionScopedModifierInfo> CalculationModifiers;
	public TArray<UClass> ConditionalGameplayEffectClasses_DEPRECATED;
	public TArray<FConditionalGameplayEffect> ConditionalGameplayEffects;
}
