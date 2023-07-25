#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingActorReference.h")]
///<summary>Exposes a Sequencer Actor Reference type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingActorReferenceKey : UMovieSceneScriptingKey {
// MovieSceneScriptingActorReferenceKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FMovieSceneObjectBindingID GetValue() { return default; }
	public void SetValue(FMovieSceneObjectBindingID InNewValue) {}
}
