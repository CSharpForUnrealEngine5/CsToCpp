#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct representing the definition of a custom execution for a gameplay effect.</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectExecutionDefinition {
	public UClass CalculationClass;
	public FGameplayTagContainer PassedInTags;
	public TArray<FGameplayEffectExecutionScopedModifierInfo> CalculationModifiers;
	public TArray<UClass> ConditionalGameplayEffectClasses_DEPRECATED;
	public TArray<FConditionalGameplayEffect> ConditionalGameplayEffects;
}
