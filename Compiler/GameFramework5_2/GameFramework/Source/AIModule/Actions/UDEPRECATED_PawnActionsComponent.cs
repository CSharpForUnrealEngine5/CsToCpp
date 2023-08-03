#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnActionsComponent.h")]
public partial class UDEPRECATED_PawnActionsComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>ControlledPawn</summary>
	public APawn ControlledPawn;
	///<summary>ActionStacks</summary>
	public TArray<FPawnActionStack> ActionStacks;
	///<summary>ActionEvents</summary>
	public TArray<FPawnActionEvent> ActionEvents;
	///<summary>CurrentAction_DEPRECATED</summary>
	public UDEPRECATED_PawnAction CurrentAction_DEPRECATED;
	///<summary>blueprint interface</summary>
	public static bool K2_PerformAction(APawn Pawn,UDEPRECATED_PawnAction Action,EAIRequestPriority Priority/*=EAIRequestPriority.HardScript*/) { return default; }
	///<summary>K2_PushAction</summary>
	public  bool K2_PushAction(UDEPRECATED_PawnAction NewAction,EAIRequestPriority Priority,UObject Instigator/*=NULL*/) { return default; }
	///<summary>Aborts given action instance</summary>
	public  EPawnActionAbortState K2_AbortAction(UDEPRECATED_PawnAction ActionToAbort) { return default; }
	///<summary>Aborts given action instance</summary>
	public  EPawnActionAbortState K2_ForceAbortAction(UDEPRECATED_PawnAction ActionToAbort) { return default; }
}
