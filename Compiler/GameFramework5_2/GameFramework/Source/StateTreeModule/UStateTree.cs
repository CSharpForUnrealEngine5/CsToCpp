#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StateTree asset. Contains the StateTree definition in both editor and runtime (baked) formats.</summary>
[CppInclude("StateTree.h")]
public partial class UStateTree : UDataAsset {
	///<summary>Edit time data for the StateTree, instance of UStateTreeEditorData</summary>
	public UObject EditorData;
	///<summary>Hash of the editor data from last compile.</summary>
	public uint LastCompiledEditorDataHash;
	///<summary>Schema used to compile the StateTree.</summary>
	public UStateTreeSchema Schema;
	///<summary>Runtime states, root state at index 0</summary>
	public TArray<FCompactStateTreeState> States;
	///<summary>Runtime transitions.</summary>
	public TArray<FCompactStateTransition> Transitions;
	///<summary>Evaluators, Tasks, and Condition nodes.</summary>
	public FInstancedStructContainer Nodes;
	///<summary>Default node instance data (e.g. evaluators, tasks).</summary>
	public FStateTreeInstanceData DefaultInstanceData;
	///<summary>Shared node instance data (e.g. conditions).</summary>
	public FStateTreeInstanceData SharedInstanceData;
	///<summary>List of names external data enforced by the schema, created at compilation.</summary>
	public TArray<FStateTreeExternalDataDesc> ContextDataDescs;
	///<summary>PropertyBindings</summary>
	public FStateTreePropertyBindings PropertyBindings;
	///<summary>Parameters that could be used for bindings within the Tree.</summary>
	public FInstancedPropertyBag Parameters;
	///<summary>Data view index of the tree Parameters</summary>
	public FStateTreeIndex8 ParametersDataViewIndex;
	///<summary>Index of first evaluator in Nodes.</summary>
	public ushort EvaluatorsBegin;
	///<summary>Number of evaluators.</summary>
	public ushort EvaluatorsNum;
	///<summary>Index of first global task in Nodes.</summary>
	public ushort GlobalTasksBegin;
	///<summary>Number of global tasks.</summary>
	public ushort GlobalTasksNum;
	///<summary>True if any global task is a transition task.</summary>
	public bool bHasGlobalTransitionTasks;
	///<summary>List of external data required by the state tree, created during linking.</summary>
	public TArray<FStateTreeExternalDataDesc> ExternalDataDescs;
	///<summary>Base index of external data, created during linking.</summary>
	public int ExternalDataBaseIndex;
	///<summary>Total number of data views, created during linking.</summary>
	public int NumDataViews;
}
