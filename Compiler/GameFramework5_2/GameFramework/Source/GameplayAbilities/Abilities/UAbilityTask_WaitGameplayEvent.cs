#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEvent.h")]
public partial class UAbilityTask_WaitGameplayEvent : UAbilityTask {
// AbilityTask_WaitGameplayEvent
	public FWaitGameplayEventDelegate EventReceived;
	public static UAbilityTask_WaitGameplayEvent WaitGameplayEvent(UGameplayAbility OwningAbility,FGameplayTag EventTag,AActor OptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/,bool OnlyMatchExact/*=true*/) { return default; }
	public UAbilitySystemComponent OptionalExternalTarget;
}
