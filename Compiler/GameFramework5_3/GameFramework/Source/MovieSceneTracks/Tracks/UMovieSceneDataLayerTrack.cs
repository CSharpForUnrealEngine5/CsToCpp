namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A track that controls loading, unloading and visibility of data layers</summary>
[CppInclude("Tracks/MovieSceneDataLayerTrack.h")]
public partial class UMovieSceneDataLayerTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Sections</summary>
	public TArray<UMovieSceneSection> Sections;
}
