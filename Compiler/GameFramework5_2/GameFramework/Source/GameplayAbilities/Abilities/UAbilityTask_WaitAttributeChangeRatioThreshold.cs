#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChangeRatioThreshold.h")]
///<summary>Waits for the ratio between two attributes to match a threshold</summary>
public partial class UAbilityTask_WaitAttributeChangeRatioThreshold : UAbilityTask {
// AbilityTask_WaitAttributeChangeRatioThreshold
	public FWaitAttributeChangeRatioThresholdDelegate OnChange;
	public static UAbilityTask_WaitAttributeChangeRatioThreshold WaitForAttributeChangeRatioThreshold(UGameplayAbility OwningAbility,FGameplayAttribute AttributeNumerator,FGameplayAttribute AttributeDenominator,EWaitAttributeChangeComparison ComparisonType,float ComparisonValue,bool bTriggerOnce,AActor OptionalExternalOwner/*=nullptr*/) { return default; }
	public UAbilitySystemComponent ExternalOwner;
}
