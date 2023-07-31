#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct representing the output of a custom gameplay effect execution.</summary>
[CppInclude("GameplayEffectExecutionCalculation.h")]
public partial struct FGameplayEffectCustomExecutionOutput {
	public TArray<FGameplayModifierEvaluatedData> OutputModifiers;
	public bool bTriggerConditionalGameplayEffects;
	public bool bHandledStackCountManually;
	public bool bHandledGameplayCuesManually;
}
