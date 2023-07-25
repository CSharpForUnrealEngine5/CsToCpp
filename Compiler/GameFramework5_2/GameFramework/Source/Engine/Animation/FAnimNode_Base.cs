#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNodeBase.h")]
///<summary>This is the base of all runtime animation nodes</summary>
public partial struct FAnimNode_Base {
// AnimNode_Base
	public FAnimNodeFunctionRef InitialUpdateFunction;
	public FAnimNodeFunctionRef BecomeRelevantFunction;
	public FAnimNodeFunctionRef UpdateFunction;
}
