#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Track for setting (and restoring) Console Variables during playback.</summary>
[CppInclude("Tracks/MovieSceneCVarTrack.h")]
public partial class UMovieSceneCVarTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>All movie scene sections.</summary>
	public TArray<UMovieSceneSection> Sections;
}
