#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Character.h")]
///<summary>Characters are Pawns that have a mesh, collision, and built-in movement logic.</summary>
public partial class ACharacter : APawn {
// Character
	public USkeletalMeshComponent Mesh;
	public UCharacterMovementComponent CharacterMovement;
	public UCapsuleComponent CapsuleComponent;
	public UArrowComponent ArrowComponent;
	public  void ServerMovePacked(FCharacterServerMovePackedBits PackedBits) {}
	public  void ClientMoveResponsePacked(FCharacterMoveResponsePackedBits PackedBits) {}
	public  void ServerMove(float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte CompressedMoveFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode) {}
	public  void ServerMoveNoBase(float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte CompressedMoveFlags,byte ClientRoll,uint View,byte ClientMovementMode) {}
	public  void ServerMoveDual(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode) {}
	public  void ServerMoveDualNoBase(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,byte ClientMovementMode) {}
	public  void ServerMoveDualHybridRootMotion(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode) {}
	public  void ServerMoveOld(float OldTimeStamp,FVector_NetQuantize10 OldAccel,byte OldMoveFlags) {}
	public  void ClientAckGoodMove(float TimeStamp) {}
	public  void ClientAdjustPosition(float TimeStamp,FVector NewLoc,FVector NewVel,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode) {}
	public  void ClientVeryShortAdjustPosition(float TimeStamp,FVector NewLoc,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode) {}
	public  void ClientAdjustRootMotionPosition(float TimeStamp,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode) {}
	public  void ClientAdjustRootMotionSourcePosition(float TimeStamp,FRootMotionSourceGroup ServerRootMotion,bool bHasAnimRootMotion,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode) {}
	public  void CacheInitialMeshOffset(FVector MeshRelativeLocation,FRotator MeshRelativeRotation) {}
	public FBasedMovementInfo BasedMovement;
	public FBasedMovementInfo ReplicatedBasedMovement;
	public float AnimRootMotionTranslationScale;
	public  void OnRep_ReplicatedBasedMovement() {}
	public FVector BaseTranslationOffset;
	public FQuat BaseRotationOffset;
	public float ReplicatedServerLastTransformUpdateTimeStamp;
	public float ReplayLastTransformUpdateTimeStamp;
	public byte ReplicatedMovementMode;
	public bool bInBaseReplication;
	public  void OnRep_ReplayLastTransformUpdateTimeStamp() {}
	public  FVector GetBaseTranslationOffset() { return default; }
	public  FRotator GetBaseRotationOffsetRotator() { return default; }
	public float CrouchedEyeHeight;
	public bool bIsCrouched;
	public bool bProxyIsJumpForceApplied;
	public  void OnRep_IsCrouched() {}
	public bool bPressedJump;
	public bool bClientUpdating;
	public bool bClientWasFalling;
	public bool bClientResimulateRootMotion;
	public bool bClientResimulateRootMotionSources;
	public bool bSimGravityDisabled;
	public bool bClientCheckEncroachmentOnNetUpdate;
	public bool bServerMoveIgnoreRootMotion;
	public bool bWasJumping;
	public float JumpKeyHoldTime;
	public float JumpForceTimeRemaining;
	public float ProxyJumpForceStartedTime;
	public float JumpMaxHoldTime;
	public int JumpMaxCount;
	public int JumpCurrentCount;
	public int JumpCurrentCountPreJump;
	public  void Jump() {}
	public  void StopJumping() {}
	public  bool CanJump() { return default; }
	public  bool CanJumpInternal() { return default; }
	public  bool IsJumpProvidingForce() { return default; }
	public  float PlayAnimMontage(UAnimMontage AnimMontage,float InPlayRate/*=1.0f*/,string StartSectionName/*=NAME_None*/) { return default; }
	public  void StopAnimMontage(UAnimMontage AnimMontage/*=nullptr*/) {}
	public  UAnimMontage GetCurrentMontage() { return default; }
	public  void LaunchCharacter(FVector LaunchVelocity,bool bXYOverride,bool bZOverride) {}
	public  void OnLaunched(FVector LaunchVelocity,bool bXYOverride,bool bZOverride) {}
	public  void OnJumped() {}
	public FCharacterReachedApexSignature OnReachedJumpApex;
	public FLandedSignature LandedDelegate;
	public  void OnLanded(FHitResult Hit) {}
	public  void OnWalkingOffLedge(FVector PreviousFloorImpactNormal,FVector PreviousFloorContactNormal,FVector PreviousLocation,float TimeDelta) {}
	public  void Crouch(bool bClientSimulation/*=false*/) {}
	public  void UnCrouch(bool bClientSimulation/*=false*/) {}
	public  bool CanCrouch() { return default; }
	public  void K2_OnEndCrouch(float HalfHeightAdjust,float ScaledHalfHeightAdjust) {}
	public  void K2_OnStartCrouch(float HalfHeightAdjust,float ScaledHalfHeightAdjust) {}
	public FMovementModeChangedSignature MovementModeChangedDelegate;
	public  void K2_OnMovementModeChanged(EMovementMode PrevMovementMode,EMovementMode NewMovementMode,byte PrevCustomMode,byte NewCustomMode) {}
	public  void K2_UpdateCustomMovement(float DeltaTime) {}
	public FCharacterMovementUpdatedSignature OnCharacterMovementUpdated;
	public  void ClientCheatWalk() {}
	public  void ClientCheatFly() {}
	public  void ClientCheatGhost() {}
	public  void RootMotionDebugClientPrintOnScreen(string InString) {}
	public FRootMotionSourceGroup SavedRootMotion;
	public FRootMotionMovementParams ClientRootMotionParams;
	public TArray<FSimulatedRootMotionReplicatedMove> RootMotionRepMoves;
	public FRepRootMotionMontage RepRootMotion;
	public  void OnRep_RootMotion() {}
	public  bool IsPlayingRootMotion() { return default; }
	public  bool HasAnyRootMotion() { return default; }
	public  bool IsPlayingNetworkedRootMotionMontage() { return default; }
	public  float GetAnimRootMotionTranslationScale() { return default; }
}
