namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is sent when a device is already claimed by someone else.</summary>
[CppInclude("TargetDeviceServiceMessages.h")]
public partial struct FTargetDeviceClaimDenied {
	public string DeviceName;
	public string HostName;
	public string HostUser;
}
