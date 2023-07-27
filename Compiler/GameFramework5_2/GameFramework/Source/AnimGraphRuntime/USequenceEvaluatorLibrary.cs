#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceEvaluatorLibrary.h")]
///<summary>Exposes operations to be performed on a sequence evaluator anim node</summary>
public partial class USequenceEvaluatorLibrary : UBlueprintFunctionLibrary {
// SequenceEvaluatorLibrary
	public static FSequenceEvaluatorReference ConvertToSequenceEvaluator(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	public static void ConvertToSequenceEvaluatorPure(FAnimNodeReference Node,FSequenceEvaluatorReference SequenceEvaluator,bool Result) {}
	public static FSequenceEvaluatorReference SetExplicitTime(FSequenceEvaluatorReference SequenceEvaluator,float Time) { return default; }
	public static FSequenceEvaluatorReference AdvanceTime(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,float PlayRate/*=1.0f*/) { return default; }
	public static FSequenceEvaluatorReference SetSequence(FSequenceEvaluatorReference SequenceEvaluator,UAnimSequenceBase Sequence) { return default; }
	public static FSequenceEvaluatorReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,UAnimSequenceBase Sequence,float BlendTime/*=0.2f*/) { return default; }
	public static float GetAccumulatedTime(FSequenceEvaluatorReference SequenceEvaluator) { return default; }
	public static UAnimSequenceBase GetSequence(FSequenceEvaluatorReference SequenceEvaluator) { return default; }
}
