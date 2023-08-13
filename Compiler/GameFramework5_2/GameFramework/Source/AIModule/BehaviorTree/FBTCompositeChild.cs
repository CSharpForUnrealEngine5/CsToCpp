namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTCompositeNode.h")]
public partial struct FBTCompositeChild {
	public UBTCompositeNode ChildComposite;
	public UBTTaskNode ChildTask;
	public TArray<UBTDecorator> Decorators;
	public TArray<FBTDecoratorLogic> DecoratorOps;
}
