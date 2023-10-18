namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeComponent.h")]
public partial class UBehaviorTreeComponent : UBrainComponent {
	public static UClass StaticClass() {return default;}
	///<summary>@return the cooldown tag end time, 0.0f if CooldownTag is not found</summary>
	public double GetTagCooldownEndTime(FGameplayTag CooldownTag) { return default; }
	///<summary>add to the cooldown tag&#39;s duration</summary>
	public void AddCooldownTagDuration(FGameplayTag CooldownTag,float CooldownDuration,bool bAddToExistingDuration) {}
	///<summary>assign subtree to RunBehaviorDynamic task specified by tag</summary>
	public virtual void SetDynamicSubtree(FGameplayTag InjectTag,UBehaviorTree BehaviorAsset) {}
	///<summary>instanced nodes</summary>
	public TArray<UBTNode> NodeInstances;
	///<summary>data asset defining the tree</summary>
	public UBehaviorTree DefaultBehaviorTreeAsset;
}
