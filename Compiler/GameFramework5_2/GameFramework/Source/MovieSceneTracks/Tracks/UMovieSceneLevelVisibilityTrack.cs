#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A track for controlling the visibility of streamed levels.</summary>
[CppInclude("Tracks/MovieSceneLevelVisibilityTrack.h")]
public partial class UMovieSceneLevelVisibilityTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Sections</summary>
	public TArray<UMovieSceneSection> Sections;
}
