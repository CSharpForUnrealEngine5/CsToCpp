#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChangeRatioThreshold.h")]
///<summary>Waits for the ratio between two attributes to match a threshold</summary>
public partial class UAbilityTask_WaitAttributeChangeRatioThreshold : UAbilityTask {
// AbilityTask_WaitAttributeChangeRatioThreshold
	public FWaitAttributeChangeRatioThresholdDelegate OnChange;
	public UObject WaitForAttributeChangeRatioThreshold(UObject OwningAbility,FGameplayAttribute AttributeNumerator,FGameplayAttribute AttributeDenominator,byte ComparisonType,float ComparisonValue,bool bTriggerOnce,UObject OptionalExternalOwner/*=nullptr*/) { return default; }
	public UAbilitySystemComponent ExternalOwner;
}
