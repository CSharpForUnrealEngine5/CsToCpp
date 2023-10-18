namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class used to perform custom gameplay effect modifier calculations, either via blueprint or native code</summary>
[CppInclude("GameplayModMagnitudeCalculation.h")]
public partial class UGameplayModMagnitudeCalculation : UGameplayEffectCalculation {
	public static UClass StaticClass() {return default;}
	///<summary>Calculate the base magnitude of the gameplay effect modifier, given the specified spec. Note that the owning spec def can still modify this base value</summary>
	public float CalculateBaseMagnitude(FGameplayEffectSpec Spec) { return default; }
	///<summary>Whether the calculation allows non-net authorities to register the external dependency multi-cast delegate or not; Effectively</summary>
	public bool bAllowNonNetAuthorityDependencyRegistration;
	///<summary>Gets the captured magnitude value for the given Attribute</summary>
	public float K2_GetCapturedAttributeMagnitude(FGameplayEffectSpec EffectSpec,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags) { return default; }
	///<summary>Extracts the Set by Caller Magnitude from a Gameplay Effect Spec</summary>
	public float GetSetByCallerMagnitudeByTag(FGameplayEffectSpec EffectSpec,FGameplayTag Tag) { return default; }
	///<summary>Extracts the Set by Caller Magnitude from a Gameplay Effect Spec</summary>
	public float GetSetByCallerMagnitudeByName(FGameplayEffectSpec EffectSpec,FName MagnitudeName) { return default; }
	///<summary>Copies and returns the source aggregated tags from a Gameplay Effect Spec</summary>
	public FGameplayTagContainer GetSourceAggregatedTags(FGameplayEffectSpec EffectSpec) { return default; }
	///<summary>Returns the source actor tags from a Gameplay Effect Spec</summary>
	public FGameplayTagContainer GetSourceActorTags(FGameplayEffectSpec EffectSpec) { return default; }
	///<summary>Returns the source spec tags from a Gameplay Effect Spec</summary>
	public FGameplayTagContainer GetSourceSpecTags(FGameplayEffectSpec EffectSpec) { return default; }
	///<summary>Copies and returns the target aggregated tags from a Gameplay Effect Spec</summary>
	public FGameplayTagContainer GetTargetAggregatedTags(FGameplayEffectSpec EffectSpec) { return default; }
	///<summary>Returns the target actor tags from a Gameplay Effect Spec</summary>
	public FGameplayTagContainer GetTargetActorTags(FGameplayEffectSpec EffectSpec) { return default; }
	///<summary>Returns the target spec tags from a Gameplay Effect Spec</summary>
	public FGameplayTagContainer GetTargetSpecTags(FGameplayEffectSpec EffectSpec) { return default; }
}
