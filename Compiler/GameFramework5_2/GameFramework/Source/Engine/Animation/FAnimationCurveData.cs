#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
///<summary>Structure encapsulating animated curve data. Currently only contains Float and Transform curves.</summary>
public partial struct FAnimationCurveData {
// AnimationCurveData
	public TArray<FFloatCurve> FloatCurves;
	public TArray<FTransformCurve> TransformCurves;
}
