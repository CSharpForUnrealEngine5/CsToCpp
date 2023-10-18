namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A track that holds sub-sequences within a larger sequence.</summary>
[CppInclude("Tracks/MovieSceneSubTrack.h")]
public partial class UMovieSceneSubTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>All movie scene sections.</summary>
	public TArray<UMovieSceneSection> Sections;
}
