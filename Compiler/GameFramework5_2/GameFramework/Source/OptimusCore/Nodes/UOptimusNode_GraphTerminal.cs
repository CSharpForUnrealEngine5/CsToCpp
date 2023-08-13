namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_GraphTerminal.h")]
public partial class UOptimusNode_GraphTerminal : UOptimusNode {
	public static UClass StaticClass() {return default;}
	///<summary>Indicates whether this is an entry or a return terminal node</summary>
	public EOptimusTerminalType TerminalType;
	///<summary>The graph that owns us. This contains all the necessary pin information to add on</summary>
	public TWeakObjectPtr<UOptimusNodeSubGraph> OwningGraph;
}
