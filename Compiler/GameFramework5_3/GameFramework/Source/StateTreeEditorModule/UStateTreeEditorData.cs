namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Edit time data for StateTree asset. This data gets baked into runtime format before being used by the StateTreeInstance.</summary>
[CppInclude("StateTreeEditorData.h")]
public partial class UStateTreeEditorData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Schema describing which inputs, evaluators, and tasks a StateTree can contain</summary>
	public UStateTreeSchema Schema;
	///<summary>Public parameters that could be used for bindings within the Tree.</summary>
	public FStateTreeStateParameters RootParameters;
	///<summary>Evaluators</summary>
	public TArray<FStateTreeEditorNode> Evaluators;
	///<summary>GlobalTasks</summary>
	public TArray<FStateTreeEditorNode> GlobalTasks;
	///<summary>EditorBindings</summary>
	public FStateTreeEditorPropertyBindings EditorBindings;
	///<summary>Top level States.</summary>
	public TArray<UStateTreeState> SubTrees;
	///<summary>Transient list of breakpoints added in the debugging session.</summary>
	public TArray<FStateTreeEditorBreakpoint> Breakpoints;
}
