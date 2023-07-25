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
	public void ReceiveTick(UObject OwnerActor,float DeltaSeconds) {}
	public void ReceiveExecutionStart(UObject OwnerActor) {}
	public void ReceiveExecutionFinish(UObject OwnerActor,EBTNodeResult NodeResult) {}
	public void ReceiveObserverActivated(UObject OwnerActor) {}
	public void ReceiveObserverDeactivated(UObject OwnerActor) {}
	public bool PerformConditionCheck(UObject OwnerActor) { return default; }
	public void ReceiveTickAI(UObject OwnerController,UObject ControlledPawn,float DeltaSeconds) {}
	public void ReceiveExecutionStartAI(UObject OwnerController,UObject ControlledPawn) {}
	public void ReceiveExecutionFinishAI(UObject OwnerController,UObject ControlledPawn,EBTNodeResult NodeResult) {}
	public void ReceiveObserverActivatedAI(UObject OwnerController,UObject ControlledPawn) {}
	public void ReceiveObserverDeactivatedAI(UObject OwnerController,UObject ControlledPawn) {}
	public bool PerformConditionCheckAI(UObject OwnerController,UObject ControlledPawn) { return default; }
	public bool IsDecoratorExecutionActive() { return default; }
	public bool IsDecoratorObserverActive() { return default; }
}
