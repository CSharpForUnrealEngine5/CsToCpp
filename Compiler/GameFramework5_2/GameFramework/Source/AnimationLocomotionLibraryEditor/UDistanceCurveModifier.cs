#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extracts traveling distance information from root motion and bakes it to a curve.</summary>
[CppInclude("DistanceCurveModifier.h")]
public partial class UDistanceCurveModifier : UAnimationModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Rate used to sample the animation.</summary>
	public int SampleRate;
	///<summary>Name for the generated curve.</summary>
	public string CurveName;
	///<summary>Root motion speed must be below this threshold to be considered stopped.</summary>
	public float StopSpeedThreshold;
	///<summary>Axes to calculate the distance value from.</summary>
	public EDistanceCurve_Axis Axis;
	///<summary>Root motion is considered to be stopped at the clip&#39;s end</summary>
	public bool bStopAtEnd;
}
