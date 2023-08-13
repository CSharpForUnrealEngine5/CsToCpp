namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct representing a float whose magnitude is dictated by a backing attribute and a calculation policy, follows basic form of:</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FAttributeBasedFloat {
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
