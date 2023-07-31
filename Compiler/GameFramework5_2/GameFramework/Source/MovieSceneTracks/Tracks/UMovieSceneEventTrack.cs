#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene track that triggers discrete events during playback.</summary>
[CppInclude("Tracks/MovieSceneEventTrack.h")]
public partial class UMovieSceneEventTrack : UMovieSceneNameableTrack {
	///<summary>If events should be fired when passed playing the sequence forwards.</summary>
	public bool bFireEventsWhenForwards;
	///<summary>If events should be fired when passed playing the sequence backwards.</summary>
	public bool bFireEventsWhenBackwards;
	///<summary>Defines where in the evaluation to trigger events</summary>
	public EFireEventsAtPosition EventPosition;
	///<summary>The track&#39;s sections.</summary>
	public TArray<UMovieSceneSection> Sections;
}
