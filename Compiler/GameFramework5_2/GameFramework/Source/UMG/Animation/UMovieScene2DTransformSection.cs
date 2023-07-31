#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A transform section</summary>
[CppInclude("Animation/MovieScene2DTransformSection.h")]
public partial class UMovieScene2DTransformSection : UMovieSceneSection {
	///<summary>TransformMask</summary>
	public FMovieScene2DTransformMask TransformMask;
	///<summary>Translation curves</summary>
	public FMovieSceneFloatChannel Translation;
	///<summary>Rotation curve</summary>
	public FMovieSceneFloatChannel Rotation;
	///<summary>Scale curves</summary>
	public FMovieSceneFloatChannel Scale;
	///<summary>Shear curve</summary>
	public FMovieSceneFloatChannel Shear;
}
