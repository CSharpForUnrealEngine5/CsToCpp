#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_Repeat.h")]
///<summary>Repeat a task a certain number of times at a given interval.</summary>
public partial class UAbilityTask_Repeat : UAbilityTask {
// AbilityTask_Repeat
	public FRepeatedActionDelegate OnPerformAction;
	public FRepeatedActionDelegate OnFinished;
	public UObject RepeatAction(UObject OwningAbility,float TimeBetweenActions,int TotalActionCount) { return default; }
}
