#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetInputLibrary.h")]
public partial class UKismetInputLibrary : UBlueprintFunctionLibrary {
	///<summary>Calibrate the tilt for the input device</summary>
	public static void CalibrateTilt() {}
	///<summary>Test if the input key are equal (A == B)</summary>
	public static bool EqualEqual_KeyKey(FKey A,FKey B) { return default; }
	///<summary>Test if the input chords are equal (A == B)</summary>
	public static bool EqualEqual_InputChordInputChord(FInputChord A,FInputChord B) { return default; }
	///<summary>Returns true if the key is a modifier key: Ctrl, Command, Alt, Shift</summary>
	public static bool Key_IsModifierKey(FKey Key) { return default; }
	///<summary>Returns true if the key is a gamepad button</summary>
	public static bool Key_IsGamepadKey(FKey Key) { return default; }
	///<summary>Returns true if the key is a mouse button</summary>
	public static bool Key_IsMouseButton(FKey Key) { return default; }
	///<summary>Returns true if the key is a keyboard button</summary>
	public static bool Key_IsKeyboardKey(FKey Key) { return default; }
	///<summary>Returns true if the key is a vector axis</summary>
	public static bool Key_IsVectorAxis(FKey Key) { return default; }
	///<summary>Returns true if the key is a 1D (float) axis</summary>
	public static bool Key_IsAxis1D(FKey Key) { return default; }
	///<summary>Returns true if the key is a 2D (vector) axis</summary>
	public static bool Key_IsAxis2D(FKey Key) { return default; }
	///<summary>Returns true if the key is a 3D (vector) axis</summary>
	public static bool Key_IsAxis3D(FKey Key) { return default; }
	///<summary>Returns true if the key is a 1D axis emulating a digital button press.</summary>
	public static bool Key_IsButtonAxis(FKey Key) { return default; }
	///<summary>Returns true if the key is an analog axis</summary>
	public static bool Key_IsAnalog(FKey Key) { return default; }
	///<summary>Returns true if the key is a digital button press</summary>
	public static bool Key_IsDigital(FKey Key) { return default; }
	///<summary>Returns true if this is a valid key.</summary>
	public static bool Key_IsValid(FKey Key) { return default; }
	///<summary>Key_GetNavigationAction</summary>
	public static EUINavigationAction Key_GetNavigationAction(FKey InKey) { return default; }
	///<summary>Returns the navigation action corresponding to this key, or Invalid if not found</summary>
	public static EUINavigationAction Key_GetNavigationActionFromKey(FKeyEvent InKeyEvent) { return default; }
	///<summary>Returns the navigation action corresponding to this key, or Invalid if not found</summary>
	public static EUINavigation Key_GetNavigationDirectionFromKey(FKeyEvent InKeyEvent) { return default; }
	///<summary>Returns the navigation action corresponding to this key, or Invalid if not found</summary>
	public static EUINavigation Key_GetNavigationDirectionFromAnalog(FAnalogInputEvent InAnalogEvent) { return default; }
	///<summary>Returns the display name of the key.</summary>
	public static string Key_GetDisplayName(FKey Key,bool bLongDisplayName/*=true*/) { return default; }
	///<summary>Returns whether or not this character is an auto-repeated keystroke</summary>
	public static bool InputEvent_IsRepeat(FInputEvent Input) { return default; }
	///<summary>Returns true if either shift key was down when this event occurred</summary>
	public static bool InputEvent_IsShiftDown(FInputEvent Input) { return default; }
	///<summary>Returns true if left shift key was down when this event occurred</summary>
	public static bool InputEvent_IsLeftShiftDown(FInputEvent Input) { return default; }
	///<summary>Returns true if right shift key was down when this event occurred</summary>
	public static bool InputEvent_IsRightShiftDown(FInputEvent Input) { return default; }
	///<summary>Returns true if either control key was down when this event occurred</summary>
	public static bool InputEvent_IsControlDown(FInputEvent Input) { return default; }
	///<summary>Returns true if left control key was down when this event occurred</summary>
	public static bool InputEvent_IsLeftControlDown(FInputEvent Input) { return default; }
	///<summary>Returns true if left control key was down when this event occurred</summary>
	public static bool InputEvent_IsRightControlDown(FInputEvent Input) { return default; }
	///<summary>Returns true if either alt key was down when this event occurred</summary>
	public static bool InputEvent_IsAltDown(FInputEvent Input) { return default; }
	///<summary>Returns true if left alt key was down when this event occurred</summary>
	public static bool InputEvent_IsLeftAltDown(FInputEvent Input) { return default; }
	///<summary>Returns true if right alt key was down when this event occurred</summary>
	public static bool InputEvent_IsRightAltDown(FInputEvent Input) { return default; }
	///<summary>Returns true if either command key was down when this event occurred</summary>
	public static bool InputEvent_IsCommandDown(FInputEvent Input) { return default; }
	///<summary>Returns true if left command key was down when this event occurred</summary>
	public static bool InputEvent_IsLeftCommandDown(FInputEvent Input) { return default; }
	///<summary>Returns true if right command key was down when this event occurred</summary>
	public static bool InputEvent_IsRightCommandDown(FInputEvent Input) { return default; }
	///<summary>Returns true if either shift key was down when the key state was captured</summary>
	public static bool ModifierKeysState_IsShiftDown(FSlateModifierKeysState KeysState) { return default; }
	///<summary>Returns true if either control key was down when the key state was captured</summary>
	public static bool ModifierKeysState_IsControlDown(FSlateModifierKeysState KeysState) { return default; }
	///<summary>Returns true if either alt key was down when the key state was captured</summary>
	public static bool ModifierKeysState_IsAltDown(FSlateModifierKeysState KeysState) { return default; }
	///<summary>Returns true if either command key was down when the key state was captured</summary>
	public static bool ModifierKeysState_IsCommandDown(FSlateModifierKeysState KeysState) { return default; }
	///<summary>Returns a snapshot of the cached modifier-keys state for the application.</summary>
	public static FSlateModifierKeysState GetModifierKeysState() { return default; }
	///<summary>@return The display name of the input chord</summary>
	public static string InputChord_GetDisplayName(FInputChord Key) { return default; }
	///<summary>Returns the key for this event.</summary>
	public static FKey GetKey(FKeyEvent Input) { return default; }
	///<summary>GetUserIndex</summary>
	public static int GetUserIndex(FKeyEvent Input) { return default; }
	///<summary>GetAnalogValue</summary>
	public static float GetAnalogValue(FAnalogInputEvent Input) { return default; }
	///<summary>Returns The position of the cursor in screen space</summary>
	public static FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent Input) { return default; }
	///<summary>Returns the position of the cursor in screen space last time we handled an input event</summary>
	public static FVector2D PointerEvent_GetLastScreenSpacePosition(FPointerEvent Input) { return default; }
	///<summary>Returns the distance the mouse traveled since the last event was handled.</summary>
	public static FVector2D PointerEvent_GetCursorDelta(FPointerEvent Input) { return default; }
	///<summary>Mouse buttons that are currently pressed</summary>
	public static bool PointerEvent_IsMouseButtonDown(FPointerEvent Input,FKey MouseButton) { return default; }
	///<summary>Mouse button that caused this event to be raised (possibly FKey::Invalid)</summary>
	public static FKey PointerEvent_GetEffectingButton(FPointerEvent Input) { return default; }
	///<summary>How much did the mouse wheel turn since the last mouse event</summary>
	public static float PointerEvent_GetWheelDelta(FPointerEvent Input) { return default; }
	///<summary>Returns the index of the user that caused the event</summary>
	public static int PointerEvent_GetUserIndex(FPointerEvent Input) { return default; }
	///<summary>Returns the unique identifier of the pointer (e.g., finger index)</summary>
	public static int PointerEvent_GetPointerIndex(FPointerEvent Input) { return default; }
	///<summary>Returns the index of the touch pad that generated this event (for platforms with multiple touch pads per user)</summary>
	public static int PointerEvent_GetTouchpadIndex(FPointerEvent Input) { return default; }
	///<summary>Returns true if this event a result from a touch (as opposed to a mouse)</summary>
	public static bool PointerEvent_IsTouchEvent(FPointerEvent Input) { return default; }
	///<summary>Returns the type of touch gesture</summary>
	public static ESlateGesture PointerEvent_GetGestureType(FPointerEvent Input) { return default; }
	///<summary>Returns the change in gesture value since the last gesture event of the same type.</summary>
	public static FVector2D PointerEvent_GetGestureDelta(FPointerEvent Input) { return default; }
}
