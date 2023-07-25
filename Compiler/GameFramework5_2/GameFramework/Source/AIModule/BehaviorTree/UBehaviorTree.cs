#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTree.h")]
public partial class UBehaviorTree : UObject {
// BehaviorTree
	public UBTCompositeNode RootNode;
	public UEdGraph BTGraph;
	public TArray<FEditedDocumentInfo> LastEditedDocuments;
	public UBlackboardData BlackboardAsset;
	public TArray<UBTDecorator> RootDecorators;
	public TArray<FBTDecoratorLogic> RootDecoratorOps;
}
