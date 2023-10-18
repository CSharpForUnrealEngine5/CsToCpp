namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene animation embedded within an actor.</summary>
[CppInclude("ActorSequence.h")]
public partial class UActorSequence : UMovieSceneSequence {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to the movie scene that controls this animation.</summary>
	public UMovieScene MovieScene;
	///<summary>Collection of object references.</summary>
	public FActorSequenceObjectReferenceMap ObjectReferences;
	///<summary>bHasBeenInitialized</summary>
	public bool bHasBeenInitialized;
}
