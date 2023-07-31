#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie Scene track for Lens Component</summary>
[CppInclude("MovieSceneLensComponentTrack.h")]
public partial class UMovieSceneLensComponentTrack : UMovieSceneNameableTrack {
	///<summary>Array of movie scene sections managed by this track</summary>
	public TArray<UMovieSceneSection> Sections;
}
