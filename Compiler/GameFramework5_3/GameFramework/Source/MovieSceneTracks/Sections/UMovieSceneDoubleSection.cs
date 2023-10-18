namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A double precision floating point section</summary>
[CppInclude("Sections/MovieSceneDoubleSection.h")]
public partial class UMovieSceneDoubleSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Double data</summary>
	public FMovieSceneDoubleChannel DoubleCurve;
}
