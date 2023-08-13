namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/AITask_MoveTo.h")]
public partial class UAITask_MoveTo : UAITask {
	public static UClass StaticClass() {return default;}
	///<summary>AIMoveTo</summary>
	public static UAITask_MoveTo AIMoveTo(AAIController Controller,FVector GoalLocation,AActor GoalActor/*=nullptr*/,float AcceptanceRadius/*=-1.0f*/,EAIOptionFlag StopOnOverlap/*=EAIOptionFlag.Default*/,EAIOptionFlag AcceptPartialPath/*=EAIOptionFlag.Default*/,bool bUsePathfinding/*=true*/,bool bLockAILogic/*=true*/,bool bUseContinuousGoalTracking/*=false*/,EAIOptionFlag ProjectGoalOnNavigation/*=EAIOptionFlag.Default*/) { return default; }
	///<summary>OnRequestFailed</summary>
	public FGenericGameplayTaskDelegate OnRequestFailed;
	///<summary>OnMoveFinished</summary>
	public FMoveTaskCompletedSignature OnMoveFinished;
	///<summary>parameters of move request</summary>
	public FAIMoveRequest MoveRequest;
}
