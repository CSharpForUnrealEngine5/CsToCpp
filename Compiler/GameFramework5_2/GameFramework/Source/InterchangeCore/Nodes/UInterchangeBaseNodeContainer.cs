#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interchange UInterchangeBaseNode graph is a format used to feed asset/scene import/reimport/export factories/writer.</summary>
[CppInclude("Nodes/InterchangeBaseNodeContainer.h")]
public partial class UInterchangeBaseNodeContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Add a node in the container, the node will be add into a TMap.</summary>
	public  string AddNode(UInterchangeBaseNode Node) { return default; }
	///<summary>Return true if the node unique ID exist in the container</summary>
	public  bool IsNodeUidValid(string NodeUniqueID) { return default; }
	///<summary>Return all nodes that do not have any parent</summary>
	public  void GetRoots(TArray<string> RootNodes) {}
	///<summary>Return all nodes that are of the ClassNode type</summary>
	public  void GetNodes(UClass ClassNode,TArray<string> OutNodes) {}
	///<summary>Get a node pointer. Once added to the container, nodes are considered const</summary>
	public  UInterchangeBaseNode GetNode(string NodeUniqueID) { return default; }
	///<summary>Get a factory node pointer</summary>
	public  UInterchangeFactoryBaseNode GetFactoryNode(string NodeUniqueID) { return default; }
	///<summary>Set node ParentUid</summary>
	public  bool SetNodeParentUid(string NodeUniqueID,string NewParentNodeUid) { return default; }
	///<summary>Get the node children count</summary>
	public  int GetNodeChildrenCount(string NodeUniqueID) { return default; }
	///<summary>Get all children Uid</summary>
	public  TArray<string> GetNodeChildrenUids(string NodeUniqueID) { return default; }
	///<summary>Get the node nth const children</summary>
	public  UInterchangeBaseNode GetNodeChildren(string NodeUniqueID,int ChildIndex) { return default; }
	///<summary>Serialize the node container into the specified file.</summary>
	public  void SaveToFile(string Filename) {}
	///<summary>Serialize the node container from the specified file.</summary>
	public  void LoadFromFile(string Filename) {}
	///<summary>Fill the children uids cache to optimize the GetNodeChildrenUids call.</summary>
	public  void ComputeChildrenCache() {}
	///<summary>Reset the children uids cache.</summary>
	public  void ResetChildrenCache() {}
	///<summary>Flat List of the nodes. Since the nodes are variable size, we store a pointer.</summary>
	public TMap<string,UInterchangeBaseNode> Nodes;
}
