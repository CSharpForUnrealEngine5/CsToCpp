#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RunBehaviorDynamic task allows pushing subtrees on execution stack.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_RunBehaviorDynamic.h")]
public partial class UBTTask_RunBehaviorDynamic : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>Gameplay tag that will identify this task for subtree injection</summary>
	public FGameplayTag InjectionTag;
	///<summary>default behavior to run</summary>
	public UBehaviorTree DefaultBehaviorAsset;
	///<summary>current subtree</summary>
	public UBehaviorTree BehaviorAsset;
}
