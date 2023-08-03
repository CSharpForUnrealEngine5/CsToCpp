#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of takes in a movie scene</summary>
[CppInclude("MovieSceneTakeTrack.h")]
public partial class UMovieSceneTakeTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>The track&#39;s sections.</summary>
	public TArray<UMovieSceneSection> Sections;
}
