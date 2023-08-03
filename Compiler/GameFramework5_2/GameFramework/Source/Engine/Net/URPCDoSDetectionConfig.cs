#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration for FRPCDoSDetection - using PerObjectConfig, to hack a single hardcoded section name</summary>
[CppInclude("Net/RPCDoSDetectionConfig.h")]
public partial class URPCDoSDetectionConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not RPC DoS detection is presently enabled</summary>
	public bool bRPCDoSDetection;
	///<summary>Whether or not analytics for RPC DoS detection is enabled</summary>
	public bool bRPCDoSAnalytics;
	///<summary>The amount of time since the previous frame, for detecting hitches, to prevent false positives from built-up packets</summary>
	public int HitchTimeQuotaMS;
	///<summary>The amount of time to suspend RPC DoS Detection, once a hitch is encountered, prevent false positives from built-up packets</summary>
	public int HitchSuspendDetectionTimeMS;
	///<summary>Names of the different RPC DoS detection states, for escalating severity, depending on the amount of RPC spam</summary>
	public TArray<string> DetectionSeverity;
	///<summary>The amount of time since the client connected, before time-based checks should become active (to reduce false positives)</summary>
	public int InitialConnectToleranceMS;
	///<summary>RPCBlockWhitelist</summary>
	public TArray<string> RPCBlockWhitelist;
	///<summary>List of RPC&#39;s which should never be blocked</summary>
	public TArray<string> RPCBlockAllowlist;
	///<summary>Custom thresholds for when specific RPC&#39;s should be included in analytics</summary>
	public TArray<FRPCAnalyticsThreshold> RPCAnalyticsThresholds;
	///<summary>Specifies a random chance, between 0.0 and 1.0, for when RPCAnalyticsThresholds should be overridden (adds to separate analytics)</summary>
	public double RPCAnalyticsOverrideChance;
}
