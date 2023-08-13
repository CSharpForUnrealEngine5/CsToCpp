namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is sent in response to target device service discovery messages.</summary>
[CppInclude("TargetDeviceServiceMessages.h")]
public partial struct FTargetDeviceServicePong {
	public bool Connected;
	public bool Authorized;
	public string HostName;
	public string HostUser;
	public string Make;
	public string Model;
	public string Name;
	public string DeviceUser;
	public string DeviceUserPassword;
	public bool Shared;
	public bool SupportsMultiLaunch;
	public bool SupportsPowerOff;
	public bool SupportsPowerOn;
	public bool SupportsReboot;
	public bool SupportsVariants;
	public string Type;
	public string DefaultVariant;
	public TArray<FTargetDeviceVariant> Variants;
	public bool Aggregated;
	public string AllDevicesName;
	public string AllDevicesDefaultVariant;
}
