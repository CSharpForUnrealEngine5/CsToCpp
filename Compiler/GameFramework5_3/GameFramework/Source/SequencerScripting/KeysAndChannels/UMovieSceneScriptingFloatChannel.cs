namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingFloat.h")]
public partial class UMovieSceneScriptingFloatChannel : UMovieSceneScriptingChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Add a key to this channel. This initializes a new key and returns a reference to it.</summary>
	public UMovieSceneScriptingFloatKey AddKey(FFrameNumber InTime,float NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,EMovieSceneKeyInterpolation InInterpolation/*=EMovieSceneKeyInterpolation.Auto*/) { return default; }
	///<summary>Removes the specified key. Does nothing if the key is not specified or the key belongs to another channel.</summary>
	public virtual void RemoveKey(UMovieSceneScriptingKey Key) {}
	///<summary>Gets all of the keys in this channel.</summary>
	public virtual TArray<UMovieSceneScriptingKey> GetKeys() { return default; }
	///<summary>Returns number of keys in this channel.</summary>
	public int GetNumKeys() { return default; }
	///<summary>Gets baked keys in this channel.</summary>
	public TArray<float> EvaluateKeys(FSequencerScriptingRange Range,FFrameRate FrameRate) { return default; }
	///<summary>Compute the effective range of this channel, for example, the extents of its key times</summary>
	public FSequencerScriptingRange ComputeEffectiveRange() { return default; }
	///<summary>@return Gets the Pre-infinity extrapolation state. See ERichCurveExtrapolation for more detail.</summary>
	public ERichCurveExtrapolation GetPreInfinityExtrapolation() { return default; }
	///<summary>Sets the Pre-infinity extrapolation state. See ERichCurveExtrapolation for more detail.</summary>
	public void SetPreInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation) {}
	///<summary>@return Gets the Post-infinity extrapolation state. See ERichCurveExtrapolation for more detail.</summary>
	public ERichCurveExtrapolation GetPostInfinityExtrapolation() { return default; }
	///<summary>Sets the Post-infinity extrapolation state. See ERichCurveExtrapolation for more detail.</summary>
	public void SetPostInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation) {}
	///<summary>Set this channel&#39;s default value that should be used when no keys are present.</summary>
	public void SetDefault(float InDefaultValue) {}
	///<summary>Get this channel&#39;s default value that will be used when no keys are present. Only a valid</summary>
	public float GetDefault() { return default; }
	///<summary>Remove this channel&#39;s default value causing the channel to have no effect where no keys are present</summary>
	public void RemoveDefault() {}
	///<summary>@return Does this channel have a default value set?</summary>
	public bool HasDefault() { return default; }
}
