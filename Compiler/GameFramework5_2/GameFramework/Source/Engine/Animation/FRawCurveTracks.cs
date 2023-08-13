namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Raw Curve data for serialization</summary>
[CppInclude("Animation/AnimCurveTypes.h")]
public partial struct FRawCurveTracks {
	public TArray<FFloatCurve> FloatCurves;
	public TArray<FVectorCurve> VectorCurves;
	public TArray<FTransformCurve> TransformCurves;
}
