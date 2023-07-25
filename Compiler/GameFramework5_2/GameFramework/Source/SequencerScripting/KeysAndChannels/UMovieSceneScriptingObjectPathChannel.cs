#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingObjectPath.h")]
public partial class UMovieSceneScriptingObjectPathChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingObjectPathChannel
	public UObject AddKey(FFrameNumber InTime,UObject NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys() { return default; }
	public void SetDefault(UObject InDefaultValue) {}
	public UObject GetDefault() { return default; }
	public void RemoveDefault() {}
	public bool HasDefault() { return default; }
}
