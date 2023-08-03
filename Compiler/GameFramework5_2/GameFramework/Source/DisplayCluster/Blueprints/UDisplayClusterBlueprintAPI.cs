#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/IDisplayClusterBlueprintAPI.h")]
public partial class UDisplayClusterBlueprintAPI : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if the module has been initialized.</summary>
	public  bool IsModuleInitialized() { return default; }
	///<summary>Returns current operation mode.</summary>
	public  EDisplayClusterOperationMode GetOperationMode() { return default; }
	///<summary>Returns DisplayCluster root actor.</summary>
	public  ADisplayClusterRootActor GetRootActor() { return default; }
	///<summary>Returns Id of the current node in a cluster.</summary>
	public  string GetNodeId() { return default; }
	///<summary>Returns List of the active nodes in the runtime cluster node in a cluster.</summary>
	public  void GetActiveNodeIds(TArray<string> OutNodeIds) {}
	///<summary>Returns amount of active nodes in a cluster.</summary>
	public  int GetActiveNodesAmount() { return default; }
	///<summary>Returns true if current node is a primary node in a cluster.</summary>
	public  bool IsPrimary() { return default; }
	///<summary>Returns true if current node is a secondary node in a cluster.</summary>
	public  bool IsSecondary() { return default; }
	///<summary>Returns true if current node is a backup node in a cluster.</summary>
	public  bool IsBackup() { return default; }
	///<summary>Returns the role of the current cluster node.</summary>
	public  EDisplayClusterNodeRole GetClusterRole() { return default; }
	///<summary>Adds cluster event listener.</summary>
	public  void AddClusterEventListener(object /*Listener*/ Listener) {}
	///<summary>Removes cluster event listener.</summary>
	public  void RemoveClusterEventListener(object /*Listener*/ Listener) {}
	///<summary>Emits JSON cluster event.</summary>
	public  void EmitClusterEventJson(FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	///<summary>Emits binary cluster event.</summary>
	public  void EmitClusterEventBinary(FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
	///<summary>Sends JSON cluster event to a specific target (outside of the cluster).</summary>
	public  void SendClusterEventJsonTo(string Address,int Port,FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	///<summary>Sends binary cluster event to a specific target (outside of the cluster).</summary>
	public  void SendClusterEventBinaryTo(string Address,int Port,FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
}
