#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimStateConduitNode.h")]
public partial class UAnimStateConduitNode : UAnimStateNodeBase {
	public static UClass StaticClass() {return default;}
	///<summary>The transition graph for this conduit; it&#39;s a logic graph, not an animation graph</summary>
	public UEdGraph BoundGraph;
}
