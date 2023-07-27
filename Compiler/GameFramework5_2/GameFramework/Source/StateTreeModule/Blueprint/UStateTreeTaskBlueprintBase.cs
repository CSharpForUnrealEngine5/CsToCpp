#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/StateTreeTaskBlueprintBase.h")]
///<summary>* Base class for Blueprint based Tasks.</summary>
public partial class UStateTreeTaskBlueprintBase : UStateTreeNodeBlueprintBase {
// StateTreeTaskBlueprintBase
	public  EStateTreeRunStatus ReceiveEnterState(FStateTreeTransitionResult Transition) { return default; }
	public  void ReceiveExitState(FStateTreeTransitionResult Transition) {}
	public  void ReceiveStateCompleted(EStateTreeRunStatus CompletionStatus,FStateTreeActiveStates CompletedActiveStates) {}
	public  EStateTreeRunStatus ReceiveTick(float DeltaTime) { return default; }
	public bool bShouldStateChangeOnReselect;
	public bool bShouldCallTickOnlyOnEvents;
	public bool bShouldCopyBoundPropertiesOnTick;
	public bool bShouldCopyBoundPropertiesOnExitState;
}
