#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Meter.h")]
///<summary>UMeterAnalyzer</summary>
public partial class UMeterAnalyzer : UAudioAnalyzer {
// MeterAnalyzer
	public UMeterSettings Settings;
	public FOnOverallMeterResults OnOverallMeterResults;
	public FOnPerChannelMeterResults OnPerChannelMeterResults;
	public FOnLatestOverallMeterResults OnLatestOverallMeterResults;
	public FOnLatestPerChannelMeterResults OnLatestPerChannelMeterResults;
}
