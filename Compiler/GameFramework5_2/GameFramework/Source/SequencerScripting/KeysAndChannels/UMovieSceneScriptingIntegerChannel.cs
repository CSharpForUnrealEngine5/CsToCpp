#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingInteger.h")]
public partial class UMovieSceneScriptingIntegerChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingIntegerChannel
	public  UMovieSceneScriptingIntegerKey AddKey(FFrameNumber InTime,int NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public  void RemoveKey(UMovieSceneScriptingKey Key) {}
	public  TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
	public  void SetDefault(int InDefaultValue) {}
	public  int GetDefault() { return default; }
	public  void RemoveDefault() {}
	public  bool HasDefault() { return default; }
}
