#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/GameplayBehaviorConfig_BehaviorTree.h")]
public partial class UGameplayBehaviorConfig_BehaviorTree : UGameplayBehaviorConfig {
// GameplayBehaviorConfig_BehaviorTree
	public TSoftObjectPtr<UBehaviorTree> BehaviorTree;
	public bool bRevertToPreviousBTOnFinish;
}
