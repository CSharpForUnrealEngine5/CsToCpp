#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/CharacterMovementComponent.h")]
///<summary>CharacterMovementComponent handles movement logic for the associated Character owner.</summary>
public partial class UCharacterMovementComponent : UPawnMovementComponent {
// CharacterMovementComponent
	public ACharacter CharacterOwner;
	public float GravityScale;
	public float MaxStepHeight;
	public float JumpZVelocity;
	public float JumpOffJumpZFactor;
	public float WalkableFloorAngle;
	public float WalkableFloorZ;
	public byte MovementMode;
	public byte CustomMovementMode;
	public ENetworkSmoothingMode NetworkSmoothingMode;
	public float GroundFriction;
	public float MaxWalkSpeed;
	public float MaxWalkSpeedCrouched;
	public float MaxSwimSpeed;
	public float MaxFlySpeed;
	public float MaxCustomMovementSpeed;
	public float MaxAcceleration;
	public float MinAnalogWalkSpeed;
	public float BrakingFrictionFactor;
	public float BrakingFriction;
	public float BrakingSubStepTime;
	public float BrakingDecelerationWalking;
	public float BrakingDecelerationFalling;
	public float BrakingDecelerationSwimming;
	public float BrakingDecelerationFlying;
	public float AirControl;
	public float AirControlBoostMultiplier;
	public float AirControlBoostVelocityThreshold;
	public float FallingLateralFriction;
	public float CrouchedHalfHeight;
	public float Buoyancy;
	public float PerchRadiusThreshold;
	public float PerchAdditionalHeight;
	public FRotator RotationRate;
	public bool bUseSeparateBrakingFriction;
	public bool bApplyGravityWhileJumping;
	public bool bUseControllerDesiredRotation;
	public bool bOrientRotationToMovement;
	public bool bSweepWhileNavWalking;
	public bool bMovementInProgress;
	public bool bEnableScopedMovementUpdates;
	public bool bEnableServerDualMoveScopedMovementUpdates;
	public bool bForceMaxAccel;
	public bool bRunPhysicsWithNoController;
	public bool bForceNextFloorCheck;
	public bool bShrinkProxyCapsule;
	public bool bCanWalkOffLedges;
	public bool bCanWalkOffLedgesWhenCrouching;
	public bool bNetworkSkipProxyPredictionOnNetUpdate;
	public bool bNetworkAlwaysReplicateTransformUpdateTimestamp;
	public bool bDeferUpdateMoveComponent;
	public bool bEnablePhysicsInteraction;
	public bool bTouchForceScaledToMass;
	public bool bPushForceScaledToMass;
	public bool bPushForceUsingZOffset;
	public bool bScalePushForceToVelocity;
	public USceneComponent DeferredUpdatedMoveComponent;
	public float MaxOutOfWaterStepHeight;
	public float OutofWaterZ;
	public float Mass;
	public float StandingDownwardForceScale;
	public float InitialPushForceFactor;
	public float PushForceFactor;
	public float PushForcePointZOffsetFactor;
	public float TouchForceFactor;
	public float MinTouchForce;
	public float MaxTouchForce;
	public float RepulsionForce;
	public bool bForceBraking_DEPRECATED;
	public float CrouchedSpeedMultiplier_DEPRECATED;
	public float UpperImpactNormalScale_DEPRECATED;
	public FVector Acceleration;
	public FQuat LastUpdateRotation;
	public FVector LastUpdateLocation;
	public FVector LastUpdateVelocity;
	public float ServerLastTransformUpdateTimeStamp;
	public float ServerLastClientGoodMoveAckTime;
	public float ServerLastClientAdjustmentTime;
	public FVector PendingImpulseToApply;
	public FVector PendingForceToApply;
	public float AnalogInputModifier;
	public FVector GetLastUpdateLocation() { return default; }
	public FRotator GetLastUpdateRotation() { return default; }
	public FVector GetLastUpdateVelocity() { return default; }
	public float MaxSimulationTimeStep;
	public int MaxSimulationIterations;
	public int MaxJumpApexAttemptsPerSimulation;
	public float MaxDepenetrationWithGeometry;
	public float MaxDepenetrationWithGeometryAsProxy;
	public float MaxDepenetrationWithPawn;
	public float MaxDepenetrationWithPawnAsProxy;
	public float NetworkSimulatedSmoothLocationTime;
	public float NetworkSimulatedSmoothRotationTime;
	public float ListenServerNetworkSimulatedSmoothLocationTime;
	public float ListenServerNetworkSimulatedSmoothRotationTime;
	public float NetProxyShrinkRadius;
	public float NetProxyShrinkHalfHeight;
	public float NetworkMaxSmoothUpdateDistance;
	public float NetworkNoSmoothUpdateDistance;
	public float NetworkMinTimeBetweenClientAckGoodMoves;
	public float NetworkMinTimeBetweenClientAdjustments;
	public float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection;
	public float NetworkLargeClientCorrectionDistance;
	public float LedgeCheckThreshold;
	public float JumpOutOfWaterPitch;
	public FFindFloorResult CurrentFloor;
	public byte DefaultLandMovementMode;
	public byte DefaultWaterMovementMode;
	public byte GroundMovementMode;
	public bool bMaintainHorizontalGroundVelocity;
	public bool bImpartBaseVelocityX;
	public bool bImpartBaseVelocityY;
	public bool bImpartBaseVelocityZ;
	public bool bImpartBaseAngularVelocity;
	public bool bJustTeleported;
	public bool bNetworkUpdateReceived;
	public bool bNetworkMovementModeChanged;
	public bool bIgnoreClientMovementErrorChecksAndCorrection;
	public bool bServerAcceptClientAuthoritativePosition;
	public bool bNotifyApex;
	public bool bCheatFlying;
	public bool bWantsToCrouch;
	public bool bCrouchMaintainsBaseLocation;
	public bool bIgnoreBaseRotation;
	public bool bFastAttachedMove;
	public bool bAlwaysCheckFloor;
	public bool bUseFlatBaseForFloorChecks;
	public bool bPerformingJumpOff;
	public bool bWantsToLeaveNavWalking;
	public bool bUseRVOAvoidance;
	public bool bRequestedMoveUseAcceleration;
	public bool bWasSimulatingRootMotion;
	public bool bAllowPhysicsRotationDuringAnimRootMotion;
	public float FormerBaseVelocityDecayHalfLife;
	public bool bHasRequestedVelocity;
	public bool bRequestedMoveWithMaxSpeed;
	public bool bWasAvoidanceUpdated;
	public bool bProjectNavMeshWalking;
	public bool bProjectNavMeshOnBothWorldChannels;
	public float AvoidanceConsiderationRadius;
	public FVector RequestedVelocity;
	public FVector LastUpdateRequestedVelocity;
	public FVector GetLastUpdateRequestedVelocity() { return default; }
	public int AvoidanceUID;
	public FNavAvoidanceMask AvoidanceGroup;
	public void SetAvoidanceGroup(int GroupFlags) {}
	public void SetAvoidanceGroupMask(FNavAvoidanceMask GroupMask) {}
	public FNavAvoidanceMask GroupsToAvoid;
	public void SetGroupsToAvoid(int GroupFlags) {}
	public void SetGroupsToAvoidMask(FNavAvoidanceMask GroupMask) {}
	public FNavAvoidanceMask GroupsToIgnore;
	public void SetGroupsToIgnore(int GroupFlags) {}
	public void SetGroupsToIgnoreMask(FNavAvoidanceMask GroupMask) {}
	public float AvoidanceWeight;
	public FVector PendingLaunchVelocity;
	public float NavMeshProjectionInterval;
	public float NavMeshProjectionTimer;
	public float NavMeshProjectionInterpSpeed;
	public float NavMeshProjectionHeightScaleUp;
	public float NavMeshProjectionHeightScaleDown;
	public float NavWalkingFloorDistTolerance;
	public void SetAvoidanceEnabled(bool bEnable) {}
	public UObject GetCharacterOwner() { return default; }
	public void SetMovementMode(EMovementMode NewMovementMode,byte NewCustomMode/*=0*/) {}
	public bool IsWalking() { return default; }
	public void DisableMovement() {}
	public UObject GetMovementBase() { return default; }
	public FVector GetImpartedMovementBaseVelocity() { return default; }
	public void CalcVelocity(float DeltaTime,float Friction,bool bFluid,float BrakingDeceleration) {}
	public float GetMaxJumpHeight() { return default; }
	public float GetMaxJumpHeightWithJumpTime() { return default; }
	public float GetMinAnalogSpeed() { return default; }
	public float GetMaxAcceleration() { return default; }
	public float GetMaxBrakingDeceleration() { return default; }
	public FVector GetCurrentAcceleration() { return default; }
	public float GetAnalogInputModifier() { return default; }
	public void ClearAccumulatedForces() {}
	public void SetCrouchedHalfHeight(float NewValue) {}
	public float GetCrouchedHalfHeight() { return default; }
	public void AddImpulse(FVector Impulse,bool bVelocityChange/*=false*/) {}
	public void AddForce(FVector Force) {}
	public float GetPerchRadiusThreshold() { return default; }
	public float GetValidPerchRadius() { return default; }
	public bool IsWalkable(FHitResult Hit) { return default; }
	public float K2_GetWalkableFloorAngle() { return default; }
	public void SetWalkableFloorAngle(float InWalkableFloorAngle) {}
	public float K2_GetWalkableFloorZ() { return default; }
	public void SetWalkableFloorZ(float InWalkableFloorZ) {}
	public FCharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction;
	public void K2_FindFloor(FVector CapsuleLocation,FFindFloorResult FloorResult) {}
	public void K2_ComputeFloorDist(FVector CapsuleLocation,float LineDistance,float SweepDistance,float SweepRadius,FFindFloorResult FloorResult) {}
	public void CapsuleTouched(UObject OverlappedComp,UObject Other,UObject OtherComp,int OtherBodyIndex,bool bFromSweep,FHitResult SweepResult) {}
	public float MinTimeBetweenTimeStampResets;
	public FRootMotionSourceGroup CurrentRootMotion;
	public FRootMotionSourceGroup ServerCorrectionRootMotion;
	public FRootMotionMovementParams RootMotionParams;
	public FVector AnimRootMotionVelocity;
}
