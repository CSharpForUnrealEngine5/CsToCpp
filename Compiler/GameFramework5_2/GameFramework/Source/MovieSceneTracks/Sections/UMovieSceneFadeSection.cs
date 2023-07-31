#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single floating point section.</summary>
[CppInclude("Sections/MovieSceneFadeSection.h")]
public partial class UMovieSceneFadeSection : UMovieSceneSection {
	///<summary>Float data</summary>
	public FMovieSceneFloatChannel FloatCurve;
	///<summary>Fade color.</summary>
	public FLinearColor FadeColor;
	///<summary>Fade audio.</summary>
	public bool bFadeAudio;
}
