#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeSubGraph.h")]
public partial class UOptimusNodeSubGraph : UOptimusNodeGraph {
	///<summary>FIXME: These are uneditable for now.</summary>
	public TArray<FOptimusParameterBinding> InputBindings;
	///<summary>OutputBindings</summary>
	public TArray<FOptimusParameterBinding> OutputBindings;
	///<summary>EntryNode</summary>
	public TWeakObjectPtr<UOptimusNode_GraphTerminal> EntryNode;
	///<summary>ReturnNode</summary>
	public TWeakObjectPtr<UOptimusNode_GraphTerminal> ReturnNode;
}
