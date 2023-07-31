#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputTriggerCombo</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTriggerCombo : UInputTrigger {
	///<summary>Keeps track of what action we&#39;re currently at in the combo</summary>
	public int CurrentComboStepIndex;
	///<summary>Time elapsed between last combo InputAction trigger and current time</summary>
	public float CurrentTimeBetweenComboSteps;
	///<summary>List of input actions that need to be completed (according to Combo Step Completion States) to trigger this action.</summary>
	public TArray<FInputComboStepData> ComboActions;
	///<summary>Actions that will cancel the combo if they are completed (according to Cancellation States)</summary>
	public TArray<FInputCancelAction> InputCancelActions;
}
