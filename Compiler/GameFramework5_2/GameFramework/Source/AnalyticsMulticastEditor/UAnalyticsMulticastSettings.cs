namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsMulticastSettings.h")]
public partial class UAnalyticsMulticastSettings : UAnalyticsSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>The list of analytics providers to forward analytics events to</summary>
	public TArray<string> ReleaseMulticastProviders;
	///<summary>The list of analytics providers to forward analytics events to</summary>
	public TArray<string> DebugMulticastProviders;
	///<summary>The list of analytics providers to forward analytics events to</summary>
	public TArray<string> TestMulticastProviders;
	///<summary>The list of analytics providers to forward analytics events to</summary>
	public TArray<string> DevelopmentMulticastProviders;
}
