#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifyStateMachineInspectionLibrary.h")]
///<summary>A library of commonly used functionality for Notifies related to state machines, exposed to blueprint.</summary>
public partial class UAnimNotifyStateMachineInspectionLibrary : UBlueprintFunctionLibrary {
// AnimNotifyStateMachineInspectionLibrary
	public static bool IsTriggeredByStateMachine(FAnimNotifyEventReference EventReference,UAnimInstance AnimInstance,string StateMachineName) { return default; }
	public static bool IsTriggeredByStateInStateMachine(FAnimNotifyEventReference EventReference,UAnimInstance AnimInstance,string StateMachineName,string StateName) { return default; }
	public static bool IsTriggeredByState(FAnimNotifyEventReference EventReference,UAnimInstance AnimInstance,string StateName) { return default; }
}
