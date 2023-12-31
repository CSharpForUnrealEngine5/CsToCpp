namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure representing an animated color parameter and it&#39;s associated animation curve.</summary>
[CppInclude("Sections/MovieSceneParameterSection.h")]
public partial struct FColorParameterNameAndCurves {
	public FName ParameterName;
	public FMovieSceneFloatChannel RedCurve;
	public FMovieSceneFloatChannel GreenCurve;
	public FMovieSceneFloatChannel BlueCurve;
	public FMovieSceneFloatChannel AlphaCurve;
}
