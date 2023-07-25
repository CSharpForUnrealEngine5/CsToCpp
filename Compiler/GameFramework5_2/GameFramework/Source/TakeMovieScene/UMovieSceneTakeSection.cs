#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneTakeSection.h")]
///<summary>A section in a Take track</summary>
public partial class UMovieSceneTakeSection : UMovieSceneSection {
// MovieSceneTakeSection
	public FMovieSceneIntegerChannel HoursCurve;
	public FMovieSceneIntegerChannel MinutesCurve;
	public FMovieSceneIntegerChannel SecondsCurve;
	public FMovieSceneIntegerChannel FramesCurve;
	public FMovieSceneFloatChannel SubFramesCurve;
	public FMovieSceneStringChannel Slate;
}
