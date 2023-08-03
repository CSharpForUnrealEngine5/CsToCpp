#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingBool.h")]
public partial class UMovieSceneScriptingBoolChannel : UMovieSceneScriptingChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Add a key to this channel. This initializes a new key and returns a reference to it.</summary>
	public  UMovieSceneScriptingBoolKey AddKey(FFrameNumber InTime,bool NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Removes the specified key. Does nothing if the key is not specified or the key belongs to another channel.</summary>
	public  void RemoveKey(UMovieSceneScriptingKey Key) {}
	///<summary>Gets all of the keys in this channel.</summary>
	public  TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
	///<summary>Returns number of keys in this channel.</summary>
	public  int GetNumKeys() { return default; }
	///<summary>Gets baked keys in this channel.</summary>
	public  TArray<bool> EvaluateKeys(FSequencerScriptingRange Range,FFrameRate FrameRate) { return default; }
	///<summary>Compute the effective range of this channel, for example, the extents of its key times</summary>
	public  FSequencerScriptingRange ComputeEffectiveRange() { return default; }
	///<summary>Set this channel&#39;s default value that should be used when no keys are present.</summary>
	public  void SetDefault(bool InDefaultValue) {}
	///<summary>Get this channel&#39;s default value that will be used when no keys are present. Only a valid</summary>
	public  bool GetDefault() { return default; }
	///<summary>Remove this channel&#39;s default value causing the channel to have no effect where no keys are present</summary>
	public  void RemoveDefault() {}
	///<summary>@return Does this channel have a default value set?</summary>
	public  bool HasDefault() { return default; }
}
