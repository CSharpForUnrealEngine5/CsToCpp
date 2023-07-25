#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_GraphTerminal.h")]
public partial class UOptimusNode_GraphTerminal : UOptimusNode {
// OptimusNode_GraphTerminal
	public EOptimusTerminalType TerminalType;
	public TWeakObjectPtr<UOptimusNodeSubGraph> OwningGraph;
}
