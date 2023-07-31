#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits for an attribute to match a threshold</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChangeThreshold.h")]
public partial class UAbilityTask_WaitAttributeChangeThreshold : UAbilityTask {
	///<summary>OnChange</summary>
	public FWaitAttributeChangeThresholdDelegate OnChange;
	///<summary>Wait on attribute change meeting a comparison threshold.</summary>
	public static UAbilityTask_WaitAttributeChangeThreshold WaitForAttributeChangeThreshold(UGameplayAbility OwningAbility,FGameplayAttribute Attribute,EWaitAttributeChangeComparison ComparisonType,float ComparisonValue,bool bTriggerOnce,AActor OptionalExternalOwner/*=nullptr*/) { return default; }
	///<summary>ExternalOwner</summary>
	public UAbilitySystemComponent ExternalOwner;
}
