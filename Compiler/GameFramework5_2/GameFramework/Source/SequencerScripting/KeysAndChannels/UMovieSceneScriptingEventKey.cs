#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingEvent.h")]
///<summary>Exposes a Sequencer Event type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingEventKey : UMovieSceneScriptingKey {
// MovieSceneScriptingEventKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FMovieSceneEvent GetValue() { return default; }
	public void SetValue(FMovieSceneEvent InNewValue) {}
}
