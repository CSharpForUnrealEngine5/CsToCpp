#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneFloatChannel.h")]
public partial struct FMovieSceneFloatValue {
	public float Value;
	public FMovieSceneTangentData Tangent;
	public ERichCurveInterpMode InterpMode;
	public ERichCurveTangentMode TangentMode;
	public byte PaddingByte;
}
