#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Struct representing the magnitude of a gameplay effect modifier, potentially calculated in numerous different ways</summary>
public partial struct FGameplayEffectModifierMagnitude {
// GameplayEffectModifierMagnitude
	public EGameplayEffectMagnitudeCalculation MagnitudeCalculationType;
	public FScalableFloat ScalableFloatMagnitude;
	public FAttributeBasedFloat AttributeBasedMagnitude;
	public FCustomCalculationBasedFloat CustomMagnitude;
	public FSetByCallerFloat SetByCallerMagnitude;
}
