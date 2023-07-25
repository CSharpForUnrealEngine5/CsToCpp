#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/ProjectileMovementComponent.h")]
///<summary>ProjectileMovementComponent updates the position of another component during its tick.</summary>
public partial class UProjectileMovementComponent : UMovementComponent {
// ProjectileMovementComponent
	public void FOnProjectileBounceDelegate(FHitResult ImpactResult,FVector ImpactVelocity) {}
	public void FOnProjectileStopDelegate(FHitResult ImpactResult) {}
	public float InitialSpeed;
	public float MaxSpeed;
	public bool bRotationFollowsVelocity;
	public bool bRotationRemainsVertical;
	public bool bShouldBounce;
	public bool bInitialVelocityInLocalSpace;
	public bool bForceSubStepping;
	public bool bSimulationEnabled;
	public bool bSweepCollision;
	public bool bIsHomingProjectile;
	public bool bBounceAngleAffectsFriction;
	public bool bIsSliding;
	public bool bInterpMovement;
	public bool bInterpRotation;
	public float PreviousHitTime;
	public FVector PreviousHitNormal;
	public float ProjectileGravityScale;
	public float Buoyancy;
	public float Bounciness;
	public float Friction;
	public float BounceVelocityStopSimulatingThreshold;
	public float MinFrictionFraction;
	public bool IsVelocityUnderSimulationThreshold() { return default; }
	public FOnProjectileBounceDelegate OnProjectileBounce;
	public FOnProjectileStopDelegate OnProjectileStop;
	public float HomingAccelerationMagnitude;
	public TWeakObjectPtr<USceneComponent> HomingTargetComponent;
	public void SetVelocityInLocalSpace(FVector NewVelocity) {}
	public void StopSimulating(FHitResult HitResult) {}
	public float MaxSimulationTimeStep;
	public int MaxSimulationIterations;
	public int BounceAdditionalIterations;
	public void SetInterpolatedComponent(UObject Component) {}
	public void MoveInterpolationTarget(FVector NewLocation,FRotator NewRotation) {}
	public void ResetInterpolation() {}
	public float InterpLocationTime;
	public float InterpRotationTime;
	public float InterpLocationMaxLagDistance;
	public float InterpLocationSnapToTargetDistance;
	public bool IsInterpolationComplete() { return default; }
	public FVector LimitVelocity(FVector NewVelocity) { return default; }
}
