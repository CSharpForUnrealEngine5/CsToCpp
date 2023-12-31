namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tangents for curve channel control points.</summary>
[CppInclude("Channels/MovieSceneCurveChannelCommon.h")]
public partial struct FMovieSceneTangentData {
	public float ArriveTangent;
	public float LeaveTangent;
	public float ArriveTangentWeight;
	public float LeaveTangentWeight;
	public ERichCurveTangentWeightMode TangentWeightMode;
}
