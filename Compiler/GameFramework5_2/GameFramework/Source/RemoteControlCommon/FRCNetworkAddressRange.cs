namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility struct to represent range of IPv4 Network addresses.</summary>
[CppInclude("RemoteControlSettings.h")]
public partial struct FRCNetworkAddressRange {
	public FRCNetworkAddress LowerBound;
	public FRCNetworkAddress UpperBound;
}
