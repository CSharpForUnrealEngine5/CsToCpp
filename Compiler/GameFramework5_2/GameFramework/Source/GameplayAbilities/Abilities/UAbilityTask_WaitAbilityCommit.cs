#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAbilityCommit.h")]
///<summary>Waits for the actor to activate another ability</summary>
public partial class UAbilityTask_WaitAbilityCommit : UAbilityTask {
// AbilityTask_WaitAbilityCommit
	public FWaitAbilityCommitDelegate OnCommit;
	public void OnAbilityCommit(UObject ActivatedAbility) {}
	public UObject WaitForAbilityCommit(UObject OwningAbility,FGameplayTag WithTag,FGameplayTag WithoutTage,bool TriggerOnce/*=true*/) { return default; }
	public UObject WaitForAbilityCommit_Query(UObject OwningAbility,FGameplayTagQuery Query,bool TriggerOnce/*=true*/) { return default; }
}
