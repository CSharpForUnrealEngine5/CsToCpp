#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeComponent.h")]
public partial class UBehaviorTreeComponent : UBrainComponent {
// BehaviorTreeComponent
	public  double GetTagCooldownEndTime(FGameplayTag CooldownTag) { return default; }
	public  void AddCooldownTagDuration(FGameplayTag CooldownTag,float CooldownDuration,bool bAddToExistingDuration) {}
	public  void SetDynamicSubtree(FGameplayTag InjectTag,UBehaviorTree BehaviorAsset) {}
	public TArray<UBTNode> NodeInstances;
	public UBehaviorTree DefaultBehaviorTreeAsset;
}
