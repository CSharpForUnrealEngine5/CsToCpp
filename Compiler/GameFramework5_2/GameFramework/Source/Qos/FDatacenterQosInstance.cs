#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QosRegionManager.h")]
///<summary>Runtime information about a given region</summary>
public partial struct FDatacenterQosInstance {
// DatacenterQosInstance
	public FQosDatacenterInfo Definition;
	public EQosDatacenterResult Result;
	public int AvgPingMs;
	public TArray<int> PingResults;
	public FDateTime LastCheckTimestamp;
	public bool bUsable;
}
