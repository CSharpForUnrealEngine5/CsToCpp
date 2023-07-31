#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint Configuration of a Port, used in DXM Settings to specify inputs and outputs.</summary>
[CppInclude("IO/DMXInputPortConfig.h")]
public partial struct FDMXInputPortConfig {
	public string PortName;
	public string ProtocolName;
	public EDMXCommunicationType CommunicationType;
	public bool bAutoCompleteDeviceAddressEnabled;
	public string AutoCompleteDeviceAddress;
	public string DeviceAddress;
	public int LocalUniverseStart;
	public int NumUniverses;
	public int ExternUniverseStart;
	public EDMXPortPriorityStrategy PriorityStrategy;
	public int Priority;
	public FGuid PortGuid;
}
