namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitCancel.h")]
public partial class UAbilityTask_WaitCancel : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnCancel</summary>
	public FWaitCancelDelegate OnCancel;
	///<summary>OnCancelCallback</summary>
	public void OnCancelCallback() {}
	///<summary>OnLocalCancelCallback</summary>
	public void OnLocalCancelCallback() {}
	///<summary>WaitCancel</summary>
	public static UAbilityTask_WaitCancel WaitCancel(UGameplayAbility OwningAbility) { return default; }
}
