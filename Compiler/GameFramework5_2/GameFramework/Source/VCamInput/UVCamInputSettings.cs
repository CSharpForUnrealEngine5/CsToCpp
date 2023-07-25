#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamInputSettings.h")]
public partial class UVCamInputSettings : UDeveloperSettings {
// VCamInputSettings
	public string DefaultInputProfile;
	public TMap<string,FVCamInputProfile> InputProfiles;
	public UObject GetVCamInputSettings() { return default; }
	public void SetDefaultInputProfile(string NewDefaultInputProfile) {}
	public void SetInputProfiles(TMap<string,FVCamInputProfile> NewInputProfiles) {}
	public TArray<string> GetInputProfileNames() { return default; }
}
