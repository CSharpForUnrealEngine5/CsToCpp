#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DistanceCurveModifier.h")]
///<summary>Extracts traveling distance information from root motion and bakes it to a curve.</summary>
public partial class UDistanceCurveModifier : UAnimationModifier {
// DistanceCurveModifier
	public int SampleRate;
	public string CurveName;
	public float StopSpeedThreshold;
	public EDistanceCurve_Axis Axis;
	public bool bStopAtEnd;
}
