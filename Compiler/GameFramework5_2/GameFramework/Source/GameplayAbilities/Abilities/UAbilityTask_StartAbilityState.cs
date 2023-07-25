#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_StartAbilityState.h")]
///<summary>An ability state is simply an ability task that provides a way to handle the ability being interrupted.</summary>
public partial class UAbilityTask_StartAbilityState : UAbilityTask {
// AbilityTask_StartAbilityState
	public FAbilityStateDelegate OnStateEnded;
	public FAbilityStateDelegate OnStateInterrupted;
	public UObject StartAbilityState(UObject OwningAbility,string StateName,bool bEndCurrentState/*=true*/) { return default; }
}
