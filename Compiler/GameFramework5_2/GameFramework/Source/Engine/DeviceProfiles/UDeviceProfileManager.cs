namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a helper class that manages all profiles in the Device</summary>
[CppInclude("DeviceProfiles/DeviceProfileManager.h")]
public partial class UDeviceProfileManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Holds the collection of managed profiles.</summary>
	public TArray<UDeviceProfile> Profiles;
	///<summary>Cached copy of profiles at load</summary>
	public TArray<UDeviceProfile> BackupProfiles;
}
