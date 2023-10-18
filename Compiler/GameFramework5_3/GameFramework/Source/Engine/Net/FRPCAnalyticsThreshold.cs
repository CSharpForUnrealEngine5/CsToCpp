namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies time or count thresholds for when an RPC should be included in analytics</summary>
[CppInclude("Net/RPCDoSDetectionConfig.h")]
public partial struct FRPCAnalyticsThreshold {
	public FName RPC;
	public int CountPerSec;
	public double TimePerSec;
}
