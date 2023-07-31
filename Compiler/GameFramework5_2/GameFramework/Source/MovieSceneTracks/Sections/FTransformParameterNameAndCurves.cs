#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure representing an animated transform parameter and it&#39;s associated animation curve.</summary>
[CppInclude("Sections/MovieSceneParameterSection.h")]
public partial struct FTransformParameterNameAndCurves {
	public string ParameterName;
	public FMovieSceneFloatChannel Translation;
	public FMovieSceneFloatChannel Rotation;
	public FMovieSceneFloatChannel Scale;
}
