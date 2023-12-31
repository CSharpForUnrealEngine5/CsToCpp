namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Key frame curve data for one track</summary>
[CppInclude("Animation/AnimSequence.h")]
public partial struct FCurveTrack {
	public FName CurveName;
	public TArray<float> CurveWeights;
}
