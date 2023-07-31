#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the interactor in the world</summary>
[CppInclude("ViewportInteractor.h")]
public partial class UViewportInteractor : UObject {
	///<summary>Gets the world interaction</summary>
	public  UViewportWorldInteraction GetWorldInteraction() { return default; }
	///<summary>Gets the paired interactor assigned by the world interaction, can return null when there is no other interactor</summary>
	public  UViewportInteractor GetOtherInteractor() { return default; }
	///<summary>Whenever the ViewportWorldInteraction is shut down, the interacts will shut down as well</summary>
	public  void Shutdown() {}
	///<summary>Update for this interactor called by the ViewportWorldInteraction</summary>
	public  void Tick(float DeltaTime) {}
	///<summary>Gets the world transform of this interactor</summary>
	public  FTransform GetTransform() { return default; }
	///<summary>Gets the hand transform of the interactor, in the local tracking space</summary>
	public  FTransform GetRoomSpaceTransform() { return default; }
	///<summary>Gets the last world transform of this interactor</summary>
	public  FTransform GetLastTransform() { return default; }
	///<summary>Gets the last hand transform of the interactor, in the local tracking space</summary>
	public  FTransform GetLastRoomSpaceTransform() { return default; }
	///<summary>Gets the current interactor data dragging mode</summary>
	public  EViewportInteractionDraggingMode GetDraggingMode() { return default; }
	///<summary>Gets the start and end point of the laser pointer for the specified hand</summary>
	public  bool GetLaserPointer(FVector LaserPointerStart,FVector LaserPointerEnd,bool bEvenIfBlocked/*=false*/,float LaserLengthOverride/*=0.0f*/) { return default; }
	///<summary>Creates a hand transform and forward vector for a laser pointer for a given hand</summary>
	public  bool GetTransformAndForwardVector(FTransform OutHandTransform,FVector OutForwardVector) { return default; }
	///<summary>Gets the interactor laser hover location</summary>
	public  FVector GetHoverLocation() { return default; }
	///<summary>If the interactor laser is currently hovering over a gizmo handle</summary>
	public  bool IsHoveringOverGizmo() { return default; }
	///<summary>Sets the current dragging mode for this interactor</summary>
	public  void SetDraggingMode(EViewportInteractionDraggingMode NewDraggingMode) {}
	///<summary>Sets the current gizmo filter mode used for Interaction</summary>
	public  void SetHitResultGizmoFilterMode(EHitResultGizmoFilterMode newFilter) {}
	///<summary>Gets current gizmo filter mode used for Interaction</summary>
	public  EHitResultGizmoFilterMode GetHitResultGizmoFilterMode() { return default; }
	///<summary>Sets if the interactor can carry an object</summary>
	public  void SetCanCarry(bool bInCanCarry) {}
	///<summary>Gets if the interactor can carry an object</summary>
	public  bool CanCarry() { return default; }
	///<summary>To be overridden. Called by HandleInputKey before delegates and default input implementation</summary>
	public  void HandleInputKey_BP(FViewportActionKeyInput Action,FKey Key,EInputEvent Event,bool bOutWasHandled) {}
	///<summary>To be overridden. Called by HandleInputAxis before delegates and default input implementation</summary>
	public  void HandleInputAxis_BP(FViewportActionKeyInput Action,FKey Key,float Delta,float DeltaTime,bool bOutWasHandled) {}
	///<summary>Mapping of raw keys to actions</summary>
	public TMap<FKey,FViewportActionKeyInput> KeyToActionMap;
	///<summary>The owning world interaction</summary>
	public UViewportWorldInteraction WorldInteraction;
	///<summary>The paired interactor by the world interaction</summary>
	public UViewportInteractor OtherInteractor;
}
