#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAbilityCommit.h")]
///<summary>Waits for the actor to activate another ability</summary>
public partial class UAbilityTask_WaitAbilityCommit : UAbilityTask {
// AbilityTask_WaitAbilityCommit
	public FWaitAbilityCommitDelegate OnCommit;
	public  void OnAbilityCommit(UGameplayAbility ActivatedAbility) {}
	public static UAbilityTask_WaitAbilityCommit WaitForAbilityCommit(UGameplayAbility OwningAbility,FGameplayTag WithTag,FGameplayTag WithoutTage,bool TriggerOnce/*=true*/) { return default; }
	public static UAbilityTask_WaitAbilityCommit WaitForAbilityCommit_Query(UGameplayAbility OwningAbility,FGameplayTagQuery Query,bool TriggerOnce/*=true*/) { return default; }
}
