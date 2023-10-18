namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runtime representation of a StateTree transition.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FCompactStateTransition {
	public FGameplayTag EventTag;
	public ushort ConditionsBegin;
	public FStateTreeStateHandle State;
	public FStateTreeRandomTimeDuration Delay;
	public EStateTreeTransitionTrigger Trigger;
	public EStateTreeTransitionPriority Priority;
	public byte ConditionsNum;
	public bool bTransitionEnabled;
}
