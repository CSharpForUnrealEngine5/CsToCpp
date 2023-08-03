#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FlurrySettings.h")]
public partial class UFlurrySettings : UAnalyticsSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>ReleaseApiKey</summary>
	public string ReleaseApiKey;
	///<summary>DebugApiKey</summary>
	public string DebugApiKey;
	///<summary>TestApiKey</summary>
	public string TestApiKey;
	///<summary>DevelopmentApiKey</summary>
	public string DevelopmentApiKey;
}
