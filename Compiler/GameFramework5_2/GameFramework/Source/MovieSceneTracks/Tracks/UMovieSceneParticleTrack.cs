#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles triggering of particle emitters</summary>
[CppInclude("Tracks/MovieSceneParticleTrack.h")]
public partial class UMovieSceneParticleTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>List of all particle sections.</summary>
	public TArray<UMovieSceneSection> ParticleSections;
}
