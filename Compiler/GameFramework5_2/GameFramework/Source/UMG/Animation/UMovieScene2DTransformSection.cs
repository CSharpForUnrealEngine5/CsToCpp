#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/MovieScene2DTransformSection.h")]
///<summary>A transform section</summary>
public partial class UMovieScene2DTransformSection : UMovieSceneSection {
// MovieScene2DTransformSection
	public FMovieScene2DTransformMask TransformMask;
	public FMovieSceneFloatChannel Translation;
	public FMovieSceneFloatChannel Rotation;
	public FMovieSceneFloatChannel Scale;
	public FMovieSceneFloatChannel Shear;
}
