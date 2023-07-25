#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tracks/MovieSceneSpawnTrack.h")]
///<summary>Handles when a spawnable should be spawned and destroyed</summary>
public partial class UMovieSceneSpawnTrack : UMovieSceneTrack {
// MovieSceneSpawnTrack
	public TArray<UMovieSceneSection> Sections;
	public FGuid ObjectGuid;
}
