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
