#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Characters are Pawns that have a mesh, collision, and built-in movement logic.</summary>
[CppInclude("GameFramework/Character.h")]
public partial class ACharacter : APawn {
	///<summary>The main skeletal mesh associated with this Character (optional sub-object).</summary>
	public USkeletalMeshComponent Mesh;
	///<summary>Movement component used for movement logic in various movement modes (walking, falling, etc), containing relevant settings and functions to control movement.</summary>
	public UCharacterMovementComponent CharacterMovement;
	///<summary>The CapsuleComponent being used for movement collision (by CharacterMovement). Always treated as being vertically aligned in simple collision check functions.</summary>
	public UCapsuleComponent CapsuleComponent;
	///<summary>Component shown in the editor only to indicate character facing</summary>
	public UArrowComponent ArrowComponent;
	///<summary>Server RPC that passes through to CharacterMovement (avoids RPC overhead for components).</summary>
	public  void ServerMovePacked(FCharacterServerMovePackedBits PackedBits) {}
	///<summary>Client RPC that passes through to CharacterMovement (avoids RPC overhead for components).</summary>
	public  void ClientMoveResponsePacked(FCharacterMoveResponsePackedBits PackedBits) {}
	///<summary>ServerMove</summary>
	public  void ServerMove(float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte CompressedMoveFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode) {}
	///<summary>ServerMoveNoBase</summary>
	public  void ServerMoveNoBase(float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte CompressedMoveFlags,byte ClientRoll,uint View,byte ClientMovementMode) {}
	///<summary>ServerMoveDual</summary>
	public  void ServerMoveDual(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode) {}
	///<summary>ServerMoveDualNoBase</summary>
	public  void ServerMoveDualNoBase(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,byte ClientMovementMode) {}
	///<summary>ServerMoveDualHybridRootMotion</summary>
	public  void ServerMoveDualHybridRootMotion(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode) {}
	///<summary>ServerMoveOld</summary>
	public  void ServerMoveOld(float OldTimeStamp,FVector_NetQuantize10 OldAccel,byte OldMoveFlags) {}
	///<summary>ClientAckGoodMove</summary>
	public  void ClientAckGoodMove(float TimeStamp) {}
	///<summary>ClientAdjustPosition</summary>
	public  void ClientAdjustPosition(float TimeStamp,FVector NewLoc,FVector NewVel,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode) {}
	///<summary>Bandwidth saving version, when velocity is zeroed</summary>
	public  void ClientVeryShortAdjustPosition(float TimeStamp,FVector NewLoc,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode) {}
	///<summary>ClientAdjustRootMotionPosition</summary>
	public  void ClientAdjustRootMotionPosition(float TimeStamp,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode) {}
	///<summary>ClientAdjustRootMotionSourcePosition</summary>
	public  void ClientAdjustRootMotionSourcePosition(float TimeStamp,FRootMotionSourceGroup ServerRootMotion,bool bHasAnimRootMotion,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode) {}
	///<summary>Cache mesh offset from capsule. This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing.</summary>
	public  void CacheInitialMeshOffset(FVector MeshRelativeLocation,FRotator MeshRelativeRotation) {}
	///<summary>Info about our current movement base (object we are standing on).</summary>
	public FBasedMovementInfo BasedMovement;
	///<summary>Replicated version of relative movement. Read-only on simulated proxies!</summary>
	public FBasedMovementInfo ReplicatedBasedMovement;
	///<summary>Scale to apply to root motion translation on this Character</summary>
	public float AnimRootMotionTranslationScale;
	///<summary>Rep notify for ReplicatedBasedMovement</summary>
	public  void OnRep_ReplicatedBasedMovement() {}
	///<summary>Saved translation offset of mesh.</summary>
	public FVector BaseTranslationOffset;
	///<summary>Saved rotation offset of mesh.</summary>
	public FQuat BaseRotationOffset;
	///<summary>CharacterMovement ServerLastTransformUpdateTimeStamp value, replicated to simulated proxies.</summary>
	public float ReplicatedServerLastTransformUpdateTimeStamp;
	///<summary>ReplayLastTransformUpdateTimeStamp</summary>
	public float ReplayLastTransformUpdateTimeStamp;
	///<summary>CharacterMovement MovementMode (and custom mode) replicated for simulated proxies. Use CharacterMovementComponent::UnpackNetworkMovementMode() to translate it.</summary>
	public byte ReplicatedMovementMode;
	///<summary>Flag that we are receiving replication of the based movement.</summary>
	public bool bInBaseReplication;
	///<summary>OnRep_ReplayLastTransformUpdateTimeStamp</summary>
	public  void OnRep_ReplayLastTransformUpdateTimeStamp() {}
	///<summary>Get the saved translation offset of mesh. This is how much extra offset is applied from the center of the capsule.</summary>
	public  FVector GetBaseTranslationOffset() { return default; }
	///<summary>Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation.</summary>
	public  FRotator GetBaseRotationOffsetRotator() { return default; }
	///<summary>Default crouched eye height</summary>
	public float CrouchedEyeHeight;
	///<summary>Set by character movement to specify that this Character is currently crouched.</summary>
	public bool bIsCrouched;
	///<summary>Set to indicate that this Character is currently under the force of a jump (if JumpMaxHoldTime is non-zero). IsJumpProvidingForce() handles this as well.</summary>
	public bool bProxyIsJumpForceApplied;
	///<summary>Handle Crouching replicated from server</summary>
	public  void OnRep_IsCrouched() {}
	///<summary>When true, player wants to jump</summary>
	public bool bPressedJump;
	///<summary>When true, applying updates to network client (replaying saved moves for a locally controlled character)</summary>
	public bool bClientUpdating;
	///<summary>True if Pawn was initially falling when started to replay network moves.</summary>
	public bool bClientWasFalling;
	///<summary>If server disagrees with root motion track position, client has to resimulate root motion from last AckedMove.</summary>
	public bool bClientResimulateRootMotion;
	///<summary>If server disagrees with root motion state, client has to resimulate root motion from last AckedMove.</summary>
	public bool bClientResimulateRootMotionSources;
	///<summary>Disable simulated gravity (set when character encroaches geometry on client, to keep it from falling through floors)</summary>
	public bool bSimGravityDisabled;
	///<summary>bClientCheckEncroachmentOnNetUpdate</summary>
	public bool bClientCheckEncroachmentOnNetUpdate;
	///<summary>Disable root motion on the server. When receiving a DualServerMove, where the first move is not root motion and the second is.</summary>
	public bool bServerMoveIgnoreRootMotion;
	///<summary>Tracks whether or not the character was already jumping last frame.</summary>
	public bool bWasJumping;
	///<summary>Jump key Held Time.</summary>
	public float JumpKeyHoldTime;
	///<summary>Amount of jump force time remaining, if JumpMaxHoldTime &gt; 0.</summary>
	public float JumpForceTimeRemaining;
	///<summary>Track last time a jump force started for a proxy.</summary>
	public float ProxyJumpForceStartedTime;
	///<summary>The max time the jump key can be held.</summary>
	public float JumpMaxHoldTime;
	///<summary>The max number of jumps the character can perform.</summary>
	public int JumpMaxCount;
	///<summary>Tracks the current number of jumps performed.</summary>
	public int JumpCurrentCount;
	///<summary>Represents the current number of jumps performed before CheckJumpInput modifies JumpCurrentCount.</summary>
	public int JumpCurrentCountPreJump;
	///<summary>Make the character jump on the next update.</summary>
	public  void Jump() {}
	///<summary>Stop the character from jumping on the next update.</summary>
	public  void StopJumping() {}
	///<summary>Check if the character can jump in the current state.</summary>
	public  bool CanJump() { return default; }
	///<summary>Customizable event to check if the character can jump in the current state.</summary>
	public  bool CanJumpInternal() { return default; }
	///<summary>True if jump is actively providing a force, such as when the jump key is held and the time it has been held is less than JumpMaxHoldTime.</summary>
	public  bool IsJumpProvidingForce() { return default; }
	///<summary>Play Animation Montage on the character mesh. Returns the length of the animation montage in seconds, or 0.f if failed to play. *</summary>
	public  float PlayAnimMontage(UAnimMontage AnimMontage,float InPlayRate/*=1.0f*/,string StartSectionName/*=NAME_None*/) { return default; }
	///<summary>Stop Animation Montage. If nullptr, it will stop what&#39;s currently active. The Blend Out Time is taken from the montage asset that is being stopped. *</summary>
	public  void StopAnimMontage(UAnimMontage AnimMontage/*=nullptr*/) {}
	///<summary>Return current playing Montage *</summary>
	public  UAnimMontage GetCurrentMontage() { return default; }
	///<summary>Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick,</summary>
	public  void LaunchCharacter(FVector LaunchVelocity,bool bXYOverride,bool bZOverride) {}
	///<summary>Let blueprint know that we were launched</summary>
	public  void OnLaunched(FVector LaunchVelocity,bool bXYOverride,bool bZOverride) {}
	///<summary>Event fired when the character has just started jumping</summary>
	public  void OnJumped() {}
	///<summary>Broadcast when Character&#39;s jump reaches its apex. Needs CharacterMovement-&gt;bNotifyApex = true</summary>
	public FCharacterReachedApexSignature OnReachedJumpApex;
	///<summary>Called upon landing when falling, to perform actions based on the Hit result.</summary>
	public FLandedSignature LandedDelegate;
	///<summary>Called upon landing when falling, to perform actions based on the Hit result.</summary>
	public  void OnLanded(FHitResult Hit) {}
	///<summary>Event fired when the Character is walking off a surface and is about to fall because CharacterMovement-&gt;CurrentFloor became unwalkable.</summary>
	public  void OnWalkingOffLedge(FVector PreviousFloorImpactNormal,FVector PreviousFloorContactNormal,FVector PreviousLocation,float TimeDelta) {}
	///<summary>Request the character to start crouching. The request is processed on the next update of the CharacterMovementComponent.</summary>
	public  void Crouch(bool bClientSimulation/*=false*/) {}
	///<summary>Request the character to stop crouching. The request is processed on the next update of the CharacterMovementComponent.</summary>
	public  void UnCrouch(bool bClientSimulation/*=false*/) {}
	///<summary>@return true if this character is currently able to crouch (and is not currently crouched)</summary>
	public  bool CanCrouch() { return default; }
	///<summary>Event when Character stops crouching.</summary>
	public  void K2_OnEndCrouch(float HalfHeightAdjust,float ScaledHalfHeightAdjust) {}
	///<summary>Event when Character crouches.</summary>
	public  void K2_OnStartCrouch(float HalfHeightAdjust,float ScaledHalfHeightAdjust) {}
	///<summary>Multicast delegate for MovementMode changing.</summary>
	public FMovementModeChangedSignature MovementModeChangedDelegate;
	///<summary>Called from CharacterMovementComponent to notify the character that the movement mode has changed.</summary>
	public  void K2_OnMovementModeChanged(EMovementMode PrevMovementMode,EMovementMode NewMovementMode,byte PrevCustomMode,byte NewCustomMode) {}
	///<summary>Event for implementing custom character movement mode. Called by CharacterMovement if MovementMode is set to Custom.</summary>
	public  void K2_UpdateCustomMovement(float DeltaTime) {}
	///<summary>Event triggered at the end of a CharacterMovementComponent movement update.</summary>
	public FCharacterMovementUpdatedSignature OnCharacterMovementUpdated;
	///<summary>ClientCheatWalk</summary>
	public  void ClientCheatWalk() {}
	///<summary>ClientCheatFly</summary>
	public  void ClientCheatFly() {}
	///<summary>ClientCheatGhost</summary>
	public  void ClientCheatGhost() {}
	///<summary>RootMotionDebugClientPrintOnScreen</summary>
	public  void RootMotionDebugClientPrintOnScreen(string InString) {}
	///<summary>For LocallyControlled Autonomous clients.</summary>
	public FRootMotionSourceGroup SavedRootMotion;
	///<summary>For LocallyControlled Autonomous clients. Saved root motion data to be used by SavedMoves.</summary>
	public FRootMotionMovementParams ClientRootMotionParams;
	///<summary>Array of previously received root motion moves from the server.</summary>
	public TArray<FSimulatedRootMotionReplicatedMove> RootMotionRepMoves;
	///<summary>Replicated Root Motion montage</summary>
	public FRepRootMotionMontage RepRootMotion;
	///<summary>Handles replicated root motion properties on simulated proxies and position correction.</summary>
	public  void OnRep_RootMotion() {}
	///<summary>True if we are playing Anim root motion right now</summary>
	public  bool IsPlayingRootMotion() { return default; }
	///<summary>True if we are playing root motion from any source right now (anim root motion, root motion source)</summary>
	public  bool HasAnyRootMotion() { return default; }
	///<summary>True if we are playing Root Motion right now, through a Montage with RootMotionMode == ERootMotionMode::RootMotionFromMontagesOnly.</summary>
	public  bool IsPlayingNetworkedRootMotionMontage() { return default; }
	///<summary>Returns current value of AnimRootMotionScale</summary>
	public  float GetAnimRootMotionTranslationScale() { return default; }
}
