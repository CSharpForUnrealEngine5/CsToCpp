namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single string section</summary>
[CppInclude("Sections/MovieSceneStringSection.h")]
public partial class UMovieSceneStringSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Curve data</summary>
	public FMovieSceneStringChannel StringCurve;
}
