#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration for FNetAnalyticsData - enabling/disabling analytics data, based on DataName</summary>
[CppInclude("Net/Core/Analytics/NetAnalyticsAggregatorConfig.h")]
public partial struct FNetAnalyticsDataConfig {
	public string DataName;
	public bool bEnabled;
}
