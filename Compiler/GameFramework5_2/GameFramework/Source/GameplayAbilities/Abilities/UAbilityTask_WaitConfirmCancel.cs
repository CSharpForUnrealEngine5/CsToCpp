#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitConfirmCancel.h")]
///<summary>Fixme: this name is conflicting with AbilityTask_WaitConfirm</summary>
public partial class UAbilityTask_WaitConfirmCancel : UAbilityTask {
// AbilityTask_WaitConfirmCancel
	public FWaitConfirmCancelDelegate OnConfirm;
	public FWaitConfirmCancelDelegate OnCancel;
	public  void OnConfirmCallback() {}
	public  void OnCancelCallback() {}
	public  void OnLocalConfirmCallback() {}
	public  void OnLocalCancelCallback() {}
	public static UAbilityTask_WaitConfirmCancel WaitConfirmCancel(UGameplayAbility OwningAbility) { return default; }
}
