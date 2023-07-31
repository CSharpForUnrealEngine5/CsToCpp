#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXProtocolBlueprintLibrary.h")]
public partial class UDMXProtocolBlueprintLibrary : UBlueprintFunctionLibrary {
	///<summary>Sets if DMX is sent to the network</summary>
	public static void SetSendDMXEnabled(bool bSendDMXEnabled/*=true*/,bool bAffectEditor/*=false*/) {}
	///<summary>Returns whether send DMX to the network is enabled globally.</summary>
	public static bool IsSendDMXEnabled() { return default; }
	///<summary>Sets if DMX is received from the network</summary>
	public static void SetReceiveDMXEnabled(bool bReceiveDMXEnabled/*=true*/,bool bAffectEditor/*=false*/) {}
	///<summary>Returns whether Receive DMX from the network is enabled globally.</summary>
	public static bool IsReceiveDMXEnabled() { return default; }
	///<summary>Returns the IP addresses of the network interface cards available to the system.</summary>
	public static TArray<string> GetLocalDMXNetworkInterfaceCardIPs() { return default; }
	///<summary>Sets the Device Address of the Output Port. For networking Protocols that&#39;s the IP Adress of the network interface card.</summary>
	public static void SetDMXInputPortDeviceAddress(FDMXInputPortReference InputPort,string DeviceAddress) {}
	///<summary>Sets the Device Address of the Output Port. For networking Protocols that&#39;s the IP Adress of the network interface card.</summary>
	public static void SetDMXOutputPortDeviceAddress(FDMXOutputPortReference OutputPort,string DeviceAddress) {}
	///<summary>Sets the Destination Address Address of the Output Port. For networking Protocols that&#39;s the Unicast IP Adress. Not required for Multicast and Broadcast.</summary>
	public static void SetDMXOutputPortDestinationAddresses(FDMXOutputPortReference OutputPort,TArray<string> DestinationAddresses) {}
	///<summary>SetDMXOutputPortDestinationAddress</summary>
	public static void SetDMXOutputPortDestinationAddress(FDMXOutputPortReference OutputPort,string DestinationAddress) {}
}
