namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTree.h")]
public partial class UBehaviorTree : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>root node of loaded tree</summary>
	public UBTCompositeNode RootNode;
	///<summary>Graph for Behavior Tree</summary>
	public UEdGraph BTGraph;
	///<summary>Info about the graphs we last edited</summary>
	public TArray<FEditedDocumentInfo> LastEditedDocuments;
	///<summary>blackboard asset for this tree</summary>
	public UBlackboardData BlackboardAsset;
	///<summary>root level decorators, used by subtrees</summary>
	public TArray<UBTDecorator> RootDecorators;
	///<summary>logic operators for root level decorators, used by subtrees</summary>
	public TArray<FBTDecoratorLogic> RootDecoratorOps;
}
