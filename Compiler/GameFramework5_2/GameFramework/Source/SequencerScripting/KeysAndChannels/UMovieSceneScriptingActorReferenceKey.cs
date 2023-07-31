#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes a Sequencer Actor Reference type key to Python/Blueprints.</summary>
[CppInclude("KeysAndChannels/MovieSceneScriptingActorReference.h")]
public partial class UMovieSceneScriptingActorReferenceKey : UMovieSceneScriptingKey {
	///<summary>Gets the time for this key from the owning channel.</summary>
	public  FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Sets the time for this key in the owning channel. Will replace any key that already exists at that frame number in this channel.</summary>
	public  void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Gets the value for this key from the owning channel.</summary>
	public  FMovieSceneObjectBindingID GetValue() { return default; }
	///<summary>Sets the value for this key, reflecting it in the owning channel.</summary>
	public  void SetValue(FMovieSceneObjectBindingID InNewValue) {}
}
