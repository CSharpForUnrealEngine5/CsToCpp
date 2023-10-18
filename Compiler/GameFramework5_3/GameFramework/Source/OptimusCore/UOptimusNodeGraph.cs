namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeGraph.h")]
public partial class UOptimusNodeGraph : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetGraphType</summary>
	public EOptimusNodeGraphType GetGraphType() { return default; }
	///<summary>IsExecutionGraph</summary>
	public bool IsExecutionGraph() { return default; }
	///<summary>IsFunctionGraph</summary>
	public bool IsFunctionGraph() { return default; }
	///<summary>GetGraphIndex</summary>
	public int GetGraphIndex() { return default; }
	///<summary>TODO: Add magic connection from a pin.</summary>
	public UOptimusNode AddNode(UClass InNodeClass,FVector2D InPosition) { return default; }
	///<summary>AddValueNode</summary>
	public UOptimusNode AddValueNode(FOptimusDataTypeRef InDataTypeRef,FVector2D InPosition) { return default; }
	///<summary>AddDataInterfaceNode</summary>
	public UOptimusNode AddDataInterfaceNode(UClass InDataInterfaceClass,FVector2D InPosition) { return default; }
	///<summary>AddResourceNode</summary>
	public UOptimusNode AddResourceNode(UOptimusResourceDescription InResourceDesc,FVector2D InPosition) { return default; }
	///<summary>AddResourceGetNode</summary>
	public UOptimusNode AddResourceGetNode(UOptimusResourceDescription InResourceDesc,FVector2D InPosition) { return default; }
	///<summary>AddResourceSetNode</summary>
	public UOptimusNode AddResourceSetNode(UOptimusResourceDescription InResourceDesc,FVector2D InPosition) { return default; }
	///<summary>AddVariableGetNode</summary>
	public UOptimusNode AddVariableGetNode(UOptimusVariableDescription InVariableDesc,FVector2D InPosition) { return default; }
	///<summary>AddComponentBindingGetNode</summary>
	public UOptimusNode AddComponentBindingGetNode(UOptimusComponentSourceBinding InComponentBinding,FVector2D InPosition) { return default; }
	///<summary>RemoveNode</summary>
	public bool RemoveNode(UOptimusNode InNode) { return default; }
	///<summary>RemoveNodes</summary>
	public bool RemoveNodes(TArray<UOptimusNode> InNodes) { return default; }
	///<summary>DuplicateNode</summary>
	public UOptimusNode DuplicateNode(UOptimusNode InNode,FVector2D InPosition) { return default; }
	///<summary>Duplicate a collection of nodes from the same graph, using the InPosition position</summary>
	public bool DuplicateNodes(TArray<UOptimusNode> InNodes,FVector2D InPosition) { return default; }
	///<summary>AddLink</summary>
	public bool AddLink(UOptimusNodePin InNodeOutputPin,UOptimusNodePin InNodeInputPin) { return default; }
	///<summary>@brief Removes a single link between two nodes.</summary>
	public bool RemoveLink(UOptimusNodePin InNodeOutputPin,UOptimusNodePin InNodeInputPin) { return default; }
	///<summary>@brief Removes all links to the given pin, whether it&#39;s an input or an output pin.</summary>
	public bool RemoveAllLinks(UOptimusNodePin InNodePin) { return default; }
	///<summary>Takes a custom kernel and converts to a packaged function. If the given node is not a</summary>
	public UOptimusNode ConvertCustomKernelToFunction(UOptimusNode InCustomKernel) { return default; }
	///<summary>Takes a kernel function and unpackages to a custom kernel. If the given node is not a</summary>
	public UOptimusNode ConvertFunctionToCustomKernel(UOptimusNode InKernelFunction) { return default; }
	///<summary>Take a set of nodes and collapse them into a single function, replacing the given nodes</summary>
	public UOptimusNode CollapseNodesToFunction(TArray<UOptimusNode> InNodes) { return default; }
	///<summary>Take a set of nodes and collapse them into a subgraph, replacing the given nodes</summary>
	public UOptimusNode CollapseNodesToSubGraph(TArray<UOptimusNode> InNodes) { return default; }
	///<summary>Take a function or subgraph node and expand it in-place, replacing the given function</summary>
	public TArray<UOptimusNode> ExpandCollapsedNodes(UOptimusNode InFunctionNode) { return default; }
	///<summary>Returns true if the node in question is a custom kernel node that can be converted to</summary>
	public bool IsCustomKernel(UOptimusNode InNode) { return default; }
	///<summary>Returns true if the node in question is a kernel function node that can be converted to</summary>
	public bool IsKernelFunction(UOptimusNode InNode) { return default; }
	///<summary>Returns true if the node in question is a function reference node that can be expanded</summary>
	public bool IsFunctionReference(UOptimusNode InNode) { return default; }
	///<summary>Returns true if the node in question is a function sub-graph node that can be expanded</summary>
	public bool IsSubGraphReference(UOptimusNode InNode) { return default; }
	///<summary>GetGraphs</summary>
	public TArray<UOptimusNodeGraph> GetGraphs() { return default; }
	///<summary>MoveGraph</summary>
	public bool MoveGraph(UOptimusNodeGraph InGraph,int InInsertBefore) { return default; }
	///<summary>RenameGraph</summary>
	public bool RenameGraph(UOptimusNodeGraph InGraph,string InNewName) { return default; }
	///<summary>The type of graph this represents.</summary>
	public EOptimusNodeGraphType GraphType;
	///<summary>bViewLocationSet</summary>
	public bool bViewLocationSet;
	///<summary>ViewLocation</summary>
	public FVector2D ViewLocation;
	///<summary>ViewZoom</summary>
	public float ViewZoom;
	///<summary>Nodes</summary>
	public TArray<UOptimusNode> Nodes;
	///<summary>FIXME: Use a map.</summary>
	public TArray<UOptimusNodeLink> Links;
	///<summary>SubGraphs</summary>
	public TArray<UOptimusNodeGraph> SubGraphs;
}
