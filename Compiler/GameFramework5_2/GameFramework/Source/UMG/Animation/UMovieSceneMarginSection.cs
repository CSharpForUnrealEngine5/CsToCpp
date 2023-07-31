#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A section in a Margin track</summary>
[CppInclude("Animation/MovieSceneMarginSection.h")]
public partial class UMovieSceneMarginSection : UMovieSceneSection {
	///<summary>Red curve data</summary>
	public FMovieSceneFloatChannel TopCurve;
	///<summary>Green curve data</summary>
	public FMovieSceneFloatChannel LeftCurve;
	///<summary>Blue curve data</summary>
	public FMovieSceneFloatChannel RightCurve;
	///<summary>Alpha curve data</summary>
	public FMovieSceneFloatChannel BottomCurve;
}
