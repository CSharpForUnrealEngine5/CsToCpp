namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controllers are non-physical actors that can possess a Pawn to control</summary>
[CppInclude("GameFramework/Controller.h")]
public partial class AController : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>PlayerState containing replicated information about the player using this controller (only exists for players, not NPCs).</summary>
	public APlayerState PlayerState;
	///<summary>Called when the controller has instigated damage in any way</summary>
	public FInstigatedAnyDamageSignature OnInstigatedAnyDamage;
	///<summary>Called on both authorities and clients when the possessed pawn changes (either OldPawn or NewPawn might be nullptr)</summary>
	public FOnPossessedPawnChanged OnPossessedPawnChanged;
	///<summary>Current gameplay state this controller is in</summary>
	public FName StateName;
	///<summary>Pawn currently being controlled by this controller.  Use Pawn.Possess() to take control of a pawn</summary>
	public APawn Pawn;
	///<summary>Character currently being controlled by this controller.  Value is same as Pawn if the controlled pawn is a character, otherwise nullptr</summary>
	public ACharacter Character;
	///<summary>Component to give controllers a transform and enable attachment if desired.</summary>
	public USceneComponent TransformComponent;
	///<summary>The control rotation of the Controller. See GetControlRotation.</summary>
	public FRotator ControlRotation;
	///<summary>If true, the controller location will match the possessed Pawn&#39;s location. If false, it will not be updated. Rotation will match ControlRotation in either case.</summary>
	public bool bAttachToPawn;
	///<summary>Get the control rotation. This is the full aim rotation, which may be different than a camera orientation (for example in a third person view),</summary>
	public virtual FRotator GetControlRotation() { return default; }
	///<summary>Set the control rotation.</summary>
	public virtual void SetControlRotation(FRotator NewRotation) {}
	///<summary>Set the initial location and rotation of the controller, as well as the control rotation. Typically used when the controller is first created.</summary>
	public virtual void SetInitialLocationAndRotation(FVector NewLocation,FRotator NewRotation) {}
	///<summary>Checks line to center and top of other actor</summary>
	public virtual bool LineOfSightTo(AActor Other,FVector ViewPoint/*=new FVector(ForceInit)*/,bool bAlternateChecks/*=false*/) { return default; }
	///<summary>Replication Notification Callbacks</summary>
	public virtual void OnRep_Pawn() {}
	///<summary>OnRep_PlayerState</summary>
	public virtual void OnRep_PlayerState() {}
	///<summary>Replicated function to set the pawn location and rotation, allowing server to force (ex. teleports).</summary>
	public void ClientSetLocation(FVector NewLocation,FRotator NewRotation) {}
	///<summary>Replicated function to set the pawn rotation, allowing the server to force.</summary>
	public void ClientSetRotation(FRotator NewRotation,bool bResetCamera) {}
	///<summary>Return the Pawn that is currently &#39;controlled&#39; by this PlayerController</summary>
	public APawn K2_GetPawn() { return default; }
	///<summary>Get the actor the controller is looking at</summary>
	public virtual AActor GetViewTarget() { return default; }
	///<summary>Get the desired pawn target rotation</summary>
	public virtual FRotator GetDesiredRotation() { return default; }
	///<summary>Returns whether this Controller is a PlayerController.</summary>
	public bool IsPlayerController() { return default; }
	///<summary>Returns whether this Controller is a locally controlled PlayerController.</summary>
	public bool IsLocalPlayerController() { return default; }
	///<summary>Returns whether this Controller is a local controller.</summary>
	public virtual bool IsLocalController() { return default; }
	///<summary>Handles attaching this controller to the specified pawn.</summary>
	public virtual void Possess(APawn InPawn) {}
	///<summary>Called to unpossess our pawn for any reason that is not the pawn being destroyed (destruction handled by PawnDestroyed()).</summary>
	public virtual void UnPossess() {}
	///<summary>Blueprint implementable event to react to the controller possessing a pawn</summary>
	public void ReceivePossess(APawn PossessedPawn) {}
	///<summary>Blueprint implementable event to react to the controller unpossessing a pawn</summary>
	public void ReceiveUnPossess(APawn UnpossessedPawn) {}
	///<summary>Returns Player&#39;s Point of View</summary>
	public virtual void GetPlayerViewPoint(FVector Location,FRotator Rotation) {}
	///<summary>Aborts the move the controller is currently performing</summary>
	public virtual void StopMovement() {}
	///<summary>Locks or unlocks movement input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreMoveInput.</summary>
	public virtual void SetIgnoreMoveInput(bool bNewMoveInput) {}
	///<summary>Stops ignoring move input by resetting the ignore move input state.</summary>
	public virtual void ResetIgnoreMoveInput() {}
	///<summary>Returns true if movement input is ignored.</summary>
	public virtual bool IsMoveInputIgnored() { return default; }
	///<summary>Locks or unlocks look input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreLookInput.</summary>
	public virtual void SetIgnoreLookInput(bool bNewLookInput) {}
	///<summary>Stops ignoring look input by resetting the ignore look input state.</summary>
	public virtual void ResetIgnoreLookInput() {}
	///<summary>Returns true if look input is ignored.</summary>
	public virtual bool IsLookInputIgnored() { return default; }
	///<summary>Reset move and look input ignore flags.</summary>
	public virtual void ResetIgnoreInputFlags() {}
	///<summary>Event when this controller instigates ANY damage</summary>
	public void ReceiveInstigatedAnyDamage(float Damage,UDamageType DamageType,AActor DamagedActor,AActor DamageCauser) {}
}
