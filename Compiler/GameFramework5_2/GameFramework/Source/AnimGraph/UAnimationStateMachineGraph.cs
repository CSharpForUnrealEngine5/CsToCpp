#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationStateMachineGraph.h")]
public partial class UAnimationStateMachineGraph : UEdGraph {
	///<summary>Entry node within the state machine</summary>
	public UAnimStateEntryNode EntryNode;
	///<summary>Parent instance node</summary>
	public UAnimGraphNode_StateMachineBase OwnerAnimGraphNode;
}
