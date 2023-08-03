#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits for the actor to activate another ability</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChange.h")]
public partial class UAbilityTask_WaitAttributeChange : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnChange</summary>
	public FWaitAttributeChangeDelegate OnChange;
	///<summary>Wait until an attribute changes.</summary>
	public static UAbilityTask_WaitAttributeChange WaitForAttributeChange(UGameplayAbility OwningAbility,FGameplayAttribute Attribute,FGameplayTag WithSrcTag,FGameplayTag WithoutSrcTag,bool TriggerOnce/*=true*/,AActor OptionalExternalOwner/*=nullptr*/) { return default; }
	///<summary>Wait until an attribute changes to pass a given test.</summary>
	public static UAbilityTask_WaitAttributeChange WaitForAttributeChangeWithComparison(UGameplayAbility OwningAbility,FGameplayAttribute InAttribute,FGameplayTag InWithTag,FGameplayTag InWithoutTag,EWaitAttributeChangeComparison InComparisonType,float InComparisonValue,bool TriggerOnce/*=true*/,AActor OptionalExternalOwner/*=nullptr*/) { return default; }
	///<summary>ExternalOwner</summary>
	public UAbilitySystemComponent ExternalOwner;
}
