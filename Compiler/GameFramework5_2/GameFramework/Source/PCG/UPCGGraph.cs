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
	public UObject AddNodeOfType(UClass InSettingsClass,UObject DefaultNodeSettings) { return default; }
	public UObject AddNodeInstance(UObject InSettings) { return default; }
	public UObject AddNodeCopy(UObject InSettings,UObject DefaultNodeSettings) { return default; }
	public void RemoveNode(UObject InNode) {}
	public UObject AddEdge(UObject From,string FromPinLabel,UObject To,string ToPinLabel) { return default; }
	public bool RemoveEdge(UObject From,string FromLabel,UObject To,string ToLabel) { return default; }
	public UObject GetInputNode() { return default; }
	public UObject GetOutputNode() { return default; }
	public void ForceNotificationForEditor() {}
	public TArray<UPCGNode> Nodes;
	public UPCGNode InputNode;
	public UPCGNode OutputNode;
	public TArray<UObject> ExtraEditorNodes;
	public FInstancedPropertyBag UserParameters;
}
