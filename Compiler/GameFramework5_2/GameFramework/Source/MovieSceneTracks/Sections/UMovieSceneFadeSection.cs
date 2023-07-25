#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneFadeSection.h")]
///<summary>A single floating point section.</summary>
public partial class UMovieSceneFadeSection : UMovieSceneSection {
// MovieSceneFadeSection
	public FMovieSceneFloatChannel FloatCurve;
	public FLinearColor FadeColor;
	public bool bFadeAudio;
}
