#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint API interface implementation</summary>
[CppInclude("Blueprints/DisplayClusterBlueprintAPIImpl.h")]
public partial class UDisplayClusterBlueprintAPIImpl : UObject {
	///<summary>DisplayCluster module API</summary>
	public  bool IsModuleInitialized() { return default; }
	///<summary>Runtime Cluster API</summary>
	public  EDisplayClusterOperationMode GetOperationMode() { return default; }
	///<summary>GetRootActor</summary>
	public  ADisplayClusterRootActor GetRootActor() { return default; }
	///<summary>Runtime local node API</summary>
	public  string GetNodeId() { return default; }
	///<summary>Returns List of the active nodes in the runtime cluster node in a cluster.</summary>
	public  void GetActiveNodeIds(TArray<string> OutNodeIds) {}
	///<summary>Returns amount of active nodes in a cluster.</summary>
	public  int GetActiveNodesAmount() { return default; }
	///<summary>GetClusterRole</summary>
	public  EDisplayClusterNodeRole GetClusterRole() { return default; }
	///<summary>IsPrimary</summary>
	public  bool IsPrimary() { return default; }
	///<summary>IsSecondary</summary>
	public  bool IsSecondary() { return default; }
	///<summary>Returns true if current node is a backup node in a cluster.</summary>
	public  bool IsBackup() { return default; }
	///<summary>Cluster events API</summary>
	public  void AddClusterEventListener(object /*Listener*/ Listener) {}
	///<summary>RemoveClusterEventListener</summary>
	public  void RemoveClusterEventListener(object /*Listener*/ Listener) {}
	///<summary>EmitClusterEventJson</summary>
	public  void EmitClusterEventJson(FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	///<summary>EmitClusterEventBinary</summary>
	public  void EmitClusterEventBinary(FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
	///<summary>SendClusterEventJsonTo</summary>
	public  void SendClusterEventJsonTo(string Address,int Port,FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	///<summary>SendClusterEventBinaryTo</summary>
	public  void SendClusterEventBinaryTo(string Address,int Port,FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
}
