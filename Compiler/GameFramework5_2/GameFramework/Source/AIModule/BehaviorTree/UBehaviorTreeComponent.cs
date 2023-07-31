#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeComponent.h")]
public partial class UBehaviorTreeComponent : UBrainComponent {
	///<summary>@return the cooldown tag end time, 0.0f if CooldownTag is not found</summary>
	public  double GetTagCooldownEndTime(FGameplayTag CooldownTag) { return default; }
	///<summary>add to the cooldown tag&#39;s duration</summary>
	public  void AddCooldownTagDuration(FGameplayTag CooldownTag,float CooldownDuration,bool bAddToExistingDuration) {}
	///<summary>assign subtree to RunBehaviorDynamic task specified by tag</summary>
	public  void SetDynamicSubtree(FGameplayTag InjectTag,UBehaviorTree BehaviorAsset) {}
	///<summary>instanced nodes</summary>
	public TArray<UBTNode> NodeInstances;
	///<summary>data asset defining the tree</summary>
	public UBehaviorTree DefaultBehaviorTreeAsset;
}
