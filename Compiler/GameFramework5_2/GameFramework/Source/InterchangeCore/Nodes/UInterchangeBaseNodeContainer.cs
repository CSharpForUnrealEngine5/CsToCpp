#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeBaseNodeContainer.h")]
///<summary>Interchange UInterchangeBaseNode graph is a format used to feed asset/scene import/reimport/export factories/writer.</summary>
public partial class UInterchangeBaseNodeContainer : UObject {
// InterchangeBaseNodeContainer
	public string AddNode(UObject Node) { return default; }
	public bool IsNodeUidValid(string NodeUniqueID) { return default; }
	public void GetRoots(TArray<string> RootNodes) {}
	public void GetNodes(UClass ClassNode,TArray<string> OutNodes) {}
	public UObject GetNode(string NodeUniqueID) { return default; }
	public UObject GetFactoryNode(string NodeUniqueID) { return default; }
	public bool SetNodeParentUid(string NodeUniqueID,string NewParentNodeUid) { return default; }
	public int GetNodeChildrenCount(string NodeUniqueID) { return default; }
	public TArray<string> GetNodeChildrenUids(string NodeUniqueID) { return default; }
	public UObject GetNodeChildren(string NodeUniqueID,int ChildIndex) { return default; }
	public void SaveToFile(string Filename) {}
	public void LoadFromFile(string Filename) {}
	public void ComputeChildrenCache() {}
	public void ResetChildrenCache() {}
	public TMap<string,UInterchangeBaseNode> Nodes;
}
