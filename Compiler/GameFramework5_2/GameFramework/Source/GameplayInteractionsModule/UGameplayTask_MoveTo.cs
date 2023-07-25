#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_MoveTo.h")]
public partial class UGameplayTask_MoveTo : UGameplayTask {
// GameplayTask_MoveTo
	public UObject MoveTo(UObject Actor,FVector GoalLocation,UObject GoalActor/*=nullptr*/,EGameplayTaskMoveToIntent EndOfPathIntent/*=EGameplayTaskMoveToIntent.Stop*/,float AcceptanceRadius/*=-1.0f*/,EAIOptionFlag StopOnOverlap/*=EAIOptionFlag.Default*/,EAIOptionFlag AcceptPartialPath/*=EAIOptionFlag.Default*/,bool bUsePathfinding/*=true*/,bool bUseContinuousGoalTracking/*=false*/,EAIOptionFlag ProjectGoalOnNavigation/*=EAIOptionFlag.Default*/) { return default; }
	public FGenericGameplayTaskDelegate OnRequestFailed;
	public FGameplayTaskActuationCompleted OnCompleted;
	public UCharacterMovementComponent MovementComponent;
	public UGameplayActuationComponent ActuationComponent;
	public FAIMoveRequest MoveRequest;
	public UGameplayTask StartTransitionTask;
	public UGameplayTask EndTransitionTask;
}
