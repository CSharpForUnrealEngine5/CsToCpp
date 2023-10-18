namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles when a spawnable should be spawned and destroyed</summary>
[CppInclude("Tracks/MovieSceneSpawnTrack.h")]
public partial class UMovieSceneSpawnTrack : UMovieSceneTrack {
	public static UClass StaticClass() {return default;}
	///<summary>All the sections in this track</summary>
	public TArray<UMovieSceneSection> Sections;
	///<summary>The guid relating to the object we are to spawn and destroy</summary>
	public FGuid ObjectGuid;
}
