#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingEvent.h")]
public partial class UMovieSceneScriptingEventChannel : UMovieSceneScriptingChannel {
	///<summary>Add a key to this channel. This initializes a new key and returns a reference to it.</summary>
	public  UMovieSceneScriptingEventKey AddKey(FFrameNumber InTime,FMovieSceneEvent NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Removes the specified key. Does nothing if the key is not specified or the key belongs to another channel.</summary>
	public  void RemoveKey(UMovieSceneScriptingKey Key) {}
	///<summary>Gets all of the keys in this channel.</summary>
	public  TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
}
