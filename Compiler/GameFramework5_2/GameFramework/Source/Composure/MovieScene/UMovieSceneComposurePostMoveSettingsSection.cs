#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A movie scene section for animating FComposurePostMoveSettings properties.</summary>
[CppInclude("MovieScene/MovieSceneComposurePostMoveSettingsSection.h")]
public partial class UMovieSceneComposurePostMoveSettingsSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>The curves for animating the pivot property.</summary>
	public FMovieSceneFloatChannel Pivot;
	///<summary>The curves for animating the translation property.</summary>
	public FMovieSceneFloatChannel Translation;
	///<summary>The curve for animating the rotation angle property.</summary>
	public FMovieSceneFloatChannel RotationAngle;
	///<summary>The curve for animating the scale property.</summary>
	public FMovieSceneFloatChannel Scale;
}
