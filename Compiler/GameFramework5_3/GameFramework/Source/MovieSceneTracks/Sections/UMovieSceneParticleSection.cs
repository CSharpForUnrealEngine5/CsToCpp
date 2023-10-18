namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Particle section, for particle toggling and triggering.</summary>
[CppInclude("Sections/MovieSceneParticleSection.h")]
public partial class UMovieSceneParticleSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Curve containing the particle keys.</summary>
	public FMovieSceneParticleChannel ParticleKeys;
}
