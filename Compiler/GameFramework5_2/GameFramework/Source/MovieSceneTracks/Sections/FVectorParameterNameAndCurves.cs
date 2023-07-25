#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneParameterSection.h")]
///<summary>Structure representing an animated vector parameter and it's associated animation curve.</summary>
public partial struct FVectorParameterNameAndCurves {
// VectorParameterNameAndCurves
	public string ParameterName;
	public FMovieSceneFloatChannel XCurve;
	public FMovieSceneFloatChannel YCurve;
	public FMovieSceneFloatChannel ZCurve;
}
