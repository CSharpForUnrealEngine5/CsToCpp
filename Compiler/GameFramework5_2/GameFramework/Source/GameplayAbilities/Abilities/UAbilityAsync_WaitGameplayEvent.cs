#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayEvent.h")]
public partial class UAbilityAsync_WaitGameplayEvent : UAbilityAsync {
// AbilityAsync_WaitGameplayEvent
	public UObject WaitGameplayEventToActor(UObject TargetActor,FGameplayTag EventTag,bool OnlyTriggerOnce/*=false*/,bool OnlyMatchExact/*=true*/) { return default; }
	public void FEventReceivedDelegate(FGameplayEventData Payload) {}
	public FEventReceivedDelegate EventReceived;
}
