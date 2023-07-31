#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNode.h")]
public partial class USoundNode : UObject {
	///<summary>ChildNodes</summary>
	public TArray<USoundNode> ChildNodes;
	///<summary>Node&#39;s Graph representation, used to get position.</summary>
	public UEdGraphNode GraphNode;
}
