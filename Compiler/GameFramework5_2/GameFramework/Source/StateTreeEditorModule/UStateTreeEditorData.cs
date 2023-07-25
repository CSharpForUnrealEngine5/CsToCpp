#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeEditorData.h")]
///<summary>Edit time data for StateTree asset. This data gets baked into runtime format before being used by the StateTreeInstance.</summary>
public partial class UStateTreeEditorData : UObject {
// StateTreeEditorData
	public UStateTreeSchema Schema;
	public FStateTreeStateParameters RootParameters;
	public TArray<FStateTreeEditorNode> Evaluators;
	public TArray<FStateTreeEditorNode> GlobalTasks;
	public FStateTreeEditorPropertyBindings EditorBindings;
	public TArray<UStateTreeState> SubTrees;
}
