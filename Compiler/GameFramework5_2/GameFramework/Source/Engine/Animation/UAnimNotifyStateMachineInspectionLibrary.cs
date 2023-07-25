#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifyStateMachineInspectionLibrary.h")]
///<summary>A library of commonly used functionality for Notifies related to state machines, exposed to blueprint.</summary>
public partial class UAnimNotifyStateMachineInspectionLibrary : UBlueprintFunctionLibrary {
// AnimNotifyStateMachineInspectionLibrary
	public bool IsTriggeredByStateMachine(FAnimNotifyEventReference EventReference,UObject AnimInstance,string StateMachineName) { return default; }
	public bool IsTriggeredByStateInStateMachine(FAnimNotifyEventReference EventReference,UObject AnimInstance,string StateMachineName,string StateName) { return default; }
	public bool IsTriggeredByState(FAnimNotifyEventReference EventReference,UObject AnimInstance,string StateName) { return default; }
}
