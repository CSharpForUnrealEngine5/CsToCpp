#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure encapsulating animated curve data. Currently only contains Float and Transform curves.</summary>
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
public partial struct FAnimationCurveData {
	public TArray<FFloatCurve> FloatCurves;
	public TArray<FTransformCurve> TransformCurves;
}
