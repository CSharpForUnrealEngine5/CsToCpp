namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single floating point section</summary>
[CppInclude("Sections/MovieSceneColorSection.h")]
public partial class UMovieSceneColorSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Red curve data</summary>
	public FMovieSceneFloatChannel RedCurve;
	///<summary>Green curve data</summary>
	public FMovieSceneFloatChannel GreenCurve;
	///<summary>Blue curve data</summary>
	public FMovieSceneFloatChannel BlueCurve;
	///<summary>Alpha curve data</summary>
	public FMovieSceneFloatChannel AlphaCurve;
}
