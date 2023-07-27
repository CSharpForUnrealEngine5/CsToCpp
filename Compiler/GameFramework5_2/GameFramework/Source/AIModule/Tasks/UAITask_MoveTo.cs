#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/AITask_MoveTo.h")]
public partial class UAITask_MoveTo : UAITask {
// AITask_MoveTo
	public static UAITask_MoveTo AIMoveTo(AAIController Controller,FVector GoalLocation,AActor GoalActor/*=nullptr*/,float AcceptanceRadius/*=-1.0f*/,EAIOptionFlag StopOnOverlap/*=EAIOptionFlag.Default*/,EAIOptionFlag AcceptPartialPath/*=EAIOptionFlag.Default*/,bool bUsePathfinding/*=true*/,bool bLockAILogic/*=true*/,bool bUseContinuousGoalTracking/*=false*/,EAIOptionFlag ProjectGoalOnNavigation/*=EAIOptionFlag.Default*/) { return default; }
	public FGenericGameplayTaskDelegate OnRequestFailed;
	public FMoveTaskCompletedSignature OnMoveFinished;
	public FAIMoveRequest MoveRequest;
}
