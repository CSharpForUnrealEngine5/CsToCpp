#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Repeat a task a certain number of times at a given interval.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_Repeat.h")]
public partial class UAbilityTask_Repeat : UAbilityTask {
	///<summary>OnPerformAction</summary>
	public FRepeatedActionDelegate OnPerformAction;
	///<summary>OnFinished</summary>
	public FRepeatedActionDelegate OnFinished;
	///<summary>Start a task that repeats an action or set of actions.</summary>
	public static UAbilityTask_Repeat RepeatAction(UGameplayAbility OwningAbility,float TimeBetweenActions,int TotalActionCount) { return default; }
}
