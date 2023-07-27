#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_StandAt.h")]
public partial class UGameplayTask_StandAt : UGameplayTask {
// GameplayTask_StandAt
	public static UGameplayTask_StandAt StandAt(APawn Pawn,float Duration) { return default; }
	public FGenericGameplayTaskDelegate OnRequestFailed;
	public FGameplayTaskActuationCompleted OnCompleted;
	public UCharacterMovementComponent MovementComponent;
}
