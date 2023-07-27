#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitDelay.h")]
public partial class UAbilityTask_WaitDelay : UAbilityTask {
// AbilityTask_WaitDelay
	public FWaitDelayDelegate OnFinish;
	public static UAbilityTask_WaitDelay WaitDelay(UGameplayAbility OwningAbility,float Time) { return default; }
}
