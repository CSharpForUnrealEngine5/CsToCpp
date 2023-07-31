#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A library of commonly used functionality for Notifies related to state machines, exposed to blueprint.</summary>
[CppInclude("Animation/AnimNotifyStateMachineInspectionLibrary.h")]
public partial class UAnimNotifyStateMachineInspectionLibrary : UBlueprintFunctionLibrary {
	///<summary>Get whether the notify was triggered from the specified state machine</summary>
	public static bool IsTriggeredByStateMachine(FAnimNotifyEventReference EventReference,UAnimInstance AnimInstance,string StateMachineName) { return default; }
	///<summary>Get whether a particular state in a specific state machine triggered the notify</summary>
	public static bool IsTriggeredByStateInStateMachine(FAnimNotifyEventReference EventReference,UAnimInstance AnimInstance,string StateMachineName,string StateName) { return default; }
	///<summary>Get whether a state with the given name in any state machine triggered the notify</summary>
	public static bool IsTriggeredByState(FAnimNotifyEventReference EventReference,UAnimInstance AnimInstance,string StateName) { return default; }
}
