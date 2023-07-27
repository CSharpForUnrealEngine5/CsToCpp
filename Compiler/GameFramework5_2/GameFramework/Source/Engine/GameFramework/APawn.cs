#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Pawn.h")]
///<summary>Pawn is the base class of all actors that can be possessed by players or AI.</summary>
public partial class APawn : AActor {
// Pawn
	public  UPawnMovementComponent GetMovementComponent() { return default; }
	public bool bUseControllerRotationPitch;
	public bool bUseControllerRotationYaw;
	public bool bUseControllerRotationRoll;
	public bool bCanAffectNavigationGeneration;
	public bool bIsLocalViewTarget;
	public float BaseEyeHeight;
	public byte AutoPossessPlayer;
	public EAutoPossessAI AutoPossessAI;
	public byte RemoteViewPitch;
	public UClass AIControllerClass;
	public  void PawnMakeNoise(float Loudness,FVector NoiseLocation,bool bUseNoiseMakerLocation/*=true*/,AActor NoiseMaker/*=nullptr*/) {}
	public  APlayerController GetLocalViewingPlayerController() { return default; }
	public  bool IsLocallyViewed() { return default; }
	public APlayerState PlayerState;
	public AController LastHitBy;
	public AController Controller;
	public AController PreviousController;
	public static AActor GetMovementBaseActor(APawn Pawn) { return default; }
	public  bool IsControlled() { return default; }
	public  bool IsPawnControlled() { return default; }
	public  AController GetController() { return default; }
	public  FRotator GetControlRotation() { return default; }
	public  void OnRep_Controller() {}
	public  void OnRep_PlayerState() {}
	public  void SetCanAffectNavigationGeneration(bool bNewValue,bool bForceUpdate/*=false*/) {}
	public  FVector GetNavAgentLocation() { return default; }
	public  void ReceivePossessed(AController NewController) {}
	public  void ReceiveUnpossessed(AController OldController) {}
	public  void ReceiveControllerChanged(AController OldController,AController NewController) {}
	public FPawnControllerChangedSignature ReceiveControllerChangedDelegate;
	public  void ReceiveRestarted() {}
	public FPawnRestartedSignature ReceiveRestartedDelegate;
	public  bool IsLocallyControlled() { return default; }
	public  FPlatformUserId GetPlatformUserId() { return default; }
	public  bool IsPlayerControlled() { return default; }
	public  bool IsBotControlled() { return default; }
	public  FRotator GetBaseAimRotation() { return default; }
	public  void DetachFromControllerPendingDestroy() {}
	public  void SpawnDefaultController() {}
	public  void AddMovementInput(FVector WorldDirection,float ScaleValue/*=1.0f*/,bool bForce/*=false*/) {}
	public  FVector GetPendingMovementInputVector() { return default; }
	public  FVector GetLastMovementInputVector() { return default; }
	public  FVector ConsumeMovementInputVector() { return default; }
	public  void AddControllerPitchInput(float Val) {}
	public  void AddControllerYawInput(float Val) {}
	public  void AddControllerRollInput(float Val) {}
	public  bool IsMoveInputIgnored() { return default; }
	public  UClass GetOverrideInputComponentClass() { return default; }
	public FVector ControlInputVector;
	public FVector LastControlInputVector;
	public UClass OverrideInputComponentClass;
}
