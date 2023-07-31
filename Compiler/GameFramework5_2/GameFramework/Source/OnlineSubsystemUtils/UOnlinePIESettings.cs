#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Setup login credentials for the Play In Editor (PIE) feature</summary>
[CppInclude("OnlinePIESettings.h")]
public partial class UOnlinePIESettings : UDeveloperSettings {
	///<summary>Attempt to login with user credentials on a backend service before launching the PIE instance.</summary>
	public bool bOnlinePIEEnabled;
	///<summary>Login credentials, at least one for each instance of PIE that is intended to be run</summary>
	public TArray<FPIELoginSettingsInternal> Logins;
}
