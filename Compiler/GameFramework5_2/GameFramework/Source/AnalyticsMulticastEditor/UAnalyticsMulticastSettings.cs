#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsMulticastSettings.h")]
public partial class UAnalyticsMulticastSettings : UAnalyticsSettingsBase {
	///<summary>The list of analytics providers to forward analytics events to</summary>
	public TArray<string> ReleaseMulticastProviders;
	///<summary>The list of analytics providers to forward analytics events to</summary>
	public TArray<string> DebugMulticastProviders;
	///<summary>The list of analytics providers to forward analytics events to</summary>
	public TArray<string> TestMulticastProviders;
	///<summary>The list of analytics providers to forward analytics events to</summary>
	public TArray<string> DevelopmentMulticastProviders;
}
