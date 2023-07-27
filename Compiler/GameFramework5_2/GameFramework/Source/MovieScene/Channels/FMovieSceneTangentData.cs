#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneCurveChannelCommon.h")]
///<summary>Tangents for curve channel control points.</summary>
public partial struct FMovieSceneTangentData {
// MovieSceneTangentData
	public float ArriveTangent;
	public float LeaveTangent;
	public float ArriveTangentWeight;
	public float LeaveTangentWeight;
	public ERichCurveTangentWeightMode TangentWeightMode;
}
