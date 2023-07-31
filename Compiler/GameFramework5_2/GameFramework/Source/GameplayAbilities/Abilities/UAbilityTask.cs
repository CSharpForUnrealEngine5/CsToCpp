#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask.h")]
public partial class UAbilityTask : UGameplayTask {
	///<summary>GameplayAbility that created us</summary>
	public UGameplayAbility Ability;
	///<summary>AbilitySystemComponent</summary>
	public TWeakObjectPtr<UAbilitySystemComponent> AbilitySystemComponent;
}
