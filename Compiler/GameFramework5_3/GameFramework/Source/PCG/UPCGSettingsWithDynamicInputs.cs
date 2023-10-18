namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPCGSettings subclass with functionality to dynamically add/remove input pins</summary>
[CppInclude("PCGSettingsWithDynamicInputs.h")]
public partial class UPCGSettingsWithDynamicInputs : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Dynamic pin properties that the user can add or remove from</summary>
	public TArray<FPCGPinProperties> DynamicInputPinProperties;
}
