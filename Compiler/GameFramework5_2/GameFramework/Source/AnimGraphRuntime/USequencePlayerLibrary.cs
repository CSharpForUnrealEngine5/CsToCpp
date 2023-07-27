#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencePlayerLibrary.h")]
///<summary>Exposes operations to be performed on a sequence player anim node</summary>
public partial class USequencePlayerLibrary : UBlueprintFunctionLibrary {
// SequencePlayerLibrary
	public static FSequencePlayerReference ConvertToSequencePlayer(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	public static void ConvertToSequencePlayerPure(FAnimNodeReference Node,FSequencePlayerReference SequencePlayer,bool Result) {}
	public static FSequencePlayerReference SetAccumulatedTime(FSequencePlayerReference SequencePlayer,float Time) { return default; }
	public static FSequencePlayerReference SetStartPosition(FSequencePlayerReference SequencePlayer,float StartPosition) { return default; }
	public static FSequencePlayerReference SetPlayRate(FSequencePlayerReference SequencePlayer,float PlayRate) { return default; }
	public static FSequencePlayerReference SetSequence(FSequencePlayerReference SequencePlayer,UAnimSequenceBase Sequence) { return default; }
	public static FSequencePlayerReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext,FSequencePlayerReference SequencePlayer,UAnimSequenceBase Sequence,float BlendTime/*=0.2f*/) { return default; }
	public static FSequencePlayerReference GetSequence(FSequencePlayerReference SequencePlayer,UAnimSequenceBase SequenceBase) { return default; }
	public static UAnimSequenceBase GetSequencePure(FSequencePlayerReference SequencePlayer) { return default; }
	public static float GetAccumulatedTime(FSequencePlayerReference SequencePlayer) { return default; }
	public static float GetStartPosition(FSequencePlayerReference SequencePlayer) { return default; }
	public static float GetPlayRate(FSequencePlayerReference SequencePlayer) { return default; }
	public static bool GetLoopAnimation(FSequencePlayerReference SequencePlayer) { return default; }
	public static float ComputePlayRateFromDuration(FSequencePlayerReference SequencePlayer,float Duration/*=1.0f*/) { return default; }
}
