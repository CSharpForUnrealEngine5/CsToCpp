#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorSequenceComponent.h")]
///<summary>Movie scene animation embedded within an actor.</summary>
public partial class UActorSequenceComponent : UActorComponent {
// ActorSequenceComponent
	public void PlaySequence() {}
	public void PauseSequence() {}
	public void StopSequence() {}
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	public UActorSequence Sequence;
	public UActorSequencePlayer SequencePlayer;
}
