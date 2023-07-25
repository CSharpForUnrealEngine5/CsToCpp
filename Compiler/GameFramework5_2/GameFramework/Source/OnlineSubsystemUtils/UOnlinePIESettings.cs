#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlinePIESettings.h")]
///<summary>Setup login credentials for the Play In Editor (PIE) feature</summary>
public partial class UOnlinePIESettings : UDeveloperSettings {
// OnlinePIESettings
	public bool bOnlinePIEEnabled;
	public TArray<FPIELoginSettingsInternal> Logins;
}
