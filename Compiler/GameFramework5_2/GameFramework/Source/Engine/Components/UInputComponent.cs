#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/InputComponent.h")]
///<summary>Implement an Actor component for input bindings.</summary>
public partial class UInputComponent : UActorComponent {
// InputComponent
	public TArray<FCachedKeyToActionInfo> CachedKeyToActionInfo;
	public  void OnInputOwnerEndPlayed(AActor InOwner,EEndPlayReason EndPlayReason) {}
	public  bool IsControllerKeyDown(FKey Key) { return default; }
	public  bool WasControllerKeyJustPressed(FKey Key) { return default; }
	public  bool WasControllerKeyJustReleased(FKey Key) { return default; }
	public  float GetControllerAnalogKeyState(FKey Key) { return default; }
	public  FVector GetControllerVectorKeyState(FKey Key) { return default; }
	public  void GetTouchState(int FingerIndex,float LocationX,float LocationY,bool bIsCurrentlyPressed) {}
	public  float GetControllerKeyTimeDown(FKey Key) { return default; }
	public  void GetControllerMouseDelta(float DeltaX,float DeltaY) {}
	public  void GetControllerAnalogStickState(EControllerAnalogStick WhichStick,float StickX,float StickY) {}
}
