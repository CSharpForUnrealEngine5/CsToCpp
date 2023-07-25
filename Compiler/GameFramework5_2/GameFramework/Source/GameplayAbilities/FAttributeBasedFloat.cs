#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Struct representing a float whose magnitude is dictated by a backing attribute and a calculation policy, follows basic form of:</summary>
public partial struct FAttributeBasedFloat {
// AttributeBasedFloat
	public FScalableFloat Coefficient;
	public FScalableFloat PreMultiplyAdditiveValue;
	public FScalableFloat PostMultiplyAdditiveValue;
	public FGameplayEffectAttributeCaptureDefinition BackingAttribute;
	public FCurveTableRowHandle AttributeCurve;
	public EAttributeBasedFloatCalculationType AttributeCalculationType;
	public EGameplayModEvaluationChannel FinalChannel;
	public FGameplayTagContainer SourceTagFilter;
	public FGameplayTagContainer TargetTagFilter;
}
