#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitInputPress.h")]
///<summary>Waits until the input is pressed from activating an ability. This should be true immediately upon starting the ability, since the key was pressed to activate it.</summary>
public partial class UAbilityTask_WaitInputPress : UAbilityTask {
// AbilityTask_WaitInputPress
	public FInputPressDelegate OnPress;
	public  void OnPressCallback() {}
	public static UAbilityTask_WaitInputPress WaitInputPress(UGameplayAbility OwningAbility,bool bTestAlreadyPressed/*=false*/) { return default; }
}
