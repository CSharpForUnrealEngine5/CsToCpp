namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure representing an animated scalar parameter and it&#39;s associated animation curve.</summary>
[CppInclude("Sections/MovieSceneParameterSection.h")]
public partial struct FScalarParameterNameAndCurve {
	public string ParameterName;
	public FMovieSceneFloatChannel ParameterCurve;
}
