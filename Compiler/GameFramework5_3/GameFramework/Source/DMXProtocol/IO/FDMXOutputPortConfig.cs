namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint Configuration of a Port, used in DXM Settings to specify inputs and outputs.</summary>
[CppInclude("IO/DMXOutputPortConfig.h")]
public partial struct FDMXOutputPortConfig {
	public string PortName;
	public FName ProtocolName;
	public EDMXCommunicationType CommunicationType;
	public bool bAutoCompleteDeviceAddressEnabled;
	public string AutoCompleteDeviceAddress;
	public string DeviceAddress;
	public string DestinationAddress;
	public TArray<FDMXOutputPortDestinationAddress> DestinationAddresses;
	public bool bLoopbackToEngine;
	public int LocalUniverseStart;
	public int NumUniverses;
	public int ExternUniverseStart;
	public bool bIsExternUnivereStartEditable;
	public int Priority;
	public double Delay;
	public FFrameRate DelayFrameRate;
	public FGuid PortGuid;
}
