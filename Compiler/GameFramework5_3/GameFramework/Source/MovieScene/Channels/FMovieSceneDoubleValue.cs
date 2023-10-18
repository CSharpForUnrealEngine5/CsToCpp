namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneDoubleChannel.h")]
public partial struct FMovieSceneDoubleValue {
	public double Value;
	public FMovieSceneTangentData Tangent;
	public ERichCurveInterpMode InterpMode;
	public ERichCurveTangentMode TangentMode;
	public byte PaddingByte;
}
