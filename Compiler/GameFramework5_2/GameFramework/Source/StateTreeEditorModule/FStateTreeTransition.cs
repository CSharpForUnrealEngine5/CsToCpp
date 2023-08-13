namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor representation of a transition in StateTree</summary>
[CppInclude("StateTreeState.h")]
public partial struct FStateTreeTransition {
	public EStateTreeTransitionTrigger Trigger;
	public FGameplayTag EventTag;
	public FStateTreeStateLink State;
	public EStateTreeTransitionPriority Priority;
	public bool bDelayTransition;
	public float DelayDuration;
	public float DelayRandomVariance;
	public TArray<FStateTreeEditorNode> Conditions;
}
