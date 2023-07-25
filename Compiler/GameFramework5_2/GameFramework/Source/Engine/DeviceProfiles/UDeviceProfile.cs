#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeviceProfiles/DeviceProfile.h")]
public partial class UDeviceProfile : UTextureLODSettings {
// DeviceProfile
	public string DeviceType;
	public string BaseProfileName;
	public bool bIsVisibleForAssets;
	public UDeviceProfile Parent;
	public TArray<string> CVars;
	public TArray<FDPMatchingRulestruct> MatchingRules;
}
