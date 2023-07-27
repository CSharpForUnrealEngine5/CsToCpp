#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStateMachineTypes.h")]
///<summary>This represents a baked transition</summary>
public partial struct FAnimationTransitionBetweenStates {
// AnimationTransitionBetweenStates
	public int PreviousState;
	public int NextState;
	public float CrossfadeDuration;
	public int StartNotify;
	public int EndNotify;
	public int InterruptNotify;
	public EAlphaBlendOption BlendMode;
	public UCurveFloat CustomCurve;
	public UBlendProfile BlendProfile;
	public ETransitionLogicType LogicType;
}
