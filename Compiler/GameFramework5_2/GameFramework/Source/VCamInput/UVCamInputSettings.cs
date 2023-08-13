namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamInputSettings.h")]
public partial class UVCamInputSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultInputProfile</summary>
	public string DefaultInputProfile;
	///<summary>InputProfiles</summary>
	public TMap<string,FVCamInputProfile> InputProfiles;
	///<summary>GetVCamInputSettings</summary>
	public static UVCamInputSettings GetVCamInputSettings() { return default; }
	///<summary>SetDefaultInputProfile</summary>
	public void SetDefaultInputProfile(string NewDefaultInputProfile) {}
	///<summary>SetInputProfiles</summary>
	public void SetInputProfiles(TMap<string,FVCamInputProfile> NewInputProfiles) {}
	///<summary>GetInputProfileNames</summary>
	public TArray<string> GetInputProfileNames() { return default; }
}
