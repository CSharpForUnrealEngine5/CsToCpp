#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Tasks/BTTask_RunBehaviorDynamic.h")]
///<summary>RunBehaviorDynamic task allows pushing subtrees on execution stack.</summary>
public partial class UBTTask_RunBehaviorDynamic : UBTTaskNode {
// BTTask_RunBehaviorDynamic
	public FGameplayTag InjectionTag;
	public UBehaviorTree DefaultBehaviorAsset;
	public UBehaviorTree BehaviorAsset;
}
