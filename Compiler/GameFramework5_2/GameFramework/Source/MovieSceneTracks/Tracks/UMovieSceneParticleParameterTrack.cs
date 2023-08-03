#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of material parameters in a movie scene.</summary>
[CppInclude("Tracks/MovieSceneParticleParameterTrack.h")]
public partial class UMovieSceneParticleParameterTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>The sections owned by this track .</summary>
	public TArray<UMovieSceneSection> Sections;
}
