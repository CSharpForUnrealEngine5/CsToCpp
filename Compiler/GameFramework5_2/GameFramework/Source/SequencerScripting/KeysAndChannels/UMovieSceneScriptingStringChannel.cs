#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingString.h")]
public partial class UMovieSceneScriptingStringChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingStringChannel
	public UObject AddKey(FFrameNumber InTime,string NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys() { return default; }
	public void SetDefault(string InDefaultValue) {}
	public string GetDefault() { return default; }
	public void RemoveDefault() {}
	public bool HasDefault() { return default; }
}
