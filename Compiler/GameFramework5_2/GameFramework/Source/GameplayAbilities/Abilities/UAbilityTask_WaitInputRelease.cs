namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits until the input is released from activating an ability. Clients will replicate a &#39;release input&#39; event to the server, but not the exact time it was held locally.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitInputRelease.h")]
public partial class UAbilityTask_WaitInputRelease : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnRelease</summary>
	public FInputReleaseDelegate OnRelease;
	///<summary>OnReleaseCallback</summary>
	public void OnReleaseCallback() {}
	///<summary>Wait until the user releases the input button for this ability&#39;s activation. Returns time from hitting this node, till release. Will return 0 if input was already released.</summary>
	public static UAbilityTask_WaitInputRelease WaitInputRelease(UGameplayAbility OwningAbility,bool bTestAlreadyReleased/*=false*/) { return default; }
}
