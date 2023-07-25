#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Structure to encapsulate magnitudes that are calculated via custom calculation</summary>
public partial struct FCustomCalculationBasedFloat {
// CustomCalculationBasedFloat
	public UClass CalculationClassMagnitude;
	public FScalableFloat Coefficient;
	public FScalableFloat PreMultiplyAdditiveValue;
	public FScalableFloat PostMultiplyAdditiveValue;
	public FCurveTableRowHandle FinalLookupCurve;
}
