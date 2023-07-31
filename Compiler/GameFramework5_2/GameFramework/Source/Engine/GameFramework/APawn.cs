#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pawn is the base class of all actors that can be possessed by players or AI.</summary>
[CppInclude("GameFramework/Pawn.h")]
public partial class APawn : AActor {
	///<summary>Return our PawnMovementComponent, if we have one.</summary>
	public  UPawnMovementComponent GetMovementComponent() { return default; }
	///<summary>If true, this Pawn&#39;s pitch will be updated to match the Controller&#39;s ControlRotation pitch, if controlled by a PlayerController.</summary>
	public bool bUseControllerRotationPitch;
	///<summary>If true, this Pawn&#39;s yaw will be updated to match the Controller&#39;s ControlRotation yaw, if controlled by a PlayerController.</summary>
	public bool bUseControllerRotationYaw;
	///<summary>If true, this Pawn&#39;s roll will be updated to match the Controller&#39;s ControlRotation roll, if controlled by a PlayerController.</summary>
	public bool bUseControllerRotationRoll;
	///<summary>If set to false (default) given pawn instance will never affect navigation generation (but components could).</summary>
	public bool bCanAffectNavigationGeneration;
	///<summary>bIsLocalViewTarget</summary>
	public bool bIsLocalViewTarget;
	///<summary>Base eye height above collision center.</summary>
	public float BaseEyeHeight;
	///<summary>Determines which PlayerController, if any, should automatically possess the pawn when the level starts or when the pawn is spawned.</summary>
	public EAutoReceiveInput AutoPossessPlayer;
	///<summary>Determines when the Pawn creates and is possessed by an AI Controller (on level start, when spawned, etc).</summary>
	public EAutoPossessAI AutoPossessAI;
	///<summary>Replicated so we can see where remote clients are looking.</summary>
	public byte RemoteViewPitch;
	///<summary>Default class to use when pawn is controlled by AI.</summary>
	public UClass AIControllerClass;
	///<summary>Inform AIControllers that you&#39;ve made a noise they might hear (they are sent a HearNoise message if they have bHearNoises==true)</summary>
	public  void PawnMakeNoise(float Loudness,FVector NoiseLocation,bool bUseNoiseMakerLocation/*=true*/,AActor NoiseMaker/*=nullptr*/) {}
	///<summary>Returns local Player Controller viewing this pawn, whether it is controlling or spectating</summary>
	public  APlayerController GetLocalViewingPlayerController() { return default; }
	///<summary>Is this pawn the ViewTarget of a local PlayerController?  Helpful for determining whether the pawn is</summary>
	public  bool IsLocallyViewed() { return default; }
	///<summary>If Pawn is possessed by a player, points to its Player State.  Needed for network play as controllers are not replicated to clients.</summary>
	public APlayerState PlayerState;
	///<summary>Controller of the last Actor that caused us damage.</summary>
	public AController LastHitBy;
	///<summary>Controller currently possessing this Actor</summary>
	public AController Controller;
	///<summary>Previous controller that was controlling this pawn since the last controller change notification</summary>
	public AController PreviousController;
	///<summary>Gets the owning actor of the Movement Base Component on which the pawn is standing.</summary>
	public static AActor GetMovementBaseActor(APawn Pawn) { return default; }
	///<summary>IsControlled</summary>
	public  bool IsControlled() { return default; }
	///<summary>Check if this actor is currently being controlled at all (the actor has a valid Controller, which will be false for remote clients)</summary>
	public  bool IsPawnControlled() { return default; }
	///<summary>Returns controller for this actor.</summary>
	public  AController GetController() { return default; }
	///<summary>Get the rotation of the Controller, often the &#39;view&#39; rotation of this Pawn.</summary>
	public  FRotator GetControlRotation() { return default; }
	///<summary>Called when Controller is replicated</summary>
	public  void OnRep_Controller() {}
	///<summary>PlayerState Replication Notification Callback</summary>
	public  void OnRep_PlayerState() {}
	///<summary>Use SetCanAffectNavigationGeneration to change this value at runtime.</summary>
	public  void SetCanAffectNavigationGeneration(bool bNewValue,bool bForceUpdate/*=false*/) {}
	///<summary>Basically retrieved pawn&#39;s location on navmesh</summary>
	public  FVector GetNavAgentLocation() { return default; }
	///<summary>Event called when the Pawn is possessed by a Controller. Only called on the server (or in standalone)</summary>
	public  void ReceivePossessed(AController NewController) {}
	///<summary>Event called when the Pawn is no longer possessed by a Controller. Only called on the server (or in standalone)</summary>
	public  void ReceiveUnpossessed(AController OldController) {}
	///<summary>Event called after a pawn&#39;s controller has changed, on the server and owning client. This will happen at the same time as the delegate on GameInstance</summary>
	public  void ReceiveControllerChanged(AController OldController,AController NewController) {}
	///<summary>Event called after a pawn&#39;s controller has changed, on the server and owning client. This will happen at the same time as the delegate on GameInstance</summary>
	public FPawnControllerChangedSignature ReceiveControllerChangedDelegate;
	///<summary>Event called after a pawn has been restarted, usually by a possession change. This is called on the server for all pawns and the owning client for player pawns</summary>
	public  void ReceiveRestarted() {}
	///<summary>Event called after a pawn has been restarted, usually by a possession change. This is called on the server for all pawns and the owning client for player pawns</summary>
	public FPawnRestartedSignature ReceiveRestartedDelegate;
	///<summary>Returns true if controlled by a local (not network) Controller.</summary>
	public  bool IsLocallyControlled() { return default; }
	///<summary>Returns the Platform User ID of the PlayerController that is controlling this character.</summary>
	public  FPlatformUserId GetPlatformUserId() { return default; }
	///<summary>Returns true if controlled by a human player (possessed by a PlayerController).        This returns true for players controlled by remote clients</summary>
	public  bool IsPlayerControlled() { return default; }
	///<summary>Returns true if controlled by a bot.</summary>
	public  bool IsBotControlled() { return default; }
	///<summary>Return the aim rotation for the Pawn.</summary>
	public  FRotator GetBaseAimRotation() { return default; }
	///<summary>Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon.</summary>
	public  void DetachFromControllerPendingDestroy() {}
	///<summary>Spawn default controller for this Pawn, and get possessed by it.</summary>
	public  void SpawnDefaultController() {}
	///<summary>Add movement input along the given world direction vector (usually normalized) scaled by &#39;ScaleValue&#39;. If ScaleValue &lt; 0, movement will be in the opposite direction.</summary>
	public  void AddMovementInput(FVector WorldDirection,float ScaleValue/*=1.0f*/,bool bForce/*=false*/) {}
	///<summary>Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it,</summary>
	public  FVector GetPendingMovementInputVector() { return default; }
	///<summary>Return the last input vector in world space that was processed by ConsumeMovementInputVector(), which is usually done by the Pawn or PawnMovementComponent.</summary>
	public  FVector GetLastMovementInputVector() { return default; }
	///<summary>Returns the pending input vector and resets it to zero.</summary>
	public  FVector ConsumeMovementInputVector() { return default; }
	///<summary>Add input (affecting Pitch) to the Controller&#39;s ControlRotation, if it is a local PlayerController.</summary>
	public  void AddControllerPitchInput(float Val) {}
	///<summary>Add input (affecting Yaw) to the Controller&#39;s ControlRotation, if it is a local PlayerController.</summary>
	public  void AddControllerYawInput(float Val) {}
	///<summary>Add input (affecting Roll) to the Controller&#39;s ControlRotation, if it is a local PlayerController.</summary>
	public  void AddControllerRollInput(float Val) {}
	///<summary>Helper to see if move input is ignored. If our controller is a PlayerController, checks Controller-&gt;IsMoveInputIgnored().</summary>
	public  bool IsMoveInputIgnored() { return default; }
	///<summary>GetOverrideInputComponentClass</summary>
	public  UClass GetOverrideInputComponentClass() { return default; }
	///<summary>Accumulated control input vector, stored in world space. This is the pending input, which is cleared (zeroed) once consumed.</summary>
	public FVector ControlInputVector;
	///<summary>The last control input vector that was processed by ConsumeMovementInputVector().</summary>
	public FVector LastControlInputVector;
	///<summary>If set, then this InputComponent class will be used instead of the Input Settings&#39; DefaultInputComponentClass</summary>
	public UClass OverrideInputComponentClass;
}
