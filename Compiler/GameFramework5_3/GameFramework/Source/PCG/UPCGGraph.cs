namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGGraph.h")]
public partial class UPCGGraph : UPCGGraphInterface {
	public static UClass StaticClass() {return default;}
	///<summary>bExposeToLibrary</summary>
	public bool bExposeToLibrary;
	///<summary>Category</summary>
	public FText Category;
	///<summary>Description</summary>
	public FText Description;
	///<summary>bLandscapeUsesMetadata</summary>
	public bool bLandscapeUsesMetadata;
	///<summary>Creates a default node based on the settings class wanted. Returns the newly created node.</summary>
	public UPCGNode AddNodeOfType(UClass InSettingsClass,UPCGSettings DefaultNodeSettings) { return default; }
	///<summary>Creates a node containing an instance to the given settings. Returns the created node.</summary>
	public UPCGNode AddNodeInstance(UPCGSettings InSettings) { return default; }
	///<summary>Creates a node and copies the input settings. Returns the created node.</summary>
	public UPCGNode AddNodeCopy(UPCGSettings InSettings,UPCGSettings DefaultNodeSettings) { return default; }
	///<summary>Removes a node from the graph.</summary>
	public void RemoveNode(UPCGNode InNode) {}
	///<summary>Adds a directed edge in the graph. Returns the &quot;To&quot; node for easy chaining</summary>
	public UPCGNode AddEdge(UPCGNode From,FName FromPinLabel,UPCGNode To,FName ToPinLabel) { return default; }
	///<summary>Removes an edge in the graph. Returns true if an edge was removed.</summary>
	public bool RemoveEdge(UPCGNode From,FName FromLabel,UPCGNode To,FName ToLabel) { return default; }
	///<summary>Returns the graph input node</summary>
	public UPCGNode GetInputNode() { return default; }
	///<summary>Returns the graph output node</summary>
	public UPCGNode GetOutputNode() { return default; }
	///<summary>ForceNotificationForEditor</summary>
	public void ForceNotificationForEditor() {}
	///<summary>Nodes</summary>
	public TArray<UPCGNode> Nodes;
	///<summary>Add input/output nodes</summary>
	public UPCGNode InputNode;
	///<summary>OutputNode</summary>
	public UPCGNode OutputNode;
	///<summary>Extra data to hold information that is useful only in editor (like comments)</summary>
	public TArray<UObject> ExtraEditorNodes;
	///<summary>Parameters</summary>
	public FInstancedPropertyBag UserParameters;
	///<summary>UserParametersIsPinTypeAccepted</summary>
	public bool UserParametersIsPinTypeAccepted(FEdGraphPinType InPinType) { return default; }
	///<summary>UserParametersCanRemoveProperty</summary>
	public bool UserParametersCanRemoveProperty(FGuid InPropertyID,FName InPropertyName) { return default; }
	///<summary>bUseHierarchicalGeneration</summary>
	public bool bUseHierarchicalGeneration;
	///<summary>HiGenGridSize</summary>
	public EPCGHiGenGrid HiGenGridSize;
	///<summary>When true the Debug flag in the graph editor will display debug information contextually for the selected debug object. Otherwise</summary>
	public bool bDebugFlagAppliesToIndividualComponents;
}
