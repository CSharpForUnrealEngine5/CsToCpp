namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenXRInputFunctionLibrary.h")]
public partial class UOpenXRInputFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Add a player mappable input config for Enhanced Input. This will make the tracking system aware of the actions and bindings that are used for XR motion controllers.</summary>
	public static bool BeginXRSession(UPlayerMappableInputConfig InputConfig) { return default; }
	///<summary>EndXRSession</summary>
	public static void EndXRSession() {}
}
