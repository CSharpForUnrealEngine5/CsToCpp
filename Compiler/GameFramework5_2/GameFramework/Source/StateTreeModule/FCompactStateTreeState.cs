#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Runtime representation of a StateTree state.</summary>
public partial struct FCompactStateTreeState {
// CompactStateTreeState
	public string Name;
	public FStateTreeStateHandle LinkedState;
	public FStateTreeStateHandle Parent;
	public ushort ChildrenBegin;
	public ushort ChildrenEnd;
	public ushort EnterConditionsBegin;
	public ushort TransitionsBegin;
	public ushort TasksBegin;
	public FStateTreeIndex16 ParameterInstanceIndex;
	public FStateTreeIndex16 ParameterDataViewIndex;
	public byte EnterConditionsNum;
	public byte TransitionsNum;
	public byte TasksNum;
	public EStateTreeStateType Type;
	public bool bHasTransitionTasks;
}
