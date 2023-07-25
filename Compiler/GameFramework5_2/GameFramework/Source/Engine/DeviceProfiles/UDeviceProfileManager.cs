#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeviceProfiles/DeviceProfileManager.h")]
///<summary>Implements a helper class that manages all profiles in the Device</summary>
public partial class UDeviceProfileManager : UObject {
// DeviceProfileManager
	public TArray<UDeviceProfile> Profiles;
	public TArray<UDeviceProfile> BackupProfiles;
}
