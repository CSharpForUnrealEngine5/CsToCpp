#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/InterpToMovementComponent.h")]
///<summary>Move the root component between a series of points over a given time *</summary>
public partial class UInterpToMovementComponent : UMovementComponent {
// InterpToMovementComponent
	public  void FOnInterpToReverseDelegate(FHitResult ImpactResult,float Time) {}
	public  void FOnInterpToStopDelegate(FHitResult ImpactResult,float Time) {}
	public  void FOnInterpToWaitBeginDelegate(FHitResult ImpactResult,float Time) {}
	public  void FOnInterpToWaitEndDelegate(FHitResult ImpactResult,float Time) {}
	public  void FOnInterpToResetDelegate(FHitResult ImpactResult,float Time) {}
	public float Duration;
	public bool bPauseOnImpact;
	public bool bSweep;
	public ETeleportType TeleportType;
	public EInterpToBehaviourType BehaviourType;
	public bool bCheckIfStillInWorld;
	public bool bForceSubStepping;
	public FOnInterpToReverseDelegate OnInterpToReverse;
	public FOnInterpToStopDelegate OnInterpToStop;
	public FOnInterpToWaitBeginDelegate OnWaitBeginDelegate;
	public FOnInterpToWaitEndDelegate OnWaitEndDelegate;
	public FOnInterpToResetDelegate OnResetDelegate;
	public  void StopSimulating(FHitResult HitResult) {}
	public float MaxSimulationTimeStep;
	public int MaxSimulationIterations;
	public TArray<FInterpControlPoint> ControlPoints;
	public  void AddControlPointPosition(FVector Pos,bool bPositionIsRelative/*=true*/) {}
	public  void RestartMovement(float InitialDirection/*=1.0f*/) {}
	public  void FinaliseControlPoints() {}
	public  void ResetControlPoints() {}
}
