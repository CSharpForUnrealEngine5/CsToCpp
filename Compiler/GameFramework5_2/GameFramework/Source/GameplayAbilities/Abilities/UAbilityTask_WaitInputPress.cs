namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits until the input is pressed from activating an ability. This should be true immediately upon starting the ability, since the key was pressed to activate it.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitInputPress.h")]
public partial class UAbilityTask_WaitInputPress : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnPress</summary>
	public FInputPressDelegate OnPress;
	///<summary>OnPressCallback</summary>
	public void OnPressCallback() {}
	///<summary>Wait until the user presses the input button for this ability&#39;s activation. Returns time this node spent waiting for the press. Will return 0 if input was already down.</summary>
	public static UAbilityTask_WaitInputPress WaitInputPress(UGameplayAbility OwningAbility,bool bTestAlreadyPressed/*=false*/) { return default; }
}
