namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Calls specified user-defined events/functions during anim graph execution</summary>
[CppInclude("AnimNodes/AnimNode_CallFunction.h")]
public partial struct FAnimNode_CallFunction {
	public FPoseLink Source;
	public FAnimNodeFunctionRef Function;
	public EAnimFunctionCallSite CallSite;
}
