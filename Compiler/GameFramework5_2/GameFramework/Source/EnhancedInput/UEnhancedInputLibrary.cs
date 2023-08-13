namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputLibrary.h")]
public partial class UEnhancedInputLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Flag all enhanced input subsystems making use of the mapping context for reapplication of all control mappings at the end of this frame.</summary>
	public static void RequestRebuildControlMappingsUsingContext(UInputMappingContext Context,bool bForceImmediately/*=false*/) {}
	///<summary>Breaks an ActionValue into X, Y, Z. Axes not supported by value type will be 0.</summary>
	public static void BreakInputActionValue(FInputActionValue InActionValue,double X,double Y,double Z,EInputActionValueType Type) {}
	///<summary>Builds an ActionValue from X, Y, Z. Inherits type from an existing ActionValue. Ignores axis values unused by the provided value type.</summary>
	public static FInputActionValue MakeInputActionValueOfType(double X,double Y,double Z,EInputActionValueType ValueType) { return default; }
	///<summary>MakeInputActionValue</summary>
	public static FInputActionValue MakeInputActionValue(double X,double Y,double Z,FInputActionValue MatchValueType) { return default; }
	///<summary>Returns the Player Mappable Key Settings owned by the Action Key Mapping or by the referenced Input Action, or nothing based of the Setting Behavior.</summary>
	public static UPlayerMappableKeySettings GetPlayerMappableKeySettings(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	///<summary>Returns the name of the mapping based on setting behavior used. If no name is found in the Mappable Key Settings it will return the name set in Player Mappable Options if bIsPlayerMappable is true.</summary>
	public static string GetMappingName(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	///<summary>Returns true if this Action Key Mapping either holds a Player Mappable Key Settings or is set bIsPlayerMappable.</summary>
	public static bool IsActionKeyMappingPlayerMappable(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	///<summary>GetInputActionvalue internal accessor function for actions that have been bound to from a UEnhancedInputComponent</summary>
	public static FInputActionValue GetBoundActionValue(AActor Actor,UInputAction Action) { return default; }
	///<summary>Interpret an InputActionValue as a boolean input</summary>
	public static bool Conv_InputActionValueToBool(FInputActionValue InValue) { return default; }
	///<summary>Interpret an InputActionValue as a 1D axis (double) input</summary>
	public static double Conv_InputActionValueToAxis1D(FInputActionValue InValue) { return default; }
	///<summary>Interpret an InputActionValue as a 2D axis (Vector2D) input</summary>
	public static FVector2D Conv_InputActionValueToAxis2D(FInputActionValue InValue) { return default; }
	///<summary>Interpret an InputActionValue as a 3D axis (Vector) input</summary>
	public static FVector Conv_InputActionValueToAxis3D(FInputActionValue ActionValue) { return default; }
	///<summary>Converts a FInputActionValue to a string</summary>
	public static string Conv_InputActionValueToString(FInputActionValue ActionValue) { return default; }
	///<summary>GetFirstPlayerMappableKeySlot</summary>
	public static FPlayerMappableKeySlot GetFirstPlayerMappableKeySlot() { return default; }
	///<summary>GetSecondPlayerMappableKeySlot</summary>
	public static FPlayerMappableKeySlot GetSecondPlayerMappableKeySlot() { return default; }
	///<summary>GetThirdPlayerMappableKeySlot</summary>
	public static FPlayerMappableKeySlot GetThirdPlayerMappableKeySlot() { return default; }
	///<summary>GetFourthPlayerMappableKeySlot</summary>
	public static FPlayerMappableKeySlot GetFourthPlayerMappableKeySlot() { return default; }
}
