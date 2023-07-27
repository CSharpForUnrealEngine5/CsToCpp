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
	public  void ReceiveTick(AActor OwnerActor,float DeltaSeconds) {}
	public  void ReceiveSearchStart(AActor OwnerActor) {}
	public  void ReceiveActivation(AActor OwnerActor) {}
	public  void ReceiveDeactivation(AActor OwnerActor) {}
	public  void ReceiveTickAI(AAIController OwnerController,APawn ControlledPawn,float DeltaSeconds) {}
	public  void ReceiveSearchStartAI(AAIController OwnerController,APawn ControlledPawn) {}
	public  void ReceiveActivationAI(AAIController OwnerController,APawn ControlledPawn) {}
	public  void ReceiveDeactivationAI(AAIController OwnerController,APawn ControlledPawn) {}
	public  bool IsServiceActive() { return default; }
}
