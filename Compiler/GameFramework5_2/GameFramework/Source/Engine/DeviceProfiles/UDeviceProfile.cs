#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeviceProfiles/DeviceProfile.h")]
public partial class UDeviceProfile : UTextureLODSettings {
	///<summary>The type of this profile, I.e. IOS, Windows, PS4 etc</summary>
	public string DeviceType;
	///<summary>The name of the parent profile of this object</summary>
	public string BaseProfileName;
	///<summary>Some asset types can reference Device Profiles, is this profile visible to those assets.</summary>
	public bool bIsVisibleForAssets;
	///<summary>The parent object of this profile, it is the object matching this DeviceType with the BaseProfileName</summary>
	public UDeviceProfile Parent;
	///<summary>The collection of CVars which is set from this profile</summary>
	public TArray<string> CVars;
	///<summary>An array of conditions to test against and fragment names to select.</summary>
	public TArray<FDPMatchingRulestruct> MatchingRules;
}
