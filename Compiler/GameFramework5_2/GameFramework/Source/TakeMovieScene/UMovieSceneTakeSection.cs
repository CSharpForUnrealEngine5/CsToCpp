#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A section in a Take track</summary>
[CppInclude("MovieSceneTakeSection.h")]
public partial class UMovieSceneTakeSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Hours curve data</summary>
	public FMovieSceneIntegerChannel HoursCurve;
	///<summary>Minutes curve data</summary>
	public FMovieSceneIntegerChannel MinutesCurve;
	///<summary>Seconds curve data</summary>
	public FMovieSceneIntegerChannel SecondsCurve;
	///<summary>Frames curve data</summary>
	public FMovieSceneIntegerChannel FramesCurve;
	///<summary>Subframes curve data</summary>
	public FMovieSceneFloatChannel SubFramesCurve;
	///<summary>Slate data</summary>
	public FMovieSceneStringChannel Slate;
}
