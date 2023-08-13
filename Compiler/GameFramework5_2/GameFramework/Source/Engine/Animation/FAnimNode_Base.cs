namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the base of all runtime animation nodes</summary>
[CppInclude("Animation/AnimNodeBase.h")]
public partial struct FAnimNode_Base {
	public FAnimNodeFunctionRef InitialUpdateFunction;
	public FAnimNodeFunctionRef BecomeRelevantFunction;
	public FAnimNodeFunctionRef UpdateFunction;
}
