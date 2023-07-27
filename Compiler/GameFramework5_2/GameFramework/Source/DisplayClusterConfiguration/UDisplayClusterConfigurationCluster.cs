#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationCluster : UDisplayClusterConfigurationData_Base {
// DisplayClusterConfigurationCluster
	public FDisplayClusterConfigurationPrimaryNode PrimaryNode;
	public FDisplayClusterConfigurationClusterSync Sync;
	public FDisplayClusterConfigurationNetworkSettings Network;
	public FDisplayClusterConfigurationFailoverSettings Failover;
	public TMap<string,UDisplayClusterConfigurationClusterNode> Nodes;
	public TMap<string,UDisplayClusterConfigurationHostDisplayData> HostDisplayData;
	public  void GetReferencedMeshNames(TArray<string> OutMeshNames) {}
	public  void GetNodeIds(TArray<string> OutNodeIds) {}
	public  UDisplayClusterConfigurationClusterNode GetNode(string NodeId) { return default; }
}
