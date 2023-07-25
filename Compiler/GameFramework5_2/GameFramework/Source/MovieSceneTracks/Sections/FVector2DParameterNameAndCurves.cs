#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneParameterSection.h")]
///<summary>Structure representing an animated vector2D parameter and it's associated animation curve.</summary>
public partial struct FVector2DParameterNameAndCurves {
// Vector2DParameterNameAndCurves
	public string ParameterName;
	public FMovieSceneFloatChannel XCurve;
	public FMovieSceneFloatChannel YCurve;
}
