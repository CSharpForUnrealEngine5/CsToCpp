namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectApplied.h")]
public partial class UAbilityTask_WaitGameplayEffectApplied : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnApplyGameplayEffectCallback</summary>
	public void OnApplyGameplayEffectCallback(UAbilitySystemComponent Target,FGameplayEffectSpec SpecApplied,FActiveGameplayEffectHandle ActiveHandle) {}
	///<summary>ExternalOwner</summary>
	public UAbilitySystemComponent ExternalOwner;
}
