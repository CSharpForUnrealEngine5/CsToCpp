namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNode.h")]
public partial class USoundNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ChildNodes</summary>
	public TArray<USoundNode> ChildNodes;
	///<summary>Node&#39;s Graph representation, used to get position.</summary>
	public UEdGraphNode GraphNode;
}
