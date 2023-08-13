namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runtime information about a given region</summary>
[CppInclude("QosRegionManager.h")]
public partial struct FDatacenterQosInstance {
	public FQosDatacenterInfo Definition;
	public EQosDatacenterResult Result;
	public int AvgPingMs;
	public TArray<int> PingResults;
	public FDateTime LastCheckTimestamp;
	public bool bUsable;
}
