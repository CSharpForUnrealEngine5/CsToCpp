namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure representing an animated vector parameter and it&#39;s associated animation curve.</summary>
[CppInclude("Sections/MovieSceneParameterSection.h")]
public partial struct FVectorParameterNameAndCurves {
	public string ParameterName;
	public FMovieSceneFloatChannel XCurve;
	public FMovieSceneFloatChannel YCurve;
	public FMovieSceneFloatChannel ZCurve;
}
