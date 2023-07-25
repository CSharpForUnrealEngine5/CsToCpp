#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingActorReference.h")]
public partial class UMovieSceneScriptingActorReferenceChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingActorReferenceChannel
	public UObject AddKey(FFrameNumber InTime,FMovieSceneObjectBindingID NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys() { return default; }
	public void SetDefault(FMovieSceneObjectBindingID InDefaultValue) {}
	public FMovieSceneObjectBindingID GetDefault() { return default; }
	public void RemoveDefault() {}
	public bool HasDefault() { return default; }
}
