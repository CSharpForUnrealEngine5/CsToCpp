namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single floating point section.</summary>
[CppInclude("Sections/MovieSceneFadeSection.h")]
public partial class UMovieSceneFadeSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Float data</summary>
	public FMovieSceneFloatChannel FloatCurve;
	///<summary>Fade color.</summary>
	public FLinearColor FadeColor;
	///<summary>Fade audio.</summary>
	public bool bFadeAudio;
}
