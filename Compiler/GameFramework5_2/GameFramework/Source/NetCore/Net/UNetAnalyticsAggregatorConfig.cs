namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration for FNetAnalyticsAggregator - loaded PerObjectConfig, for each NetDriverName</summary>
[CppInclude("Net/Core/Analytics/NetAnalyticsAggregatorConfig.h")]
public partial class UNetAnalyticsAggregatorConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Registers FNetAnalyticsData data holders, by DataName - and specifies whether they are enabled or disabled</summary>
	public TArray<FNetAnalyticsDataConfig> NetAnalyticsData;
}
