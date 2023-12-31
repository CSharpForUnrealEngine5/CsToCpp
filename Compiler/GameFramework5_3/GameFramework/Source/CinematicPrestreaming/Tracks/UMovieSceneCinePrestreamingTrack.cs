namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A track that controls playback of streaming triggers for some rendering systems.</summary>
[CppInclude("Tracks/MovieSceneCinePrestreamingTrack.h")]
public partial class UMovieSceneCinePrestreamingTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Sections</summary>
	public TArray<UMovieSceneSection> Sections;
}
