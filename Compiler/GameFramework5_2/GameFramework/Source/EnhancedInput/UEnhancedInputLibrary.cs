#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputLibrary.h")]
public partial class UEnhancedInputLibrary : UBlueprintFunctionLibrary {
// EnhancedInputLibrary
	public void RequestRebuildControlMappingsUsingContext(UObject Context,bool bForceImmediately/*=false*/) {}
	public void BreakInputActionValue(FInputActionValue InActionValue,double X,double Y,double Z,EInputActionValueType Type) {}
	public FInputActionValue MakeInputActionValueOfType(double X,double Y,double Z,EInputActionValueType ValueType) { return default; }
	public FInputActionValue MakeInputActionValue(double X,double Y,double Z,FInputActionValue MatchValueType) { return default; }
	public UObject GetPlayerMappableKeySettings(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	public string GetMappingName(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	public bool IsActionKeyMappingPlayerMappable(FEnhancedActionKeyMapping ActionKeyMapping) { return default; }
	public FInputActionValue GetBoundActionValue(UObject Actor,UObject Action) { return default; }
	public bool Conv_InputActionValueToBool(FInputActionValue InValue) { return default; }
	public double Conv_InputActionValueToAxis1D(FInputActionValue InValue) { return default; }
	public FVector2D Conv_InputActionValueToAxis2D(FInputActionValue InValue) { return default; }
	public FVector Conv_InputActionValueToAxis3D(FInputActionValue ActionValue) { return default; }
	public string Conv_InputActionValueToString(FInputActionValue ActionValue) { return default; }
	public FPlayerMappableKeySlot GetFirstPlayerMappableKeySlot() { return default; }
	public FPlayerMappableKeySlot GetSecondPlayerMappableKeySlot() { return default; }
	public FPlayerMappableKeySlot GetThirdPlayerMappableKeySlot() { return default; }
	public FPlayerMappableKeySlot GetFourthPlayerMappableKeySlot() { return default; }
}
