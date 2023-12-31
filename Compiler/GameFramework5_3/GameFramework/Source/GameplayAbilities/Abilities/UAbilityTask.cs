namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask.h")]
public partial class UAbilityTask : UGameplayTask {
	public static UClass StaticClass() {return default;}
	///<summary>GameplayAbility that created us</summary>
	public UGameplayAbility Ability;
	///<summary>AbilitySystemComponent</summary>
	public TWeakObjectPtr<UAbilitySystemComponent> AbilitySystemComponent;
}
