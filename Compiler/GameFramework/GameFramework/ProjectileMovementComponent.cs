using CSharpToCpp.Utilities;

namespace GameFramework
{

    [CppInclude("GameFramework/ProjectileMovementComponent.h")]
    public partial class UProjectileMovementComponent : UMovementComponent
    {
        public float InitialSpeed;
        public float MaxSpeed;
        public bool bRotationFollowsVelocity;

        /** If true, this projectile will have its rotation updated each frame to maintain the rotations Yaw only. (bRotationFollowsVelocity is required to be true) */
        public bool bRotationRemainsVertical;

        /** If true, simple bounces will be simulated. Set this to false to stop simulating on contact. */
        public bool bShouldBounce;

        /**
         * If true, the initial Velocity is interpreted as being in local space upon startup.
         * @see SetVelocityInLocalSpace()
         */
        public bool bInitialVelocityInLocalSpace;

        /**
         * If true, forces sub-stepping to break up movement into discrete smaller steps to improve accuracy of the trajectory.
         * Objects that move in a straight line typically do *not* need to set this, as movement always uses continuous collision detection (sweeps) so collision is not missed.
         * Sub-stepping is automatically enabled when under the effects of gravity or when homing towards a target.
         * @see MaxSimulationTimeStep, MaxSimulationIterations
         */
        public bool bForceSubStepping;

        /**
         * If true, does normal simulation ticking and update. If false, simulation is halted, but component will still tick (allowing interpolation to run).
         */
        public bool bSimulationEnabled;

        /**
         * If true, movement uses swept collision checks.
         * If false, collision effectively teleports to the destination. Note that when this is disabled, movement will never generate blocking collision hits (though overlaps will be updated).
         */
        public bool bSweepCollision;

        /**
         * If true, we will accelerate toward our homing target. HomingTargetComponent must be set after the projectile is spawned.
         * @see HomingTargetComponent, HomingAccelerationMagnitude
         */
        public bool bIsHomingProjectile;

        /**
         * Controls the effects of friction on velocity parallel to the impact surface when bouncing.
         * If true, friction will be modified based on the angle of impact, making friction higher for perpendicular impacts and lower for glancing impacts.
         * If false, a bounce will retain a proportion of tangential velocity equal to (1.0 - Friction), acting as a "horizontal restitution".
         */
        public bool bBounceAngleAffectsFriction;

        /**
         * If true, projectile is sliding / rolling along a surface.
         */
        public bool bIsSliding;

        /**
         * If true and there is an interpolated component set, location (and optionally rotation) interpolation is enabled which allows the interpolated object to smooth uneven updates
         * of the UpdatedComponent's location (usually to smooth network updates). This requires using SetInterpolatedComponent() to indicate the visual component that lags behind the collision,
         * and using MoveInterpolationTarget() when the new target location/rotation is received (usually on a net update).
         * @see SetInterpolatedComponent(), MoveInterpolationTarget()
         */
        public bool bInterpMovement;

        /**
         * If true and there is an interpolated component set, rotation interpolation is enabled which allows the interpolated object to smooth uneven updates
         * of the UpdatedComponent's rotation (usually to smooth network updates).
         * Rotation interpolation is *only* applied if bInterpMovement is also enabled.
         * @see SetInterpolatedComponent(), MoveInterpolationTarget()
         */
        public bool bInterpRotation;

        public float PreviousHitTime;
        public FVector PreviousHitNormal;
        public float ProjectileGravityScale;
        public float Buoyancy;
        public float Bounciness;
        public float Friction;
        public float BounceVelocityStopSimulatingThreshold;
        public float MinFrictionFraction;


    }

}