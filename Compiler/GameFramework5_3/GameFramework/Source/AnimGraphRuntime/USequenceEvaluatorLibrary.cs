namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on a sequence evaluator anim node</summary>
[CppInclude("SequenceEvaluatorLibrary.h")]
public partial class USequenceEvaluatorLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a sequence evaluator context from an anim node context</summary>
	public static FSequenceEvaluatorReference ConvertToSequenceEvaluator(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Get a sequence evaluator context from an anim node context (pure)</summary>
	public static void ConvertToSequenceEvaluatorPure(FAnimNodeReference Node,FSequenceEvaluatorReference SequenceEvaluator,bool Result) {}
	///<summary>Set the current accumulated time of the sequence evaluator</summary>
	public static FSequenceEvaluatorReference SetExplicitTime(FSequenceEvaluatorReference SequenceEvaluator,float Time) { return default; }
	///<summary>Advance the current accumulated time of the sequence evaluator</summary>
	public static FSequenceEvaluatorReference AdvanceTime(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,float PlayRate/*=1.0f*/) { return default; }
	///<summary>Set the current sequence of the sequence evaluator</summary>
	public static FSequenceEvaluatorReference SetSequence(FSequenceEvaluatorReference SequenceEvaluator,UAnimSequenceBase Sequence) { return default; }
	///<summary>Set the current sequence of the sequence evaluator with an inertial blend time</summary>
	public static FSequenceEvaluatorReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,UAnimSequenceBase Sequence,float BlendTime/*=0.2f*/) { return default; }
	///<summary>Gets the current accumulated time of the sequence evaluator</summary>
	public static float GetAccumulatedTime(FSequenceEvaluatorReference SequenceEvaluator) { return default; }
	///<summary>Gets the current sequence of the sequence evaluator</summary>
	public static UAnimSequenceBase GetSequence(FSequenceEvaluatorReference SequenceEvaluator) { return default; }
}
