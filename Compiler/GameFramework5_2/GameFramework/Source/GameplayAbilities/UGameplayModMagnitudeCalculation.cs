#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayModMagnitudeCalculation.h")]
///<summary>Class used to perform custom gameplay effect modifier calculations, either via blueprint or native code</summary>
public partial class UGameplayModMagnitudeCalculation : UGameplayEffectCalculation {
// GameplayModMagnitudeCalculation
	public float CalculateBaseMagnitude(FGameplayEffectSpec Spec) { return default; }
	public bool bAllowNonNetAuthorityDependencyRegistration;
	public float K2_GetCapturedAttributeMagnitude(FGameplayEffectSpec EffectSpec,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags) { return default; }
	public float GetSetByCallerMagnitudeByTag(FGameplayEffectSpec EffectSpec,FGameplayTag Tag) { return default; }
	public float GetSetByCallerMagnitudeByName(FGameplayEffectSpec EffectSpec,string MagnitudeName) { return default; }
	public FGameplayTagContainer GetSourceAggregatedTags(FGameplayEffectSpec EffectSpec) { return default; }
	public FGameplayTagContainer GetSourceActorTags(FGameplayEffectSpec EffectSpec) { return default; }
	public FGameplayTagContainer GetSourceSpecTags(FGameplayEffectSpec EffectSpec) { return default; }
	public FGameplayTagContainer GetTargetAggregatedTags(FGameplayEffectSpec EffectSpec) { return default; }
	public FGameplayTagContainer GetTargetActorTags(FGameplayEffectSpec EffectSpec) { return default; }
	public FGameplayTagContainer GetTargetSpecTags(FGameplayEffectSpec EffectSpec) { return default; }
}
