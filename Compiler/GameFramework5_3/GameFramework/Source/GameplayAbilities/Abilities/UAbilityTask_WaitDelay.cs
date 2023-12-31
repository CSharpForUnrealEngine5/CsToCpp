namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitDelay.h")]
public partial class UAbilityTask_WaitDelay : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnFinish</summary>
	public FWaitDelayDelegate OnFinish;
	///<summary>Wait specified time. This is functionally the same as a standard Delay node.</summary>
	public static UAbilityTask_WaitDelay WaitDelay(UGameplayAbility OwningAbility,float Time) { return default; }
}
