#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingInteger.h")]
///<summary>Exposes a Sequencer integer type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingIntegerKey : UMovieSceneScriptingKey {
// MovieSceneScriptingIntegerKey
	public  FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public  void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public  int GetValue() { return default; }
	public  void SetValue(int InNewValue) {}
}
