#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for blueprint based service nodes. Do NOT use it for creating native c++ classes!</summary>
[CppInclude("BehaviorTree/Services/BTService_BlueprintBase.h")]
public partial class UBTService_BlueprintBase : UBTService {
	///<summary>Cached AIController owner of BehaviorTreeComponent.</summary>
	public AAIController AIOwner;
	///<summary>Cached actor owner of BehaviorTreeComponent.</summary>
	public AActor ActorOwner;
	///<summary>CustomDescription</summary>
	public string CustomDescription;
	///<summary>show detailed information about properties</summary>
	public bool bShowPropertyDetails;
	///<summary>show detailed information about implemented events</summary>
	public bool bShowEventDetails;
	///<summary>tick function</summary>
	public  void ReceiveTick(AActor OwnerActor,float DeltaSeconds) {}
	///<summary>task search enters branch of tree</summary>
	public  void ReceiveSearchStart(AActor OwnerActor) {}
	///<summary>service became active</summary>
	public  void ReceiveActivation(AActor OwnerActor) {}
	///<summary>service became inactive</summary>
	public  void ReceiveDeactivation(AActor OwnerActor) {}
	///<summary>Alternative AI version of ReceiveTick function.</summary>
	public  void ReceiveTickAI(AAIController OwnerController,APawn ControlledPawn,float DeltaSeconds) {}
	///<summary>Alternative AI version of ReceiveSearchStart function.</summary>
	public  void ReceiveSearchStartAI(AAIController OwnerController,APawn ControlledPawn) {}
	///<summary>Alternative AI version of ReceiveActivation function.</summary>
	public  void ReceiveActivationAI(AAIController OwnerController,APawn ControlledPawn) {}
	///<summary>Alternative AI version of ReceiveDeactivation function.</summary>
	public  void ReceiveDeactivationAI(AAIController OwnerController,APawn ControlledPawn) {}
	///<summary>check if service is currently being active</summary>
	public  bool IsServiceActive() { return default; }
}
