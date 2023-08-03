#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationCluster : UDisplayClusterConfigurationData_Base {
	public static UClass StaticClass() {return default;}
	///<summary>PrimaryNode</summary>
	public FDisplayClusterConfigurationPrimaryNode PrimaryNode;
	///<summary>Sync</summary>
	public FDisplayClusterConfigurationClusterSync Sync;
	///<summary>Network</summary>
	public FDisplayClusterConfigurationNetworkSettings Network;
	///<summary>Failover</summary>
	public FDisplayClusterConfigurationFailoverSettings Failover;
	///<summary>Nodes</summary>
	public TMap<string,UDisplayClusterConfigurationClusterNode> Nodes;
	///<summary>HostDisplayData</summary>
	public TMap<string,UDisplayClusterConfigurationHostDisplayData> HostDisplayData;
	///<summary>Return all references to meshes from policy, and other</summary>
	public  void GetReferencedMeshNames(TArray<string> OutMeshNames) {}
	///<summary>Nodes API</summary>
	public  void GetNodeIds(TArray<string> OutNodeIds) {}
	///<summary>GetNode</summary>
	public  UDisplayClusterConfigurationClusterNode GetNode(string NodeId) { return default; }
}
