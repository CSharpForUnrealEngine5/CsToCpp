#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayTag.h")]
public partial class UAbilityTask_WaitGameplayTagAdded : UAbilityTask_WaitGameplayTag {
// AbilityTask_WaitGameplayTagAdded
	public FWaitGameplayTagDelegate Added;
	public static UAbilityTask_WaitGameplayTagAdded WaitGameplayTagAdd(UGameplayAbility OwningAbility,FGameplayTag Tag,AActor InOptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/) { return default; }
}
