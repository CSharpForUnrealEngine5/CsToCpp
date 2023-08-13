namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Root node of this behavior tree, holds Blackboard data</summary>
[CppInclude("BehaviorTreeGraphNode_Root.h")]
public partial class UBehaviorTreeGraphNode_Root : UBehaviorTreeGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>BlackboardAsset</summary>
	public UBlackboardData BlackboardAsset;
}
