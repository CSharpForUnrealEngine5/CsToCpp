#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportInteractor.h")]
///<summary>Represents the interactor in the world</summary>
public partial class UViewportInteractor : UObject {
// ViewportInteractor
	public  UViewportWorldInteraction GetWorldInteraction() { return default; }
	public  UViewportInteractor GetOtherInteractor() { return default; }
	public  void Shutdown() {}
	public  void Tick(float DeltaTime) {}
	public  FTransform GetTransform() { return default; }
	public  FTransform GetRoomSpaceTransform() { return default; }
	public  FTransform GetLastTransform() { return default; }
	public  FTransform GetLastRoomSpaceTransform() { return default; }
	public  EViewportInteractionDraggingMode GetDraggingMode() { return default; }
	public  bool GetLaserPointer(FVector LaserPointerStart,FVector LaserPointerEnd,bool bEvenIfBlocked/*=false*/,float LaserLengthOverride/*=0.0f*/) { return default; }
	public  bool GetTransformAndForwardVector(FTransform OutHandTransform,FVector OutForwardVector) { return default; }
	public  FVector GetHoverLocation() { return default; }
	public  bool IsHoveringOverGizmo() { return default; }
	public  void SetDraggingMode(EViewportInteractionDraggingMode NewDraggingMode) {}
	public  void SetHitResultGizmoFilterMode(EHitResultGizmoFilterMode newFilter) {}
	public  EHitResultGizmoFilterMode GetHitResultGizmoFilterMode() { return default; }
	public  void SetCanCarry(bool bInCanCarry) {}
	public  bool CanCarry() { return default; }
	public  void HandleInputKey_BP(FViewportActionKeyInput Action,FKey Key,EInputEvent Event,bool bOutWasHandled) {}
	public  void HandleInputAxis_BP(FViewportActionKeyInput Action,FKey Key,float Delta,float DeltaTime,bool bOutWasHandled) {}
	public TMap<FKey,FViewportActionKeyInput> KeyToActionMap;
	public UViewportWorldInteraction WorldInteraction;
	public UViewportInteractor OtherInteractor;
}
