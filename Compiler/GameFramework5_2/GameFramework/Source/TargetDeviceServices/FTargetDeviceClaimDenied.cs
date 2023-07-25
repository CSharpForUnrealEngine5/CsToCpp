#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TargetDeviceServiceMessages.h")]
///<summary>Implements a message that is sent when a device is already claimed by someone else.</summary>
public partial struct FTargetDeviceClaimDenied {
// TargetDeviceClaimDenied
	public string DeviceName;
	public string HostName;
	public string HostUser;
}
