#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnAction_BlueprintBase.h")]
public partial class UDEPRECATED_PawnAction_BlueprintBase : UDEPRECATED_PawnAction {
// PawnAction_BlueprintBase
	public  void ActionStart(APawn ControlledPawn) {}
	public  void ActionTick(APawn ControlledPawn,float DeltaSeconds) {}
	public  void ActionPause(APawn ControlledPawn) {}
	public  void ActionResume(APawn ControlledPawn) {}
	public  void ActionFinished(APawn ControlledPawn,EPawnActionResult WithResult) {}
}
