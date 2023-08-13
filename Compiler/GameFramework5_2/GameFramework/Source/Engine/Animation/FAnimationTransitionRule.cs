namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This structure represents a baked transition rule inside a state</summary>
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FAnimationTransitionRule {
	public string RuleToExecute;
	public bool TransitionReturnVal;
	public int TransitionIndex;
}
