namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for blueprint based decorator nodes. Do NOT use it for creating native c++ classes!</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_BlueprintBase.h")]
public partial class UBTDecorator_BlueprintBase : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>Cached AIController owner of BehaviorTreeComponent.</summary>
	public AAIController AIOwner;
	///<summary>Cached AIController owner of BehaviorTreeComponent.</summary>
	public AActor ActorOwner;
	///<summary>blackboard key names that should be observed</summary>
	public TArray<string> ObservedKeyNames;
	///<summary>CustomDescription</summary>
	public string CustomDescription;
	///<summary>show detailed information about properties</summary>
	public bool bShowPropertyDetails;
	///<summary>Applies only if Decorator has any FBlackboardKeySelector property and if decorator is</summary>
	public bool bCheckConditionOnlyBlackBoardChanges;
	///<summary>gets set to true if decorator declared BB keys it can potentially observe</summary>
	public bool bIsObservingBB;
	///<summary>tick function</summary>
	public void ReceiveTick(AActor OwnerActor,float DeltaSeconds) {}
	///<summary>called on execution of underlying node</summary>
	public void ReceiveExecutionStart(AActor OwnerActor) {}
	///<summary>called when execution of underlying node is finished</summary>
	public void ReceiveExecutionFinish(AActor OwnerActor,EBTNodeResult NodeResult) {}
	///<summary>called when observer is activated (flow controller)</summary>
	public void ReceiveObserverActivated(AActor OwnerActor) {}
	///<summary>called when observer is deactivated (flow controller)</summary>
	public void ReceiveObserverDeactivated(AActor OwnerActor) {}
	///<summary>called when testing if underlying node can be executed, must call FinishConditionCheck</summary>
	public bool PerformConditionCheck(AActor OwnerActor) { return default; }
	///<summary>Alternative AI version of ReceiveTick</summary>
	public void ReceiveTickAI(AAIController OwnerController,APawn ControlledPawn,float DeltaSeconds) {}
	///<summary>Alternative AI version of ReceiveExecutionStart</summary>
	public void ReceiveExecutionStartAI(AAIController OwnerController,APawn ControlledPawn) {}
	///<summary>Alternative AI version of ReceiveExecutionFinish</summary>
	public void ReceiveExecutionFinishAI(AAIController OwnerController,APawn ControlledPawn,EBTNodeResult NodeResult) {}
	///<summary>Alternative AI version of ReceiveObserverActivated</summary>
	public void ReceiveObserverActivatedAI(AAIController OwnerController,APawn ControlledPawn) {}
	///<summary>Alternative AI version of ReceiveObserverDeactivated</summary>
	public void ReceiveObserverDeactivatedAI(AAIController OwnerController,APawn ControlledPawn) {}
	///<summary>Alternative AI version of ReceiveConditionCheck</summary>
	public bool PerformConditionCheckAI(AAIController OwnerController,APawn ControlledPawn) { return default; }
	///<summary>check if decorator is part of currently active branch</summary>
	public bool IsDecoratorExecutionActive() { return default; }
	///<summary>check if decorator&#39;s observer is currently active</summary>
	public bool IsDecoratorObserverActive() { return default; }
}
