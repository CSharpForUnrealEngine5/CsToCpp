namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single byte section.</summary>
[CppInclude("Sections/MovieSceneByteSection.h")]
public partial class UMovieSceneByteSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Ordered curve data</summary>
	public FMovieSceneByteChannel ByteCurve;
}
