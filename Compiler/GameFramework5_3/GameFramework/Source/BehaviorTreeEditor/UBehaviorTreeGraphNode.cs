namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTreeGraphNode.h")]
public partial class UBehaviorTreeGraphNode : UAIGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>only some of behavior tree nodes support decorators</summary>
	public TArray<UBehaviorTreeGraphNode> Decorators;
	///<summary>only some of behavior tree nodes support services</summary>
	public TArray<UBehaviorTreeGraphNode> Services;
	///<summary>if set, this node was injected from subtree and shouldn&#39;t be edited</summary>
	public bool bInjectedNode;
}
