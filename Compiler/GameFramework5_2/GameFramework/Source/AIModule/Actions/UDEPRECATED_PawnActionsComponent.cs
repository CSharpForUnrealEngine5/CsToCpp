#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnActionsComponent.h")]
public partial class UDEPRECATED_PawnActionsComponent : UActorComponent {
// PawnActionsComponent
	public APawn ControlledPawn;
	public TArray<FPawnActionStack> ActionStacks;
	public TArray<FPawnActionEvent> ActionEvents;
	public UDEPRECATED_PawnAction CurrentAction_DEPRECATED;
	public static bool K2_PerformAction(APawn Pawn,UDEPRECATED_PawnAction Action,EAIRequestPriority Priority/*=EAIRequestPriority.HardScript*/) { return default; }
	public  bool K2_PushAction(UDEPRECATED_PawnAction NewAction,EAIRequestPriority Priority,UObject Instigator/*=NULL*/) { return default; }
	public  EPawnActionAbortState K2_AbortAction(UDEPRECATED_PawnAction ActionToAbort) { return default; }
	public  EPawnActionAbortState K2_ForceAbortAction(UDEPRECATED_PawnAction ActionToAbort) { return default; }
}
