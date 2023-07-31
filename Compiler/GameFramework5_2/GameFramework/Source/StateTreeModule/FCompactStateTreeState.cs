#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runtime representation of a StateTree state.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FCompactStateTreeState {
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
