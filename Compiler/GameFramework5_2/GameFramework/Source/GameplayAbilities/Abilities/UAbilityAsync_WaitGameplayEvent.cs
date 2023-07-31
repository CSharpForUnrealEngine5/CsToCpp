#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayEvent.h")]
public partial class UAbilityAsync_WaitGameplayEvent : UAbilityAsync {
	///<summary>Wait until the specified gameplay tag event is triggered on a target ability system component</summary>
	public static UAbilityAsync_WaitGameplayEvent WaitGameplayEventToActor(AActor TargetActor,FGameplayTag EventTag,bool OnlyTriggerOnce/*=false*/,bool OnlyMatchExact/*=true*/) { return default; }
	///<summary>FEventReceivedDelegate</summary>
	public  void FEventReceivedDelegate(FGameplayEventData Payload) {}
	///<summary>EventReceived</summary>
	public FEventReceivedDelegate EventReceived;
}
