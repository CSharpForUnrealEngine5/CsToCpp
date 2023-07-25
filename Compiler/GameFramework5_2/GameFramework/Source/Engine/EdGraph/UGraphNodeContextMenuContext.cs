#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphNode.h")]
///<summary>This is the context for GetContextMenuActions and GetNodeContextMenuActions calls.</summary>
public partial class UGraphNodeContextMenuContext : UObject {
// GraphNodeContextMenuContext
	public UBlueprint Blueprint;
	public UEdGraph Graph;
	public UEdGraphNode Node;
	public bool bIsDebugging;
}
