#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayInteractionsTypes.h")]
///<summary>Value specifying when a State Tree task based action should be triggered.</summary>
public enum EGameplayInteractionTaskTrigger {
	OnEnterState=0,
	OnExitState=1,
	OnExitStateSucceeded=2,
	OnExitStateFailed=3,
}
