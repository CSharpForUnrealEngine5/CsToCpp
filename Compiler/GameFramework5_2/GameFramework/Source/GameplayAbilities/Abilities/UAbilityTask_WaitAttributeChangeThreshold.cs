#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChangeThreshold.h")]
///<summary>Waits for an attribute to match a threshold</summary>
public partial class UAbilityTask_WaitAttributeChangeThreshold : UAbilityTask {
// AbilityTask_WaitAttributeChangeThreshold
	public FWaitAttributeChangeThresholdDelegate OnChange;
	public static UAbilityTask_WaitAttributeChangeThreshold WaitForAttributeChangeThreshold(UGameplayAbility OwningAbility,FGameplayAttribute Attribute,EWaitAttributeChangeComparison ComparisonType,float ComparisonValue,bool bTriggerOnce,AActor OptionalExternalOwner/*=nullptr*/) { return default; }
	public UAbilitySystemComponent ExternalOwner;
}
