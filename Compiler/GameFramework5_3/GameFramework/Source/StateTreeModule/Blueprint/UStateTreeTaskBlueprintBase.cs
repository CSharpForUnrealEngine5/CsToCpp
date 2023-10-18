namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for Blueprint based Tasks.</summary>
[CppInclude("Blueprint/StateTreeTaskBlueprintBase.h")]
public partial class UStateTreeTaskBlueprintBase : UStateTreeNodeBlueprintBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when a new state is entered and task is part of active states.</summary>
	public void ReceiveLatentEnterState(FStateTreeTransitionResult Transition) {}
	///<summary>Called when a current state is exited and task is part of active states.</summary>
	public void ReceiveExitState(FStateTreeTransitionResult Transition) {}
	///<summary>Called right after a state has been completed, but before new state has been selected. StateCompleted is called in reverse order to allow to propagate state to other Tasks that</summary>
	public void ReceiveStateCompleted(EStateTreeRunStatus CompletionStatus,FStateTreeActiveStates CompletedActiveStates) {}
	///<summary>Called during state tree tick when the task is on active state.</summary>
	public void ReceiveLatentTick(float DeltaTime) {}
	///<summary>ReceiveEnterState</summary>
	public EStateTreeRunStatus ReceiveEnterState(FStateTreeTransitionResult Transition) { return default; }
	///<summary>ReceiveTick</summary>
	public EStateTreeRunStatus ReceiveTick(float DeltaTime) { return default; }
	///<summary>Finish the task and sets it&#39;s status.</summary>
	public void FinishTask(bool bSucceeded/*=true*/) {}
	///<summary>If set to true, the task will receive EnterState/ExitState even if the state was previously active.</summary>
	public bool bShouldStateChangeOnReselect;
	///<summary>If set to true, Tick() is called. Default false.</summary>
	public bool bShouldCallTickOnlyOnEvents;
	///<summary>If set to true, copy the values of bound properties before calling Tick(). Default true.</summary>
	public bool bShouldCopyBoundPropertiesOnTick;
	///<summary>If set to true, copy the values of bound properties before calling ExitState(). Default true.</summary>
	public bool bShouldCopyBoundPropertiesOnExitState;
}
