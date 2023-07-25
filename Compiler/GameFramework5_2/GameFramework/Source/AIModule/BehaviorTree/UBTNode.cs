#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTNode.h")]
public partial class UBTNode : UObject {
// BTNode
	public string NodeName;
	public UBehaviorTree TreeAsset;
	public UBTCompositeNode ParentNode;
}
