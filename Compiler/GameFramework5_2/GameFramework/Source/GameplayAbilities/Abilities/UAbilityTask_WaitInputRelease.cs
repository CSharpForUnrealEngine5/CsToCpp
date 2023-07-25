#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitInputRelease.h")]
///<summary>Waits until the input is released from activating an ability. Clients will replicate a 'release input' event to the server, but not the exact time it was held locally.</summary>
public partial class UAbilityTask_WaitInputRelease : UAbilityTask {
// AbilityTask_WaitInputRelease
	public FInputReleaseDelegate OnRelease;
	public void OnReleaseCallback() {}
	public UObject WaitInputRelease(UObject OwningAbility,bool bTestAlreadyReleased/*=false*/) { return default; }
}
