#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTCompositeNode.h")]
public partial class UBTCompositeNode : UBTNode {
	///<summary>child nodes</summary>
	public TArray<FBTCompositeChild> Children;
	///<summary>service nodes</summary>
	public TArray<UBTService> Services;
	///<summary>if set, all decorators in branch below will be removed when execution flow leaves (decorators on this node are not affected)</summary>
	public bool bApplyDecoratorScope;
}
