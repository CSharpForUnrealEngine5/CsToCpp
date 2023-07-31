#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayInteractionsTypes.h")]
///<summary>Value specifying when a State Tree task based modification should take place.</summary>
public enum EGameplayInteractionTaskModify {
	OnEnterStateUndoOnExitState=0,
	OnEnterState=1,
	OnExitState=2,
	OnExitStateFailed=3,
	OnExitStateSucceeded=4,
}
