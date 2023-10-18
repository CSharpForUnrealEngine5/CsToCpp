namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPin.h")]
public partial class UPCGBlueprintPinHelpers : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>BreakPinProperty</summary>
	public static void BreakPinProperty(FPCGPinProperties PinProperty,FName Label,bool bAllowMultipleData,bool bAllowMultipleConnections,bool bAdvancedPin,EPCGExclusiveDataType AllowedType) {}
	///<summary>MakePinProperty</summary>
	public static FPCGPinProperties MakePinProperty(FName Label,bool bAllowMultipleData,bool bAllowMultipleConnections,bool bAdvancedPin,EPCGExclusiveDataType AllowedType/*=EPCGExclusiveDataType.Any*/) { return default; }
}
