#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Describes a state tree transition. Source is the state where the transition started, Target describes the state where the transition pointed at,</summary>
public partial struct FStateTreeTransitionResult {
// StateTreeTransitionResult
	public FStateTreeActiveStates CurrentActiveStates;
	public EStateTreeRunStatus CurrentRunStatus;
	public FStateTreeStateHandle SourceState;
	public FStateTreeStateHandle TargetState;
	public FStateTreeActiveStates NextActiveStates;
	public FStateTreeStateHandle CurrentState;
	public EStateTreeStateChangeType ChangeType;
	public EStateTreeTransitionPriority Priority;
}
