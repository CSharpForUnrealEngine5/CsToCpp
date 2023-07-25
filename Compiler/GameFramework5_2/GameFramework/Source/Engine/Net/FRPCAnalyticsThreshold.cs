#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/RPCDoSDetectionConfig.h")]
///<summary>Specifies time or count thresholds for when an RPC should be included in analytics</summary>
public partial struct FRPCAnalyticsThreshold {
// RPCAnalyticsThreshold
	public string RPC;
	public int CountPerSec;
	public double TimePerSec;
}
