namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeSubGraph.h")]
public partial class UOptimusNodeSubGraph : UOptimusNodeGraph {
	public static UClass StaticClass() {return default;}
	///<summary>FIXME: These are uneditable for now.</summary>
	public TArray<FOptimusParameterBinding> InputBindings;
	///<summary>OutputBindings</summary>
	public TArray<FOptimusParameterBinding> OutputBindings;
	///<summary>EntryNode</summary>
	public TWeakObjectPtr<UOptimusNode_GraphTerminal> EntryNode;
	///<summary>ReturnNode</summary>
	public TWeakObjectPtr<UOptimusNode_GraphTerminal> ReturnNode;
}
