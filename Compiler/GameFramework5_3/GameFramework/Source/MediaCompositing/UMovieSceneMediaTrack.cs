namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene track for media playback.</summary>
[CppInclude("MovieSceneMediaTrack.h")]
public partial class UMovieSceneMediaTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>List of all media sections.</summary>
	public TArray<UMovieSceneSection> MediaSections;
}
