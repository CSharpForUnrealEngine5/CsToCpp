#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingByte.h")]
public partial class UMovieSceneScriptingByteChannel : UMovieSceneScriptingChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Add a key to this channel. This initializes a new key and returns a reference to it.</summary>
	public  UMovieSceneScriptingByteKey AddKey(FFrameNumber InTime,byte NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,EMovieSceneKeyInterpolation InInterpolation/*=EMovieSceneKeyInterpolation.Auto*/) { return default; }
	///<summary>Removes the specified key. Does nothing if the key is not specified or the key belongs to another channel.</summary>
	public  void RemoveKey(UMovieSceneScriptingKey Key) {}
	///<summary>Gets all of the keys in this channel.</summary>
	public  TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
	///<summary>Set this channel&#39;s default value that should be used when no keys are present.</summary>
	public  void SetDefault(byte InDefaultValue) {}
	///<summary>Get this channel&#39;s default value that will be used when no keys are present. Only a valid</summary>
	public  byte GetDefault() { return default; }
	///<summary>Remove this channel&#39;s default value causing the channel to have no effect where no keys are present</summary>
	public  void RemoveDefault() {}
	///<summary>@return Does this channel have a default value set?</summary>
	public  bool HasDefault() { return default; }
}
