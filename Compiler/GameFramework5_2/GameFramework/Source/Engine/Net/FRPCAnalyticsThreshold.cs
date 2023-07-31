#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies time or count thresholds for when an RPC should be included in analytics</summary>
[CppInclude("Net/RPCDoSDetectionConfig.h")]
public partial struct FRPCAnalyticsThreshold {
	public string RPC;
	public int CountPerSec;
	public double TimePerSec;
}
