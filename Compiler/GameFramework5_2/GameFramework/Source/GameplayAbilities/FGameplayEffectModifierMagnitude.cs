#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct representing the magnitude of a gameplay effect modifier, potentially calculated in numerous different ways</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectModifierMagnitude {
	public EGameplayEffectMagnitudeCalculation MagnitudeCalculationType;
	public FScalableFloat ScalableFloatMagnitude;
	public FAttributeBasedFloat AttributeBasedMagnitude;
	public FCustomCalculationBasedFloat CustomMagnitude;
	public FSetByCallerFloat SetByCallerMagnitude;
}
