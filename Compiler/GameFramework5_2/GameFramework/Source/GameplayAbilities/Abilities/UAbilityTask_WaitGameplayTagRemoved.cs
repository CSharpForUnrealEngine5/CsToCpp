#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayTag.h")]
public partial class UAbilityTask_WaitGameplayTagRemoved : UAbilityTask_WaitGameplayTag {
// AbilityTask_WaitGameplayTagRemoved
	public FWaitGameplayTagDelegate Removed;
	public static UAbilityTask_WaitGameplayTagRemoved WaitGameplayTagRemove(UGameplayAbility OwningAbility,FGameplayTag Tag,AActor InOptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/) { return default; }
}
