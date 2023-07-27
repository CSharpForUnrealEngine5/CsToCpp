#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitCancel.h")]
public partial class UAbilityTask_WaitCancel : UAbilityTask {
// AbilityTask_WaitCancel
	public FWaitCancelDelegate OnCancel;
	public  void OnCancelCallback() {}
	public  void OnLocalCancelCallback() {}
	public static UAbilityTask_WaitCancel WaitCancel(UGameplayAbility OwningAbility) { return default; }
}
