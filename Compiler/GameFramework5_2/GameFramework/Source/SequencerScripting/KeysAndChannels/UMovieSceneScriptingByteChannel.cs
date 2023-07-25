#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingByte.h")]
public partial class UMovieSceneScriptingByteChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingByteChannel
	public UObject AddKey(FFrameNumber InTime,byte NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,EMovieSceneKeyInterpolation InInterpolation/*=EMovieSceneKeyInterpolation.Auto*/) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys() { return default; }
	public void SetDefault(byte InDefaultValue) {}
	public byte GetDefault() { return default; }
	public void RemoveDefault() {}
	public bool HasDefault() { return default; }
}
