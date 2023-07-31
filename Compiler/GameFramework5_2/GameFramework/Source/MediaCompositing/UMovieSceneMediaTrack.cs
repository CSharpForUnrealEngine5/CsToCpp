#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene track for media playback.</summary>
[CppInclude("MovieSceneMediaTrack.h")]
public partial class UMovieSceneMediaTrack : UMovieSceneNameableTrack {
	///<summary>List of all media sections.</summary>
	public TArray<UMovieSceneSection> MediaSections;
}
