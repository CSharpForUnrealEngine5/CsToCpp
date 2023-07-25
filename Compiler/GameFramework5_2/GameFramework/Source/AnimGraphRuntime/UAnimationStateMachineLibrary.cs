#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationStateMachineLibrary.h")]
///<summary>Exposes operations to be performed on anim state machine node contexts</summary>
public partial class UAnimationStateMachineLibrary : UBlueprintFunctionLibrary {
// AnimationStateMachineLibrary
	public void ConvertToAnimationStateResult(FAnimNodeReference Node,FAnimationStateResultReference AnimationState,EAnimNodeReferenceConversionResult Result) {}
	public void ConvertToAnimationStateResultPure(FAnimNodeReference Node,FAnimationStateResultReference AnimationState,bool Result) {}
	public void ConvertToAnimationStateMachine(FAnimNodeReference Node,FAnimationStateMachineReference AnimationState,EAnimNodeReferenceConversionResult Result) {}
	public void ConvertToAnimationStateMachinePure(FAnimNodeReference Node,FAnimationStateMachineReference AnimationState,bool Result) {}
	public bool IsStateBlendingIn(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	public bool IsStateBlendingOut(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	public void SetState(FAnimUpdateContext UpdateContext,FAnimationStateMachineReference Node,string TargetState,float Duration,byte BlendType,UObject BlendProfile,EAlphaBlendOption AlphaBlendOption,UObject CustomBlendCurve) {}
	public string GetState(FAnimUpdateContext UpdateContext,FAnimationStateMachineReference Node) { return default; }
	public float GetRelevantAnimTimeRemaining(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	public float GetRelevantAnimTimeRemainingFraction(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
}
