namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGInputOutputSettings.h")]
public partial class UPCGGraphInputOutputSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>PinLabels_DEPRECATED</summary>
	public TSet<FName> PinLabels_DEPRECATED;
	///<summary>CustomPins</summary>
	public TArray<FPCGPinProperties> CustomPins;
}
