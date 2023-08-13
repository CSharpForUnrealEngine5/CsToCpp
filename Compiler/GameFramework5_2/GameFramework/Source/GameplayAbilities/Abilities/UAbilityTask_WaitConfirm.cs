namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitConfirm.h")]
public partial class UAbilityTask_WaitConfirm : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnConfirm</summary>
	public FGenericGameplayTaskDelegate OnConfirm;
	///<summary>OnConfirmCallback</summary>
	public void OnConfirmCallback(UGameplayAbility InAbility) {}
	///<summary>Wait until the server confirms the use of this ability. This is used to gate predictive portions of the ability</summary>
	public static UAbilityTask_WaitConfirm WaitConfirm(UGameplayAbility OwningAbility) { return default; }
}
