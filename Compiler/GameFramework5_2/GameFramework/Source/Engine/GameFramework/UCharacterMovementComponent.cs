namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>CharacterMovementComponent handles movement logic for the associated Character owner.</summary>
[CppInclude("GameFramework/CharacterMovementComponent.h")]
public partial class UCharacterMovementComponent : UPawnMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Character movement component belongs to</summary>
	public ACharacter CharacterOwner;
	///<summary>Custom gravity scale. Gravity is multiplied by this amount for the character.</summary>
	public float GravityScale;
	///<summary>Maximum height character can step up</summary>
	public float MaxStepHeight;
	///<summary>Initial velocity (instantaneous vertical acceleration) when jumping.</summary>
	public float JumpZVelocity;
	///<summary>Fraction of JumpZVelocity to use when automatically &quot;jumping off&quot; of a base actor that&#39;s not allowed to be a base for a character. (For example, if you&#39;re not allowed to stand on other players.)</summary>
	public float JumpOffJumpZFactor;
	///<summary>Max angle in degrees of a walkable surface. Any greater than this and it is too steep to be walkable.</summary>
	public float WalkableFloorAngle;
	///<summary>Minimum Z value for floor normal. If less, not a walkable surface. Computed from WalkableFloorAngle.</summary>
	public float WalkableFloorZ;
	///<summary>Actor&#39;s current movement mode (walking, falling, etc).</summary>
	public EMovementMode MovementMode;
	///<summary>Current custom sub-mode if MovementMode is set to Custom.</summary>
	public byte CustomMovementMode;
	///<summary>Smoothing mode for simulated proxies in network game.</summary>
	public ENetworkSmoothingMode NetworkSmoothingMode;
	///<summary>Setting that affects movement control. Higher values allow faster changes in direction.</summary>
	public float GroundFriction;
	///<summary>The maximum ground speed when walking. Also determines maximum lateral speed when falling.</summary>
	public float MaxWalkSpeed;
	///<summary>The maximum ground speed when walking and crouched.</summary>
	public float MaxWalkSpeedCrouched;
	///<summary>The maximum swimming speed.</summary>
	public float MaxSwimSpeed;
	///<summary>The maximum flying speed.</summary>
	public float MaxFlySpeed;
	///<summary>The maximum speed when using Custom movement mode.</summary>
	public float MaxCustomMovementSpeed;
	///<summary>Max Acceleration (rate of change of velocity)</summary>
	public float MaxAcceleration;
	///<summary>The ground speed that we should accelerate up to when walking at minimum analog stick tilt</summary>
	public float MinAnalogWalkSpeed;
	///<summary>Factor used to multiply actual value of friction used when braking.</summary>
	public float BrakingFrictionFactor;
	///<summary>Friction (drag) coefficient applied when braking (whenever Acceleration = 0, or if character is exceeding max speed); actual value used is this multiplied by BrakingFrictionFactor.</summary>
	public float BrakingFriction;
	///<summary>Time substepping when applying braking friction. Smaller time steps increase accuracy at the slight cost of performance, especially if there are large frame times.</summary>
	public float BrakingSubStepTime;
	///<summary>Deceleration when walking and not applying acceleration. This is a constant opposing force that directly lowers velocity by a constant value.</summary>
	public float BrakingDecelerationWalking;
	///<summary>Lateral deceleration when falling and not applying acceleration.</summary>
	public float BrakingDecelerationFalling;
	///<summary>Deceleration when swimming and not applying acceleration.</summary>
	public float BrakingDecelerationSwimming;
	///<summary>Deceleration when flying and not applying acceleration.</summary>
	public float BrakingDecelerationFlying;
	///<summary>When falling, amount of lateral movement control available to the character.</summary>
	public float AirControl;
	///<summary>When falling, multiplier applied to AirControl when lateral velocity is less than AirControlBoostVelocityThreshold.</summary>
	public float AirControlBoostMultiplier;
	///<summary>When falling, if lateral velocity magnitude is less than this value, AirControl is multiplied by AirControlBoostMultiplier.</summary>
	public float AirControlBoostVelocityThreshold;
	///<summary>Friction to apply to lateral air movement when falling.</summary>
	public float FallingLateralFriction;
	///<summary>CrouchedHalfHeight</summary>
	public float CrouchedHalfHeight;
	///<summary>Water buoyancy. A ratio (1.0 = neutral buoyancy, 0.0 = no buoyancy)</summary>
	public float Buoyancy;
	///<summary>Don&#39;t allow the character to perch on the edge of a surface if the contact is this close to the edge of the capsule.</summary>
	public float PerchRadiusThreshold;
	///<summary>When perching on a ledge, add this additional distance to MaxStepHeight when determining how high above a walkable floor we can perch.</summary>
	public float PerchAdditionalHeight;
	///<summary>Change in rotation per second, used when UseControllerDesiredRotation or OrientRotationToMovement are true. Set a negative value for infinite rotation rate and instant turns.</summary>
	public FRotator RotationRate;
	///<summary>If true, BrakingFriction will be used to slow the character to a stop (when there is no Acceleration).</summary>
	public bool bUseSeparateBrakingFriction;
	///<summary>Apply gravity while the character is actively jumping (e.g. holding the jump key).</summary>
	public bool bApplyGravityWhileJumping;
	///<summary>If true, smoothly rotate the Character toward the Controller&#39;s desired rotation (typically Controller-&gt;ControlRotation), using RotationRate as the rate of rotation change. Overridden by OrientRotationToMovement.</summary>
	public bool bUseControllerDesiredRotation;
	///<summary>If true, rotate the Character toward the direction of acceleration, using RotationRate as the rate of rotation change. Overrides UseControllerDesiredRotation.</summary>
	public bool bOrientRotationToMovement;
	///<summary>Whether or not the character should sweep for collision geometry while walking.</summary>
	public bool bSweepWhileNavWalking;
	///<summary>True during movement update.</summary>
	public bool bMovementInProgress;
	///<summary>If true, high-level movement updates will be wrapped in a movement scope that accumulates updates and defers a bulk of the work until the end.</summary>
	public bool bEnableScopedMovementUpdates;
	///<summary>Optional scoped movement update to combine moves for cheaper performance on the server when the client sends two moves in one packet.</summary>
	public bool bEnableServerDualMoveScopedMovementUpdates;
	///<summary>Ignores size of acceleration component, and forces max acceleration to drive character at full velocity.</summary>
	public bool bForceMaxAccel;
	///<summary>If true, movement will be performed even if there is no Controller for the Character owner.</summary>
	public bool bRunPhysicsWithNoController;
	///<summary>Force the Character in MOVE_Walking to do a check for a valid floor even if it hasn&#39;t moved. Cleared after next floor check.</summary>
	public bool bForceNextFloorCheck;
	///<summary>If true, the capsule needs to be shrunk on this simulated proxy, to avoid replication rounding putting us in geometry.</summary>
	public bool bShrinkProxyCapsule;
	///<summary>If true, Character can walk off a ledge.</summary>
	public bool bCanWalkOffLedges;
	///<summary>If true, Character can walk off a ledge when crouching.</summary>
	public bool bCanWalkOffLedgesWhenCrouching;
	///<summary>Whether we skip prediction on frames where a proxy receives a network update. This can avoid expensive prediction on those frames,</summary>
	public bool bNetworkSkipProxyPredictionOnNetUpdate;
	///<summary>Flag used on the server to determine whether to always replicate ReplicatedServerLastTransformUpdateTimeStamp to clients.</summary>
	public bool bNetworkAlwaysReplicateTransformUpdateTimestamp;
	///<summary>true to update CharacterOwner and UpdatedComponent after movement ends</summary>
	public bool bDeferUpdateMoveComponent;
	///<summary>If enabled, the player will interact with physics objects when walking into them.</summary>
	public bool bEnablePhysicsInteraction;
	///<summary>If enabled, the TouchForceFactor is applied per kg mass of the affected object.</summary>
	public bool bTouchForceScaledToMass;
	///<summary>If enabled, the PushForceFactor is applied per kg mass of the affected object.</summary>
	public bool bPushForceScaledToMass;
	///<summary>If enabled, the PushForce location is moved using PushForcePointZOffsetFactor. Otherwise simply use the impact point.</summary>
	public bool bPushForceUsingZOffset;
	///<summary>If enabled, the applied push force will try to get the physics object to the same velocity than the player, not faster. This will only</summary>
	public bool bScalePushForceToVelocity;
	///<summary>What to update CharacterOwner and UpdatedComponent after movement ends</summary>
	public USceneComponent DeferredUpdatedMoveComponent;
	///<summary>Maximum step height for getting out of water</summary>
	public float MaxOutOfWaterStepHeight;
	///<summary>Z velocity applied when pawn tries to get out of water</summary>
	public float OutofWaterZ;
	///<summary>Mass of pawn (for when momentum is imparted to it).</summary>
	public float Mass;
	///<summary>Force applied to objects we stand on (due to Mass and Gravity) is scaled by this amount.</summary>
	public float StandingDownwardForceScale;
	///<summary>Initial impulse force to apply when the player bounces into a blocking physics object.</summary>
	public float InitialPushForceFactor;
	///<summary>Force to apply when the player collides with a blocking physics object.</summary>
	public float PushForceFactor;
	///<summary>Z-Offset for the position the force is applied to. 0.0f is the center of the physics object, 1.0f is the top and -1.0f is the bottom of the object.</summary>
	public float PushForcePointZOffsetFactor;
	///<summary>Force to apply to physics objects that are touched by the player.</summary>
	public float TouchForceFactor;
	///<summary>Minimum Force applied to touched physics objects. If &lt; 0.0f, there is no minimum.</summary>
	public float MinTouchForce;
	///<summary>Maximum force applied to touched physics objects. If &lt; 0.0f, there is no maximum.</summary>
	public float MaxTouchForce;
	///<summary>Force per kg applied constantly to all overlapping components.</summary>
	public float RepulsionForce;
	///<summary>Deprecated properties</summary>
	public bool bForceBraking_DEPRECATED;
	///<summary>Multiplier to max ground speed to use when crouched</summary>
	public float CrouchedSpeedMultiplier_DEPRECATED;
	///<summary>UpperImpactNormalScale_DEPRECATED</summary>
	public float UpperImpactNormalScale_DEPRECATED;
	///<summary>Current acceleration vector (with magnitude).</summary>
	public FVector Acceleration;
	///<summary>Rotation after last PerformMovement or SimulateMovement update.</summary>
	public FQuat LastUpdateRotation;
	///<summary>Location after last PerformMovement or SimulateMovement update. Used internally to detect changes in position from outside character movement to try to validate the current floor.</summary>
	public FVector LastUpdateLocation;
	///<summary>Velocity after last PerformMovement or SimulateMovement update. Used internally to detect changes in velocity from external sources.</summary>
	public FVector LastUpdateVelocity;
	///<summary>Timestamp when location or rotation last changed during an update. Only valid on the server.</summary>
	public float ServerLastTransformUpdateTimeStamp;
	///<summary>Timestamp of last client adjustment sent. See NetworkMinTimeBetweenClientAdjustments.</summary>
	public float ServerLastClientGoodMoveAckTime;
	///<summary>Timestamp of last client adjustment sent. See NetworkMinTimeBetweenClientAdjustments.</summary>
	public float ServerLastClientAdjustmentTime;
	///<summary>Accumulated impulse to be added next tick.</summary>
	public FVector PendingImpulseToApply;
	///<summary>Accumulated force to be added next tick.</summary>
	public FVector PendingForceToApply;
	///<summary>Modifier to applied to values such as acceleration and max speed due to analog input.</summary>
	public float AnalogInputModifier;
	///<summary>Returns the location at the end of the last tick.</summary>
	public FVector GetLastUpdateLocation() { return default; }
	///<summary>Returns the rotation at the end of the last tick.</summary>
	public FRotator GetLastUpdateRotation() { return default; }
	///<summary>Returns the velocity at the end of the last tick.</summary>
	public FVector GetLastUpdateVelocity() { return default; }
	///<summary>Max time delta for each discrete simulation step.</summary>
	public float MaxSimulationTimeStep;
	///<summary>Max number of iterations used for each discrete simulation step.</summary>
	public int MaxSimulationIterations;
	///<summary>Max number of attempts per simulation to attempt to exactly reach the jump apex when falling movement reaches the top of the arc.</summary>
	public int MaxJumpApexAttemptsPerSimulation;
	///<summary>Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.</summary>
	public float MaxDepenetrationWithGeometry;
	///<summary>Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.</summary>
	public float MaxDepenetrationWithGeometryAsProxy;
	///<summary>Max distance we are allowed to depenetrate when moving out of other Pawns.</summary>
	public float MaxDepenetrationWithPawn;
	///<summary>Max distance we allow simulated proxies to depenetrate when moving out of other Pawns.</summary>
	public float MaxDepenetrationWithPawnAsProxy;
	///<summary>How long to take to smoothly interpolate from the old pawn position on the client to the corrected one sent by the server. Not used by Linear smoothing.</summary>
	public float NetworkSimulatedSmoothLocationTime;
	///<summary>How long to take to smoothly interpolate from the old pawn rotation on the client to the corrected one sent by the server. Not used by Linear smoothing.</summary>
	public float NetworkSimulatedSmoothRotationTime;
	///<summary>Similar setting as NetworkSimulatedSmoothLocationTime but only used on Listen servers.</summary>
	public float ListenServerNetworkSimulatedSmoothLocationTime;
	///<summary>Similar setting as NetworkSimulatedSmoothRotationTime but only used on Listen servers.</summary>
	public float ListenServerNetworkSimulatedSmoothRotationTime;
	///<summary>Shrink simulated proxy capsule radius by this amount, to account for network rounding that may cause encroachment. Changing during gameplay is not supported.</summary>
	public float NetProxyShrinkRadius;
	///<summary>Shrink simulated proxy capsule half height by this amount, to account for network rounding that may cause encroachment. Changing during gameplay is not supported.</summary>
	public float NetProxyShrinkHalfHeight;
	///<summary>Maximum distance character is allowed to lag behind server location when interpolating between updates.</summary>
	public float NetworkMaxSmoothUpdateDistance;
	///<summary>Maximum distance beyond which character is teleported to the new server location without any smoothing.</summary>
	public float NetworkNoSmoothUpdateDistance;
	///<summary>Minimum time on the server between acknowledging good client moves. This can save on bandwidth. Set to 0 to disable throttling.</summary>
	public float NetworkMinTimeBetweenClientAckGoodMoves;
	///<summary>Minimum time on the server between sending client adjustments when client has exceeded allowable position error.</summary>
	public float NetworkMinTimeBetweenClientAdjustments;
	///<summary>Minimum time on the server between sending client adjustments when client has exceeded allowable position error by a large amount (NetworkLargeClientCorrectionDistance).</summary>
	public float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection;
	///<summary>If client error is larger than this, sets bNetworkLargeClientCorrection to reduce delay between client adjustments.</summary>
	public float NetworkLargeClientCorrectionDistance;
	///<summary>Used in determining if pawn is going off ledge.  If the ledge is &quot;shorter&quot; than this value then the pawn will be able to walk off it. *</summary>
	public float LedgeCheckThreshold;
	///<summary>When exiting water, jump if control pitch angle is this high or above.</summary>
	public float JumpOutOfWaterPitch;
	///<summary>Information about the floor the Character is standing on (updated only during walking movement).</summary>
	public FFindFloorResult CurrentFloor;
	///<summary>Default movement mode when not in water. Used at player startup or when teleported.</summary>
	public EMovementMode DefaultLandMovementMode;
	///<summary>Default movement mode when in water. Used at player startup or when teleported.</summary>
	public EMovementMode DefaultWaterMovementMode;
	///<summary>Ground movement mode to switch to after falling and resuming ground movement.</summary>
	public EMovementMode GroundMovementMode;
	///<summary>If true, walking movement always maintains horizontal velocity when moving up ramps, which causes movement up ramps to be faster parallel to the ramp surface.</summary>
	public bool bMaintainHorizontalGroundVelocity;
	///<summary>If true, impart the base actor&#39;s X velocity when falling off it (which includes jumping)</summary>
	public bool bImpartBaseVelocityX;
	///<summary>If true, impart the base actor&#39;s Y velocity when falling off it (which includes jumping)</summary>
	public bool bImpartBaseVelocityY;
	///<summary>If true, impart the base actor&#39;s Z velocity when falling off it (which includes jumping)</summary>
	public bool bImpartBaseVelocityZ;
	///<summary>If true, impart the base component&#39;s tangential components of angular velocity when jumping or falling off it.</summary>
	public bool bImpartBaseAngularVelocity;
	///<summary>Used by movement code to determine if a change in position is based on normal movement or a teleport. If not a teleport, velocity can be recomputed based on the change in position.</summary>
	public bool bJustTeleported;
	///<summary>True when a network replication update is received for simulated proxies.</summary>
	public bool bNetworkUpdateReceived;
	///<summary>True when the networked movement mode has been replicated.</summary>
	public bool bNetworkMovementModeChanged;
	///<summary>If true, we should ignore server location difference checks for client error on this movement component.</summary>
	public bool bIgnoreClientMovementErrorChecksAndCorrection;
	///<summary>If true, and server does not detect client position error, server will copy the client movement location/velocity/etc after simulating the move.</summary>
	public bool bServerAcceptClientAuthoritativePosition;
	///<summary>If true, event NotifyJumpApex() to CharacterOwner&#39;s controller when at apex of jump. Is cleared when event is triggered.</summary>
	public bool bNotifyApex;
	///<summary>Instantly stop when in flying mode and no acceleration is being applied.</summary>
	public bool bCheatFlying;
	///<summary>If true, try to crouch (or keep crouching) on next update. If false, try to stop crouching on next update.</summary>
	public bool bWantsToCrouch;
	///<summary>If true, crouching should keep the base of the capsule in place by lowering the center of the shrunken capsule. If false, the base of the capsule moves up and the center stays in place.</summary>
	public bool bCrouchMaintainsBaseLocation;
	///<summary>Whether the character ignores changes in rotation of the base it is standing on.</summary>
	public bool bIgnoreBaseRotation;
	///<summary>Set this to true if riding on a moving base that you know is clear from non-moving world obstructions.</summary>
	public bool bFastAttachedMove;
	///<summary>Whether we always force floor checks for stationary Characters while walking.</summary>
	public bool bAlwaysCheckFloor;
	///<summary>Performs floor checks as if the character is using a shape with a flat base.</summary>
	public bool bUseFlatBaseForFloorChecks;
	///<summary>Used to prevent reentry of JumpOff()</summary>
	public bool bPerformingJumpOff;
	///<summary>Used to safely leave NavWalking movement mode</summary>
	public bool bWantsToLeaveNavWalking;
	///<summary>If set, component will use RVO avoidance. This only runs on the server.</summary>
	public bool bUseRVOAvoidance;
	///<summary>Should use acceleration for path following?</summary>
	public bool bRequestedMoveUseAcceleration;
	///<summary>True when SimulatedProxies are simulating RootMotion</summary>
	public bool bWasSimulatingRootMotion;
	///<summary>bAllowPhysicsRotationDuringAnimRootMotion</summary>
	public bool bAllowPhysicsRotationDuringAnimRootMotion;
	///<summary>When applying a root motion override while falling off a moving object, this controls how long it takes to lose half the former base&#39;s velocity (in seconds).</summary>
	public float FormerBaseVelocityDecayHalfLife;
	///<summary>Was velocity requested by path following?</summary>
	public bool bHasRequestedVelocity;
	///<summary>Was acceleration requested to be always max speed?</summary>
	public bool bRequestedMoveWithMaxSpeed;
	///<summary>Was avoidance updated in this frame?</summary>
	public bool bWasAvoidanceUpdated;
	///<summary>Whether to raycast to underlying geometry to better conform navmesh-walking characters</summary>
	public bool bProjectNavMeshWalking;
	///<summary>Use both WorldStatic and WorldDynamic channels for NavWalking geometry conforming</summary>
	public bool bProjectNavMeshOnBothWorldChannels;
	///<summary>AvoidanceConsiderationRadius</summary>
	public float AvoidanceConsiderationRadius;
	///<summary>Velocity requested by path following.</summary>
	public FVector RequestedVelocity;
	///<summary>Velocity requested by path following during last Update</summary>
	public FVector LastUpdateRequestedVelocity;
	///<summary>Returns velocity requested by path following</summary>
	public FVector GetLastUpdateRequestedVelocity() { return default; }
	///<summary>No default value, for now it&#39;s assumed to be valid if GetAvoidanceManager() returns non-NULL.</summary>
	public int AvoidanceUID;
	///<summary>Moving actor&#39;s group mask</summary>
	public FNavAvoidanceMask AvoidanceGroup;
	///<summary>SetAvoidanceGroup</summary>
	public void SetAvoidanceGroup(int GroupFlags) {}
	///<summary>SetAvoidanceGroupMask</summary>
	public void SetAvoidanceGroupMask(FNavAvoidanceMask GroupMask) {}
	///<summary>Will avoid other agents if they are in one of specified groups</summary>
	public FNavAvoidanceMask GroupsToAvoid;
	///<summary>SetGroupsToAvoid</summary>
	public void SetGroupsToAvoid(int GroupFlags) {}
	///<summary>SetGroupsToAvoidMask</summary>
	public void SetGroupsToAvoidMask(FNavAvoidanceMask GroupMask) {}
	///<summary>Will NOT avoid other agents if they are in one of specified groups, higher priority than GroupsToAvoid</summary>
	public FNavAvoidanceMask GroupsToIgnore;
	///<summary>SetGroupsToIgnore</summary>
	public void SetGroupsToIgnore(int GroupFlags) {}
	///<summary>SetGroupsToIgnoreMask</summary>
	public void SetGroupsToIgnoreMask(FNavAvoidanceMask GroupMask) {}
	///<summary>De facto default value 0.5 (due to that being the default in the avoidance registration function), indicates RVO behavior.</summary>
	public float AvoidanceWeight;
	///<summary>Temporarily holds launch velocity when pawn is to be launched so it happens at end of movement.</summary>
	public FVector PendingLaunchVelocity;
	///<summary>How often we should raycast to project from navmesh to underlying geometry</summary>
	public float NavMeshProjectionInterval;
	///<summary>NavMeshProjectionTimer</summary>
	public float NavMeshProjectionTimer;
	///<summary>Speed at which to interpolate agent navmesh offset between traces. 0: Instant (no interp) &gt; 0: Interp speed&quot;)</summary>
	public float NavMeshProjectionInterpSpeed;
	///<summary>Scale of the total capsule height to use for projection from navmesh to underlying geometry in the upward direction.</summary>
	public float NavMeshProjectionHeightScaleUp;
	///<summary>Scale of the total capsule height to use for projection from navmesh to underlying geometry in the downward direction.</summary>
	public float NavMeshProjectionHeightScaleDown;
	///<summary>Ignore small differences in ground height between server and client data during NavWalking mode</summary>
	public float NavWalkingFloorDistTolerance;
	///<summary>Change avoidance state and registers in RVO manager if needed</summary>
	public void SetAvoidanceEnabled(bool bEnable) {}
	///<summary>Get the Character that owns UpdatedComponent.</summary>
	public ACharacter GetCharacterOwner() { return default; }
	///<summary>Change movement mode.</summary>
	public virtual void SetMovementMode(EMovementMode NewMovementMode,byte NewCustomMode/*=0*/) {}
	///<summary>Returns true if the character is in the &#39;Walking&#39; movement mode.</summary>
	public bool IsWalking() { return default; }
	///<summary>Make movement impossible (sets movement mode to MOVE_None).</summary>
	public virtual void DisableMovement() {}
	///<summary>Return PrimitiveComponent we are based on (standing and walking on).</summary>
	public UPrimitiveComponent GetMovementBase() { return default; }
	///<summary>If we have a movement base, get the velocity that should be imparted by that base, usually when jumping off of it.</summary>
	public virtual FVector GetImpartedMovementBaseVelocity() { return default; }
	///<summary>Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity.</summary>
	public virtual void CalcVelocity(float DeltaTime,float Friction,bool bFluid,float BrakingDeceleration) {}
	///<summary>Compute the max jump height based on the JumpZVelocity velocity and gravity.</summary>
	public virtual float GetMaxJumpHeight() { return default; }
	///<summary>Compute the max jump height based on the JumpZVelocity velocity and gravity.</summary>
	public virtual float GetMaxJumpHeightWithJumpTime() { return default; }
	///<summary>Returns maximum acceleration for the current state.</summary>
	public virtual float GetMinAnalogSpeed() { return default; }
	///<summary>Returns maximum acceleration for the current state.</summary>
	public virtual float GetMaxAcceleration() { return default; }
	///<summary>Returns maximum deceleration for the current state when braking (ie when there is no acceleration).</summary>
	public virtual float GetMaxBrakingDeceleration() { return default; }
	///<summary>Returns current acceleration, computed from input vector each update.</summary>
	public FVector GetCurrentAcceleration() { return default; }
	///<summary>Returns modifier [0..1] based on the magnitude of the last input vector, which is used to modify the acceleration and max speed during movement.</summary>
	public float GetAnalogInputModifier() { return default; }
	///<summary>Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity.</summary>
	public virtual void ClearAccumulatedForces() {}
	///<summary>Sets collision half-height when crouching and updates dependent computations</summary>
	public void SetCrouchedHalfHeight(float NewValue) {}
	///<summary>Returns the collision half-height when crouching (component scale is applied separately)</summary>
	public float GetCrouchedHalfHeight() { return default; }
	///<summary>Add impulse to character. Impulses are accumulated each tick and applied together</summary>
	public virtual void AddImpulse(FVector Impulse,bool bVelocityChange/*=false*/) {}
	///<summary>Add force to character. Forces are accumulated each tick and applied together</summary>
	public virtual void AddForce(FVector Force) {}
	///<summary>Returns The distance from the edge of the capsule within which we don&#39;t allow the character to perch on the edge of a surface.</summary>
	public float GetPerchRadiusThreshold() { return default; }
	///<summary>Returns the radius within which we can stand on the edge of a surface without falling (if this is a walkable surface).</summary>
	public float GetValidPerchRadius() { return default; }
	///<summary>Return true if the hit result should be considered a walkable surface for the character.</summary>
	public virtual bool IsWalkable(FHitResult Hit) { return default; }
	///<summary>Get the max angle in degrees of a walkable surface for the character.</summary>
	public float K2_GetWalkableFloorAngle() { return default; }
	///<summary>Set the max angle in degrees of a walkable surface for the character. Also computes WalkableFloorZ.</summary>
	public void SetWalkableFloorAngle(float InWalkableFloorAngle) {}
	///<summary>Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable.</summary>
	public float K2_GetWalkableFloorZ() { return default; }
	///<summary>Set the Z component of the normal of the steepest walkable surface for the character. Also computes WalkableFloorAngle.</summary>
	public void SetWalkableFloorZ(float InWalkableFloorZ) {}
	///<summary>Post-physics tick function for this character</summary>
	public FCharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction;
	///<summary>Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result.</summary>
	public virtual void K2_FindFloor(FVector CapsuleLocation,FFindFloorResult FloorResult) {}
	///<summary>Compute distance to the floor from bottom sphere of capsule and store the result in FloorResult.</summary>
	public virtual void K2_ComputeFloorDist(FVector CapsuleLocation,float LineDistance,float SweepDistance,float SweepRadius,FFindFloorResult FloorResult) {}
	///<summary>Called when the collision capsule touches another primitive component</summary>
	public virtual void CapsuleTouched(UPrimitiveComponent OverlappedComp,AActor Other,UPrimitiveComponent OtherComp,int OtherBodyIndex,bool bFromSweep,FHitResult SweepResult) {}
	///<summary>Minimum time between client TimeStamp resets.</summary>
	public float MinTimeBetweenTimeStampResets;
	///<summary>Root Motion Group containing active root motion sources being applied to movement</summary>
	public FRootMotionSourceGroup CurrentRootMotion;
	///<summary>ServerCorrectionRootMotion</summary>
	public FRootMotionSourceGroup ServerCorrectionRootMotion;
	///<summary>Root Motion movement params. Holds result of anim montage root motion during PerformMovement(), and is overridden</summary>
	public FRootMotionMovementParams RootMotionParams;
	///<summary>Velocity extracted from RootMotionParams when there is anim root motion active. Invalid to use when HasAnimRootMotion() returns false.</summary>
	public FVector AnimRootMotionVelocity;
}
