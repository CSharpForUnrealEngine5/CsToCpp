#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes a Sequencer double type key to Python/Blueprints.</summary>
[CppInclude("KeysAndChannels/MovieSceneScriptingDouble.h")]
public partial class UMovieSceneScriptingDoubleKey : UMovieSceneScriptingKey {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the time for this key from the owning channel.</summary>
	public  FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Sets the time for this key in the owning channel. Will replace any key that already exists at that frame number in this channel.</summary>
	public  void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Gets the value for this key from the owning channel.</summary>
	public  double GetValue() { return default; }
	///<summary>Sets the value for this key, reflecting it in the owning channel.</summary>
	public  void SetValue(double InNewValue) {}
	///<summary>Gets the interpolation mode for this key from the owning channel.</summary>
	public  ERichCurveInterpMode GetInterpolationMode() { return default; }
	///<summary>Sets the interpolation mode for this key, reflecting it in the owning channel.</summary>
	public  void SetInterpolationMode(ERichCurveInterpMode InNewValue) {}
	///<summary>Gets the tangent mode for this key from the owning channel.</summary>
	public  ERichCurveTangentMode GetTangentMode() { return default; }
	///<summary>Sets the tangent mode for this key, reflecting it in the owning channel.</summary>
	public  void SetTangentMode(ERichCurveTangentMode InNewValue) {}
	///<summary>If Interpolation Mode is RCIM_Cubic, the arriving tangent at this key</summary>
	public  float GetArriveTangent() { return default; }
	///<summary>If Interpolation Mode is RCIM_Cubic, the arriving tangent at this key.</summary>
	public  void SetArriveTangent(float InNewValue) {}
	///<summary>If Interpolation Mode is RCIM_Cubic, the leaving tangent at this key</summary>
	public  float GetLeaveTangent() { return default; }
	///<summary>If Interpolation Mode is RCIM_Cubic, the leaving tangent at this key.</summary>
	public  void SetLeaveTangent(float InNewValue) {}
	///<summary>If Interpolation Mode is RCIM_Cubic, the tangent weight mode at this key</summary>
	public  ERichCurveTangentWeightMode GetTangentWeightMode() { return default; }
	///<summary>If Interpolation Mode is RCIM_Cubic, the tangent weight mode at this key.</summary>
	public  void SetTangentWeightMode(ERichCurveTangentWeightMode InNewValue) {}
	///<summary>If Tangent Weight Mode is RCTWM_WeightedArrive or RCTWM_WeightedBoth, the weight of the arriving tangent on the left side.</summary>
	public  float GetArriveTangentWeight() { return default; }
	///<summary>If Tangent Weight Mode is RCTWM_WeightedArrive or RCTWM_WeightedBoth, the weight of the arriving tangent on the left side.</summary>
	public  void SetArriveTangentWeight(float InNewValue) {}
	///<summary>If Tangent Weight Mode is RCTWM_WeightedLeave or RCTWM_WeightedBoth, the weight of the leaving tangent on the right side.</summary>
	public  float GetLeaveTangentWeight() { return default; }
	///<summary>If Tangent Weight Mode is RCTWM_WeightedLeave or RCTWM_WeightedBoth, the weight of the leaving tangent on the right side.</summary>
	public  void SetLeaveTangentWeight(float InNewValue) {}
}
