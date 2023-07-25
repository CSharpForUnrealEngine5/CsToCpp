#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectExecutionCalculation.h")]
///<summary>Struct representing the output of a custom gameplay effect execution.</summary>
public partial struct FGameplayEffectCustomExecutionOutput {
// GameplayEffectCustomExecutionOutput
	public TArray<FGameplayModifierEvaluatedData> OutputModifiers;
	public bool bTriggerConditionalGameplayEffects;
	public bool bHandledStackCountManually;
	public bool bHandledGameplayCuesManually;
}
