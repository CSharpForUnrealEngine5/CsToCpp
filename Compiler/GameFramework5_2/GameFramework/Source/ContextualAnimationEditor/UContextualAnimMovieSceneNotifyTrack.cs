#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimMovieSceneNotifyTrack.h")]
///<summary>MovieSceneTrack used to show the notifies in the animation the track was created from in Sequencer Panel</summary>
public partial class UContextualAnimMovieSceneNotifyTrack : UMovieSceneNameableTrack {
// ContextualAnimMovieSceneNotifyTrack
	public TArray<UMovieSceneSection> Sections;
	public TWeakObjectPtr<UAnimSequenceBase> Animation;
}
