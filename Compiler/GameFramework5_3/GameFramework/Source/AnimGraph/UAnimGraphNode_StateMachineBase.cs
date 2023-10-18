namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_StateMachineBase.h")]
public partial class UAnimGraphNode_StateMachineBase : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Editor state machine representation</summary>
	public UAnimationStateMachineGraph EditorStateMachineGraph;
}
