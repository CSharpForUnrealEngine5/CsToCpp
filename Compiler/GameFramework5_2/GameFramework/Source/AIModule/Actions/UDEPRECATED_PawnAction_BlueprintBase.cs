#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnAction_BlueprintBase.h")]
public partial class UDEPRECATED_PawnAction_BlueprintBase : UDEPRECATED_PawnAction {
	///<summary>Blueprint interface</summary>
	public  void ActionStart(APawn ControlledPawn) {}
	///<summary>ActionTick</summary>
	public  void ActionTick(APawn ControlledPawn,float DeltaSeconds) {}
	///<summary>ActionPause</summary>
	public  void ActionPause(APawn ControlledPawn) {}
	///<summary>ActionResume</summary>
	public  void ActionResume(APawn ControlledPawn) {}
	///<summary>ActionFinished</summary>
	public  void ActionFinished(APawn ControlledPawn,EPawnActionResult WithResult) {}
}
