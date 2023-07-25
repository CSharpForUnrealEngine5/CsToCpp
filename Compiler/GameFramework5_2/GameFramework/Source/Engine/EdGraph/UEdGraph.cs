#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraph.h")]
public partial class UEdGraph : UObject {
// EdGraph
	public UClass Schema;
	public TArray<UEdGraphNode> Nodes;
	public bool bEditable;
	public bool bAllowDeletion;
	public bool bAllowRenaming;
	public TArray<UEdGraph> SubGraphs;
	public FGuid GraphGuid;
	public FGuid InterfaceGuid;
}
