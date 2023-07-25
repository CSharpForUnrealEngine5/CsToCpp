#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTCompositeNode.h")]
public partial struct FBTCompositeChild {
// BTCompositeChild
	public UBTCompositeNode ChildComposite;
	public UBTTaskNode ChildTask;
	public TArray<UBTDecorator> Decorators;
	public TArray<FBTDecoratorLogic> DecoratorOps;
}
