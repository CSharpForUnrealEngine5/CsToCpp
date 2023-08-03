#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An ability state is simply an ability task that provides a way to handle the ability being interrupted.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_StartAbilityState.h")]
public partial class UAbilityTask_StartAbilityState : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>Invoked if &#39;EndAbilityState&#39; is called or if &#39;EndAbility&#39; is called and this state is active.</summary>
	public FAbilityStateDelegate OnStateEnded;
	///<summary>Invoked if the ability was interrupted and this state is active.</summary>
	public FAbilityStateDelegate OnStateInterrupted;
	///<summary>Starts a new ability state.</summary>
	public static UAbilityTask_StartAbilityState StartAbilityState(UGameplayAbility OwningAbility,string StateName,bool bEndCurrentState/*=true*/) { return default; }
}
