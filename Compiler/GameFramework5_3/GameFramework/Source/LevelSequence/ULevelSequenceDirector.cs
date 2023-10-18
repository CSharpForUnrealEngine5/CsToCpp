namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceDirector.h")]
public partial class ULevelSequenceDirector : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when this director is created</summary>
	public void OnCreated() {}
	///<summary>Get the current time for the outermost (root) sequence</summary>
	public FQualifiedFrameTime GetRootSequenceTime() { return default; }
	///<summary>GetMasterSequenceTime</summary>
	public FQualifiedFrameTime GetMasterSequenceTime() { return default; }
	///<summary>Get the current time for this director&#39;s sub-sequence (or the root sequence, if this is a root sequence director)</summary>
	public FQualifiedFrameTime GetCurrentTime() { return default; }
	///<summary>Resolve the bindings inside this sub-sequence that relate to the specified ID</summary>
	public TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	///<summary>Resolve the first valid binding inside this sub-sequence that relates to the specified ID</summary>
	public UObject GetBoundObject(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	///<summary>Resolve the actor bindings inside this sub-sequence that relate to the specified ID</summary>
	public TArray<AActor> GetBoundActors(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	///<summary>Resolve the first valid Actor binding inside this sub-sequence that relates to the specified ID</summary>
	public AActor GetBoundActor(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	///<summary>* Get the current sequence that this director is playing back within</summary>
	public UMovieSceneSequence GetSequence() { return default; }
	///<summary>Pointer to the player that&#39;s playing back this director&#39;s sequence. Only valid in game or in PIE/Simulate.</summary>
	public ULevelSequencePlayer Player;
	///<summary>The Sequence ID for the sequence this director is playing back within - has to be stored as an int32 so that it is reinstanced correctly</summary>
	public int SubSequenceID;
	///<summary>Native player interface index - stored by index so that it can be reinstanced correctly</summary>
	public int MovieScenePlayerIndex;
}
