#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_MoveTo.h")]
public partial class UGameplayTask_MoveTo : UGameplayTask {
	///<summary>MoveTo</summary>
	public static UGameplayTask_MoveTo MoveTo(AActor Actor,FVector GoalLocation,AActor GoalActor/*=nullptr*/,EGameplayTaskMoveToIntent EndOfPathIntent/*=EGameplayTaskMoveToIntent.Stop*/,float AcceptanceRadius/*=-1.0f*/,EAIOptionFlag StopOnOverlap/*=EAIOptionFlag.Default*/,EAIOptionFlag AcceptPartialPath/*=EAIOptionFlag.Default*/,bool bUsePathfinding/*=true*/,bool bUseContinuousGoalTracking/*=false*/,EAIOptionFlag ProjectGoalOnNavigation/*=EAIOptionFlag.Default*/) { return default; }
	///<summary>OnRequestFailed</summary>
	public FGenericGameplayTaskDelegate OnRequestFailed;
	///<summary>OnCompleted</summary>
	public FGameplayTaskActuationCompleted OnCompleted;
	///<summary>MovementComponent</summary>
	public UCharacterMovementComponent MovementComponent;
	///<summary>ActuationComponent</summary>
	public UGameplayActuationComponent ActuationComponent;
	///<summary>parameters of move request</summary>
	public FAIMoveRequest MoveRequest;
	///<summary>StartTransitionTask</summary>
	public UGameplayTask StartTransitionTask;
	///<summary>EndTransitionTask</summary>
	public UGameplayTask EndTransitionTask;
}
