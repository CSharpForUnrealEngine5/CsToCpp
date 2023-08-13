namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for Blueprint based Tasks.</summary>
[CppInclude("Blueprint/StateTreeTaskBlueprintBase.h")]
public partial class UStateTreeTaskBlueprintBase : UStateTreeNodeBlueprintBase {
	public static UClass StaticClass() {return default;}
	///<summary>ReceiveEnterState</summary>
	public EStateTreeRunStatus ReceiveEnterState(FStateTreeTransitionResult Transition) { return default; }
	///<summary>ReceiveExitState</summary>
	public void ReceiveExitState(FStateTreeTransitionResult Transition) {}
	///<summary>ReceiveStateCompleted</summary>
	public void ReceiveStateCompleted(EStateTreeRunStatus CompletionStatus,FStateTreeActiveStates CompletedActiveStates) {}
	///<summary>ReceiveTick</summary>
	public EStateTreeRunStatus ReceiveTick(float DeltaTime) { return default; }
	///<summary>If set to true, the task will receive EnterState/ExitState even if the state was previously active.</summary>
	public bool bShouldStateChangeOnReselect;
	///<summary>If set to true, Tick() is called. Default false.</summary>
	public bool bShouldCallTickOnlyOnEvents;
	///<summary>If set to true, copy the values of bound properties before calling Tick(). Default true.</summary>
	public bool bShouldCopyBoundPropertiesOnTick;
	///<summary>If set to true, copy the values of bound properties before calling ExitState(). Default true.</summary>
	public bool bShouldCopyBoundPropertiesOnExitState;
}
