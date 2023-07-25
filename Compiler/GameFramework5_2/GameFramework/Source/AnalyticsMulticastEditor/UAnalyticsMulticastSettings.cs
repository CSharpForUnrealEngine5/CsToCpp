#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsMulticastSettings.h")]
public partial class UAnalyticsMulticastSettings : UAnalyticsSettingsBase {
// AnalyticsMulticastSettings
	public TArray<string> ReleaseMulticastProviders;
	public TArray<string> DebugMulticastProviders;
	public TArray<string> TestMulticastProviders;
	public TArray<string> DevelopmentMulticastProviders;
}
