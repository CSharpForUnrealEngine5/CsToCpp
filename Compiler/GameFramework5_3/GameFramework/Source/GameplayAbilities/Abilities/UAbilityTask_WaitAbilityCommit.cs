namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits for the actor to activate another ability</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitAbilityCommit.h")]
public partial class UAbilityTask_WaitAbilityCommit : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnCommit</summary>
	public FWaitAbilityCommitDelegate OnCommit;
	///<summary>OnAbilityCommit</summary>
	public void OnAbilityCommit(UGameplayAbility ActivatedAbility) {}
	///<summary>Wait until a new ability (of the same or different type) is commited.</summary>
	public static UAbilityTask_WaitAbilityCommit WaitForAbilityCommit(UGameplayAbility OwningAbility,FGameplayTag WithTag,FGameplayTag WithoutTage,bool TriggerOnce/*=true*/) { return default; }
	///<summary>WaitForAbilityCommit_Query</summary>
	public static UAbilityTask_WaitAbilityCommit WaitForAbilityCommit_Query(UGameplayAbility OwningAbility,FGameplayTagQuery Query,bool TriggerOnce/*=true*/) { return default; }
}
