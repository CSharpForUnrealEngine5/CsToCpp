#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_BlueprintBase.h")]
///<summary>Base class for blueprint based decorator nodes. Do NOT use it for creating native c++ classes!</summary>
public partial class UBTDecorator_BlueprintBase : UBTDecorator {
// BTDecorator_BlueprintBase
	public AAIController AIOwner;
	public AActor ActorOwner;
	public TArray<string> ObservedKeyNames;
	public string CustomDescription;
	public bool bShowPropertyDetails;
	public bool bCheckConditionOnlyBlackBoardChanges;
	public bool bIsObservingBB;
	public  void ReceiveTick(AActor OwnerActor,float DeltaSeconds) {}
	public  void ReceiveExecutionStart(AActor OwnerActor) {}
	public  void ReceiveExecutionFinish(AActor OwnerActor,EBTNodeResult NodeResult) {}
	public  void ReceiveObserverActivated(AActor OwnerActor) {}
	public  void ReceiveObserverDeactivated(AActor OwnerActor) {}
	public  bool PerformConditionCheck(AActor OwnerActor) { return default; }
	public  void ReceiveTickAI(AAIController OwnerController,APawn ControlledPawn,float DeltaSeconds) {}
	public  void ReceiveExecutionStartAI(AAIController OwnerController,APawn ControlledPawn) {}
	public  void ReceiveExecutionFinishAI(AAIController OwnerController,APawn ControlledPawn,EBTNodeResult NodeResult) {}
	public  void ReceiveObserverActivatedAI(AAIController OwnerController,APawn ControlledPawn) {}
	public  void ReceiveObserverDeactivatedAI(AAIController OwnerController,APawn ControlledPawn) {}
	public  bool PerformConditionCheckAI(AAIController OwnerController,APawn ControlledPawn) { return default; }
	public  bool IsDecoratorExecutionActive() { return default; }
	public  bool IsDecoratorObserverActive() { return default; }
}
