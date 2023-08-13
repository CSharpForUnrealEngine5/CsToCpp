namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a state tree transition. Source is the state where the transition started, Target describes the state where the transition pointed at,</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeTransitionResult {
	public FStateTreeActiveStates CurrentActiveStates;
	public EStateTreeRunStatus CurrentRunStatus;
	public FStateTreeStateHandle SourceState;
	public FStateTreeStateHandle TargetState;
	public FStateTreeActiveStates NextActiveStates;
	public FStateTreeStateHandle CurrentState;
	public EStateTreeStateChangeType ChangeType;
	public EStateTreeTransitionPriority Priority;
}
