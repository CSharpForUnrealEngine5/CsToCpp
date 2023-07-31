#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single floating point section</summary>
[CppInclude("Sections/MovieSceneColorSection.h")]
public partial class UMovieSceneColorSection : UMovieSceneSection {
	///<summary>Red curve data</summary>
	public FMovieSceneFloatChannel RedCurve;
	///<summary>Green curve data</summary>
	public FMovieSceneFloatChannel GreenCurve;
	///<summary>Blue curve data</summary>
	public FMovieSceneFloatChannel BlueCurve;
	///<summary>Alpha curve data</summary>
	public FMovieSceneFloatChannel AlphaCurve;
}
