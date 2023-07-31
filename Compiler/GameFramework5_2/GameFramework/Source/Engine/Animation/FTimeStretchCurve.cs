#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>= Time Stretch Curve =</summary>
[CppInclude("Animation/TimeStretchCurve.h")]
public partial struct FTimeStretchCurve {
	public float SamplingRate;
	public float CurveValueMinPrecision;
	public TArray<FTimeStretchCurveMarker> Markers;
	public float Sum_dT_i_by_C_i;
}
