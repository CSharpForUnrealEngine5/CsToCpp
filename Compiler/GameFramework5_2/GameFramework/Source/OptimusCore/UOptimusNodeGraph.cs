#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeGraph.h")]
public partial class UOptimusNodeGraph : UObject {
// OptimusNodeGraph
	public EOptimusNodeGraphType GetGraphType() { return default; }
	public bool IsExecutionGraph() { return default; }
	public bool IsFunctionGraph() { return default; }
	public int GetGraphIndex() { return default; }
	public UObject AddNode(UClass InNodeClass,FVector2D InPosition) { return default; }
	public UObject AddValueNode(FOptimusDataTypeRef InDataTypeRef,FVector2D InPosition) { return default; }
	public UObject AddDataInterfaceNode(UClass InDataInterfaceClass,FVector2D InPosition) { return default; }
	public UObject AddResourceNode(UObject InResourceDesc,FVector2D InPosition) { return default; }
	public UObject AddResourceGetNode(UObject InResourceDesc,FVector2D InPosition) { return default; }
	public UObject AddResourceSetNode(UObject InResourceDesc,FVector2D InPosition) { return default; }
	public UObject AddVariableGetNode(UObject InVariableDesc,FVector2D InPosition) { return default; }
	public UObject AddComponentBindingGetNode(UObject InComponentBinding,FVector2D InPosition) { return default; }
	public bool RemoveNode(UObject InNode) { return default; }
	public bool RemoveNodes(TArray<UObject> InNodes) { return default; }
	public UObject DuplicateNode(UObject InNode,FVector2D InPosition) { return default; }
	public bool DuplicateNodes(TArray<UObject> InNodes,FVector2D InPosition) { return default; }
	public bool AddLink(UObject InNodeOutputPin,UObject InNodeInputPin) { return default; }
	public bool RemoveLink(UObject InNodeOutputPin,UObject InNodeInputPin) { return default; }
	public bool RemoveAllLinks(UObject InNodePin) { return default; }
	public UObject ConvertCustomKernelToFunction(UObject InCustomKernel) { return default; }
	public UObject ConvertFunctionToCustomKernel(UObject InKernelFunction) { return default; }
	public UObject CollapseNodesToFunction(TArray<UObject> InNodes) { return default; }
	public UObject CollapseNodesToSubGraph(TArray<UObject> InNodes) { return default; }
	public TArray<UObject> ExpandCollapsedNodes(UObject InFunctionNode) { return default; }
	public bool IsCustomKernel(UObject InNode) { return default; }
	public bool IsKernelFunction(UObject InNode) { return default; }
	public bool IsFunctionReference(UObject InNode) { return default; }
	public bool IsSubGraphReference(UObject InNode) { return default; }
	public TArray<UObject> GetGraphs() { return default; }
	public bool MoveGraph(UObject InGraph,int InInsertBefore) { return default; }
	public bool RenameGraph(UObject InGraph,string InNewName) { return default; }
	public EOptimusNodeGraphType GraphType;
	public TArray<UOptimusNode> Nodes;
	public TArray<UOptimusNodeLink> Links;
	public TArray<UOptimusNodeGraph> SubGraphs;
}
