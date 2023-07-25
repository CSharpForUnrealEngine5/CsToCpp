#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Services/BTService_BlueprintBase.h")]
///<summary>Base class for blueprint based service nodes. Do NOT use it for creating native c++ classes!</summary>
public partial class UBTService_BlueprintBase : UBTService {
// BTService_BlueprintBase
	public AAIController AIOwner;
	public AActor ActorOwner;
	public string CustomDescription;
	public bool bShowPropertyDetails;
	public bool bShowEventDetails;
	public void ReceiveTick(UObject OwnerActor,float DeltaSeconds) {}
	public void ReceiveSearchStart(UObject OwnerActor) {}
	public void ReceiveActivation(UObject OwnerActor) {}
	public void ReceiveDeactivation(UObject OwnerActor) {}
	public void ReceiveTickAI(UObject OwnerController,UObject ControlledPawn,float DeltaSeconds) {}
	public void ReceiveSearchStartAI(UObject OwnerController,UObject ControlledPawn) {}
	public void ReceiveActivationAI(UObject OwnerController,UObject ControlledPawn) {}
	public void ReceiveDeactivationAI(UObject OwnerController,UObject ControlledPawn) {}
	public bool IsServiceActive() { return default; }
}
