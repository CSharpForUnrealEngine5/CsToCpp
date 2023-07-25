#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCurveTypes.h")]
///<summary>Raw Curve data for serialization</summary>
public partial struct FRawCurveTracks {
// RawCurveTracks
	public TArray<FFloatCurve> FloatCurves;
	public TArray<FVectorCurve> VectorCurves;
	public TArray<FTransformCurve> TransformCurves;
}
