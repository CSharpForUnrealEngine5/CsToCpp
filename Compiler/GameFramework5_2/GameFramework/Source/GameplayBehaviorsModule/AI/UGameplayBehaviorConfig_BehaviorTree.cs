namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/GameplayBehaviorConfig_BehaviorTree.h")]
public partial class UGameplayBehaviorConfig_BehaviorTree : UGameplayBehaviorConfig {
	public static UClass StaticClass() {return default;}
	///<summary>BehaviorTree</summary>
	public TSoftObjectPtr<UBehaviorTree> BehaviorTree;
	///<summary>bRevertToPreviousBTOnFinish</summary>
	public bool bRevertToPreviousBTOnFinish;
}
