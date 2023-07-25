#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tracks/MovieSceneEventTrack.h")]
///<summary>Implements a movie scene track that triggers discrete events during playback.</summary>
public partial class UMovieSceneEventTrack : UMovieSceneNameableTrack {
// MovieSceneEventTrack
	public bool bFireEventsWhenForwards;
	public bool bFireEventsWhenBackwards;
	public EFireEventsAtPosition EventPosition;
	public TArray<UMovieSceneSection> Sections;
}
