namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationStateMachineGraph.h")]
public partial class UAnimationStateMachineGraph : UEdGraph {
	public static UClass StaticClass() {return default;}
	///<summary>Entry node within the state machine</summary>
	public UAnimStateEntryNode EntryNode;
	///<summary>Parent instance node</summary>
	public UAnimGraphNode_StateMachineBase OwnerAnimGraphNode;
}
