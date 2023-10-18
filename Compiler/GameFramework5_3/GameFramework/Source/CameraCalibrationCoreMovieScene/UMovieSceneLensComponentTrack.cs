namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie Scene track for Lens Component</summary>
[CppInclude("MovieSceneLensComponentTrack.h")]
public partial class UMovieSceneLensComponentTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Array of movie scene sections managed by this track</summary>
	public TArray<UMovieSceneSection> Sections;
}
