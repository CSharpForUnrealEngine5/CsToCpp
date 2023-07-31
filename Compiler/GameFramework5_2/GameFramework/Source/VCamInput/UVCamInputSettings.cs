#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamInputSettings.h")]
public partial class UVCamInputSettings : UDeveloperSettings {
	///<summary>DefaultInputProfile</summary>
	public string DefaultInputProfile;
	///<summary>InputProfiles</summary>
	public TMap<string,FVCamInputProfile> InputProfiles;
	///<summary>GetVCamInputSettings</summary>
	public static UVCamInputSettings GetVCamInputSettings() { return default; }
	///<summary>SetDefaultInputProfile</summary>
	public  void SetDefaultInputProfile(string NewDefaultInputProfile) {}
	///<summary>SetInputProfiles</summary>
	public  void SetInputProfiles(TMap<string,FVCamInputProfile> NewInputProfiles) {}
	///<summary>GetInputProfileNames</summary>
	public  TArray<string> GetInputProfileNames() { return default; }
}
