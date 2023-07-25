#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeState.h")]
///<summary>Editor representation of a state in StateTree</summary>
public partial class UStateTreeState : UObject {
// StateTreeState
	public string Name;
	public EStateTreeStateType Type;
	public FStateTreeStateLink LinkedSubtree;
	public FStateTreeStateParameters Parameters;
	public FGuid ID;
	public TArray<FStateTreeEditorNode> EnterConditions;
	public TArray<FStateTreeEditorNode> Evaluators_DEPRECATED;
	public TArray<FStateTreeEditorNode> Tasks;
	public FStateTreeEditorNode SingleTask;
	public TArray<FStateTreeTransition> Transitions;
	public TArray<UStateTreeState> Children;
	public bool bExpanded;
	public UStateTreeState Parent;
}
