#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEvent.h")]
public partial class UAbilityTask_WaitGameplayEvent : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>EventReceived</summary>
	public FWaitGameplayEventDelegate EventReceived;
	///<summary>Wait until the specified gameplay tag event is triggered. By default this will look at the owner of this ability. OptionalExternalTarget can be set to make this look at another actor&#39;s tags for changes</summary>
	public static UAbilityTask_WaitGameplayEvent WaitGameplayEvent(UGameplayAbility OwningAbility,FGameplayTag EventTag,AActor OptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/,bool OnlyMatchExact/*=true*/) { return default; }
	///<summary>OptionalExternalTarget</summary>
	public UAbilitySystemComponent OptionalExternalTarget;
}
