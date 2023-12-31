namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single floating point section</summary>
[CppInclude("Sections/MovieSceneFloatSection.h")]
public partial class UMovieSceneFloatSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Float data</summary>
	public FMovieSceneFloatChannel FloatCurve;
	///<summary>Channel overrides</summary>
	public UMovieSceneSectionChannelOverrideRegistry OverrideRegistry;
}
