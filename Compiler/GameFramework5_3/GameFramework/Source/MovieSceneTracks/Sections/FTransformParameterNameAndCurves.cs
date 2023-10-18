namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure representing an animated transform parameter and it&#39;s associated animation curve.</summary>
[CppInclude("Sections/MovieSceneParameterSection.h")]
public partial struct FTransformParameterNameAndCurves {
	public FName ParameterName;
	public FMovieSceneFloatChannel Translation;
	public FMovieSceneFloatChannel Rotation;
	public FMovieSceneFloatChannel Scale;
}
