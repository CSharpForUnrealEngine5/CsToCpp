#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask.h")]
public partial class UAbilityTask : UGameplayTask {
// AbilityTask
	public UGameplayAbility Ability;
	public TWeakObjectPtr<UAbilitySystemComponent> AbilitySystemComponent;
}
