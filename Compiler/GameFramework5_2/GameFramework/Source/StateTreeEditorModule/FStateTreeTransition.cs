#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeState.h")]
///<summary>Editor representation of a transition in StateTree</summary>
public partial struct FStateTreeTransition {
// StateTreeTransition
	public EStateTreeTransitionTrigger Trigger;
	public FGameplayTag EventTag;
	public FStateTreeStateLink State;
	public EStateTreeTransitionPriority Priority;
	public bool bDelayTransition;
	public float DelayDuration;
	public float DelayRandomVariance;
	public TArray<FStateTreeEditorNode> Conditions;
}
