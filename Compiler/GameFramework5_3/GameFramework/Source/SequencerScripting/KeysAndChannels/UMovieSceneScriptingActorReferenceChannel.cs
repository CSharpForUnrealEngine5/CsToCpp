namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingActorReference.h")]
public partial class UMovieSceneScriptingActorReferenceChannel : UMovieSceneScriptingChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Add a key to this channel. This initializes a new key and returns a reference to it.</summary>
	public UMovieSceneScriptingActorReferenceKey AddKey(FFrameNumber InTime,FMovieSceneObjectBindingID NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Removes the specified key. Does nothing if the key is not specified or the key belongs to another channel.</summary>
	public virtual void RemoveKey(UMovieSceneScriptingKey Key) {}
	///<summary>Gets all of the keys in this channel.</summary>
	public virtual TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
	///<summary>Set this channel&#39;s default value that should be used when no keys are present.</summary>
	public void SetDefault(FMovieSceneObjectBindingID InDefaultValue) {}
	///<summary>Get this channel&#39;s default value that will be used when no keys are present. Only a valid</summary>
	public FMovieSceneObjectBindingID GetDefault() { return default; }
	///<summary>Remove this channel&#39;s default value causing the channel to have no effect where no keys are present</summary>
	public void RemoveDefault() {}
	///<summary>@return Does this channel have a default value set?</summary>
	public bool HasDefault() { return default; }
}
