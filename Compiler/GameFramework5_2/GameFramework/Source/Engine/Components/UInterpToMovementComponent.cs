#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Move the root component between a series of points over a given time *</summary>
[CppInclude("Components/InterpToMovementComponent.h")]
public partial class UInterpToMovementComponent : UMovementComponent {
	///<summary>FOnInterpToReverseDelegate</summary>
	public  void FOnInterpToReverseDelegate(FHitResult ImpactResult,float Time) {}
	///<summary>FOnInterpToStopDelegate</summary>
	public  void FOnInterpToStopDelegate(FHitResult ImpactResult,float Time) {}
	///<summary>FOnInterpToWaitBeginDelegate</summary>
	public  void FOnInterpToWaitBeginDelegate(FHitResult ImpactResult,float Time) {}
	///<summary>FOnInterpToWaitEndDelegate</summary>
	public  void FOnInterpToWaitEndDelegate(FHitResult ImpactResult,float Time) {}
	///<summary>FOnInterpToResetDelegate</summary>
	public  void FOnInterpToResetDelegate(FHitResult ImpactResult,float Time) {}
	///<summary>How long to take to move from the first point to the last (or vice versa)</summary>
	public float Duration;
	///<summary>If true, will pause movement on impact. If false it will behave as if the end of the movement range was reached based on the BehaviourType.</summary>
	public bool bPauseOnImpact;
	///<summary>If true, will sweep for blocking collision during movement. If false, it will simply teleport to the next position and ignore collision.</summary>
	public bool bSweep;
	///<summary>Physics teleport type.</summary>
	public ETeleportType TeleportType;
	///<summary>Movement behaviour of the component</summary>
	public EInterpToBehaviourType BehaviourType;
	///<summary>Do we want this comp to perform CheckStillInWorld checks?</summary>
	public bool bCheckIfStillInWorld;
	///<summary>If true, forces sub-stepping to break up movement into discrete smaller steps to improve accuracy of the trajectory.</summary>
	public bool bForceSubStepping;
	///<summary>Called when InterpTo impacts something and reverse is enabled.</summary>
	public FOnInterpToReverseDelegate OnInterpToReverse;
	///<summary>Called when InterpTo has come to a stop.</summary>
	public FOnInterpToStopDelegate OnInterpToStop;
	///<summary>Called when InterpTo has come to a stop but will resume when possible.</summary>
	public FOnInterpToWaitBeginDelegate OnWaitBeginDelegate;
	///<summary>Called when InterpTo has resumed following a stop.</summary>
	public FOnInterpToWaitEndDelegate OnWaitEndDelegate;
	///<summary>Called when InterpTo reached the end and reset back to start .</summary>
	public FOnInterpToResetDelegate OnResetDelegate;
	///<summary>Clears the reference to UpdatedComponent, fires stop event, and stops ticking.</summary>
	public  void StopSimulating(FHitResult HitResult) {}
	///<summary>Max time delta for each discrete simulation step.</summary>
	public float MaxSimulationTimeStep;
	///<summary>Max number of iterations used for each discrete simulation step.</summary>
	public int MaxSimulationIterations;
	///<summary>List of control points to visit.</summary>
	public TArray<FInterpControlPoint> ControlPoints;
	///<summary>Add a control point that represents a position.</summary>
	public  void AddControlPointPosition(FVector Pos,bool bPositionIsRelative/*=true*/) {}
	///<summary>Reset to start. Sets time to zero and direction to 1.</summary>
	public  void RestartMovement(float InitialDirection/*=1.0f*/) {}
	///<summary>Initialise the control points array. Call after adding control points if they are add after begin play .</summary>
	public  void FinaliseControlPoints() {}
	///<summary>Clear the control points array and set to stopped.</summary>
	public  void ResetControlPoints() {}
}
