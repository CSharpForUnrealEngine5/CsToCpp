namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes a Sequencer float type key to Python/Blueprints.</summary>
[CppInclude("KeysAndChannels/MovieSceneScriptingFloat.h")]
public partial class UMovieSceneScriptingFloatKey : UMovieSceneScriptingKey {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the time for this key from the owning channel.</summary>
	public virtual FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Sets the time for this key in the owning channel. Will replace any key that already exists at that frame number in this channel.</summary>
	public virtual void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Gets the value for this key from the owning channel.</summary>
	public virtual float GetValue() { return default; }
	///<summary>Sets the value for this key, reflecting it in the owning channel.</summary>
	public virtual void SetValue(float InNewValue) {}
	///<summary>Gets the interpolation mode for this key from the owning channel.</summary>
	public virtual ERichCurveInterpMode GetInterpolationMode() { return default; }
	///<summary>Sets the interpolation mode for this key, reflecting it in the owning channel.</summary>
	public virtual void SetInterpolationMode(ERichCurveInterpMode InNewValue) {}
	///<summary>Gets the tangent mode for this key from the owning channel.</summary>
	public virtual ERichCurveTangentMode GetTangentMode() { return default; }
	///<summary>Sets the tangent mode for this key, reflecting it in the owning channel.</summary>
	public virtual void SetTangentMode(ERichCurveTangentMode InNewValue) {}
	///<summary>If Interpolation Mode is RCIM_Cubic, the arriving tangent at this key</summary>
	public virtual float GetArriveTangent() { return default; }
	///<summary>If Interpolation Mode is RCIM_Cubic, the arriving tangent at this key.</summary>
	public virtual void SetArriveTangent(float InNewValue) {}
	///<summary>If Interpolation Mode is RCIM_Cubic, the leaving tangent at this key</summary>
	public virtual float GetLeaveTangent() { return default; }
	///<summary>If Interpolation Mode is RCIM_Cubic, the leaving tangent at this key.</summary>
	public virtual void SetLeaveTangent(float InNewValue) {}
	///<summary>If Interpolation Mode is RCIM_Cubic, the tangent weight mode at this key</summary>
	public virtual ERichCurveTangentWeightMode GetTangentWeightMode() { return default; }
	///<summary>If Interpolation Mode is RCIM_Cubic, the tangent weight mode at this key.</summary>
	public virtual void SetTangentWeightMode(ERichCurveTangentWeightMode InNewValue) {}
	///<summary>If Tangent Weight Mode is RCTWM_WeightedArrive or RCTWM_WeightedBoth, the weight of the arriving tangent on the left side.</summary>
	public virtual float GetArriveTangentWeight() { return default; }
	///<summary>If Tangent Weight Mode is RCTWM_WeightedArrive or RCTWM_WeightedBoth, the weight of the arriving tangent on the left side.</summary>
	public virtual void SetArriveTangentWeight(float InNewValue) {}
	///<summary>If Tangent Weight Mode is RCTWM_WeightedLeave or RCTWM_WeightedBoth, the weight of the leaving tangent on the right side.</summary>
	public virtual float GetLeaveTangentWeight() { return default; }
	///<summary>If Tangent Weight Mode is RCTWM_WeightedLeave or RCTWM_WeightedBoth, the weight of the leaving tangent on the right side.</summary>
	public virtual void SetLeaveTangentWeight(float InNewValue) {}
}
