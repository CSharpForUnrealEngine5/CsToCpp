#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTCompositeNode.h")]
public partial class UBTCompositeNode : UBTNode {
// BTCompositeNode
	public TArray<FBTCompositeChild> Children;
	public TArray<UBTService> Services;
	public bool bApplyDecoratorScope;
}
