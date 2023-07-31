#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ProjectileMovementComponent updates the position of another component during its tick.</summary>
[CppInclude("GameFramework/ProjectileMovementComponent.h")]
public partial class UProjectileMovementComponent : UMovementComponent {
	///<summary>FOnProjectileBounceDelegate</summary>
	public  void FOnProjectileBounceDelegate(FHitResult ImpactResult,FVector ImpactVelocity) {}
	///<summary>FOnProjectileStopDelegate</summary>
	public  void FOnProjectileStopDelegate(FHitResult ImpactResult) {}
	///<summary>Initial speed of projectile. If greater than zero, this will override the initial Velocity value and instead treat Velocity as a direction.</summary>
	public float InitialSpeed;
	///<summary>Limit on speed of projectile (0 means no limit).</summary>
	public float MaxSpeed;
	///<summary>If true, this projectile will have its rotation updated each frame to match the direction of its velocity.</summary>
	public bool bRotationFollowsVelocity;
	///<summary>If true, this projectile will have its rotation updated each frame to maintain the rotations Yaw only. (bRotationFollowsVelocity is required to be true)</summary>
	public bool bRotationRemainsVertical;
	///<summary>If true, simple bounces will be simulated. Set this to false to stop simulating on contact.</summary>
	public bool bShouldBounce;
	///<summary>If true, the initial Velocity is interpreted as being in local space upon startup.</summary>
	public bool bInitialVelocityInLocalSpace;
	///<summary>If true, forces sub-stepping to break up movement into discrete smaller steps to improve accuracy of the trajectory.</summary>
	public bool bForceSubStepping;
	///<summary>If true, does normal simulation ticking and update. If false, simulation is halted, but component will still tick (allowing interpolation to run).</summary>
	public bool bSimulationEnabled;
	///<summary>If true, movement uses swept collision checks.</summary>
	public bool bSweepCollision;
	///<summary>If true, we will accelerate toward our homing target. HomingTargetComponent must be set after the projectile is spawned.</summary>
	public bool bIsHomingProjectile;
	///<summary>Controls the effects of friction on velocity parallel to the impact surface when bouncing.</summary>
	public bool bBounceAngleAffectsFriction;
	///<summary>If true, projectile is sliding / rolling along a surface.</summary>
	public bool bIsSliding;
	///<summary>If true and there is an interpolated component set, location (and optionally rotation) interpolation is enabled which allows the interpolated object to smooth uneven updates</summary>
	public bool bInterpMovement;
	///<summary>If true and there is an interpolated component set, rotation interpolation is enabled which allows the interpolated object to smooth uneven updates</summary>
	public bool bInterpRotation;
	///<summary>Saved HitResult Time (0 to 1) from previous simulation step. Equal to 1.0 when there was no impact.</summary>
	public float PreviousHitTime;
	///<summary>Saved HitResult Normal from previous simulation step that resulted in an impact. If PreviousHitTime is 1.0, then the hit was not in the last step.</summary>
	public FVector PreviousHitNormal;
	///<summary>Custom gravity scale for this projectile. Set to 0 for no gravity.</summary>
	public float ProjectileGravityScale;
	///<summary>Buoyancy of UpdatedComponent in fluid. 0.0=sinks as fast as in air, 1.0=neutral buoyancy</summary>
	public float Buoyancy;
	///<summary>Percentage of velocity maintained after the bounce in the direction of the normal of impact (coefficient of restitution).</summary>
	public float Bounciness;
	///<summary>Coefficient of friction, affecting the resistance to sliding along a surface.</summary>
	public float Friction;
	///<summary>If velocity is below this threshold after a bounce, stops simulating and triggers the OnProjectileStop event.</summary>
	public float BounceVelocityStopSimulatingThreshold;
	///<summary>When bounce angle affects friction, apply at least this fraction of normal friction.</summary>
	public float MinFrictionFraction;
	///<summary>Returns true if velocity magnitude is less than BounceVelocityStopSimulatingThreshold.</summary>
	public  bool IsVelocityUnderSimulationThreshold() { return default; }
	///<summary>Called when projectile impacts something and bounces are enabled.</summary>
	public FOnProjectileBounceDelegate OnProjectileBounce;
	///<summary>Called when projectile has come to a stop (velocity is below simulation threshold, bounces are disabled, or it is forcibly stopped).</summary>
	public FOnProjectileStopDelegate OnProjectileStop;
	///<summary>The magnitude of our acceleration towards the homing target. Overall velocity magnitude will still be limited by MaxSpeed.</summary>
	public float HomingAccelerationMagnitude;
	///<summary>The current target we are homing towards. Can only be set at runtime (when projectile is spawned or updating).</summary>
	public TWeakObjectPtr<USceneComponent> HomingTargetComponent;
	///<summary>Sets the velocity to the new value, rotated into Actor space.</summary>
	public  void SetVelocityInLocalSpace(FVector NewVelocity) {}
	///<summary>Clears the reference to UpdatedComponent, fires stop event (OnProjectileStop), and stops ticking (if bAutoUpdateTickRegistration is true).</summary>
	public  void StopSimulating(FHitResult HitResult) {}
	///<summary>Max time delta for each discrete simulation step.</summary>
	public float MaxSimulationTimeStep;
	///<summary>Max number of iterations used for each discrete simulation step.</summary>
	public int MaxSimulationIterations;
	///<summary>On the first few bounces (up to this amount), allow extra iterations over MaxSimulationIterations if necessary.</summary>
	public int BounceAdditionalIterations;
	///<summary>Assigns the component that will be used for network interpolation/smoothing. It is expected that this is a component attached somewhere below the UpdatedComponent.</summary>
	public  void SetInterpolatedComponent(USceneComponent Component) {}
	///<summary>Moves the UpdatedComponent, which is also the interpolation target for the interpolated component. If there is not interpolated component, this simply moves UpdatedComponent.</summary>
	public  void MoveInterpolationTarget(FVector NewLocation,FRotator NewRotation) {}
	///<summary>Resets interpolation so that interpolated component snaps back to the initial location/rotation without any additional offsets.</summary>
	public  void ResetInterpolation() {}
	///<summary>&quot;Time&quot; over which most of the location interpolation occurs, when the UpdatedComponent (target) moves ahead of the interpolated component.</summary>
	public float InterpLocationTime;
	///<summary>&quot;Time&quot; over which most of the rotation interpolation occurs, when the UpdatedComponent (target) moves ahead of the interpolated component.</summary>
	public float InterpRotationTime;
	///<summary>Max distance behind UpdatedComponent which the interpolated component is allowed to lag.</summary>
	public float InterpLocationMaxLagDistance;
	///<summary>Max distance behind UpdatedComponent beyond which the interpolated component is snapped to the target location instead.</summary>
	public float InterpLocationSnapToTargetDistance;
	///<summary>Returns whether interpolation is complete because the target has been reached. True when interpolation is disabled.</summary>
	public  bool IsInterpolationComplete() { return default; }
	///<summary>Don&#39;t allow velocity magnitude to exceed MaxSpeed, if MaxSpeed is non-zero.</summary>
	public  FVector LimitVelocity(FVector NewVelocity) { return default; }
}
