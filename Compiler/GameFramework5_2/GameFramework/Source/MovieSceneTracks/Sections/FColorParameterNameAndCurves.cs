#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneParameterSection.h")]
///<summary>Structure representing an animated color parameter and it's associated animation curve.</summary>
public partial struct FColorParameterNameAndCurves {
// ColorParameterNameAndCurves
	public string ParameterName;
	public FMovieSceneFloatChannel RedCurve;
	public FMovieSceneFloatChannel GreenCurve;
	public FMovieSceneFloatChannel BlueCurve;
	public FMovieSceneFloatChannel AlphaCurve;
}
