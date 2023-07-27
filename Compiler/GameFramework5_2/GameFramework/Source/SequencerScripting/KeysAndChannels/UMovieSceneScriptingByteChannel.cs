#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingByte.h")]
public partial class UMovieSceneScriptingByteChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingByteChannel
	public  UMovieSceneScriptingByteKey AddKey(FFrameNumber InTime,byte NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,EMovieSceneKeyInterpolation InInterpolation/*=EMovieSceneKeyInterpolation.Auto*/) { return default; }
	public  void RemoveKey(UMovieSceneScriptingKey Key) {}
	public  TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
	public  void SetDefault(byte InDefaultValue) {}
	public  byte GetDefault() { return default; }
	public  void RemoveDefault() {}
	public  bool HasDefault() { return default; }
}
