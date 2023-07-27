#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingEvent.h")]
public partial class UMovieSceneScriptingEventChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingEventChannel
	public  UMovieSceneScriptingEventKey AddKey(FFrameNumber InTime,FMovieSceneEvent NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public  void RemoveKey(UMovieSceneScriptingKey Key) {}
	public  TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
}
