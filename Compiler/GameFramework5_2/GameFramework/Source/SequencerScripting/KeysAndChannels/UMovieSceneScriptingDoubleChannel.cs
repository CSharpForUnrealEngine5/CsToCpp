#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingDouble.h")]
public partial class UMovieSceneScriptingDoubleChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingDoubleChannel
	public UObject AddKey(FFrameNumber InTime,double NewValue,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,EMovieSceneKeyInterpolation InInterpolation/*=EMovieSceneKeyInterpolation.Auto*/) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys() { return default; }
	public int GetNumKeys() { return default; }
	public TArray<double> EvaluateKeys(FSequencerScriptingRange Range,FFrameRate FrameRate) { return default; }
	public FSequencerScriptingRange ComputeEffectiveRange() { return default; }
	public ERichCurveExtrapolation GetPreInfinityExtrapolation() { return default; }
	public void SetPreInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation) {}
	public ERichCurveExtrapolation GetPostInfinityExtrapolation() { return default; }
	public void SetPostInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation) {}
	public void SetDefault(double InDefaultValue) {}
	public double GetDefault() { return default; }
	public void RemoveDefault() {}
	public bool HasDefault() { return default; }
}
