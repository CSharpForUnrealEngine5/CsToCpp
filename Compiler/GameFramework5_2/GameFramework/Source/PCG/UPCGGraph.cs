#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGGraph.h")]
public partial class UPCGGraph : UPCGGraphInterface {
// PCGGraph
	public bool bExposeToLibrary;
	public string Category;
	public string Description;
	public bool bLandscapeUsesMetadata;
	public  UPCGNode AddNodeOfType(UClass InSettingsClass,UPCGSettings DefaultNodeSettings) { return default; }
	public  UPCGNode AddNodeInstance(UPCGSettings InSettings) { return default; }
	public  UPCGNode AddNodeCopy(UPCGSettings InSettings,UPCGSettings DefaultNodeSettings) { return default; }
	public  void RemoveNode(UPCGNode InNode) {}
	public  UPCGNode AddEdge(UPCGNode From,string FromPinLabel,UPCGNode To,string ToPinLabel) { return default; }
	public  bool RemoveEdge(UPCGNode From,string FromLabel,UPCGNode To,string ToLabel) { return default; }
	public  UPCGNode GetInputNode() { return default; }
	public  UPCGNode GetOutputNode() { return default; }
	public  void ForceNotificationForEditor() {}
	public TArray<UPCGNode> Nodes;
	public UPCGNode InputNode;
	public UPCGNode OutputNode;
	public TArray<UObject> ExtraEditorNodes;
	public FInstancedPropertyBag UserParameters;
}
