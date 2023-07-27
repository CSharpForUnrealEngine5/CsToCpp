#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetInputLibrary.h")]
public partial class UKismetInputLibrary : UBlueprintFunctionLibrary {
// KismetInputLibrary
	public static void CalibrateTilt() {}
	public static bool EqualEqual_KeyKey(FKey A,FKey B) { return default; }
	public static bool EqualEqual_InputChordInputChord(FInputChord A,FInputChord B) { return default; }
	public static bool Key_IsModifierKey(FKey Key) { return default; }
	public static bool Key_IsGamepadKey(FKey Key) { return default; }
	public static bool Key_IsMouseButton(FKey Key) { return default; }
	public static bool Key_IsKeyboardKey(FKey Key) { return default; }
	public static bool Key_IsVectorAxis(FKey Key) { return default; }
	public static bool Key_IsAxis1D(FKey Key) { return default; }
	public static bool Key_IsAxis2D(FKey Key) { return default; }
	public static bool Key_IsAxis3D(FKey Key) { return default; }
	public static bool Key_IsButtonAxis(FKey Key) { return default; }
	public static bool Key_IsAnalog(FKey Key) { return default; }
	public static bool Key_IsDigital(FKey Key) { return default; }
	public static bool Key_IsValid(FKey Key) { return default; }
	public static EUINavigationAction Key_GetNavigationAction(FKey InKey) { return default; }
	public static EUINavigationAction Key_GetNavigationActionFromKey(FKeyEvent InKeyEvent) { return default; }
	public static EUINavigation Key_GetNavigationDirectionFromKey(FKeyEvent InKeyEvent) { return default; }
	public static EUINavigation Key_GetNavigationDirectionFromAnalog(FAnalogInputEvent InAnalogEvent) { return default; }
	public static string Key_GetDisplayName(FKey Key,bool bLongDisplayName/*=true*/) { return default; }
	public static bool InputEvent_IsRepeat(FInputEvent Input) { return default; }
	public static bool InputEvent_IsShiftDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsLeftShiftDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsRightShiftDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsControlDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsLeftControlDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsRightControlDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsAltDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsLeftAltDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsRightAltDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsCommandDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsLeftCommandDown(FInputEvent Input) { return default; }
	public static bool InputEvent_IsRightCommandDown(FInputEvent Input) { return default; }
	public static bool ModifierKeysState_IsShiftDown(FSlateModifierKeysState KeysState) { return default; }
	public static bool ModifierKeysState_IsControlDown(FSlateModifierKeysState KeysState) { return default; }
	public static bool ModifierKeysState_IsAltDown(FSlateModifierKeysState KeysState) { return default; }
	public static bool ModifierKeysState_IsCommandDown(FSlateModifierKeysState KeysState) { return default; }
	public static FSlateModifierKeysState GetModifierKeysState() { return default; }
	public static string InputChord_GetDisplayName(FInputChord Key) { return default; }
	public static FKey GetKey(FKeyEvent Input) { return default; }
	public static int GetUserIndex(FKeyEvent Input) { return default; }
	public static float GetAnalogValue(FAnalogInputEvent Input) { return default; }
	public static FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent Input) { return default; }
	public static FVector2D PointerEvent_GetLastScreenSpacePosition(FPointerEvent Input) { return default; }
	public static FVector2D PointerEvent_GetCursorDelta(FPointerEvent Input) { return default; }
	public static bool PointerEvent_IsMouseButtonDown(FPointerEvent Input,FKey MouseButton) { return default; }
	public static FKey PointerEvent_GetEffectingButton(FPointerEvent Input) { return default; }
	public static float PointerEvent_GetWheelDelta(FPointerEvent Input) { return default; }
	public static int PointerEvent_GetUserIndex(FPointerEvent Input) { return default; }
	public static int PointerEvent_GetPointerIndex(FPointerEvent Input) { return default; }
	public static int PointerEvent_GetTouchpadIndex(FPointerEvent Input) { return default; }
	public static bool PointerEvent_IsTouchEvent(FPointerEvent Input) { return default; }
	public static ESlateGesture PointerEvent_GetGestureType(FPointerEvent Input) { return default; }
	public static FVector2D PointerEvent_GetGestureDelta(FPointerEvent Input) { return default; }
}
