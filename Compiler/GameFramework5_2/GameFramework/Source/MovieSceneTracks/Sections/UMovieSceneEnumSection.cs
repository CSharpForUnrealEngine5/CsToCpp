namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single enum section.</summary>
[CppInclude("Sections/MovieSceneEnumSection.h")]
public partial class UMovieSceneEnumSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Ordered curve data</summary>
	public FMovieSceneByteChannel EnumCurve;
}
