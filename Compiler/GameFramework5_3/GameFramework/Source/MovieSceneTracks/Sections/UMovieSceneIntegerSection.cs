namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single integer section.</summary>
[CppInclude("Sections/MovieSceneIntegerSection.h")]
public partial class UMovieSceneIntegerSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Ordered curve data</summary>
	public FMovieSceneIntegerChannel IntegerCurve;
}
