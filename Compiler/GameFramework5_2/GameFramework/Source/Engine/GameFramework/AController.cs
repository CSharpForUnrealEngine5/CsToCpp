#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Controller.h")]
///<summary>Controllers are non-physical actors that can possess a Pawn to control</summary>
public partial class AController : AActor {
// Controller
	public APlayerState PlayerState;
	public FInstigatedAnyDamageSignature OnInstigatedAnyDamage;
	public FOnPossessedPawnChanged OnPossessedPawnChanged;
	public string StateName;
	public APawn Pawn;
	public ACharacter Character;
	public USceneComponent TransformComponent;
	public FRotator ControlRotation;
	public bool bAttachToPawn;
	public  FRotator GetControlRotation() { return default; }
	public  void SetControlRotation(FRotator NewRotation) {}
	public  void SetInitialLocationAndRotation(FVector NewLocation,FRotator NewRotation) {}
	public  bool LineOfSightTo(AActor Other,FVector ViewPoint/*=new FVector(ForceInit)*/,bool bAlternateChecks/*=false*/) { return default; }
	public  void OnRep_Pawn() {}
	public  void OnRep_PlayerState() {}
	public  void ClientSetLocation(FVector NewLocation,FRotator NewRotation) {}
	public  void ClientSetRotation(FRotator NewRotation,bool bResetCamera) {}
	public  APawn K2_GetPawn() { return default; }
	public  AActor GetViewTarget() { return default; }
	public  FRotator GetDesiredRotation() { return default; }
	public  bool IsPlayerController() { return default; }
	public  bool IsLocalPlayerController() { return default; }
	public  bool IsLocalController() { return default; }
	public  void Possess(APawn InPawn) {}
	public  void UnPossess() {}
	public  void ReceivePossess(APawn PossessedPawn) {}
	public  void ReceiveUnPossess(APawn UnpossessedPawn) {}
	public  void GetPlayerViewPoint(FVector Location,FRotator Rotation) {}
	public  void StopMovement() {}
	public  void SetIgnoreMoveInput(bool bNewMoveInput) {}
	public  void ResetIgnoreMoveInput() {}
	public  bool IsMoveInputIgnored() { return default; }
	public  void SetIgnoreLookInput(bool bNewLookInput) {}
	public  void ResetIgnoreLookInput() {}
	public  bool IsLookInputIgnored() { return default; }
	public  void ResetIgnoreInputFlags() {}
	public  void ReceiveInstigatedAnyDamage(float Damage,UDamageType DamageType,AActor DamagedActor,AActor DamageCauser) {}
}
