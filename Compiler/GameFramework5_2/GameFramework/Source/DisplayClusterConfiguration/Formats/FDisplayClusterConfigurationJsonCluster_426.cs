namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON426/DisplayClusterConfigurationJsonTypes_426.h")]
public partial struct FDisplayClusterConfigurationJsonCluster_426 {
	public FDisplayClusterConfigurationJsonPrimaryNode_426 MasterNode;
	public FDisplayClusterConfigurationJsonClusterSync_426 Sync;
	public TMap<string,string> Network;
	public TMap<string,FDisplayClusterConfigurationJsonClusterNode_426> Nodes;
}
