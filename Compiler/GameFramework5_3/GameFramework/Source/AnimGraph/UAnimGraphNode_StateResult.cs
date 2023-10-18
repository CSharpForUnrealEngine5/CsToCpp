namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_StateResult.h")]
public partial class UAnimGraphNode_StateResult : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_StateResult Node;
	///<summary>Function called when the owning state is entered, meaning it becomes the state machine&#39;s current state.</summary>
	public FMemberReference StateEntryFunction;
	///<summary>Function called when the owning state is fully blended in.</summary>
	public FMemberReference StateFullyBlendedInFunction;
	///<summary>Function called when the owning state is exited, meaning it stops being the state machine&#39;s current state.</summary>
	public FMemberReference StateExitFunction;
	///<summary>Function called when the owning state is fully blended out.</summary>
	public FMemberReference StateFullyBlendedOutFunction;
}
