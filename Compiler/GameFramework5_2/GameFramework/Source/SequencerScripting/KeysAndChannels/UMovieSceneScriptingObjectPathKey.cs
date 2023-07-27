#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingObjectPath.h")]
///<summary>Exposes a Sequencer Object Path type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingObjectPathKey : UMovieSceneScriptingKey {
// MovieSceneScriptingObjectPathKey
	public  FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public  void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public  UObject GetValue() { return default; }
	public  void SetValue(UObject InNewValue) {}
}
