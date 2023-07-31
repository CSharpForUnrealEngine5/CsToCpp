#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is sent when a device is no longer claimed.</summary>
[CppInclude("TargetDeviceServiceMessages.h")]
public partial struct FTargetDeviceUnclaimed {
	public string DeviceName;
	public string HostName;
	public string HostUser;
}
