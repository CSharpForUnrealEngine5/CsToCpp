#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on a sequence player anim node</summary>
[CppInclude("SequencePlayerLibrary.h")]
public partial class USequencePlayerLibrary : UBlueprintFunctionLibrary {
	///<summary>Get a sequence player context from an anim node context</summary>
	public static FSequencePlayerReference ConvertToSequencePlayer(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Get a sequence player context from an anim node context (pure)</summary>
	public static void ConvertToSequencePlayerPure(FAnimNodeReference Node,FSequencePlayerReference SequencePlayer,bool Result) {}
	///<summary>Set the current accumulated time of the sequence player</summary>
	public static FSequencePlayerReference SetAccumulatedTime(FSequencePlayerReference SequencePlayer,float Time) { return default; }
	///<summary>Set the start position of the sequence player.</summary>
	public static FSequencePlayerReference SetStartPosition(FSequencePlayerReference SequencePlayer,float StartPosition) { return default; }
	///<summary>Set the play rate of the sequence player</summary>
	public static FSequencePlayerReference SetPlayRate(FSequencePlayerReference SequencePlayer,float PlayRate) { return default; }
	///<summary>Set the current sequence of the sequence player</summary>
	public static FSequencePlayerReference SetSequence(FSequencePlayerReference SequencePlayer,UAnimSequenceBase Sequence) { return default; }
	///<summary>Set the current sequence of the sequence player with an inertial blend time</summary>
	public static FSequencePlayerReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext,FSequencePlayerReference SequencePlayer,UAnimSequenceBase Sequence,float BlendTime/*=0.2f*/) { return default; }
	///<summary>Get the current sequence of the sequence player - DEPRECATED, please use pure version</summary>
	public static FSequencePlayerReference GetSequence(FSequencePlayerReference SequencePlayer,UAnimSequenceBase SequenceBase) { return default; }
	///<summary>Get the current sequence of the sequence player</summary>
	public static UAnimSequenceBase GetSequencePure(FSequencePlayerReference SequencePlayer) { return default; }
	///<summary>Gets the current accumulated time of the sequence player</summary>
	public static float GetAccumulatedTime(FSequencePlayerReference SequencePlayer) { return default; }
	///<summary>Get the start position of the sequence player</summary>
	public static float GetStartPosition(FSequencePlayerReference SequencePlayer) { return default; }
	///<summary>Get the play rate of the sequence player</summary>
	public static float GetPlayRate(FSequencePlayerReference SequencePlayer) { return default; }
	///<summary>Get the looping state of the sequence player</summary>
	public static bool GetLoopAnimation(FSequencePlayerReference SequencePlayer) { return default; }
	///<summary>Returns the Play Rate to provide when playing this animation if a specific animation duration is desired</summary>
	public static float ComputePlayRateFromDuration(FSequencePlayerReference SequencePlayer,float Duration/*=1.0f*/) { return default; }
}
