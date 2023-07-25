#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/TimeStretchCurve.h")]
///<summary>= Time Stretch Curve =</summary>
public partial struct FTimeStretchCurve {
// TimeStretchCurve
	public float SamplingRate;
	public float CurveValueMinPrecision;
	public TArray<FTimeStretchCurveMarker> Markers;
	public float Sum_dT_i_by_C_i;
}
