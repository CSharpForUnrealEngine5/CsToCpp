#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorSequence.h")]
///<summary>Movie scene animation embedded within an actor.</summary>
public partial class UActorSequence : UMovieSceneSequence {
// ActorSequence
	public UMovieScene MovieScene;
	public FActorSequenceObjectReferenceMap ObjectReferences;
	public bool bHasBeenInitialized;
}
