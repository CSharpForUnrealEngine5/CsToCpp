#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChange.h")]
///<summary>Waits for the actor to activate another ability</summary>
public partial class UAbilityTask_WaitAttributeChange : UAbilityTask {
// AbilityTask_WaitAttributeChange
	public FWaitAttributeChangeDelegate OnChange;
	public UObject WaitForAttributeChange(UObject OwningAbility,FGameplayAttribute Attribute,FGameplayTag WithSrcTag,FGameplayTag WithoutSrcTag,bool TriggerOnce/*=true*/,UObject OptionalExternalOwner/*=nullptr*/) { return default; }
	public UObject WaitForAttributeChangeWithComparison(UObject OwningAbility,FGameplayAttribute InAttribute,FGameplayTag InWithTag,FGameplayTag InWithoutTag,byte InComparisonType,float InComparisonValue,bool TriggerOnce/*=true*/,UObject OptionalExternalOwner/*=nullptr*/) { return default; }
	public UAbilitySystemComponent ExternalOwner;
}
