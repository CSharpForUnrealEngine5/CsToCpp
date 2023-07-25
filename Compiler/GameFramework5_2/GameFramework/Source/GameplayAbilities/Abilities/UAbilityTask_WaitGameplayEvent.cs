#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEvent.h")]
public partial class UAbilityTask_WaitGameplayEvent : UAbilityTask {
// AbilityTask_WaitGameplayEvent
	public FWaitGameplayEventDelegate EventReceived;
	public UObject WaitGameplayEvent(UObject OwningAbility,FGameplayTag EventTag,UObject OptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/,bool OnlyMatchExact/*=true*/) { return default; }
	public UAbilitySystemComponent OptionalExternalTarget;
}
