namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fixme: this name is conflicting with AbilityTask_WaitConfirm</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitConfirmCancel.h")]
public partial class UAbilityTask_WaitConfirmCancel : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnConfirm</summary>
	public FWaitConfirmCancelDelegate OnConfirm;
	///<summary>OnCancel</summary>
	public FWaitConfirmCancelDelegate OnCancel;
	///<summary>OnConfirmCallback</summary>
	public void OnConfirmCallback() {}
	///<summary>OnCancelCallback</summary>
	public void OnCancelCallback() {}
	///<summary>OnLocalConfirmCallback</summary>
	public void OnLocalConfirmCallback() {}
	///<summary>OnLocalCancelCallback</summary>
	public void OnLocalCancelCallback() {}
	///<summary>WaitConfirmCancel</summary>
	public static UAbilityTask_WaitConfirmCancel WaitConfirmCancel(UGameplayAbility OwningAbility) { return default; }
}
