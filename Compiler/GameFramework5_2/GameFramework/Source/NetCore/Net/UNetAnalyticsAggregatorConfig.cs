#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration for FNetAnalyticsAggregator - loaded PerObjectConfig, for each NetDriverName</summary>
[CppInclude("Net/Core/Analytics/NetAnalyticsAggregatorConfig.h")]
public partial class UNetAnalyticsAggregatorConfig : UObject {
	///<summary>Registers FNetAnalyticsData data holders, by DataName - and specifies whether they are enabled or disabled</summary>
	public TArray<FNetAnalyticsDataConfig> NetAnalyticsData;
}
