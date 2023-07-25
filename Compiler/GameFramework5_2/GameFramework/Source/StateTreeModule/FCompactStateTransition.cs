#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Runtime representation of a StateTree transition.</summary>
public partial struct FCompactStateTransition {
// CompactStateTransition
	public FGameplayTag EventTag;
	public ushort ConditionsBegin;
	public FStateTreeStateHandle State;
	public FStateTreeRandomTimeDuration Delay;
	public EStateTreeTransitionTrigger Trigger;
	public EStateTreeTransitionPriority Priority;
	public byte ConditionsNum;
}
