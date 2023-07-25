#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneParameterSection.h")]
///<summary>Structure representing an animated transform parameter and it's associated animation curve.</summary>
public partial struct FTransformParameterNameAndCurves {
// TransformParameterNameAndCurves
	public string ParameterName;
	public FMovieSceneFloatChannel Translation;
	public FMovieSceneFloatChannel Rotation;
	public FMovieSceneFloatChannel Scale;
}
