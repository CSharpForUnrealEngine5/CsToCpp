namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for blueprint based task nodes. Do NOT use it for creating native c++ classes!</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_BlueprintBase.h")]
public partial class UBTTask_BlueprintBase : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>Cached AIController owner of BehaviorTreeComponent.</summary>
	public AAIController AIOwner;
	///<summary>Cached actor owner of BehaviorTreeComponent.</summary>
	public AActor ActorOwner;
	///<summary>If any of the Tick functions is implemented, how often should they be ticked.</summary>
	public FIntervalCountdown TickInterval;
	///<summary>CustomDescription</summary>
	public string CustomDescription;
	///<summary>show detailed information about properties</summary>
	public bool bShowPropertyDetails;
	///<summary>entry point, task will stay active until FinishExecute is called.</summary>
	public void ReceiveExecute(AActor OwnerActor) {}
	///<summary>if blueprint graph contains this event, task will stay active until FinishAbort is called</summary>
	public void ReceiveAbort(AActor OwnerActor) {}
	///<summary>tick function</summary>
	public void ReceiveTick(AActor OwnerActor,float DeltaSeconds) {}
	///<summary>Alternative AI version of ReceiveExecute</summary>
	public void ReceiveExecuteAI(AAIController OwnerController,APawn ControlledPawn) {}
	///<summary>Alternative AI version of ReceiveAbort</summary>
	public void ReceiveAbortAI(AAIController OwnerController,APawn ControlledPawn) {}
	///<summary>Alternative AI version of tick function.</summary>
	public void ReceiveTickAI(AAIController OwnerController,APawn ControlledPawn,float DeltaSeconds) {}
	///<summary>finishes task execution with Success or Fail result</summary>
	public void FinishExecute(bool bSuccess) {}
	///<summary>aborts task execution</summary>
	public void FinishAbort() {}
	///<summary>task execution will be finished (with result &#39;Success&#39;) after receiving specified message</summary>
	public void SetFinishOnMessage(FName MessageName) {}
	///<summary>task execution will be finished (with result &#39;Success&#39;) after receiving specified message with indicated ID</summary>
	public void SetFinishOnMessageWithId(FName MessageName,int RequestID/*=-1*/) {}
	///<summary>check if task is currently being executed</summary>
	public bool IsTaskExecuting() { return default; }
	///<summary>check if task is currently being aborted</summary>
	public bool IsTaskAborting() { return default; }
}
