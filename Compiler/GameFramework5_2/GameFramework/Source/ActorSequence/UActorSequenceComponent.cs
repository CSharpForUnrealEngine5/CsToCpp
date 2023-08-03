#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene animation embedded within an actor.</summary>
[CppInclude("ActorSequenceComponent.h")]
public partial class UActorSequenceComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Calls the Play function on the SequencePlayer if its valid.</summary>
	public  void PlaySequence() {}
	///<summary>Calls the Pause function on the SequencePlayer if its valid.</summary>
	public  void PauseSequence() {}
	///<summary>Calls the Stop function on the SequencePlayer if its valid.</summary>
	public  void StopSequence() {}
	///<summary>PlaybackSettings</summary>
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	///<summary>Embedded actor sequence data</summary>
	public UActorSequence Sequence;
	///<summary>SequencePlayer</summary>
	public UActorSequencePlayer SequencePlayer;
}
