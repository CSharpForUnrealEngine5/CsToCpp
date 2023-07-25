#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTree.h")]
///<summary>StateTree asset. Contains the StateTree definition in both editor and runtime (baked) formats.</summary>
public partial class UStateTree : UDataAsset {
// StateTree
	public UObject EditorData;
	public uint LastCompiledEditorDataHash;
	public UStateTreeSchema Schema;
	public TArray<FCompactStateTreeState> States;
	public TArray<FCompactStateTransition> Transitions;
	public FInstancedStructContainer Nodes;
	public FStateTreeInstanceData DefaultInstanceData;
	public FStateTreeInstanceData SharedInstanceData;
	public TArray<FStateTreeExternalDataDesc> ContextDataDescs;
	public FStateTreePropertyBindings PropertyBindings;
	public FInstancedPropertyBag Parameters;
	public FStateTreeIndex8 ParametersDataViewIndex;
	public ushort EvaluatorsBegin;
	public ushort EvaluatorsNum;
	public ushort GlobalTasksBegin;
	public ushort GlobalTasksNum;
	public bool bHasGlobalTransitionTasks;
	public TArray<FStateTreeExternalDataDesc> ExternalDataDescs;
	public int ExternalDataBaseIndex;
	public int NumDataViews;
}
