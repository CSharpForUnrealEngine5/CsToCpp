#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/MovieSceneMarginSection.h")]
///<summary>A section in a Margin track</summary>
public partial class UMovieSceneMarginSection : UMovieSceneSection {
// MovieSceneMarginSection
	public FMovieSceneFloatChannel TopCurve;
	public FMovieSceneFloatChannel LeftCurve;
	public FMovieSceneFloatChannel RightCurve;
	public FMovieSceneFloatChannel BottomCurve;
}
