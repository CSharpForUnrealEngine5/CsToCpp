#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie Scene track for LiveLink Camera Controller properties</summary>
[CppInclude("MovieSceneLiveLinkCameraControllerTrack.h")]
public partial class UMovieSceneLiveLinkCameraControllerTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Array of movie scene sections managed by this track</summary>
	public TArray<UMovieSceneSection> Sections;
}
