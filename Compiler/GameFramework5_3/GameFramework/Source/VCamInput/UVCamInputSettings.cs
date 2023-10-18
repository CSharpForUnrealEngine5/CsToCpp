namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamInputSettings.h")]
public partial class UVCamInputSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultInputProfile</summary>
	public FName DefaultInputProfile;
	///<summary>InputProfiles</summary>
	public TMap<FName,FVCamInputProfile> InputProfiles;
	///<summary>GetVCamInputSettings</summary>
	public static UVCamInputSettings GetVCamInputSettings() { return default; }
	///<summary>SetDefaultInputProfile</summary>
	public void SetDefaultInputProfile(FName NewDefaultInputProfile) {}
	///<summary>SetInputProfiles</summary>
	public void SetInputProfiles(TMap<FName,FVCamInputProfile> NewInputProfiles) {}
	///<summary>GetInputProfileNames</summary>
	public TArray<FName> GetInputProfileNames() { return default; }
}
