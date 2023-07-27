#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationStateMachineLibrary.h")]
///<summary>Exposes operations to be performed on anim state machine node contexts</summary>
public partial class UAnimationStateMachineLibrary : UBlueprintFunctionLibrary {
// AnimationStateMachineLibrary
	public static void ConvertToAnimationStateResult(FAnimNodeReference Node,FAnimationStateResultReference AnimationState,EAnimNodeReferenceConversionResult Result) {}
	public static void ConvertToAnimationStateResultPure(FAnimNodeReference Node,FAnimationStateResultReference AnimationState,bool Result) {}
	public static void ConvertToAnimationStateMachine(FAnimNodeReference Node,FAnimationStateMachineReference AnimationState,EAnimNodeReferenceConversionResult Result) {}
	public static void ConvertToAnimationStateMachinePure(FAnimNodeReference Node,FAnimationStateMachineReference AnimationState,bool Result) {}
	public static bool IsStateBlendingIn(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	public static bool IsStateBlendingOut(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	public static void SetState(FAnimUpdateContext UpdateContext,FAnimationStateMachineReference Node,string TargetState,float Duration,ETransitionLogicType BlendType,UBlendProfile BlendProfile,EAlphaBlendOption AlphaBlendOption,UCurveFloat CustomBlendCurve) {}
	public static string GetState(FAnimUpdateContext UpdateContext,FAnimationStateMachineReference Node) { return default; }
	public static float GetRelevantAnimTimeRemaining(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	public static float GetRelevantAnimTimeRemainingFraction(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
}
