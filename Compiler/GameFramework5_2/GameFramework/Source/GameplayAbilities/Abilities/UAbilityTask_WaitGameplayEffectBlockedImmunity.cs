#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectBlockedImmunity.h")]
public partial class UAbilityTask_WaitGameplayEffectBlockedImmunity : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>Blocked</summary>
	public FGameplayEffectBlockedDelegate Blocked;
	///<summary>Listens for GE immunity. By default this means &quot;this hero blocked a GE due to immunity&quot;. Setting OptionalExternalTarget will listen for a GE being blocked on an external target. Note this only works on the server.</summary>
	public static UAbilityTask_WaitGameplayEffectBlockedImmunity WaitGameplayEffectBlockedByImmunity(UGameplayAbility OwningAbility,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,AActor OptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/) { return default; }
	///<summary>ExternalOwner</summary>
	public UAbilitySystemComponent ExternalOwner;
}
