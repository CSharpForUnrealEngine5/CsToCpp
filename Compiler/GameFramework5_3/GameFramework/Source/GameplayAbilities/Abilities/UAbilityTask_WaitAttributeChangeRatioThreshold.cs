namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits for the ratio between two attributes to match a threshold</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChangeRatioThreshold.h")]
public partial class UAbilityTask_WaitAttributeChangeRatioThreshold : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnChange</summary>
	public FWaitAttributeChangeRatioThresholdDelegate OnChange;
	///<summary>Wait on attribute ratio change meeting a comparison threshold.</summary>
	public static UAbilityTask_WaitAttributeChangeRatioThreshold WaitForAttributeChangeRatioThreshold(UGameplayAbility OwningAbility,FGameplayAttribute AttributeNumerator,FGameplayAttribute AttributeDenominator,EWaitAttributeChangeComparison ComparisonType,float ComparisonValue,bool bTriggerOnce,AActor OptionalExternalOwner/*=nullptr*/) { return default; }
	///<summary>ExternalOwner</summary>
	public UAbilitySystemComponent ExternalOwner;
}
