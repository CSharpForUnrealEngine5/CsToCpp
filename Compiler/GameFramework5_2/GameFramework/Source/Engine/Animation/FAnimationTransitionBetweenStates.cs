#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This represents a baked transition</summary>
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FAnimationTransitionBetweenStates {
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
