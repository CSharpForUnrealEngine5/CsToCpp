#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGInputOutputSettings.h")]
public partial class UPCGGraphInputOutputSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>PinLabels_DEPRECATED</summary>
	public TSet<string> PinLabels_DEPRECATED;
	///<summary>CustomPins</summary>
	public TArray<FPCGPinProperties> CustomPins;
}
