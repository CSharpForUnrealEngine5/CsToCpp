#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeterAnalyzer</summary>
[CppInclude("Meter.h")]
public partial class UMeterAnalyzer : UAudioAnalyzer {
	///<summary>The settings for the meter audio analyzer.</summary>
	public UMeterSettings Settings;
	///<summary>Delegate to receive all overall meter results since last delegate call.</summary>
	public FOnOverallMeterResults OnOverallMeterResults;
	///<summary>Delegate to receive all meter results, per-channel, since last delegate call.</summary>
	public FOnPerChannelMeterResults OnPerChannelMeterResults;
	///<summary>Delegate to receive the latest overall meter results.</summary>
	public FOnLatestOverallMeterResults OnLatestOverallMeterResults;
	///<summary>Delegate to receive the latest per-channel meter results.</summary>
	public FOnLatestPerChannelMeterResults OnLatestPerChannelMeterResults;
}
