#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeGraph.h")]
public partial class UOptimusNodeGraph : UObject {
// OptimusNodeGraph
	public  EOptimusNodeGraphType GetGraphType() { return default; }
	public  bool IsExecutionGraph() { return default; }
	public  bool IsFunctionGraph() { return default; }
	public  int GetGraphIndex() { return default; }
	public  UOptimusNode AddNode(UClass InNodeClass,FVector2D InPosition) { return default; }
	public  UOptimusNode AddValueNode(FOptimusDataTypeRef InDataTypeRef,FVector2D InPosition) { return default; }
	public  UOptimusNode AddDataInterfaceNode(UClass InDataInterfaceClass,FVector2D InPosition) { return default; }
	public  UOptimusNode AddResourceNode(UOptimusResourceDescription InResourceDesc,FVector2D InPosition) { return default; }
	public  UOptimusNode AddResourceGetNode(UOptimusResourceDescription InResourceDesc,FVector2D InPosition) { return default; }
	public  UOptimusNode AddResourceSetNode(UOptimusResourceDescription InResourceDesc,FVector2D InPosition) { return default; }
	public  UOptimusNode AddVariableGetNode(UOptimusVariableDescription InVariableDesc,FVector2D InPosition) { return default; }
	public  UOptimusNode AddComponentBindingGetNode(UOptimusComponentSourceBinding InComponentBinding,FVector2D InPosition) { return default; }
	public  bool RemoveNode(UOptimusNode InNode) { return default; }
	public  bool RemoveNodes(TArray<UOptimusNode> InNodes) { return default; }
	public  UOptimusNode DuplicateNode(UOptimusNode InNode,FVector2D InPosition) { return default; }
	public  bool DuplicateNodes(TArray<UOptimusNode> InNodes,FVector2D InPosition) { return default; }
	public  bool AddLink(UOptimusNodePin InNodeOutputPin,UOptimusNodePin InNodeInputPin) { return default; }
	public  bool RemoveLink(UOptimusNodePin InNodeOutputPin,UOptimusNodePin InNodeInputPin) { return default; }
	public  bool RemoveAllLinks(UOptimusNodePin InNodePin) { return default; }
	public  UOptimusNode ConvertCustomKernelToFunction(UOptimusNode InCustomKernel) { return default; }
	public  UOptimusNode ConvertFunctionToCustomKernel(UOptimusNode InKernelFunction) { return default; }
	public  UOptimusNode CollapseNodesToFunction(TArray<UOptimusNode> InNodes) { return default; }
	public  UOptimusNode CollapseNodesToSubGraph(TArray<UOptimusNode> InNodes) { return default; }
	public  TArray<UOptimusNode> ExpandCollapsedNodes(UOptimusNode InFunctionNode) { return default; }
	public  bool IsCustomKernel(UOptimusNode InNode) { return default; }
	public  bool IsKernelFunction(UOptimusNode InNode) { return default; }
	public  bool IsFunctionReference(UOptimusNode InNode) { return default; }
	public  bool IsSubGraphReference(UOptimusNode InNode) { return default; }
	public  TArray<UOptimusNodeGraph> GetGraphs() { return default; }
	public  bool MoveGraph(UOptimusNodeGraph InGraph,int InInsertBefore) { return default; }
	public  bool RenameGraph(UOptimusNodeGraph InGraph,string InNewName) { return default; }
	public EOptimusNodeGraphType GraphType;
	public TArray<UOptimusNode> Nodes;
	public TArray<UOptimusNodeLink> Links;
	public TArray<UOptimusNodeGraph> SubGraphs;
}
