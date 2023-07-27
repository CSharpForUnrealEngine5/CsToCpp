#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingBool.h")]
public partial class UMovieSceneScriptingBoolChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingBoolChannel
	public  UMovieSceneScriptingBoolKey AddKey(FFrameNumber InTime,bool NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public  void RemoveKey(UMovieSceneScriptingKey Key) {}
	public  TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
	public  int GetNumKeys() { return default; }
	public  TArray<bool> EvaluateKeys(FSequencerScriptingRange Range,FFrameRate FrameRate) { return default; }
	public  FSequencerScriptingRange ComputeEffectiveRange() { return default; }
	public  void SetDefault(bool InDefaultValue) {}
	public  bool GetDefault() { return default; }
	public  void RemoveDefault() {}
	public  bool HasDefault() { return default; }
}
