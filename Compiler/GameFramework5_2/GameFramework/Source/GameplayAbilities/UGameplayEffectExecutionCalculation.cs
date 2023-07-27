#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectExecutionCalculation.h")]
public partial class UGameplayEffectExecutionCalculation : UGameplayEffectCalculation {
// GameplayEffectExecutionCalculation
	public bool bRequiresPassedInTags;
	public TArray<FGameplayEffectAttributeCaptureDefinition> InvalidScopedModifierAttributes;
	public FGameplayTagContainer ValidTransientAggregatorIdentifiers;
	public  void Execute(FGameplayEffectCustomExecutionParameters ExecutionParams,FGameplayEffectCustomExecutionOutput OutExecutionOutput) {}
}
