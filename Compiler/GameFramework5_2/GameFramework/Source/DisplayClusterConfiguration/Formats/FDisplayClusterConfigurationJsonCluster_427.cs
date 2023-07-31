#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON427/DisplayClusterConfigurationJsonTypes_427.h")]
public partial struct FDisplayClusterConfigurationJsonCluster_427 {
	public FDisplayClusterConfigurationJsonPrimaryNode_427 MasterNode;
	public FDisplayClusterConfigurationJsonClusterSync_427 Sync;
	public TMap<string,string> Network;
	public TMap<string,FDisplayClusterConfigurationJsonClusterNode_427> Nodes;
}
