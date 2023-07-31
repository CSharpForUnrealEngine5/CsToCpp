#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FBakedAnimationStateMachine {
	public string MachineName;
	public int InitialState;
	public TArray<FBakedAnimationState> States;
	public TArray<FAnimationTransitionBetweenStates> Transitions;
}
