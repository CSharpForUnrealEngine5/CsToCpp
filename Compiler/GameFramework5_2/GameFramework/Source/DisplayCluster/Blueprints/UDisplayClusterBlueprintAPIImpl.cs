namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint API interface implementation</summary>
[CppInclude("Blueprints/DisplayClusterBlueprintAPIImpl.h")]
public partial class UDisplayClusterBlueprintAPIImpl : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DisplayCluster module API</summary>
	public virtual bool IsModuleInitialized() { return default; }
	///<summary>Runtime Cluster API</summary>
	public virtual EDisplayClusterOperationMode GetOperationMode() { return default; }
	///<summary>GetRootActor</summary>
	public virtual ADisplayClusterRootActor GetRootActor() { return default; }
	///<summary>Runtime local node API</summary>
	public virtual string GetNodeId() { return default; }
	///<summary>Returns List of the active nodes in the runtime cluster node in a cluster.</summary>
	public virtual void GetActiveNodeIds(TArray<string> OutNodeIds) {}
	///<summary>Returns amount of active nodes in a cluster.</summary>
	public virtual int GetActiveNodesAmount() { return default; }
	///<summary>GetClusterRole</summary>
	public virtual EDisplayClusterNodeRole GetClusterRole() { return default; }
	///<summary>IsPrimary</summary>
	public virtual bool IsPrimary() { return default; }
	///<summary>IsSecondary</summary>
	public virtual bool IsSecondary() { return default; }
	///<summary>Returns true if current node is a backup node in a cluster.</summary>
	public virtual bool IsBackup() { return default; }
	///<summary>Cluster events API</summary>
	public virtual void AddClusterEventListener(object /*Listener*/ Listener) {}
	///<summary>RemoveClusterEventListener</summary>
	public virtual void RemoveClusterEventListener(object /*Listener*/ Listener) {}
	///<summary>EmitClusterEventJson</summary>
	public virtual void EmitClusterEventJson(FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	///<summary>EmitClusterEventBinary</summary>
	public virtual void EmitClusterEventBinary(FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
	///<summary>SendClusterEventJsonTo</summary>
	public virtual void SendClusterEventJsonTo(string Address,int Port,FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	///<summary>SendClusterEventBinaryTo</summary>
	public virtual void SendClusterEventBinaryTo(string Address,int Port,FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
}
