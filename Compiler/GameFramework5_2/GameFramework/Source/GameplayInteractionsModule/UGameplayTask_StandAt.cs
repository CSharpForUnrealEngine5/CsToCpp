#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_StandAt.h")]
public partial class UGameplayTask_StandAt : UGameplayTask {
	///<summary>StandAt</summary>
	public static UGameplayTask_StandAt StandAt(APawn Pawn,float Duration) { return default; }
	///<summary>OnRequestFailed</summary>
	public FGenericGameplayTaskDelegate OnRequestFailed;
	///<summary>OnCompleted</summary>
	public FGameplayTaskActuationCompleted OnCompleted;
	///<summary>MovementComponent</summary>
	public UCharacterMovementComponent MovementComponent;
}
