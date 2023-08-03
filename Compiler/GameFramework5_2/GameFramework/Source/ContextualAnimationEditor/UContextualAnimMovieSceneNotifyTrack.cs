#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MovieSceneTrack used to show the notifies in the animation the track was created from in Sequencer Panel</summary>
[CppInclude("ContextualAnimMovieSceneNotifyTrack.h")]
public partial class UContextualAnimMovieSceneNotifyTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>List of sections in this track</summary>
	public TArray<UMovieSceneSection> Sections;
	///<summary>Ptr to the animation this track was created from</summary>
	public TWeakObjectPtr<UAnimSequenceBase> Animation;
}
