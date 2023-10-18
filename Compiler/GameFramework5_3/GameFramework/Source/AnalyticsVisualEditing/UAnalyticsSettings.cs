namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsSettings.h")]
public partial class UAnalyticsSettings : UAnalyticsSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the plugin containing your desired analytics provider</summary>
	public string DevelopmentProviderName;
	///<summary>The name of the plugin containing your desired analytics provider</summary>
	public string DebugProviderName;
	///<summary>The name of the plugin containing your desired analytics provider</summary>
	public string TestProviderName;
	///<summary>The name of the plugin containing your desired analytics provider</summary>
	public string ReleaseProviderName;
}
