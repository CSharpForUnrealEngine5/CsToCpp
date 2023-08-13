namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implement an Actor component for input bindings.</summary>
[CppInclude("Components/InputComponent.h")]
public partial class UInputComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CachedKeyToActionInfo</summary>
	public TArray<FCachedKeyToActionInfo> CachedKeyToActionInfo;
	///<summary>OnInputOwnerEndPlayed</summary>
	public void OnInputOwnerEndPlayed(AActor InOwner,EEndPlayReason EndPlayReason) {}
	///<summary>Returns true if the given key/button is pressed on the input of the controller (if present)</summary>
	public bool IsControllerKeyDown(FKey Key) { return default; }
	///<summary>Returns true if the given key/button was up last frame and down this frame.</summary>
	public bool WasControllerKeyJustPressed(FKey Key) { return default; }
	///<summary>Returns true if the given key/button was down last frame and up this frame.</summary>
	public bool WasControllerKeyJustReleased(FKey Key) { return default; }
	///<summary>Returns the analog value for the given key/button.  If analog isn&#39;t supported, returns 1 for down and 0 for up.</summary>
	public float GetControllerAnalogKeyState(FKey Key) { return default; }
	///<summary>Returns the vector value for the given key/button.</summary>
	public FVector GetControllerVectorKeyState(FKey Key) { return default; }
	///<summary>Returns the location of a touch, and if it&#39;s held down</summary>
	public void GetTouchState(int FingerIndex,float LocationX,float LocationY,bool bIsCurrentlyPressed) {}
	///<summary>Returns how long the given key/button has been down.  Returns 0 if it&#39;s up or it just went down this frame.</summary>
	public float GetControllerKeyTimeDown(FKey Key) { return default; }
	///<summary>Retrieves how far the mouse moved this frame.</summary>
	public void GetControllerMouseDelta(float DeltaX,float DeltaY) {}
	///<summary>Retrieves the X and Y displacement of the given analog stick.  For WhickStick, 0 = left, 1 = right.</summary>
	public void GetControllerAnalogStickState(EControllerAnalogStick WhichStick,float StickX,float StickY) {}
}
