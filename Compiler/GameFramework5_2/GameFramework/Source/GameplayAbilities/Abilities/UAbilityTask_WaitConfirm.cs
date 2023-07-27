#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitConfirm.h")]
public partial class UAbilityTask_WaitConfirm : UAbilityTask {
// AbilityTask_WaitConfirm
	public FGenericGameplayTaskDelegate OnConfirm;
	public  void OnConfirmCallback(UGameplayAbility InAbility) {}
	public static UAbilityTask_WaitConfirm WaitConfirm(UGameplayAbility OwningAbility) { return default; }
}
