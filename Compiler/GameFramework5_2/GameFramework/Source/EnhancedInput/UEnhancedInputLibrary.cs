#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputLibrary.h")]
public partial class UEnhancedInputLibrary : UBlueprintFunctionLibrary {
// EnhancedInputLibrary
	public static void RequestRebuildControlMappingsUsingContext(UInputMappingContext Context,bool bForceImmediately/*=false*/) {}
	public static void BreakInputActionValue(FInputActionValue InActionValue,double X,double Y,double Z,EInputActionValueType Type) {}
	public static FInputActionValue MakeInputActionValueOfType(double X,double Y,double Z,EInputActionValueType ValueType) { return default; }
	public static FInputActionValue MakeInputActionValue(double X,double Y,double Z,FInputActionValue MatchValueType) { return default; }
	public static UPlayerMappableKeySettings GetPlayerMappableKeySettings(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	public static string GetMappingName(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	public static bool IsActionKeyMappingPlayerMappable(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	public static FInputActionValue GetBoundActionValue(AActor Actor,UInputAction Action) { return default; }
	public static bool Conv_InputActionValueToBool(FInputActionValue InValue) { return default; }
	public static double Conv_InputActionValueToAxis1D(FInputActionValue InValue) { return default; }
	public static FVector2D Conv_InputActionValueToAxis2D(FInputActionValue InValue) { return default; }
	public static FVector Conv_InputActionValueToAxis3D(FInputActionValue ActionValue) { return default; }
	public static string Conv_InputActionValueToString(FInputActionValue ActionValue) { return default; }
	public static FPlayerMappableKeySlot GetFirstPlayerMappableKeySlot() { return default; }
	public static FPlayerMappableKeySlot GetSecondPlayerMappableKeySlot() { return default; }
	public static FPlayerMappableKeySlot GetThirdPlayerMappableKeySlot() { return default; }
	public static FPlayerMappableKeySlot GetFourthPlayerMappableKeySlot() { return default; }
}
