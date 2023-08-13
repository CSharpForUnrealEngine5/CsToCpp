namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Metadata about datacenters that can be queried</summary>
[CppInclude("QosRegionManager.h")]
public partial struct FQosDatacenterInfo {
	public string Id;
	public string RegionId;
	public bool bEnabled;
	public TArray<FQosPingServerInfo> Servers;
}
