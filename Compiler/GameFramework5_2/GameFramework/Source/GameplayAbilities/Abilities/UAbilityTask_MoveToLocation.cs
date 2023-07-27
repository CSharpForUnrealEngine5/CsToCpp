#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_MoveToLocation.h")]
///<summary>Move to a location, ignoring clipping, over a given length of time. Ends when the TargetLocation is reached.</summary>
public partial class UAbilityTask_MoveToLocation : UAbilityTask {
// AbilityTask_MoveToLocation
	public FMoveToLocationDelegate OnTargetLocationReached;
	public static UAbilityTask_MoveToLocation MoveToLocation(UGameplayAbility OwningAbility,string TaskInstanceName,FVector Location,float Duration,UCurveFloat OptionalInterpolationCurve,UCurveVector OptionalVectorInterpolationCurve) { return default; }
	public FVector StartLocation;
	public FVector TargetLocation;
	public float DurationOfMovement;
	public UCurveFloat LerpCurve;
	public UCurveVector LerpCurveVector;
}
