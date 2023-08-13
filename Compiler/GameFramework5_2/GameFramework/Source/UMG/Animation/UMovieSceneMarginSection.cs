namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A section in a Margin track</summary>
[CppInclude("Animation/MovieSceneMarginSection.h")]
public partial class UMovieSceneMarginSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Red curve data</summary>
	public FMovieSceneFloatChannel TopCurve;
	///<summary>Green curve data</summary>
	public FMovieSceneFloatChannel LeftCurve;
	///<summary>Blue curve data</summary>
	public FMovieSceneFloatChannel RightCurve;
	///<summary>Alpha curve data</summary>
	public FMovieSceneFloatChannel BottomCurve;
}
