#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on anim state machine node contexts</summary>
[CppInclude("AnimationStateMachineLibrary.h")]
public partial class UAnimationStateMachineLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get an anim state reference from an anim node reference</summary>
	public static void ConvertToAnimationStateResult(FAnimNodeReference Node,FAnimationStateResultReference AnimationState,EAnimNodeReferenceConversionResult Result) {}
	///<summary>Get an anim state reference from an anim node reference (pure)</summary>
	public static void ConvertToAnimationStateResultPure(FAnimNodeReference Node,FAnimationStateResultReference AnimationState,bool Result) {}
	///<summary>Get an anim state machine from an anim node reference</summary>
	public static void ConvertToAnimationStateMachine(FAnimNodeReference Node,FAnimationStateMachineReference AnimationState,EAnimNodeReferenceConversionResult Result) {}
	///<summary>Get an anim state machine from an anim node reference (pure)</summary>
	public static void ConvertToAnimationStateMachinePure(FAnimNodeReference Node,FAnimationStateMachineReference AnimationState,bool Result) {}
	///<summary>Returns whether the state the node belongs to is blending in</summary>
	public static bool IsStateBlendingIn(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	///<summary>Returns whether the state the node belongs to is blending out</summary>
	public static bool IsStateBlendingOut(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	///<summary>Manually set the current state of the state machine</summary>
	public static void SetState(FAnimUpdateContext UpdateContext,FAnimationStateMachineReference Node,string TargetState,float Duration,ETransitionLogicType BlendType,UBlendProfile BlendProfile,EAlphaBlendOption AlphaBlendOption,UCurveFloat CustomBlendCurve) {}
	///<summary>Returns the name of the current state of this state machine</summary>
	public static string GetState(FAnimUpdateContext UpdateContext,FAnimationStateMachineReference Node) { return default; }
	///<summary>Returns the remaining animation time of the state&#39;s most relevant asset player</summary>
	public static float GetRelevantAnimTimeRemaining(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
	///<summary>Returns the remaining animation time as a fraction of the duration for the state&#39;s most relevant asset player</summary>
	public static float GetRelevantAnimTimeRemainingFraction(FAnimUpdateContext UpdateContext,FAnimationStateResultReference Node) { return default; }
}
