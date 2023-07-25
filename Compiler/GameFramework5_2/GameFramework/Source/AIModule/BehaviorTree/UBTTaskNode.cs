#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTTaskNode.h")]
///<summary>Task are leaf nodes of behavior tree, which perform actual actions</summary>
public partial class UBTTaskNode : UBTNode {
// BTTaskNode
	public TArray<UBTService> Services;
	public bool bIgnoreRestartSelf;
}
