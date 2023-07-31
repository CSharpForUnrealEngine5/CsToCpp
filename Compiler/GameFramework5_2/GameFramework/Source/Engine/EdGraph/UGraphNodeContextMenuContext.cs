#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the context for GetContextMenuActions and GetNodeContextMenuActions calls.</summary>
[CppInclude("EdGraph/EdGraphNode.h")]
public partial class UGraphNodeContextMenuContext : UObject {
	///<summary>The blueprint associated with this context; may be NULL for non-Kismet related graphs.</summary>
	public UBlueprint Blueprint;
	///<summary>The graph associated with this context.</summary>
	public UEdGraph Graph;
	///<summary>The node associated with this context.</summary>
	public UEdGraphNode Node;
	///<summary>Whether the graph editor is currently part of a debugging session (any non-debugging commands should be disabled).</summary>
	public bool bIsDebugging;
}
