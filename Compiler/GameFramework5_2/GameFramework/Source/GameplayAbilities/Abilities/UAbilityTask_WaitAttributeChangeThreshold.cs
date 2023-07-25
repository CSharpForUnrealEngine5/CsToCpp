#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAttributeChangeThreshold.h")]
///<summary>Waits for an attribute to match a threshold</summary>
public partial class UAbilityTask_WaitAttributeChangeThreshold : UAbilityTask {
// AbilityTask_WaitAttributeChangeThreshold
	public FWaitAttributeChangeThresholdDelegate OnChange;
	public UObject WaitForAttributeChangeThreshold(UObject OwningAbility,FGameplayAttribute Attribute,byte ComparisonType,float ComparisonValue,bool bTriggerOnce,UObject OptionalExternalOwner/*=nullptr*/) { return default; }
	public UAbilitySystemComponent ExternalOwner;
}
