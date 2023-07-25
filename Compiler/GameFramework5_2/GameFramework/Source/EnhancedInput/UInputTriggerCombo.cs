#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputTriggers.h")]
///<summary>UInputTriggerCombo</summary>
public partial class UInputTriggerCombo : UInputTrigger {
// InputTriggerCombo
	public int CurrentComboStepIndex;
	public float CurrentTimeBetweenComboSteps;
	public TArray<FInputComboStepData> ComboActions;
	public TArray<FInputCancelAction> InputCancelActions;
}
