namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_StateMachine.h")]
public partial class UAnimGraphNode_StateMachine : UAnimGraphNode_StateMachineBase {
	public static UClass StaticClass() {return default;}
	///<summary>Runtime state machine representation (empty; populated during compilation)</summary>
	public FAnimNode_StateMachine Node;
}
