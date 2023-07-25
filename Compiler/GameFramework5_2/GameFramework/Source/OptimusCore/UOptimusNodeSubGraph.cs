#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeSubGraph.h")]
public partial class UOptimusNodeSubGraph : UOptimusNodeGraph {
// OptimusNodeSubGraph
	public TArray<FOptimusParameterBinding> InputBindings;
	public TArray<FOptimusParameterBinding> OutputBindings;
	public TWeakObjectPtr<UOptimusNode_GraphTerminal> EntryNode;
	public TWeakObjectPtr<UOptimusNode_GraphTerminal> ReturnNode;
}
