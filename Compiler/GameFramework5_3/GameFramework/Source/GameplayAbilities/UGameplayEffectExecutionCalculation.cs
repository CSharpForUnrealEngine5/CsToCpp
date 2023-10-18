namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectExecutionCalculation.h")]
public partial class UGameplayEffectExecutionCalculation : UGameplayEffectCalculation {
	public static UClass StaticClass() {return default;}
	///<summary>Used to indicate if this execution uses Passed In Tags</summary>
	public bool bRequiresPassedInTags;
	///<summary>Any attribute in this list will not show up as a valid option for scoped modifiers; Used to allow attribute capture for internal calculation while preventing modification</summary>
	public TArray<FGameplayEffectAttributeCaptureDefinition> InvalidScopedModifierAttributes;
	///<summary>Any tag in this container will show up as a valid &quot;temporary variable&quot; for scoped modifiers; Used to allow for data-driven variable support that doesn&#39;t rely on scoped modifiers</summary>
	public FGameplayTagContainer ValidTransientAggregatorIdentifiers;
	///<summary>Called whenever the owning gameplay effect is executed. Allowed to do essentially whatever is desired, including generating new</summary>
	public void Execute(FGameplayEffectCustomExecutionParameters ExecutionParams,FGameplayEffectCustomExecutionOutput OutExecutionOutput) {}
}
