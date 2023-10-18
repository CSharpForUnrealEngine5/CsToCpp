namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Root node of an state machine state (sink node).</summary>
[CppInclude("Animation/AnimNode_StateResult.h")]
public partial struct FAnimNode_StateResult {
	public int StateIndex;
	public FAnimNodeFunctionRef StateEntryFunction;
	public FAnimNodeFunctionRef StateFullyBlendedInFunction;
	public FAnimNodeFunctionRef StateExitFunction;
	public FAnimNodeFunctionRef StateFullyBlendedOutFunction;
}
