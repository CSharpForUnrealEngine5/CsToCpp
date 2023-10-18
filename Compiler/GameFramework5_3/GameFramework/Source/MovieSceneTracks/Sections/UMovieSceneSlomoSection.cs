namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single floating point section.</summary>
[CppInclude("Sections/MovieSceneSlomoSection.h")]
public partial class UMovieSceneSlomoSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Float data</summary>
	public FMovieSceneFloatChannel FloatCurve;
}
