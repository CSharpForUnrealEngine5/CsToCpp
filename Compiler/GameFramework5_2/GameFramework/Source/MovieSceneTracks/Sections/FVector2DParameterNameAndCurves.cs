namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure representing an animated vector2D parameter and it&#39;s associated animation curve.</summary>
[CppInclude("Sections/MovieSceneParameterSection.h")]
public partial struct FVector2DParameterNameAndCurves {
	public string ParameterName;
	public FMovieSceneFloatChannel XCurve;
	public FMovieSceneFloatChannel YCurve;
}
