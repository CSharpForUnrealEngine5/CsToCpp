namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayInteractionsTypes.h")]
///<summary>Value specifying when a State Tree task based action should be triggered.</summary>
public enum EGameplayInteractionTaskTrigger {
	OnEnterState=0,
	OnExitState=1,
	OnExitStateFailed=2,
	OnExitStateSucceeded=3,
}
