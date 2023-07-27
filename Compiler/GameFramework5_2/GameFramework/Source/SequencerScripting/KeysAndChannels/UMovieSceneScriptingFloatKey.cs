#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingFloat.h")]
///<summary>Exposes a Sequencer float type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingFloatKey : UMovieSceneScriptingKey {
// MovieSceneScriptingFloatKey
	public  FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public  void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public  float GetValue() { return default; }
	public  void SetValue(float InNewValue) {}
	public  ERichCurveInterpMode GetInterpolationMode() { return default; }
	public  void SetInterpolationMode(ERichCurveInterpMode InNewValue) {}
	public  ERichCurveTangentMode GetTangentMode() { return default; }
	public  void SetTangentMode(ERichCurveTangentMode InNewValue) {}
	public  float GetArriveTangent() { return default; }
	public  void SetArriveTangent(float InNewValue) {}
	public  float GetLeaveTangent() { return default; }
	public  void SetLeaveTangent(float InNewValue) {}
	public  ERichCurveTangentWeightMode GetTangentWeightMode() { return default; }
	public  void SetTangentWeightMode(ERichCurveTangentWeightMode InNewValue) {}
	public  float GetArriveTangentWeight() { return default; }
	public  void SetArriveTangentWeight(float InNewValue) {}
	public  float GetLeaveTangentWeight() { return default; }
	public  void SetLeaveTangentWeight(float InNewValue) {}
}
