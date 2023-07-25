#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXProtocolBlueprintLibrary.h")]
public partial class UDMXProtocolBlueprintLibrary : UBlueprintFunctionLibrary {
// DMXProtocolBlueprintLibrary
	public void SetSendDMXEnabled(bool bSendDMXEnabled/*=true*/,bool bAffectEditor/*=false*/) {}
	public bool IsSendDMXEnabled() { return default; }
	public void SetReceiveDMXEnabled(bool bReceiveDMXEnabled/*=true*/,bool bAffectEditor/*=false*/) {}
	public bool IsReceiveDMXEnabled() { return default; }
	public TArray<string> GetLocalDMXNetworkInterfaceCardIPs() { return default; }
	public void SetDMXInputPortDeviceAddress(FDMXInputPortReference InputPort,string DeviceAddress) {}
	public void SetDMXOutputPortDeviceAddress(FDMXOutputPortReference OutputPort,string DeviceAddress) {}
	public void SetDMXOutputPortDestinationAddresses(FDMXOutputPortReference OutputPort,TArray<string> DestinationAddresses) {}
	public void SetDMXOutputPortDestinationAddress(FDMXOutputPortReference OutputPort,string DestinationAddress) {}
}
