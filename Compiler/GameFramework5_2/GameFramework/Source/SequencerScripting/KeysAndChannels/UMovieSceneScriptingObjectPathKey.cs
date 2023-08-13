namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes a Sequencer Object Path type key to Python/Blueprints.</summary>
[CppInclude("KeysAndChannels/MovieSceneScriptingObjectPath.h")]
public partial class UMovieSceneScriptingObjectPathKey : UMovieSceneScriptingKey {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the time for this key from the owning channel.</summary>
	public virtual FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Sets the time for this key in the owning channel. Will replace any key that already exists at that frame number in this channel.</summary>
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Gets the value for this key from the owning channel.</summary>
	public UObject GetValue() { return default; }
	///<summary>Sets the value for this key, reflecting it in the owning channel.</summary>
	public void SetValue(UObject InNewValue) {}
}
