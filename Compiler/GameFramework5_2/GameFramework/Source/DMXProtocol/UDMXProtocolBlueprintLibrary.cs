#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXProtocolBlueprintLibrary.h")]
public partial class UDMXProtocolBlueprintLibrary : UBlueprintFunctionLibrary {
// DMXProtocolBlueprintLibrary
	public static void SetSendDMXEnabled(bool bSendDMXEnabled/*=true*/,bool bAffectEditor/*=false*/) {}
	public static bool IsSendDMXEnabled() { return default; }
	public static void SetReceiveDMXEnabled(bool bReceiveDMXEnabled/*=true*/,bool bAffectEditor/*=false*/) {}
	public static bool IsReceiveDMXEnabled() { return default; }
	public static TArray<string> GetLocalDMXNetworkInterfaceCardIPs() { return default; }
	public static void SetDMXInputPortDeviceAddress(FDMXInputPortReference InputPort,string DeviceAddress) {}
	public static void SetDMXOutputPortDeviceAddress(FDMXOutputPortReference OutputPort,string DeviceAddress) {}
	public static void SetDMXOutputPortDestinationAddresses(FDMXOutputPortReference OutputPort,TArray<string> DestinationAddresses) {}
	public static void SetDMXOutputPortDestinationAddress(FDMXOutputPortReference OutputPort,string DestinationAddress) {}
}
