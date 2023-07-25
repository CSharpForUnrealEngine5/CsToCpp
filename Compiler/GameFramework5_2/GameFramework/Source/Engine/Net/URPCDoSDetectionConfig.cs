#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/RPCDoSDetectionConfig.h")]
///<summary>Configuration for FRPCDoSDetection - using PerObjectConfig, to hack a single hardcoded section name</summary>
public partial class URPCDoSDetectionConfig : UObject {
// RPCDoSDetectionConfig
	public bool bRPCDoSDetection;
	public bool bRPCDoSAnalytics;
	public int HitchTimeQuotaMS;
	public int HitchSuspendDetectionTimeMS;
	public TArray<string> DetectionSeverity;
	public int InitialConnectToleranceMS;
	public TArray<string> RPCBlockWhitelist;
	public TArray<string> RPCBlockAllowlist;
	public TArray<FRPCAnalyticsThreshold> RPCAnalyticsThresholds;
	public double RPCAnalyticsOverrideChance;
}
