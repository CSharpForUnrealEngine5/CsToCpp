#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXProtocolTypes.h")]
///<summary>Type of network communication</summary>
public enum EDMXCommunicationType {
	Broadcast=0,
	Unicast=1,
	Multicast=2,
	InternalOnly=3,
}
