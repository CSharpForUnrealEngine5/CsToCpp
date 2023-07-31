#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraph.h")]
public partial class UEdGraph : UObject {
	///<summary>The schema that this graph obeys</summary>
	public UClass Schema;
	///<summary>Set of all nodes in this graph</summary>
	public TArray<UEdGraphNode> Nodes;
	///<summary>If true, graph can be edited by the user</summary>
	public bool bEditable;
	///<summary>If true, graph can be deleted from the whatever container it is in. For FunctionGraphs</summary>
	public bool bAllowDeletion;
	///<summary>If true, graph can be renamed; Note: Graph can also be renamed if bAllowDeletion is true currently</summary>
	public bool bAllowRenaming;
	///<summary>Child graphs that are a part of this graph; the separation is purely visual</summary>
	public TArray<UEdGraph> SubGraphs;
	///<summary>Guid for this graph</summary>
	public FGuid GraphGuid;
	///<summary>Guid of interface graph this graph comes from (used for conforming)</summary>
	public FGuid InterfaceGuid;
}
