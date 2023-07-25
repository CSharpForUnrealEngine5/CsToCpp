#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTreeGraphNode.h")]
public partial class UBehaviorTreeGraphNode : UAIGraphNode {
// BehaviorTreeGraphNode
	public TArray<UBehaviorTreeGraphNode> Decorators;
	public TArray<UBehaviorTreeGraphNode> Services;
	public bool bInjectedNode;
}
