namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Move to a location, ignoring clipping, over a given length of time. Ends when the TargetLocation is reached.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_MoveToLocation.h")]
public partial class UAbilityTask_MoveToLocation : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnTargetLocationReached</summary>
	public FMoveToLocationDelegate OnTargetLocationReached;
	///<summary>Move to the specified location, using the vector curve (range 0 - 1) if specified, otherwise the float curve (range 0 - 1) or fallback to linear interpolation</summary>
	public static UAbilityTask_MoveToLocation MoveToLocation(UGameplayAbility OwningAbility,string TaskInstanceName,FVector Location,float Duration,UCurveFloat OptionalInterpolationCurve,UCurveVector OptionalVectorInterpolationCurve) { return default; }
	///<summary>StartLocation</summary>
	public FVector StartLocation;
	///<summary>FVector</summary>
	public FVector TargetLocation;
	///<summary>DurationOfMovement</summary>
	public float DurationOfMovement;
	///<summary>LerpCurve</summary>
	public UCurveFloat LerpCurve;
	///<summary>LerpCurveVector</summary>
	public UCurveVector LerpCurveVector;
}
