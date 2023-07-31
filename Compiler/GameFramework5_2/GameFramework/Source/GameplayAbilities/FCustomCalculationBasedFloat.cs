#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure to encapsulate magnitudes that are calculated via custom calculation</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FCustomCalculationBasedFloat {
	public UClass CalculationClassMagnitude;
	public FScalableFloat Coefficient;
	public FScalableFloat PreMultiplyAdditiveValue;
	public FScalableFloat PostMultiplyAdditiveValue;
	public FCurveTableRowHandle FinalLookupCurve;
}
