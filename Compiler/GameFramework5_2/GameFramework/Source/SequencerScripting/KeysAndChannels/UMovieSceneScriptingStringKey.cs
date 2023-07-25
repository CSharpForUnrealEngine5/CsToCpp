#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingString.h")]
///<summary>Exposes a Sequencer string type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingStringKey : UMovieSceneScriptingKey {
// MovieSceneScriptingStringKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public string GetValue() { return default; }
	public void SetValue(string InNewValue) {}
}
