#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene track that triggers gameplay cues</summary>
[CppInclude("Sequencer/MovieSceneGameplayCueTrack.h")]
public partial class UMovieSceneGameplayCueTrack : UMovieSceneNameableTrack {
	///<summary>Override the default function for invoking Gameplay Cues from sequencer tracks</summary>
	public static void SetSequencerTrackHandler(FMovieSceneGameplayCueEvent InGameplayCueTrackHandler) {}
	///<summary>The track&#39;s sections.</summary>
	public TArray<UMovieSceneSection> Sections;
}
