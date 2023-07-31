#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FAnimationState {
	public TArray<FAnimationTransitionRule> Transitions;
	public int StateRootNodeIndex;
	public int StartNotify;
	public int EndNotify;
	public int FullyBlendedNotify;
}
