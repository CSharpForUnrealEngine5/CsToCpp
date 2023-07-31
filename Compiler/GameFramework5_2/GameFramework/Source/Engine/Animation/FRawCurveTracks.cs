#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Raw Curve data for serialization</summary>
[CppInclude("Animation/AnimCurveTypes.h")]
public partial struct FRawCurveTracks {
	public TArray<FFloatCurve> FloatCurves;
	public TArray<FVectorCurve> VectorCurves;
	public TArray<FTransformCurve> TransformCurves;
}
