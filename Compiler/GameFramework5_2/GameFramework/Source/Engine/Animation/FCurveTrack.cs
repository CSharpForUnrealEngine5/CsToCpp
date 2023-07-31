#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Key frame curve data for one track</summary>
[CppInclude("Animation/AnimSequence.h")]
public partial struct FCurveTrack {
	public string CurveName;
	public TArray<float> CurveWeights;
}
