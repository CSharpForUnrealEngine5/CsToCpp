namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Camera controller that allows you to fly around a level mostly unrestricted by normal movement rules.</summary>
[CppInclude("Engine/DebugCameraController.h")]
public partial class ADebugCameraController : APlayerController {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to show information about the selected actor on the debug camera HUD.</summary>
	public bool bShowSelectedInfo;
	///<summary>Saves whether the FreezeRendering console command is active</summary>
	public bool bIsFrozenRendering;
	///<summary>Whether to orbit selected actor.</summary>
	public bool bIsOrbitingSelectedActor;
	///<summary>When orbiting, true if using actor center as pivot, false if using last selected hitpoint</summary>
	public bool bOrbitPivotUseCenter;
	///<summary>Whether set view mode to display GBuffer visualization overview</summary>
	public bool bEnableBufferVisualization;
	///<summary>Whether set view mode to display GBuffer visualization full</summary>
	public bool bEnableBufferVisualizationFullMode;
	///<summary>Whether GBuffer visualization overview inputs are set up</summary>
	public bool bIsBufferVisualizationInputSetup;
	///<summary>Last display enabled setting before toggling buffer visualization overview</summary>
	public bool bLastDisplayEnabled;
	///<summary>Visualizes the frustum of the camera</summary>
	public UDrawFrustumComponent DrawFrustum;
	///<summary>Sets whether to show information about the selected actor on the debug camera HUD.</summary>
	public virtual void ShowDebugSelectedInfo() {}
	///<summary>Toggles the display of debug info and input commands for the Debug Camera.</summary>
	public void ToggleDisplay() {}
	///<summary>Currently selected actor, may be invalid</summary>
	public TWeakObjectPtr<AActor> SelectedActor;
	///<summary>Returns the currently selected actor, or null if it is invalid or not set</summary>
	public AActor GetSelectedActor() { return default; }
	///<summary>Currently selected component, may be invalid</summary>
	public TWeakObjectPtr<UPrimitiveComponent> SelectedComponent;
	///<summary>Selected hit point</summary>
	public FHitResult SelectedHitPoint;
	///<summary>Controller that was active before this was spawned</summary>
	public APlayerController OriginalControllerRef;
	///<summary>Player object that was active before this was spawned</summary>
	public UPlayer OriginalPlayer;
	///<summary>Allows control over the speed of the spectator pawn. This scales the speed based on the InitialMaxSpeed. Use Set Pawn Movement Speed Scale during runtime</summary>
	public float SpeedScale;
	///<summary>Sets the pawn movement speed scale.</summary>
	public void SetPawnMovementSpeedScale(float NewSpeedScale) {}
	///<summary>Initial max speed of the spectator pawn when we start possession.</summary>
	public float InitialMaxSpeed;
	///<summary>Initial acceleration of the spectator pawn when we start possession.</summary>
	public float InitialAccel;
	///<summary>Initial deceleration of the spectator pawn when we start possession.</summary>
	public float InitialDecel;
	///<summary>Function called on activation of debug camera controller.</summary>
	public void ReceiveOnActivate(APlayerController OriginalPC) {}
	///<summary>Function called on deactivation of debug camera controller.</summary>
	public void ReceiveOnDeactivate(APlayerController RestoredPC) {}
	///<summary>Called when an actor has been selected with the primary key (e.g. left mouse button).</summary>
	public void ReceiveOnActorSelected(AActor NewSelectedActor,FVector SelectHitLocation,FVector SelectHitNormal,FHitResult Hit) {}
}
