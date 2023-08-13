namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FBakedAnimationStateMachine {
	public string MachineName;
	public int InitialState;
	public TArray<FBakedAnimationState> States;
	public TArray<FAnimationTransitionBetweenStates> Transitions;
}
