namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor representation of a state in StateTree</summary>
[CppInclude("StateTreeState.h")]
public partial class UStateTreeState : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>~StateTree Builder API</summary>
	public FName Name;
	///<summary>Type</summary>
	public EStateTreeStateType Type;
	///<summary>SelectionBehavior</summary>
	public EStateTreeStateSelectionBehavior SelectionBehavior;
	///<summary>LinkedSubtree</summary>
	public FStateTreeStateLink LinkedSubtree;
	///<summary>Parameters</summary>
	public FStateTreeStateParameters Parameters;
	///<summary>ID</summary>
	public FGuid ID;
	///<summary>EnterConditions</summary>
	public TArray<FStateTreeEditorNode> EnterConditions;
	///<summary>Evaluators_DEPRECATED</summary>
	public TArray<FStateTreeEditorNode> Evaluators_DEPRECATED;
	///<summary>Tasks</summary>
	public TArray<FStateTreeEditorNode> Tasks;
	///<summary>Single item used when schema calls for single task per state.</summary>
	public FStateTreeEditorNode SingleTask;
	///<summary>Transitions</summary>
	public TArray<FStateTreeTransition> Transitions;
	///<summary>Children</summary>
	public TArray<UStateTreeState> Children;
	///<summary>bExpanded</summary>
	public bool bExpanded;
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>Parent</summary>
	public UStateTreeState Parent;
}
