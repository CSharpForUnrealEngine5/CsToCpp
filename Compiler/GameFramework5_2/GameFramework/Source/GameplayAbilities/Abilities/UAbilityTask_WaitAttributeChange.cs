#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChange.h")]
///<summary>Waits for the actor to activate another ability</summary>
public partial class UAbilityTask_WaitAttributeChange : UAbilityTask {
// AbilityTask_WaitAttributeChange
	public FWaitAttributeChangeDelegate OnChange;
	public static UAbilityTask_WaitAttributeChange WaitForAttributeChange(UGameplayAbility OwningAbility,FGameplayAttribute Attribute,FGameplayTag WithSrcTag,FGameplayTag WithoutSrcTag,bool TriggerOnce/*=true*/,AActor OptionalExternalOwner/*=nullptr*/) { return default; }
	public static UAbilityTask_WaitAttributeChange WaitForAttributeChangeWithComparison(UGameplayAbility OwningAbility,FGameplayAttribute InAttribute,FGameplayTag InWithTag,FGameplayTag InWithoutTag,byte InComparisonType,float InComparisonValue,bool TriggerOnce/*=true*/,AActor OptionalExternalOwner/*=nullptr*/) { return default; }
	public UAbilitySystemComponent ExternalOwner;
}
