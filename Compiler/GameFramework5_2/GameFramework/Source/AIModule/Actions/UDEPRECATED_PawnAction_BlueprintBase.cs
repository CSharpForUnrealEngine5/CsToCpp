#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnAction_BlueprintBase.h")]
public partial class UDEPRECATED_PawnAction_BlueprintBase : UDEPRECATED_PawnAction {
// PawnAction_BlueprintBase
	public void ActionStart(UObject ControlledPawn) {}
	public void ActionTick(UObject ControlledPawn,float DeltaSeconds) {}
	public void ActionPause(UObject ControlledPawn) {}
	public void ActionResume(UObject ControlledPawn) {}
	public void ActionFinished(UObject ControlledPawn,EPawnActionResult WithResult) {}
}
